using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestServer
{
    public partial class CU_User : Form
    {
        MainPage mainForm;
        FormType formType;
        public User CurrentUser { get; set; }

        public CU_User(MainPage mainForm, FormType formType, string userLogin)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.formType = formType;

            if (formType == FormType.Update)
            {
                CurrentUser = mainForm.RUser.FindAll(x => x.Login == userLogin).FirstOrDefault();
                textBox_Name.Text = CurrentUser.Name;
                textBox_Login.Text = CurrentUser.Login;
                textBox_Password.Text = CurrentUser.Password;
                checkBox_IsAdmin.Checked = CurrentUser.IsAdmin;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            switch (formType)
            {
                case FormType.Create:
                    mainForm.RUser.Add(new User() { Name = textBox_Name.Text, Login = textBox_Login.Text, Password = textBox_Password.Text, IsAdmin = checkBox_IsAdmin.Checked });
                    break;
                case FormType.Update:
                    CurrentUser.Name = textBox_Name.Text;
                    CurrentUser.Login = textBox_Login.Text;
                    CurrentUser.Password = textBox_Password.Text;
                    CurrentUser.IsAdmin = checkBox_IsAdmin.Checked;
                    mainForm.RUser.Update(CurrentUser);
                    break;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
