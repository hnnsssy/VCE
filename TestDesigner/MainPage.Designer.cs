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
            this.button_AddQuestion = new System.Windows.Forms.Button();
            this.button_RemoveQuestion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_RemveAnswer = new System.Windows.Forms.Button();
            this.button_AddAnswer = new System.Windows.Forms.Button();
            this.textBox_Answer = new System.Windows.Forms.TextBox();
            this.label_AnswerCoutnt = new System.Windows.Forms.Label();
            this.label_QuestionCount = new System.Windows.Forms.Label();
            this.checkBox_CorrectAnswer = new System.Windows.Forms.CheckBox();
            this.button_SaveAnswer = new System.Windows.Forms.Button();
            this.button_SaveQuestion = new System.Windows.Forms.Button();
            this.button_ImportToXml = new System.Windows.Forms.Button();
            this.button_ExportFromXml = new System.Windows.Forms.Button();
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
            this.listBox_Questions.Size = new System.Drawing.Size(369, 69);
            this.listBox_Questions.TabIndex = 3;
            // 
            // listBox_Answers
            // 
            this.listBox_Answers.FormattingEnabled = true;
            this.listBox_Answers.Location = new System.Drawing.Point(6, 19);
            this.listBox_Answers.Name = "listBox_Answers";
            this.listBox_Answers.Size = new System.Drawing.Size(369, 69);
            this.listBox_Answers.TabIndex = 4;
            // 
            // textBox_Title
            // 
            this.textBox_Title.Location = new System.Drawing.Point(57, 10);
            this.textBox_Title.Name = "textBox_Title";
            this.textBox_Title.Size = new System.Drawing.Size(336, 20);
            this.textBox_Title.TabIndex = 5;
            // 
            // textBox_Author
            // 
            this.textBox_Author.Location = new System.Drawing.Point(57, 36);
            this.textBox_Author.Name = "textBox_Author";
            this.textBox_Author.Size = new System.Drawing.Size(336, 20);
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
            this.textBox_Question.Size = new System.Drawing.Size(369, 20);
            this.textBox_Question.TabIndex = 8;
            // 
            // groupBox_QuestionEdit
            // 
            this.groupBox_QuestionEdit.Controls.Add(this.label_QuestionCount);
            this.groupBox_QuestionEdit.Controls.Add(this.button_SaveQuestion);
            this.groupBox_QuestionEdit.Controls.Add(this.button_RemoveQuestion);
            this.groupBox_QuestionEdit.Controls.Add(this.button_AddQuestion);
            this.groupBox_QuestionEdit.Controls.Add(this.textBox_Question);
            this.groupBox_QuestionEdit.Controls.Add(this.listBox_Questions);
            this.groupBox_QuestionEdit.Location = new System.Drawing.Point(12, 89);
            this.groupBox_QuestionEdit.Name = "groupBox_QuestionEdit";
            this.groupBox_QuestionEdit.Size = new System.Drawing.Size(381, 171);
            this.groupBox_QuestionEdit.TabIndex = 9;
            this.groupBox_QuestionEdit.TabStop = false;
            this.groupBox_QuestionEdit.Text = "Question Editor";
            // 
            // button_AddQuestion
            // 
            this.button_AddQuestion.Location = new System.Drawing.Point(6, 121);
            this.button_AddQuestion.Name = "button_AddQuestion";
            this.button_AddQuestion.Size = new System.Drawing.Size(119, 23);
            this.button_AddQuestion.TabIndex = 9;
            this.button_AddQuestion.Text = "Add Question";
            this.button_AddQuestion.UseVisualStyleBackColor = true;
            // 
            // button_RemoveQuestion
            // 
            this.button_RemoveQuestion.Location = new System.Drawing.Point(131, 121);
            this.button_RemoveQuestion.Name = "button_RemoveQuestion";
            this.button_RemoveQuestion.Size = new System.Drawing.Size(119, 23);
            this.button_RemoveQuestion.TabIndex = 10;
            this.button_RemoveQuestion.Text = "Remove Question";
            this.button_RemoveQuestion.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_CorrectAnswer);
            this.groupBox1.Controls.Add(this.label_AnswerCoutnt);
            this.groupBox1.Controls.Add(this.button_SaveAnswer);
            this.groupBox1.Controls.Add(this.button_RemveAnswer);
            this.groupBox1.Controls.Add(this.button_AddAnswer);
            this.groupBox1.Controls.Add(this.textBox_Answer);
            this.groupBox1.Controls.Add(this.listBox_Answers);
            this.groupBox1.Location = new System.Drawing.Point(12, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 171);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Answer Editor";
            // 
            // button_RemveAnswer
            // 
            this.button_RemveAnswer.Location = new System.Drawing.Point(131, 120);
            this.button_RemveAnswer.Name = "button_RemveAnswer";
            this.button_RemveAnswer.Size = new System.Drawing.Size(119, 23);
            this.button_RemveAnswer.TabIndex = 10;
            this.button_RemveAnswer.Text = "Remove Answer";
            this.button_RemveAnswer.UseVisualStyleBackColor = true;
            // 
            // button_AddAnswer
            // 
            this.button_AddAnswer.Location = new System.Drawing.Point(6, 120);
            this.button_AddAnswer.Name = "button_AddAnswer";
            this.button_AddAnswer.Size = new System.Drawing.Size(119, 23);
            this.button_AddAnswer.TabIndex = 9;
            this.button_AddAnswer.Text = "Add Answer";
            this.button_AddAnswer.UseVisualStyleBackColor = true;
            // 
            // textBox_Answer
            // 
            this.textBox_Answer.Location = new System.Drawing.Point(6, 94);
            this.textBox_Answer.Name = "textBox_Answer";
            this.textBox_Answer.Size = new System.Drawing.Size(292, 20);
            this.textBox_Answer.TabIndex = 8;
            // 
            // label_AnswerCoutnt
            // 
            this.label_AnswerCoutnt.AutoSize = true;
            this.label_AnswerCoutnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_AnswerCoutnt.Location = new System.Drawing.Point(6, 146);
            this.label_AnswerCoutnt.Name = "label_AnswerCoutnt";
            this.label_AnswerCoutnt.Size = new System.Drawing.Size(60, 15);
            this.label_AnswerCoutnt.TabIndex = 12;
            this.label_AnswerCoutnt.Text = "Count: 0";
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
            // checkBox_CorrectAnswer
            // 
            this.checkBox_CorrectAnswer.AutoSize = true;
            this.checkBox_CorrectAnswer.Location = new System.Drawing.Point(304, 97);
            this.checkBox_CorrectAnswer.Name = "checkBox_CorrectAnswer";
            this.checkBox_CorrectAnswer.Size = new System.Drawing.Size(71, 17);
            this.checkBox_CorrectAnswer.TabIndex = 13;
            this.checkBox_CorrectAnswer.Text = "Is Correct";
            this.checkBox_CorrectAnswer.UseVisualStyleBackColor = true;
            // 
            // button_SaveAnswer
            // 
            this.button_SaveAnswer.Location = new System.Drawing.Point(256, 120);
            this.button_SaveAnswer.Name = "button_SaveAnswer";
            this.button_SaveAnswer.Size = new System.Drawing.Size(119, 23);
            this.button_SaveAnswer.TabIndex = 11;
            this.button_SaveAnswer.Text = "Save Answer";
            this.button_SaveAnswer.UseVisualStyleBackColor = true;
            // 
            // button_SaveQuestion
            // 
            this.button_SaveQuestion.Location = new System.Drawing.Point(256, 121);
            this.button_SaveQuestion.Name = "button_SaveQuestion";
            this.button_SaveQuestion.Size = new System.Drawing.Size(119, 23);
            this.button_SaveQuestion.TabIndex = 11;
            this.button_SaveQuestion.Text = "Save Question";
            this.button_SaveQuestion.UseVisualStyleBackColor = true;
            // 
            // button_ImportToXml
            // 
            this.button_ImportToXml.Location = new System.Drawing.Point(12, 443);
            this.button_ImportToXml.Name = "button_ImportToXml";
            this.button_ImportToXml.Size = new System.Drawing.Size(381, 23);
            this.button_ImportToXml.TabIndex = 13;
            this.button_ImportToXml.Text = "Import to XML";
            this.button_ImportToXml.UseVisualStyleBackColor = true;
            // 
            // button_ExportFromXml
            // 
            this.button_ExportFromXml.Location = new System.Drawing.Point(12, 472);
            this.button_ExportFromXml.Name = "button_ExportFromXml";
            this.button_ExportFromXml.Size = new System.Drawing.Size(381, 23);
            this.button_ExportFromXml.TabIndex = 14;
            this.button_ExportFromXml.Text = "Export from XML";
            this.button_ExportFromXml.UseVisualStyleBackColor = true;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 506);
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
        private System.Windows.Forms.Button button_RemveAnswer;
        private System.Windows.Forms.Button button_AddAnswer;
        private System.Windows.Forms.TextBox textBox_Answer;
        private System.Windows.Forms.Label label_QuestionCount;
        private System.Windows.Forms.CheckBox checkBox_CorrectAnswer;
        private System.Windows.Forms.Label label_AnswerCoutnt;
        private System.Windows.Forms.Button button_SaveQuestion;
        private System.Windows.Forms.Button button_SaveAnswer;
        private System.Windows.Forms.Button button_ImportToXml;
        private System.Windows.Forms.Button button_ExportFromXml;
    }
}

