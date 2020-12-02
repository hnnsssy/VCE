namespace TestClient
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            this.checkedListBox_Answers = new System.Windows.Forms.CheckedListBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.listBox_Tests = new System.Windows.Forms.ListBox();
            this.button_StartTest = new System.Windows.Forms.Button();
            this.button_EndTest = new System.Windows.Forms.Button();
            this.button_NextQuestion = new System.Windows.Forms.Button();
            this.button_PreviousQuestion = new System.Windows.Forms.Button();
            this.label_Question = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox_Minimize = new System.Windows.Forms.PictureBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_Login = new System.Windows.Forms.Label();
            this.groupBox_Login = new System.Windows.Forms.GroupBox();
            this.groupBox_Test = new System.Windows.Forms.GroupBox();
            this.label_Counter = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).BeginInit();
            this.groupBox_Login.SuspendLayout();
            this.groupBox_Test.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox_Answers
            // 
            this.checkedListBox_Answers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.checkedListBox_Answers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox_Answers.CheckOnClick = true;
            this.checkedListBox_Answers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox_Answers.ForeColor = System.Drawing.Color.White;
            this.checkedListBox_Answers.FormattingEnabled = true;
            this.checkedListBox_Answers.Location = new System.Drawing.Point(127, 47);
            this.checkedListBox_Answers.Name = "checkedListBox_Answers";
            this.checkedListBox_Answers.Size = new System.Drawing.Size(400, 92);
            this.checkedListBox_Answers.TabIndex = 1;
            this.checkedListBox_Answers.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_Answers_ItemCheck);
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login.Location = new System.Drawing.Point(29, 55);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(144, 22);
            this.textBox_Login.TabIndex = 3;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Pass.Location = new System.Drawing.Point(29, 83);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(144, 22);
            this.textBox_Pass.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // listBox_Tests
            // 
            this.listBox_Tests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.listBox_Tests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_Tests.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_Tests.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox_Tests.FormattingEnabled = true;
            this.listBox_Tests.ItemHeight = 17;
            this.listBox_Tests.Location = new System.Drawing.Point(12, 18);
            this.listBox_Tests.Name = "listBox_Tests";
            this.listBox_Tests.Size = new System.Drawing.Size(108, 121);
            this.listBox_Tests.TabIndex = 7;
            // 
            // button_StartTest
            // 
            this.button_StartTest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_StartTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_StartTest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_StartTest.ForeColor = System.Drawing.Color.White;
            this.button_StartTest.Location = new System.Drawing.Point(11, 143);
            this.button_StartTest.Name = "button_StartTest";
            this.button_StartTest.Size = new System.Drawing.Size(110, 25);
            this.button_StartTest.TabIndex = 19;
            this.button_StartTest.Text = "StartTest";
            this.button_StartTest.UseVisualStyleBackColor = false;
            this.button_StartTest.Click += new System.EventHandler(this.button_StartTest_Click);
            // 
            // button_EndTest
            // 
            this.button_EndTest.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_EndTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_EndTest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_EndTest.ForeColor = System.Drawing.Color.White;
            this.button_EndTest.Location = new System.Drawing.Point(417, 143);
            this.button_EndTest.Name = "button_EndTest";
            this.button_EndTest.Size = new System.Drawing.Size(109, 25);
            this.button_EndTest.TabIndex = 21;
            this.button_EndTest.Text = "End Test";
            this.button_EndTest.UseVisualStyleBackColor = false;
            this.button_EndTest.Click += new System.EventHandler(this.button_EndTest_Click);
            // 
            // button_NextQuestion
            // 
            this.button_NextQuestion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_NextQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_NextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_NextQuestion.ForeColor = System.Drawing.Color.White;
            this.button_NextQuestion.Location = new System.Drawing.Point(271, 143);
            this.button_NextQuestion.Name = "button_NextQuestion";
            this.button_NextQuestion.Size = new System.Drawing.Size(142, 25);
            this.button_NextQuestion.TabIndex = 22;
            this.button_NextQuestion.Text = "----->";
            this.button_NextQuestion.UseVisualStyleBackColor = false;
            this.button_NextQuestion.Click += new System.EventHandler(this.button_NextQuestion_Click);
            // 
            // button_PreviousQuestion
            // 
            this.button_PreviousQuestion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_PreviousQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_PreviousQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button_PreviousQuestion.ForeColor = System.Drawing.Color.White;
            this.button_PreviousQuestion.Location = new System.Drawing.Point(125, 143);
            this.button_PreviousQuestion.Name = "button_PreviousQuestion";
            this.button_PreviousQuestion.Size = new System.Drawing.Size(142, 25);
            this.button_PreviousQuestion.TabIndex = 23;
            this.button_PreviousQuestion.Text = "<-----";
            this.button_PreviousQuestion.UseVisualStyleBackColor = false;
            this.button_PreviousQuestion.Click += new System.EventHandler(this.button_PreviousQuestion_Click);
            // 
            // label_Question
            // 
            this.label_Question.AutoSize = true;
            this.label_Question.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Question.ForeColor = System.Drawing.Color.White;
            this.label_Question.Location = new System.Drawing.Point(122, 18);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(0, 19);
            this.label_Question.TabIndex = 24;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.panel.Controls.Add(this.pictureBox_Minimize);
            this.panel.Controls.Add(this.pictureBox_Close);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(223, 21);
            this.panel.TabIndex = 26;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.Location = new System.Drawing.Point(197, 0);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(25, 21);
            this.pictureBox_Close.TabIndex = 17;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            this.pictureBox_Close.MouseEnter += new System.EventHandler(this.pictureBox_Close_MouseEnter);
            this.pictureBox_Close.MouseLeave += new System.EventHandler(this.pictureBox_Close_MouseLeave);
            // 
            // pictureBox_Minimize
            // 
            this.pictureBox_Minimize.Location = new System.Drawing.Point(172, 0);
            this.pictureBox_Minimize.Name = "pictureBox_Minimize";
            this.pictureBox_Minimize.Size = new System.Drawing.Size(25, 21);
            this.pictureBox_Minimize.TabIndex = 18;
            this.pictureBox_Minimize.TabStop = false;
            this.pictureBox_Minimize.Click += new System.EventHandler(this.pictureBox_Minimize_Click);
            this.pictureBox_Minimize.MouseEnter += new System.EventHandler(this.pictureBox_Minimize_MouseEnter);
            this.pictureBox_Minimize.MouseLeave += new System.EventHandler(this.pictureBox_Minimize_MouseLeave);
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Login.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(29, 120);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(144, 25);
            this.button_Login.TabIndex = 27;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_Login
            // 
            this.label_Login.AutoSize = true;
            this.label_Login.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Login.ForeColor = System.Drawing.Color.White;
            this.label_Login.Location = new System.Drawing.Point(51, 16);
            this.label_Login.Name = "label_Login";
            this.label_Login.Size = new System.Drawing.Size(105, 36);
            this.label_Login.TabIndex = 28;
            this.label_Login.Text = "LOGIN";
            // 
            // groupBox_Login
            // 
            this.groupBox_Login.Controls.Add(this.label_Login);
            this.groupBox_Login.Controls.Add(this.textBox_Login);
            this.groupBox_Login.Controls.Add(this.button_Login);
            this.groupBox_Login.Controls.Add(this.textBox_Pass);
            this.groupBox_Login.Location = new System.Drawing.Point(12, 27);
            this.groupBox_Login.Name = "groupBox_Login";
            this.groupBox_Login.Size = new System.Drawing.Size(200, 160);
            this.groupBox_Login.TabIndex = 29;
            this.groupBox_Login.TabStop = false;
            // 
            // groupBox_Test
            // 
            this.groupBox_Test.Controls.Add(this.label_Counter);
            this.groupBox_Test.Controls.Add(this.listBox_Tests);
            this.groupBox_Test.Controls.Add(this.checkedListBox_Answers);
            this.groupBox_Test.Controls.Add(this.button_StartTest);
            this.groupBox_Test.Controls.Add(this.button_EndTest);
            this.groupBox_Test.Controls.Add(this.label_Question);
            this.groupBox_Test.Controls.Add(this.button_NextQuestion);
            this.groupBox_Test.Controls.Add(this.button_PreviousQuestion);
            this.groupBox_Test.Location = new System.Drawing.Point(12, 193);
            this.groupBox_Test.Name = "groupBox_Test";
            this.groupBox_Test.Size = new System.Drawing.Size(538, 184);
            this.groupBox_Test.TabIndex = 30;
            this.groupBox_Test.TabStop = false;
            // 
            // label_Counter
            // 
            this.label_Counter.AutoSize = true;
            this.label_Counter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.label_Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Counter.ForeColor = System.Drawing.Color.White;
            this.label_Counter.Location = new System.Drawing.Point(128, 124);
            this.label_Counter.Name = "label_Counter";
            this.label_Counter.Size = new System.Drawing.Size(27, 13);
            this.label_Counter.TabIndex = 27;
            this.label_Counter.Text = "0/0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(42)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(223, 196);
            this.Controls.Add(this.groupBox_Test);
            this.Controls.Add(this.groupBox_Login);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Minimize)).EndInit();
            this.groupBox_Login.ResumeLayout(false);
            this.groupBox_Login.PerformLayout();
            this.groupBox_Test.ResumeLayout(false);
            this.groupBox_Test.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBox_Answers;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox listBox_Tests;
        private System.Windows.Forms.Button button_StartTest;
        private System.Windows.Forms.Button button_EndTest;
        private System.Windows.Forms.Button button_NextQuestion;
        private System.Windows.Forms.Button button_PreviousQuestion;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox_Minimize;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_Login;
        private System.Windows.Forms.GroupBox groupBox_Login;
        private System.Windows.Forms.GroupBox groupBox_Test;
        private System.Windows.Forms.Label label_Counter;
    }
}

