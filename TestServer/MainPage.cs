using DAL;
using Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            /*User user = new User() {  Name = "User1", Login = "test", Password = "test", IsAdmin = false};
            Group group = new Group() { Name = "s32-rp" };
            Test test = new Test() { Title = "I Svitova" };
            Question question = new Question() { Title = "Petro I", Test = RTests.FindById(1) };
            Answer answer = new Answer() { Question = question, Body = "1473", IsCorrect = true };

            RUser.Add(user);
            RGroups.Add(group);
            RTests.Add(test);
            RAnswers.Add(answer);
            RQuestions.Add(question);

            work.SaveChanges();*/
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
            throw new NotImplementedException();
        }

        private void RefreshTable()
        {
            switch (listBox_Tables.SelectedItem.ToString())
            {
                case "Group":
                    dataGridView_Table.DataSource = RGroups.GetAll().ToList();
                    dataGridView_Table.Columns["Id"].Visible = false;

                    comboBox_Other.Visible = false;
                    comboBox_Group.Visible = false;
                    this.Height = 217;
                    break;
                case "User":
                    dataGridView_Table.DataSource = RUser.GetAll().ToList();
                    dataGridView_Table.Columns["Id"].Visible = false;
                    dataGridView_Table.Columns["UserGroup"].Visible = false;
                    dataGridView_Table.Columns["UserAnswer"].Visible = false;

                    comboBox_Other.Visible = false;
                    comboBox_Group.Visible = false;
                    this.Height = 217;
                    break;
                case "Test":
                    dataGridView_Table.DataSource = RTests.GetAll().ToList();
                    dataGridView_Table.Columns["Id"].Visible = false;

                    comboBox_Other.Visible = false;
                    comboBox_Group.Visible = false;
                    this.Height = 217;
                    break;
                case "GroupTest":
                    dataGridView_Table.DataSource = RGroupTests.GetAll().ToList();
                    dataGridView_Table.Columns["Id"].Visible = false;

                    comboBox_Other.Visible = true;
                    comboBox_Group.Visible = true;
                    this.Height = 245;

                    comboBox_Group.Items.AddRange(RGroups.GetAll().ToArray());
                    comboBox_Other.Items.AddRange(RTests.GetAll().ToArray());
                    break;
                case "UserGroup":
                    dataGridView_Table.DataSource = RUserGroups.GetAll().ToList();
                    dataGridView_Table.Columns["Id"].Visible = false;

                    comboBox_Other.Visible = true;
                    comboBox_Group.Visible = true;
                    this.Height = 245;

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
                    /*CreateSageBook createSageBook = new CreateSageBook(this, FromType.Create);
                    createSageBook.ShowDialog();
                    if (createSageBook.DialogResult == DialogResult.OK)
                        RefreshTable();*/
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
    }
}
