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
    public partial class Form1 : Form
    {
        Socket sendSocket = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_StartTest_Click(object sender, EventArgs e)
        {
            TestWrap currentTest = (listBox_Tests.SelectedItem as TestWrap);
            foreach (var item in currentTest.Questions)
            {

            }
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
                    List<TestWrappersLib.TestWrap> te = bin.Deserialize(stream) as List<TestWrappersLib.TestWrap>;
                    this.Invoke(new Action(() =>
                    {
                        listBox_Tests.Items.AddRange(te.ToArray());
                    }));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Informer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            string msg = $"#login|pass_{textBox_Login.Text}|{textBox_Pass.Text}";
            Byte[] sendByte = new Byte[1024];
            sendByte = Encoding.ASCII.GetBytes(msg);
            sendSocket.Send(sendByte);
        }
    }
}
