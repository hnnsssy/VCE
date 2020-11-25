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
    public partial class CU_GroupTest : Form
    {
        MainPage mainForm;
        public CU_GroupTest(MainPage mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            FillComboboxes();
        }
        public void FillComboboxes()
        {
            comboBox_Group.Items.AddRange(mainForm.RGroups.GetAll().ToArray());
            comboBox_Test.Items.AddRange(mainForm.RTests.GetAll().ToArray());
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            mainForm.RGroupTests.Add(new GroupTest() { Group = comboBox_Group.SelectedItem as Group, Test = comboBox_Test.SelectedItem as Test });
            this.DialogResult = DialogResult.OK;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
