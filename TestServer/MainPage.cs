using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace TestServer
{
    public partial class MainPage : Form
    {
        public IGenericRepository<User> RUser { get; set; }
        public IGenericRepository<UserAnswer> RUserAnswers { get; set; }
        public IGenericRepository<UserGroup> RUserGroups { get; set; }
        public IGenericRepository<Answer> RAnswers { get; set; }
        public IGenericRepository<Question> RQuestions { get; set; }
        public IGenericRepository<Test> RTests { get; set; }
        public IGenericRepository<GroupTest> RGroupTests { get; set; }
        public IGenericRepository<Group> RGroups { get; set; }

        GenericUnitOfWork work;

        public MainPage()
        {
            InitializeComponent();
            work = new GenericUnitOfWork(new VCE_DBcontext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));
            InitializeGenericRepositories();
        }

        public void InitializeGenericRepositories()
        {
            RUser = work.Repository<User>();
            RGroups = work.Repository<Group>();
            RTests = work.Repository<Test>();
            RAnswers = work.Repository<Answer>();
            RUserAnswers = work.Repository<UserAnswer>();
            RUserGroups = work.Repository<UserGroup>();
            RQuestions = work.Repository<Question>();
            RGroupTests = work.Repository<GroupTest>();
        }

        private void ImportTestToDataBase(string path)
        {
            DesignerClassLib.Test d_test = new DesignerClassLib.Test();
            d_test = DesignerClassLib.Serializer.Deserialize<DesignerClassLib.Test>(path);


            Test test = new Test() { Title = d_test.Title };
            List<Question> questions = new List<Question>();
            List<Answer> answers = new List<Answer>();
            foreach (DesignerClassLib.Question d_question in d_test.Questions)
            {
                Question question = new Question() { Test = test, Title = d_question.Body };
                questions.Add(question);

                foreach (DesignerClassLib.Answer d_answer in d_question.Answers)
                {
                    Answer answer = new Answer() { Body = d_answer.Body, IsCorrect = d_answer.IsCorrectAnswer, Question = question };
                    answers.Add(answer);
                }
            }

            foreach (Question item in questions)
                RQuestions.Add(item);

            foreach (Answer item in answers)
                RAnswers.Add(item);
        }

        private void RefreshTable()
        {
            comboBox_Group.Items.Clear();
            comboBox_Other.Items.Clear();
            switch (listBox_Tables.SelectedItem.ToString())
            {
                case "Group":
                    dataGridView_Table.DataSource = RGroups.GetAll().ToList();
                    dataGridView_Table.Columns["Id"].Visible = false;

                    comboBox_Other.Visible = false;
                    comboBox_Group.Visible = false;

                    break;
                case "User":
                    dataGridView_Table.DataSource = RUser.GetAll().ToList();
                    dataGridView_Table.Columns["Id"].Visible = false;
                    dataGridView_Table.Columns["UserGroup"].Visible = false;
                    dataGridView_Table.Columns["UserAnswer"].Visible = false;

                    comboBox_Other.Visible = false;
                    comboBox_Group.Visible = false;

                    break;
                case "Test":
                    dataGridView_Table.DataSource = RTests.GetAll().ToList();
                    dataGridView_Table.Columns["Id"].Visible = false;
                    dataGridView_Table.Columns["Questions"].Visible = false;

                    comboBox_Other.Visible = false;
                    comboBox_Group.Visible = false;

                    break;
                case "GroupTest":
                    dataGridView_Table.DataSource = RGroupTests.GetAll().ToList();
                    dataGridView_Table.Columns["Id"].Visible = false;

                    comboBox_Other.Visible = true;
                    comboBox_Group.Visible = true;


                    comboBox_Group.Items.AddRange(RGroups.GetAll().ToArray());
                    comboBox_Other.Items.AddRange(RTests.GetAll().ToArray());
                    break;
                case "UserGroup":
                    dataGridView_Table.DataSource = RUserGroups.GetAll().ToList();
                    dataGridView_Table.Columns["Id"].Visible = false;

                    comboBox_Other.Visible = true;
                    comboBox_Group.Visible = true;


                    comboBox_Group.Items.AddRange(RGroups.GetAll().ToArray());
                    comboBox_Other.Items.AddRange(RUser.GetAll().ToArray());
                    break;
                default:
                    break;
            }
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            switch (listBox_Tables.SelectedItem.ToString())
            {
                case "Group":
                    CU_Group createGroup = new CU_Group(this, FormType.Create, null);
                    createGroup.ShowDialog();
                    if (createGroup.DialogResult == DialogResult.OK)
                        RefreshTable();
                    break;
                case "User":
                    CU_User createUser = new CU_User(this, FormType.Create, null);
                    createUser.ShowDialog();
                    if (createUser.DialogResult == DialogResult.OK)
                        RefreshTable();
                    break;
                case "Test":
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "XML Files|*.xml";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                        ImportTestToDataBase(openFileDialog.FileName);
                    break;
                case "GroupTest":
                    CU_GroupTest groupTest = new CU_GroupTest(this);
                    groupTest.ShowDialog();
                    if (groupTest.DialogResult == DialogResult.OK)
                        RefreshTable();
                    break;
                case "UserGroup":
                    CU_UserGroup userGroup = new CU_UserGroup(this);
                    userGroup.ShowDialog();
                    if (userGroup.DialogResult == DialogResult.OK)
                        RefreshTable();
                    break;
                default:
                    break;
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            switch (listBox_Tables.SelectedItem.ToString())
            {
                case "Group":
                    CU_Group createGroup = new CU_Group(this, FormType.Update, textBox_Delete.Text);
                    createGroup.ShowDialog();
                    if (createGroup.DialogResult == DialogResult.OK)
                        RefreshTable();
                    break;
                case "User":
                    CU_User createUser = new CU_User(this, FormType.Update, textBox_Delete.Text);
                    createUser.ShowDialog();
                    if (createUser.DialogResult == DialogResult.OK)
                        RefreshTable();
                    break;
                default:
                    break;
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            switch (listBox_Tables.SelectedItem.ToString())
            {
                case "Group":
                    RGroups.Remove(RGroups.FindAll(x => x.Name == textBox_Delete.Text).FirstOrDefault());
                    break;
                case "User":
                    RUser.Remove(RUser.FindAll(x => x.Login == textBox_Delete.Text).FirstOrDefault());
                    break;
                case "UserGroup":
                    Group group = (comboBox_Group.SelectedItem as Group);
                    User user = (comboBox_Other.SelectedItem as User);
                    RUserGroups.Remove(RUserGroups.FindAll(x => x.Group.Id == group.Id && x.User.Id == user.Id).FirstOrDefault());
                    break;
                case "GroupTest":
                    Group gr= (comboBox_Group.SelectedItem as Group);
                    Test test = (comboBox_Other.SelectedItem as Test);
                    RGroupTests.Remove(RGroupTests.FindAll(x => x.Group.Id == gr.Id && x.Test.Id == test.Id).FirstOrDefault());
                    break;
                default:
                    break;
            }

            RefreshTable();
        }

        private void listBox_Tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTable();
            if (listBox_Tables.SelectedItem.ToString() == "Test")
                button_Create.Text = "Import";
            else button_Create.Text = "Create";
        }

        Socket listenSocket;
        private void button_StartServer_Click(object sender, EventArgs e)
        {
            listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPHostEntry iPHost = Dns.GetHostEntry("localhost");
            IPAddress iPAddress = iPHost.AddressList[1]; //ipconfig (карти)
            int port = int.Parse(textBox_Port.Text);
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, port);
            listenSocket.Bind(iPEndPoint);

            Task.Factory.StartNew(() => ListenThread(listenSocket));
        }

        private void ListenThread(Socket listenSocket)
        {
            listenSocket.Listen(2);
            while (true)
            {
                Socket clientSocket = listenSocket.Accept(); //блокуюча функція
                ClientInfo clientInfo = new ClientInfo() { RemoteEndPoint = clientSocket.RemoteEndPoint.ToString(), ClientSocket = clientSocket }; ;
                Thread recieveThread = new Thread(ReceiveThread);
                recieveThread.IsBackground = true;
                recieveThread.Start(clientInfo);
            }
        }

        private void ReceiveThread(object sender)
        {
            while (true)
            {
                ClientInfo clientInfo = sender as ClientInfo;
                Socket receiveSocket = clientInfo.ClientSocket;
                if (receiveSocket == null)
                    throw new ArgumentException("Receive Socket Exception");
                Byte[] receiveByte = new Byte[1024];
                Int32 nCount = receiveSocket.Receive(receiveByte); //блокуюча функція
                String receiveString = Encoding.ASCII.GetString(receiveByte, 0, nCount);

                if(receiveString.Contains("#login|pass_"))
                {
                    List<TestWrap> we = null;
                    string[] login_pass = receiveString.Replace("#login|pass_", "").Split('|');
                    this.Invoke((MethodInvoker)delegate {
                        if (AuthorizationSucceeded(login_pass[0], login_pass[1]))
                            we = GetTestInWrap(login_pass[0]);
                    });

                    if(we != null)
                    {
                        Byte[] sendByte = null;
                        BinaryFormatter bf = new BinaryFormatter();
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bf.Serialize(ms, we);
                            sendByte = ms.ToArray();
                        }
                        clientInfo.ClientSocket.Send(sendByte);
                    }
                }
            }
        }

        private bool AuthorizationSucceeded(string login, string password)
        {
            if (RUser.FindAll(x => x.Login == login && x.Password == password) != null) return true;
            return false;
        }

        private List<TestWrap> GetTestInWrap(string userLogin)
        {
            //List<Test> gr = RGroupTests.FindAll(x => x.Group == RUserGroups.FindAll(y => y.User.Login == userLogin).Fire.Select(z => z.Group)).Select(x=>x.Test).ToList();
            var param = new SqlParameter("param", SqlDbType.Int) { Value = RUser.FindAll(x => x.Login == userLogin).FirstOrDefault().Id };
            List<GroupTest> gr = RGroupTests.ExecWithStoreProcedure("select * from GroupTests where Group_Id = (select Group_Id from UserGroups where User_Id = @param)", param).ToList();

            List<TestWrap> tws = new List<TestWrap>();
            foreach (GroupTest item in gr)
            {
                GroupTest gt = RGroupTests.FindById(item.Id);
                TestWrap testWrap = new TestWrap() { Title = gt.Test.Title, Id = gt.Test.Id };
                foreach (Question wQuestion in gt.Test.Questions)
                {
                    QuestionWrap questionWrap = new QuestionWrap() { Body = wQuestion.Title };
                    foreach (Answer wAnswer in wQuestion.Answers)
                    {
                        questionWrap.Answers.Add(new AnswerWrap() { Answer = wAnswer.Body });
                    }
                    testWrap.Questions.Add(questionWrap);
                }
                tws.Add(testWrap);
            }

            return tws;
        }      
    }
}
