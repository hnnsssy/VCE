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
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestServer.Properties;
using TestWrappersLib;

namespace TestServer
{
    public partial class MainPage : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public IGenericRepository<User> RUser { get; set; }
        public IGenericRepository<UserAnswer> RUserAnswers { get; set; }
        public IGenericRepository<UserGroup> RUserGroups { get; set; }
        public IGenericRepository<Answer> RAnswers { get; set; }
        public IGenericRepository<Question> RQuestions { get; set; }
        public IGenericRepository<Test> RTests { get; set; }
        public IGenericRepository<GroupTest> RGroupTests { get; set; }
        public IGenericRepository<Group> RGroups { get; set; }
        public IGenericRepository<TestResult> RTestResult { get; set; }

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
            RTestResult = work.Repository<TestResult>();
        }

        private void ImportTestToDataBase(string path)
        {
            DesignerClassLib.Test d_test = new DesignerClassLib.Test();
            d_test = DesignerClassLib.Serializer.Deserialize<DesignerClassLib.Test>(path);


            Test test = new Test() { Title = d_test.Title, TimeToComplete = d_test.TimeToComplete };
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
            this.Size = new Size(this.Size.Width, 250);
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

                    textBox_Delete.Visible = true;
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
                case "TestResult":
                    dataGridView_Table.DataSource = RTestResult.GetAll().ToList();
                    dataGridView_Table.Columns["Id"].Visible = false;
                    this.Size = new Size(this.Size.Width, 190);
                    break;
                default:
                    break;
            }
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
                if (listBox_Tables.SelectedIndex != -1)
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
            if (listBox_Tables.SelectedIndex != -1)
                switch (listBox_Tables.SelectedItem.ToString())
                {
                    case "Group":
                        CU_Group updateGroup = new CU_Group(this, FormType.Update, textBox_Delete.Text);
                        updateGroup.ShowDialog();
                        if (updateGroup.DialogResult == DialogResult.OK)
                            RefreshTable();
                        break;
                    case "User":
                        CU_User updateUser = new CU_User(this, FormType.Update, textBox_Delete.Text);
                        updateUser.ShowDialog();
                        if (updateUser.DialogResult == DialogResult.OK)
                            RefreshTable();
                        break;
                    case "UserGroup":
                        CU_UserGroup updateUserGroup = new CU_UserGroup(this);
                        updateUserGroup.ShowDialog();
                        if (updateUserGroup.DialogResult == DialogResult.OK)
                            RefreshTable();
                        break;
                    case "GroupTest":
                        CU_GroupTest updateGroupTest = new CU_GroupTest(this);
                        updateGroupTest.ShowDialog();
                        if (updateGroupTest.DialogResult == DialogResult.OK)
                            RefreshTable();
                        break;
                    default:
                        break;
                }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listBox_Tables.SelectedIndex != -1)
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
                        Group gr = (comboBox_Group.SelectedItem as Group);
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
            if(listBox_Tables.SelectedIndex != -1)
            {
                textBox_Delete.Text = "";
                RefreshTable();
                if (listBox_Tables.SelectedItem.ToString() == "Test")
                    button_Create.Text = "Import";
                else button_Create.Text = "Create";
            }
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
                Byte[] receiveByte = new Byte[60000];
                Int32 nCount = 0;
                try { nCount = receiveSocket.Receive(receiveByte); }//блокуюча функція
                catch { }
                String receiveString = Encoding.ASCII.GetString(receiveByte, 0, nCount);

                if(receiveString.Contains("#login|pass_"))
                {
                    List<TestWrap> we = null;
                    string[] login_pass = receiveString.Replace("#login|pass_", "").Split('|');
                    this.Invoke((MethodInvoker)delegate {
                        if (AuthorizationSucceeded(login_pass[0], login_pass[1]))
                            we = GetTestInWrap(login_pass[0]);
                    });

                    //send test
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
                else
                {
                    try
                    {
                        MemoryStream stream = new MemoryStream(receiveByte);
                        BinaryFormatter bin = new BinaryFormatter();
                        TestWrap te = bin.Deserialize(stream) as TestWrap;
                        this.Invoke(new Action(() =>
                        {
                            WriteResultOfTest(te);
                        }));
                    }
                    catch { }
                }
            }
        }

        private void WriteResultOfTest(TestWrap test)
        {
            UserAnswer userAnswer = new UserAnswer();
            userAnswer.User = RUser.FindById(test.UserID);
            userAnswer.Dt = DateTime.Now.ToString("MM.dd.yyyy");
            foreach (QuestionWrap questionWrap in test.Questions)
            {
                foreach (AnswerWrap answerWrap in questionWrap.Answers)
                {
                    if (answerWrap.isChecked == true)
                    {
                        userAnswer.Answer = RAnswers.GetAll().Where(x => x.Body == answerWrap.Answer).FirstOrDefault();
                        userAnswer.User = RUser.FindById(test.UserID);
                        RUserAnswers.Add(userAnswer);
                    }
                    else continue;
                }    
            }
            int tmp = work.context.Database.SqlQuery<int>("select [dbo].[fn_CorrectAnswersPercetntage](@User, @Test)", 
                new SqlParameter("User", RUser.FindById(test.UserID).Login),
                new SqlParameter("Test", test.Title)).Single(); //нові функції не додаються
            RTestResult.Add(new TestResult() { Test = RTests.FindById(test.Id), User = RUser.FindById(test.UserID), Result = tmp.ToString() + "%" });
        }

        private bool AuthorizationSucceeded(string login, string password)
        {
            if (RUser.FindAll(x => x.Login == login && x.Password == password).FirstOrDefault() != null) 
                return true;
            return false;
        }

        private List<TestWrap> GetTestInWrap(string userLogin)
        {
            int userId = RUser.FindAll(x => x.Login == userLogin).FirstOrDefault().Id;
            var param = new SqlParameter("param", SqlDbType.Int) { Value = userId };
            List<GroupTest> gr = RGroupTests.ExecWithStoreProcedure("select * from GroupTests where Group_Id = (select Group_Id from UserGroups where User_Id = @param)", param).ToList();
            List<TestWrap> tws = new List<TestWrap>();
            foreach (GroupTest item in gr)
            {
                GroupTest gt = RGroupTests.FindById(item.Id);
                TestWrap testWrap = new TestWrap() { Title = gt.Test.Title, Id = gt.Test.Id, TimeToComplete = gt.Test.TimeToComplete, UserID = userId };
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

        private void MainPage_Load(object sender, EventArgs e)
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
