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
        public IGenericRepository<AnswerTest> RAnswerTests { get; set; }
        public IGenericRepository<Group> RGroups { get; set; }

        GenericUnitOfWork work;

        public MainPage()
        {
            InitializeComponent();
            work = new GenericUnitOfWork(new VCE_DBcontext(ConfigurationManager.ConnectionStrings["conStr"].ConnectionString));

            List<Group> gr = RGroups.GetAll().ToList();
            textBox1.Text = gr[0].Name;
        }
    }
}
