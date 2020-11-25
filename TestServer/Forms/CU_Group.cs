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
    public partial class CU_Group : Form
    {
        MainPage mainForm;
        FormType formType;
        public Group CurrentGroup { get; set; }
        public CU_Group(MainPage mainForm, FormType formType, string groupName)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.formType = formType;

            if (formType == FormType.Update)
            {
                CurrentGroup = mainForm.RGroups.FindAll(x => x.Name == groupName).FirstOrDefault();
                textBox_Name.Text = CurrentGroup.Name;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            switch (formType)
            {
                case FormType.Create:
                    mainForm.RGroups.Add(new Group() { Name = textBox_Name.Text });
                    break;
                case FormType.Update:
                    CurrentGroup.Name = textBox_Name.Text;
                    mainForm.RGroups.Update(CurrentGroup);
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
