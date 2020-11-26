namespace TestServer
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Table = new System.Windows.Forms.DataGridView();
            this.listBox_Tables = new System.Windows.Forms.ListBox();
            this.comboBox_Other = new System.Windows.Forms.ComboBox();
            this.comboBox_Group = new System.Windows.Forms.ComboBox();
            this.button_Update = new System.Windows.Forms.Button();
            this.textBox_Delete = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_StartServer = new System.Windows.Forms.Button();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Table
            // 
            this.dataGridView_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Table.Location = new System.Drawing.Point(80, 12);
            this.dataGridView_Table.Name = "dataGridView_Table";
            this.dataGridView_Table.ReadOnly = true;
            this.dataGridView_Table.Size = new System.Drawing.Size(297, 134);
            this.dataGridView_Table.TabIndex = 2;
            // 
            // listBox_Tables
            // 
            this.listBox_Tables.FormattingEnabled = true;
            this.listBox_Tables.Items.AddRange(new object[] {
            "Group",
            "User",
            "Test",
            "GroupTest",
            "UserGroup"});
            this.listBox_Tables.Location = new System.Drawing.Point(12, 12);
            this.listBox_Tables.Name = "listBox_Tables";
            this.listBox_Tables.Size = new System.Drawing.Size(62, 134);
            this.listBox_Tables.TabIndex = 3;
            this.listBox_Tables.SelectedIndexChanged += new System.EventHandler(this.listBox_Tables_SelectedIndexChanged);
            // 
            // comboBox_Other
            // 
            this.comboBox_Other.FormattingEnabled = true;
            this.comboBox_Other.Location = new System.Drawing.Point(256, 178);
            this.comboBox_Other.Name = "comboBox_Other";
            this.comboBox_Other.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Other.TabIndex = 11;
            // 
            // comboBox_Group
            // 
            this.comboBox_Group.FormattingEnabled = true;
            this.comboBox_Group.Location = new System.Drawing.Point(256, 152);
            this.comboBox_Group.Name = "comboBox_Group";
            this.comboBox_Group.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Group.TabIndex = 10;
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(93, 151);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 7;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // textBox_Delete
            // 
            this.textBox_Delete.Location = new System.Drawing.Point(256, 153);
            this.textBox_Delete.Name = "textBox_Delete";
            this.textBox_Delete.Size = new System.Drawing.Size(121, 20);
            this.textBox_Delete.TabIndex = 9;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(174, 151);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 8;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(12, 151);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(75, 23);
            this.button_Create.TabIndex = 6;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_StartServer
            // 
            this.button_StartServer.Location = new System.Drawing.Point(12, 177);
            this.button_StartServer.Name = "button_StartServer";
            this.button_StartServer.Size = new System.Drawing.Size(237, 23);
            this.button_StartServer.TabIndex = 12;
            this.button_StartServer.Text = "Start Server";
            this.button_StartServer.UseVisualStyleBackColor = true;
            this.button_StartServer.Click += new System.EventHandler(this.button_StartServer_Click);
            // 
            // textBox_Port
            // 
            this.textBox_Port.Location = new System.Drawing.Point(44, 206);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(84, 20);
            this.textBox_Port.TabIndex = 14;
            this.textBox_Port.Text = "33000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Port";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.button_StartServer);
            this.Controls.Add(this.comboBox_Other);
            this.Controls.Add(this.comboBox_Group);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.textBox_Delete);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.listBox_Tables);
            this.Controls.Add(this.dataGridView_Table);
            this.Name = "MainPage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Table;
        private System.Windows.Forms.ListBox listBox_Tables;
        private System.Windows.Forms.ComboBox comboBox_Other;
        private System.Windows.Forms.ComboBox comboBox_Group;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.TextBox textBox_Delete;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_StartServer;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label1;
    }
}

