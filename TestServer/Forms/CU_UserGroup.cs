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
    public partial class CU_UserGroup : Form
    {
        MainPage mainForm;
        public CU_UserGroup(MainPage mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            FillComboboxes();
        }

        public void FillComboboxes()
        {
            comboBox_Group.Items.AddRange(mainForm.RGroups.GetAll().ToArray());
            comboBox_User.Items.AddRange(mainForm.RUser.GetAll().ToArray());
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            mainForm.RUserGroups.Add(new UserGroup() { Group = comboBox_Group.SelectedItem as Group, User = comboBox_User.SelectedItem as User });
            this.DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
