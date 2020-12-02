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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listBox_Tables = new System.Windows.Forms.ListBox();
            this.comboBox_Other = new System.Windows.Forms.ComboBox();
            this.comboBox_Group = new System.Windows.Forms.ComboBox();
            this.textBox_Delete = new System.Windows.Forms.TextBox();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox_Minimize = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_StartServer = new System.Windows.Forms.Button();
            this.dataGridView_Table = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_Tables
            // 
            this.listBox_Tables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.listBox_Tables.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Tables.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Tables.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox_Tables.FormattingEnabled = true;
            this.listBox_Tables.ItemHeight = 17;
            this.listBox_Tables.Items.AddRange(new object[] {
            "Group",
            "User",
            "Test",
            "GroupTest",
            "UserGroup",
            "TestResult"});
            this.listBox_Tables.Location = new System.Drawing.Point(15, 63);
            this.listBox_Tables.Name = "listBox_Tables";
            this.listBox_Tables.Size = new System.Drawing.Size(72, 121);
            this.listBox_Tables.TabIndex = 3;
            this.listBox_Tables.SelectedIndexChanged += new System.EventHandler(this.listBox_Tables_SelectedIndexChanged);
            // 
            // comboBox_Other
            // 
            this.comboBox_Other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.comboBox_Other.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Other.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Other.ForeColor = System.Drawing.Color.White;
            this.comboBox_Other.FormattingEnabled = true;
            this.comboBox_Other.Location = new System.Drawing.Point(186, 218);
            this.comboBox_Other.Name = "comboBox_Other";
            this.comboBox_Other.Size = new System.Drawing.Size(163, 24);
            this.comboBox_Other.TabIndex = 11;
            // 
            // comboBox_Group
            // 
            this.comboBox_Group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.comboBox_Group.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox_Group.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Group.ForeColor = System.Drawing.Color.White;
            this.comboBox_Group.FormattingEnabled = true;
            this.comboBox_Group.Location = new System.Drawing.Point(15, 218);
            this.comboBox_Group.Name = "comboBox_Group";
            this.comboBox_Group.Size = new System.Drawing.Size(163, 24);
            this.comboBox_Group.TabIndex = 10;
            // 
            // textBox_Delete
            // 
            this.textBox_Delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Delete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Delete.Location = new System.Drawing.Point(15, 218);
            this.textBox_Delete.Multiline = true;
            this.textBox_Delete.Name = "textBox_Delete";
            this.textBox_Delete.Size = new System.Drawing.Size(163, 24);
            this.textBox_Delete.TabIndex = 9;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Port.Location = new System.Drawing.Point(41, 32);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(46, 21);
            this.textBox_Port.TabIndex = 14;
            this.textBox_Port.Text = "33000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Port";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.panel.Controls.Add(this.pictureBox_Minimize);
            this.panel.Controls.Add(this.pictureBox_Close);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(360, 21);
            this.panel.TabIndex = 17;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // pictureBox_Minimize
            // 
            this.pictureBox_Minimize.Location = new System.Drawing.Point(310, 0);
            this.pictureBox_Minimize.Name = "pictureBox_Minimize";
            this.pictureBox_Minimize.Size = new System.Drawing.Size(25, 21);
            this.pictureBox_Minimize.TabIndex = 18;
            this.pictureBox_Minimize.TabStop = false;
            this.pictureBox_Minimize.Click += new System.EventHandler(this.pictureBox_Minimize_Click);
            this.pictureBox_Minimize.MouseEnter += new System.EventHandler(this.pictureBox_Minimize_MouseEnter);
            this.pictureBox_Minimize.MouseLeave += new System.EventHandler(this.pictureBox_Minimize_MouseLeave);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Location = new System.Drawing.Point(335, 0);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(25, 21);
            this.pictureBox_Close.TabIndex = 17;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            this.pictureBox_Close.MouseEnter += new System.EventHandler(this.pictureBox_Close_MouseEnter);
            this.pictureBox_Close.MouseLeave += new System.EventHandler(this.pictureBox_Close_MouseLeave);
            // 
            // button_Create
            // 
            this.button_Create.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Create.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Create.ForeColor = System.Drawing.Color.White;
            this.button_Create.Location = new System.Drawing.Point(15, 189);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(109, 25);
            this.button_Create.TabIndex = 18;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = false;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Update.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Update.ForeColor = System.Drawing.Color.White;
            this.button_Update.Location = new System.Drawing.Point(128, 189);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(109, 25);
            this.button_Update.TabIndex = 19;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Delete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.Location = new System.Drawing.Point(241, 189);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(109, 25);
            this.button_Delete.TabIndex = 20;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_StartServer
            // 
            this.button_StartServer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_StartServer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_StartServer.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_StartServer.ForeColor = System.Drawing.Color.White;
            this.button_StartServer.Location = new System.Drawing.Point(93, 31);
            this.button_StartServer.Name = "button_StartServer";
            this.button_StartServer.Size = new System.Drawing.Size(256, 25);
            this.button_StartServer.TabIndex = 22;
            this.button_StartServer.Text = "Start Server";
            this.button_StartServer.UseVisualStyleBackColor = false;
            this.button_StartServer.Click += new System.EventHandler(this.button_StartServer_Click);
            // 
            // dataGridView_Table
            // 
            this.dataGridView_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Table.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dataGridView_Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_Table.ColumnHeadersHeight = 25;
            this.dataGridView_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Table.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_Table.EnableHeadersVisualStyles = false;
            this.dataGridView_Table.GridColor = System.Drawing.Color.SteelBlue;
            this.dataGridView_Table.Location = new System.Drawing.Point(93, 62);
            this.dataGridView_Table.Name = "dataGridView_Table";
            this.dataGridView_Table.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Table.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_Table.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Table.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Table.Size = new System.Drawing.Size(257, 123);
            this.dataGridView_Table.TabIndex = 23;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(360, 250);
            this.Controls.Add(this.dataGridView_Table);
            this.Controls.Add(this.button_StartServer);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Port);
            this.Controls.Add(this.comboBox_Other);
            this.Controls.Add(this.comboBox_Group);
            this.Controls.Add(this.textBox_Delete);
            this.Controls.Add(this.listBox_Tables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox_Tables;
        private System.Windows.Forms.ComboBox comboBox_Other;
        private System.Windows.Forms.ComboBox comboBox_Group;
        private System.Windows.Forms.TextBox textBox_Delete;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox_Minimize;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_StartServer;
        private System.Windows.Forms.DataGridView dataGridView_Table;
    }
}

