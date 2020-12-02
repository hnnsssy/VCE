using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestClient.Properties;
using TestWrappersLib;

namespace TestClient
{
    public partial class MainWindow : Form
    {
        Socket sendSocket = null;
        TestWrap currentTest;
        int currentQuestionIndex;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        //DateTime timeToComplete;
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
            if(listBox_Tests.SelectedIndex != -1)
            {
                currentTest = (listBox_Tests.SelectedItem as TestWrap);
                //label_Time.Text = currentTest.TimeToComplete;
                //timeToComplete = Convert.ToDateTime(currentTest.TimeToComplete);
                currentQuestionIndex = -1;
                //timer.Start();
                button_NextQuestion_Click(sender, e);
            }
        }

        private void button_NextQuestion_Click(object sender, EventArgs e)
        {
            currentQuestionIndex++;
            if (currentQuestionIndex > currentTest.Questions.Count - 1)
                currentQuestionIndex = 0;
            checkedListBox_Answers.Items.Clear();
            label_Question.Text = currentTest.Questions[currentQuestionIndex].Body;
            checkedListBox_Answers.Items.AddRange(currentTest.Questions[currentQuestionIndex].Answers.ToArray());
            UpdateCheckedListBox();
        }

        private void button_PreviousQuestion_Click(object sender, EventArgs e)
        {
            currentQuestionIndex--;
            if (currentQuestionIndex < 0)
                currentQuestionIndex = currentTest.Questions.Count - 1;
            checkedListBox_Answers.Items.Clear();
            label_Question.Text = currentTest.Questions[currentQuestionIndex].Body;
            checkedListBox_Answers.Items.AddRange(currentTest.Questions[currentQuestionIndex].Answers.ToArray());
            UpdateCheckedListBox();
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
                    String receiveString = Encoding.ASCII.GetString(receiveByte, 0, nCount);
                    MemoryStream stream = new MemoryStream(receiveByte);
                    BinaryFormatter bin = new BinaryFormatter();
                    List<TestWrap> te = bin.Deserialize(stream) as List<TestWrap>;
                    this.Invoke(new Action(() =>
                    {
                        listBox_Tests.Items.Clear();
                        listBox_Tests.Items.AddRange(te.ToArray());

                        groupBox_Login.Visible = false;
                        groupBox_Test.Location = groupBox_Login.Location;
                        this.Size = new Size(565, 224);
                        pictureBox_Minimize.Location = new Point(515, 0);
                        pictureBox_Close.Location = new Point(540, 0);
                    }));
                }
            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox_Login.Text) && !string.IsNullOrEmpty(textBox_Pass.Text))
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

            Thread.Sleep(200);
            if(listBox_Tests.Items.Count > 0)
            {
                
            }
        }

        private void checkedListBox_Answers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            (checkedListBox_Answers.Items[e.Index] as AnswerWrap).isChecked = true;
            for (int ix = 0; ix < checkedListBox_Answers.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox_Answers.SetItemChecked(ix, false);
        }

        private void button_EndTest_Click(object sender, EventArgs e)
        {
            Byte[] sendByte = null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, currentTest);
                sendByte = ms.ToArray();
            }
            sendSocket.Send(sendByte);

            listBox_Tests.Items.RemoveAt(listBox_Tests.SelectedIndex);
            checkedListBox_Answers.Items.Clear();
            label_Question.Text = "";
            label_Counter.Text = "0/0";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //TimeSpan elapsed = DateTime.Now - timeToComplete;

            //label_Time.Text = elapsed.ToString("HH:mm:ss");
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Close_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Close.Image = Resources.close_1;
        }

        private void pictureBox_Close_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Close.Image = Resources.close_0;
        }

        private void pictureBox_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox_Minimize_MouseEnter(object sender, EventArgs e)
        {
            pictureBox_Minimize.Image = Resources.minimize_1;
        }

        private void pictureBox_Minimize_MouseLeave(object sender, EventArgs e)
        {
            pictureBox_Minimize.Image = Resources.minimize_0;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            pictureBox_Close.Image = Resources.close_0;
            pictureBox_Minimize.Image = Resources.minimize_0;
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
