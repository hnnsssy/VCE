using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWrappersLib;

namespace TestClient
{
    public partial class MainWindow : Form
    {
        Socket sendSocket = null;
        TestWrap currentTest;
        int currentQuestionIndex;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateCheckedListBox()
        {
            for (int i = 0; i < checkedListBox_Answers.Items.Count; i++)
            {
                if ((checkedListBox_Answers.Items[i] as AnswerWrap).isChecked == true)
                    checkedListBox_Answers.SetItemChecked(i, true);
            }

            label_Counter.Text = $"{currentQuestionIndex + 1}/{currentTest.Questions.Count}";
        }

        private void button_StartTest_Click(object sender, EventArgs e)
        {
            currentTest = (listBox_Tests.SelectedItem as TestWrap);
            currentQuestionIndex = 0;
            button_NextQuestion_Click(sender, e);
        }

        private void button_NextQuestion_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex > checkedListBox_Answers.Items.Count - 1)
                currentQuestionIndex = 0;
            checkedListBox_Answers.Items.Clear();
            label_Question.Text = currentTest.Questions[currentQuestionIndex].Body;
            checkedListBox_Answers.Items.AddRange(currentTest.Questions[currentQuestionIndex].Answers.ToArray());
            UpdateCheckedListBox();
            currentQuestionIndex++;
        }

        private void button_PreviousQuestion_Click(object sender, EventArgs e)
        {
            if (currentQuestionIndex < 0)
                currentQuestionIndex = checkedListBox_Answers.Items.Count - 1;
            checkedListBox_Answers.Items.Clear();
            label_Question.Text = currentTest.Questions[currentQuestionIndex].Body;
            checkedListBox_Answers.Items.AddRange(currentTest.Questions[currentQuestionIndex].Answers.ToArray());
            UpdateCheckedListBox();
            currentQuestionIndex--;
        }

        private void ReceiveServerMsg(object sender)
        {
            while (true)
            {
                Socket receiveSocket = sender as Socket;
                if (receiveSocket != null)
                {
                    Byte[] receiveByte = new Byte[60000];
                    Int32 nCount = receiveSocket.Receive(receiveByte); //блокуюча функція
                    //String receiveString = Encoding.ASCII.GetString(receiveByte, 0, nCount);
                    MemoryStream stream = new MemoryStream(receiveByte);
                    BinaryFormatter bin = new BinaryFormatter();
                    List<TestWrap> te = bin.Deserialize(stream) as List<TestWrap>;
                    this.Invoke(new Action(() =>
                    {
                        listBox_Tests.Items.AddRange(te.ToArray());
                    }));
                }
            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            try
            {
                sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPHostEntry iPHost = Dns.GetHostEntry("localhost");
                IPAddress iPAddress = iPHost.AddressList[1];
                IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, 33000);

                sendSocket.Connect(iPEndPoint);

                Thread thread = new Thread(ReceiveServerMsg);
                thread.IsBackground = true;
                thread.Start(sendSocket);

                string msg = $"#login|pass_{textBox_Login.Text}|{textBox_Pass.Text}";
                Byte[] sendByte = new Byte[1024];
                sendByte = Encoding.ASCII.GetBytes(msg);
                sendSocket.Send(sendByte);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkedListBox_Answers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            (checkedListBox_Answers.Items[e.Index] as AnswerWrap).isChecked = true;
        }

        private void button_EndTest_Click(object sender, EventArgs e)
        {
            string msg = $"#endTest";
            Byte[] sendByte = new Byte[1024];
            sendByte = Encoding.ASCII.GetBytes(msg);
            sendSocket.Send(sendByte);
        }
    }
}
