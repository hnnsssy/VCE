namespace TestClient
{
    partial class Form1
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
            this.listBox_Tests = new System.Windows.Forms.ListBox();
            this.button_StartTest = new System.Windows.Forms.Button();
            this.groupBox_Test = new System.Windows.Forms.GroupBox();
            this.label_Question = new System.Windows.Forms.Label();
            this.checkedListBox_Answers = new System.Windows.Forms.CheckedListBox();
            this.button_NextQuestion = new System.Windows.Forms.Button();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_Pass = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_Test.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Tests
            // 
            this.listBox_Tests.FormattingEnabled = true;
            this.listBox_Tests.Location = new System.Drawing.Point(12, 12);
            this.listBox_Tests.Name = "listBox_Tests";
            this.listBox_Tests.Size = new System.Drawing.Size(120, 95);
            this.listBox_Tests.TabIndex = 0;
            // 
            // button_StartTest
            // 
            this.button_StartTest.Location = new System.Drawing.Point(12, 116);
            this.button_StartTest.Name = "button_StartTest";
            this.button_StartTest.Size = new System.Drawing.Size(119, 23);
            this.button_StartTest.TabIndex = 1;
            this.button_StartTest.Text = "StartTest";
            this.button_StartTest.UseVisualStyleBackColor = true;
            this.button_StartTest.Click += new System.EventHandler(this.button_StartTest_Click);
            // 
            // groupBox_Test
            // 
            this.groupBox_Test.Controls.Add(this.button_NextQuestion);
            this.groupBox_Test.Controls.Add(this.checkedListBox_Answers);
            this.groupBox_Test.Controls.Add(this.label_Question);
            this.groupBox_Test.Location = new System.Drawing.Point(158, 7);
            this.groupBox_Test.Name = "groupBox_Test";
            this.groupBox_Test.Size = new System.Drawing.Size(439, 132);
            this.groupBox_Test.TabIndex = 2;
            this.groupBox_Test.TabStop = false;
            this.groupBox_Test.Text = "Test";
            // 
            // label_Question
            // 
            this.label_Question.AutoSize = true;
            this.label_Question.Location = new System.Drawing.Point(6, 16);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(0, 13);
            this.label_Question.TabIndex = 0;
            // 
            // checkedListBox_Answers
            // 
            this.checkedListBox_Answers.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox_Answers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox_Answers.FormattingEnabled = true;
            this.checkedListBox_Answers.Location = new System.Drawing.Point(7, 38);
            this.checkedListBox_Answers.Name = "checkedListBox_Answers";
            this.checkedListBox_Answers.Size = new System.Drawing.Size(207, 90);
            this.checkedListBox_Answers.TabIndex = 1;
            // 
            // button_NextQuestion
            // 
            this.button_NextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_NextQuestion.Location = new System.Drawing.Point(358, 103);
            this.button_NextQuestion.Name = "button_NextQuestion";
            this.button_NextQuestion.Size = new System.Drawing.Size(75, 23);
            this.button_NextQuestion.TabIndex = 2;
            this.button_NextQuestion.Text = "--->";
            this.button_NextQuestion.UseVisualStyleBackColor = true;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(12, 159);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(118, 20);
            this.textBox_Login.TabIndex = 3;
            // 
            // textBox_Pass
            // 
            this.textBox_Pass.Location = new System.Drawing.Point(12, 183);
            this.textBox_Pass.Name = "textBox_Pass";
            this.textBox_Pass.Size = new System.Drawing.Size(118, 20);
            this.textBox_Pass.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "LogIn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 244);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox_Pass);
            this.Controls.Add(this.textBox_Login);
            this.Controls.Add(this.groupBox_Test);
            this.Controls.Add(this.button_StartTest);
            this.Controls.Add(this.listBox_Tests);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox_Test.ResumeLayout(false);
            this.groupBox_Test.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Tests;
        private System.Windows.Forms.Button button_StartTest;
        private System.Windows.Forms.GroupBox groupBox_Test;
        private System.Windows.Forms.Button button_NextQuestion;
        private System.Windows.Forms.CheckedListBox checkedListBox_Answers;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_Pass;
        private System.Windows.Forms.Button button2;
    }
}

