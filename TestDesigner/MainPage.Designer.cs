namespace TestDesigner
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
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.label_TimeToCompelte = new System.Windows.Forms.Label();
            this.listBox_Questions = new System.Windows.Forms.ListBox();
            this.listBox_Answers = new System.Windows.Forms.ListBox();
            this.textBox_Title = new System.Windows.Forms.TextBox();
            this.textBox_Author = new System.Windows.Forms.TextBox();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.groupBox_QuestionEdit = new System.Windows.Forms.GroupBox();
            this.button_EditQuestion = new System.Windows.Forms.Button();
            this.label_QuestionCount = new System.Windows.Forms.Label();
            this.button_SaveQuestion = new System.Windows.Forms.Button();
            this.button_RemoveQuestion = new System.Windows.Forms.Button();
            this.button_AddQuestion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_EditAnswer = new System.Windows.Forms.Button();
            this.label_AnswerCount = new System.Windows.Forms.Label();
            this.button_SaveAnswer = new System.Windows.Forms.Button();
            this.button_RemoveAnswer = new System.Windows.Forms.Button();
            this.button_AddAnswer = new System.Windows.Forms.Button();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.button_ImportToXml = new System.Windows.Forms.Button();
            this.button_ExportFromXml = new System.Windows.Forms.Button();
            this.button_MarkAsCorrect = new System.Windows.Forms.Button();
            this.label_CorrectAnswer = new System.Windows.Forms.Label();
            this.groupBox_QuestionEdit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Location = new System.Drawing.Point(9, 13);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(27, 13);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Title";
            // 
            // label_Author
            // 
            this.label_Author.AutoSize = true;
            this.label_Author.Location = new System.Drawing.Point(9, 39);
            this.label_Author.Name = "label_Author";
            this.label_Author.Size = new System.Drawing.Size(38, 13);
            this.label_Author.TabIndex = 1;
            this.label_Author.Text = "Author";
            // 
            // label_TimeToCompelte
            // 
            this.label_TimeToCompelte.AutoSize = true;
            this.label_TimeToCompelte.Location = new System.Drawing.Point(9, 67);
            this.label_TimeToCompelte.Name = "label_TimeToCompelte";
            this.label_TimeToCompelte.Size = new System.Drawing.Size(30, 13);
            this.label_TimeToCompelte.TabIndex = 2;
            this.label_TimeToCompelte.Text = "Time";
            // 
            // listBox_Questions
            // 
            this.listBox_Questions.FormattingEnabled = true;
            this.listBox_Questions.Location = new System.Drawing.Point(6, 19);
            this.listBox_Questions.Name = "listBox_Questions";
            this.listBox_Questions.Size = new System.Drawing.Size(418, 69);
            this.listBox_Questions.TabIndex = 3;
            this.listBox_Questions.SelectedIndexChanged += new System.EventHandler(this.listBox_Questions_SelectedIndexChanged);
            // 
            // listBox_Answers
            // 
            this.listBox_Answers.FormattingEnabled = true;
            this.listBox_Answers.Location = new System.Drawing.Point(6, 19);
            this.listBox_Answers.Name = "listBox_Answers";
            this.listBox_Answers.Size = new System.Drawing.Size(312, 69);
            this.listBox_Answers.TabIndex = 4;
            this.listBox_Answers.SelectedIndexChanged += new System.EventHandler(this.listBox_Answers_SelectedIndexChanged);
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(57, 10);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(386, 20);
            this.textBox_Title.TabIndex = 5;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(57, 36);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(386, 20);
            this.textBox_Author.TabIndex = 6;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(57, 63);
            this.timePicker.Name = "timePicker";
            this.timePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(66, 20);
            this.timePicker.TabIndex = 7;
            this.timePicker.Value = new System.DateTime(2020, 11, 23, 0, 0, 0, 0);
            // 
            // textBox_Question
            // 
            this.textBox_Question.Location = new System.Drawing.Point(6, 94);
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(418, 20);
            this.textBox_Question.TabIndex = 8;
            // 
            // groupBox_QuestionEdit
            // 
            this.groupBox_QuestionEdit.Controls.Add(this.button_EditQuestion);
            this.groupBox_QuestionEdit.Controls.Add(this.label_QuestionCount);
            this.groupBox_QuestionEdit.Controls.Add(this.button_SaveQuestion);
            this.groupBox_QuestionEdit.Controls.Add(this.button_RemoveQuestion);
            this.groupBox_QuestionEdit.Controls.Add(this.button_AddQuestion);
            this.groupBox_QuestionEdit.Controls.Add(this.textBox_Question);
            this.groupBox_QuestionEdit.Controls.Add(this.listBox_Questions);
            this.groupBox_QuestionEdit.Location = new System.Drawing.Point(12, 89);
            this.groupBox_QuestionEdit.Name = "groupBox_QuestionEdit";
            this.groupBox_QuestionEdit.Size = new System.Drawing.Size(431, 171);
            this.groupBox_QuestionEdit.TabIndex = 9;
            this.groupBox_QuestionEdit.TabStop = false;
            this.groupBox_QuestionEdit.Text = "Question Editor";
            // 
            // button_EditQuestion
            // 
            this.button_EditQuestion.Location = new System.Drawing.Point(218, 121);
            this.button_EditQuestion.Name = "button_EditQuestion";
            this.button_EditQuestion.Size = new System.Drawing.Size(100, 23);
            this.button_EditQuestion.TabIndex = 14;
            this.button_EditQuestion.Text = "Edit Question";
            this.button_EditQuestion.UseVisualStyleBackColor = true;
            this.button_EditQuestion.Click += new System.EventHandler(this.button_EditQuestion_Click);
            // 
            // label_QuestionCount
            // 
            this.label_QuestionCount.AutoSize = true;
            this.label_QuestionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_QuestionCount.Location = new System.Drawing.Point(6, 147);
            this.label_QuestionCount.Name = "label_QuestionCount";
            this.label_QuestionCount.Size = new System.Drawing.Size(60, 15);
            this.label_QuestionCount.TabIndex = 13;
            this.label_QuestionCount.Text = "Count: 0";
            // 
            // button_SaveQuestion
            // 
            this.button_SaveQuestion.Enabled = false;
            this.button_SaveQuestion.Location = new System.Drawing.Point(325, 121);
            this.button_SaveQuestion.Name = "button_SaveQuestion";
            this.button_SaveQuestion.Size = new System.Drawing.Size(100, 23);
            this.button_SaveQuestion.TabIndex = 11;
            this.button_SaveQuestion.Text = "Save Question";
            this.button_SaveQuestion.UseVisualStyleBackColor = true;
            this.button_SaveQuestion.Click += new System.EventHandler(this.button_SaveQuestion_Click);
            // 
            // button_RemoveQuestion
            // 
            this.button_RemoveQuestion.Location = new System.Drawing.Point(112, 121);
            this.button_RemoveQuestion.Name = "button_RemoveQuestion";
            this.button_RemoveQuestion.Size = new System.Drawing.Size(100, 23);
            this.button_RemoveQuestion.TabIndex = 10;
            this.button_RemoveQuestion.Text = "Remove Question";
            this.button_RemoveQuestion.UseVisualStyleBackColor = true;
            this.button_RemoveQuestion.Click += new System.EventHandler(this.button_RemoveQuestion_Click);
            // 
            // button_AddQuestion
            // 
            this.button_AddQuestion.Location = new System.Drawing.Point(6, 121);
            this.button_AddQuestion.Name = "button_AddQuestion";
            this.button_AddQuestion.Size = new System.Drawing.Size(100, 23);
            this.button_AddQuestion.TabIndex = 9;
            this.button_AddQuestion.Text = "Add Question";
            this.button_AddQuestion.UseVisualStyleBackColor = true;
            this.button_AddQuestion.Click += new System.EventHandler(this.button_AddQuestion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_CorrectAnswer);
            this.groupBox1.Controls.Add(this.button_MarkAsCorrect);
            this.groupBox1.Controls.Add(this.button_EditAnswer);
            this.groupBox1.Controls.Add(this.label_AnswerCount);
            this.groupBox1.Controls.Add(this.button_SaveAnswer);
            this.groupBox1.Controls.Add(this.button_RemoveAnswer);
            this.groupBox1.Controls.Add(this.button_AddAnswer);
            this.groupBox1.Controls.Add(this.textBox_Answer);
            this.groupBox1.Controls.Add(this.listBox_Answers);
            this.groupBox1.Location = new System.Drawing.Point(12, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 186);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Answer Editor";
            // 
            // button_EditAnswer
            // 
            this.button_EditAnswer.Location = new System.Drawing.Point(218, 120);
            this.button_EditAnswer.Name = "button_EditAnswer";
            this.button_EditAnswer.Size = new System.Drawing.Size(100, 23);
            this.button_EditAnswer.TabIndex = 15;
            this.button_EditAnswer.Text = "Edit Answer";
            this.button_EditAnswer.UseVisualStyleBackColor = true;
            this.button_EditAnswer.Click += new System.EventHandler(this.button_EditAnswer_Click);
            // 
            // label_AnswerCount
            // 
            this.label_AnswerCount.AutoSize = true;
            this.label_AnswerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AnswerCount.Location = new System.Drawing.Point(6, 146);
            this.label_AnswerCount.Name = "label_AnswerCount";
            this.label_AnswerCount.Size = new System.Drawing.Size(60, 15);
            this.label_AnswerCount.TabIndex = 12;
            this.label_AnswerCount.Text = "Count: 0";
            // 
            // button_SaveAnswer
            // 
            this.button_SaveAnswer.Enabled = false;
            this.button_SaveAnswer.Location = new System.Drawing.Point(324, 120);
            this.button_SaveAnswer.Name = "button_SaveAnswer";
            this.button_SaveAnswer.Size = new System.Drawing.Size(100, 23);
            this.button_SaveAnswer.TabIndex = 11;
            this.button_SaveAnswer.Text = "Save Answer";
            this.button_SaveAnswer.UseVisualStyleBackColor = true;
            this.button_SaveAnswer.Click += new System.EventHandler(this.button_SaveAnswer_Click);
            // 
            // button_RemoveAnswer
            // 
            this.button_RemoveAnswer.Location = new System.Drawing.Point(112, 120);
            this.button_RemoveAnswer.Name = "button_RemoveAnswer";
            this.button_RemoveAnswer.Size = new System.Drawing.Size(100, 23);
            this.button_RemoveAnswer.TabIndex = 10;
            this.button_RemoveAnswer.Text = "Remove Answer";
            this.button_RemoveAnswer.UseVisualStyleBackColor = true;
            this.button_RemoveAnswer.Click += new System.EventHandler(this.button_RemoveAnswer_Click);
            // 
            // button_AddAnswer
            // 
            this.button_AddAnswer.Location = new System.Drawing.Point(6, 120);
            this.button_AddAnswer.Name = "button_AddAnswer";
            this.button_AddAnswer.Size = new System.Drawing.Size(100, 23);
            this.button_AddAnswer.TabIndex = 9;
            this.button_AddAnswer.Text = "Add Answer";
            this.button_AddAnswer.UseVisualStyleBackColor = true;
            this.button_AddAnswer.Click += new System.EventHandler(this.button_AddAnswer_Click);
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Location = new System.Drawing.Point(6, 94);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(418, 20);
            this.textBox_Answer.TabIndex = 8;
            // 
            // button_ImportToXml
            // 
            this.button_ImportToXml.Location = new System.Drawing.Point(12, 458);
            this.button_ImportToXml.Name = "button_ImportToXml";
            this.button_ImportToXml.Size = new System.Drawing.Size(212, 23);
            this.button_ImportToXml.TabIndex = 13;
            this.button_ImportToXml.Text = "Import to XML";
            this.button_ImportToXml.UseVisualStyleBackColor = true;
            this.button_ImportToXml.Click += new System.EventHandler(this.button_ImportToXml_Click);
            // 
            // button_ExportFromXml
            // 
            this.button_ExportFromXml.Location = new System.Drawing.Point(230, 458);
            this.button_ExportFromXml.Name = "button_ExportFromXml";
            this.button_ExportFromXml.Size = new System.Drawing.Size(213, 23);
            this.button_ExportFromXml.TabIndex = 14;
            this.button_ExportFromXml.Text = "Export from XML";
            this.button_ExportFromXml.UseVisualStyleBackColor = true;
            this.button_ExportFromXml.Click += new System.EventHandler(this.button_ExportFromXml_Click);
            // 
            // button_MarkAsCorrect
            // 
            this.button_MarkAsCorrect.Location = new System.Drawing.Point(325, 19);
            this.button_MarkAsCorrect.Name = "button_MarkAsCorrect";
            this.button_MarkAsCorrect.Size = new System.Drawing.Size(99, 69);
            this.button_MarkAsCorrect.TabIndex = 16;
            this.button_MarkAsCorrect.Text = "Mark As Correct";
            this.button_MarkAsCorrect.UseVisualStyleBackColor = true;
            this.button_MarkAsCorrect.Click += new System.EventHandler(this.button_MarkAsCorrect_Click);
            // 
            // label_CorrectAnswer
            // 
            this.label_CorrectAnswer.AutoSize = true;
            this.label_CorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_CorrectAnswer.Location = new System.Drawing.Point(6, 163);
            this.label_CorrectAnswer.Name = "label_CorrectAnswer";
            this.label_CorrectAnswer.Size = new System.Drawing.Size(111, 15);
            this.label_CorrectAnswer.TabIndex = 17;
            this.label_CorrectAnswer.Text = "Correct Answer: ";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 493);
            this.Controls.Add(this.button_ExportFromXml);
            this.Controls.Add(this.button_ImportToXml);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_QuestionEdit);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.textBox_Author);
            this.Controls.Add(this.textBox_Title);
            this.Controls.Add(this.label_TimeToCompelte);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.label_Title);
            this.Name = "MainPage";
            this.Text = "Test Designer";
            this.groupBox_QuestionEdit.ResumeLayout(false);
            this.groupBox_QuestionEdit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label_TimeToCompelte;
        private System.Windows.Forms.ListBox listBox_Questions;
        private System.Windows.Forms.ListBox listBox_Answers;
        private System.Windows.Forms.TextBox textBox_Title;
        private System.Windows.Forms.TextBox textBox_Author;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.TextBox textBox_Question;
        private System.Windows.Forms.GroupBox groupBox_QuestionEdit;
        private System.Windows.Forms.Button button_RemoveQuestion;
        private System.Windows.Forms.Button button_AddQuestion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_RemoveAnswer;
        private System.Windows.Forms.Button button_AddAnswer;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label label_QuestionCount;
        private System.Windows.Forms.Label label_AnswerCount;
        private System.Windows.Forms.Button button_SaveQuestion;
        private System.Windows.Forms.Button button_SaveAnswer;
        private System.Windows.Forms.Button button_ImportToXml;
        private System.Windows.Forms.Button button_ExportFromXml;
        private System.Windows.Forms.Button button_EditQuestion;
        private System.Windows.Forms.Button button_EditAnswer;
        private System.Windows.Forms.Button button_MarkAsCorrect;
        private System.Windows.Forms.Label label_CorrectAnswer;
    }
}

