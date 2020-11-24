using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDesigner
{
    public partial class MainPage : Form
    {
        private Test _test;
        private Question _currentQuestion;
        private Answer _currentAnswer;
        public MainPage()
        {
            InitializeComponent();
            _test = new Test();
        }

        private void UpdateQuestionsListBox()
        {
            _test.ResetBindings();
            listBox_Questions.DataSource = _test.Questions;
            listBox_Questions.ValueMember = "Body";
            UpdateQuestionCounter();
        }

        private void UpdateQuestionCounter()
        {
            label_QuestionCount.Text = $"Count: {_test.Questions.Count}";
        }

        private void UpdateAnswersListBox()
        {
            _currentQuestion.ResetBindings();
            string correctAnswerBody = _currentQuestion.GetBodyOfCorrectAnswer();
            if (correctAnswerBody != "")
                label_CorrectAnswer.Text = "Correct Answer: " + _currentQuestion.GetBodyOfCorrectAnswer();
            else label_CorrectAnswer.Text = "Correct Answer: ";
            listBox_Answers.DataSource = _currentQuestion.Answers;
            listBox_Answers.ValueMember = "Body";
            UpdateAnswersCounter();
        }

        private void UpdateAnswersCounter()
        {
            label_AnswerCount.Text = $"Count: {_currentQuestion.Answers.Count}";
        }

        private void button_AddQuestion_Click(object sender, EventArgs e)
        {
            _test.AddQuestion(textBox_Question.Text);
            UpdateQuestionsListBox();
            textBox_Question.Clear();
        }

        private void button_RemoveQuestion_Click(object sender, EventArgs e)
        {
            if(listBox_Questions.SelectedItem == null) return;
            _test.RemoveQuestion(_currentQuestion);
            UpdateQuestionsListBox();
        }

        private void button_EditQuestion_Click(object sender, EventArgs e)
        {
            if (listBox_Questions.SelectedItem == null) return;
            textBox_Question.Text = _currentQuestion.Body;
            button_SaveQuestion.Enabled = true;
        }

        private void button_SaveQuestion_Click(object sender, EventArgs e)
        {
            _currentQuestion.Body = textBox_Question.Text;
            textBox_Question.Clear();
            UpdateQuestionsListBox();
            button_SaveQuestion.Enabled = false;
        }

        private void listBox_Questions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentQuestion = (Question)listBox_Questions.SelectedItem;
            _currentAnswer = null;
            UpdateAnswersListBox();
        }

        private void button_AddAnswer_Click(object sender, EventArgs e)
        {
            Answer answer = new Answer(textBox_Answer.Text);
            _currentQuestion.AddAnswer(answer);
            listBox_Answers.SelectedItem = answer;
            textBox_Answer.Clear();
            UpdateAnswersListBox();
        }

        private void button_RemoveAnswer_Click(object sender, EventArgs e)
        {
            if (listBox_Answers.SelectedItem == null) return;
            _currentQuestion.RemoveAnswer(_currentAnswer);
            UpdateAnswersListBox();
        }

        private void button_EditAnswer_Click(object sender, EventArgs e)
        {
            if (listBox_Answers.SelectedItem == null) return;
            textBox_Answer.Text = _currentAnswer.Body;
            button_SaveAnswer.Enabled = true;
        }

        private void button_SaveAnswer_Click(object sender, EventArgs e)
        {
            _currentAnswer.Body = textBox_Answer.Text;
            textBox_Answer.Clear();
            UpdateAnswersListBox();
            button_SaveAnswer.Enabled = false;
        }

        private void listBox_Answers_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentAnswer = (Answer)listBox_Answers.SelectedItem;
            UpdateAnswersListBox();
        }

        private void button_ImportToXml_Click(object sender, EventArgs e)
        {
            _test.Title = textBox_Title.Text;
            _test.Author = textBox_Author.Text;
            _test.TimeToComplete = timePicker.Value.TimeOfDay.ToString();
            Serializer.Serialize(_test);
        }

        private void button_ExportFromXml_Click(object sender, EventArgs e)
        {

        }

        private void button_MarkAsCorrect_Click(object sender, EventArgs e)
        {
            _currentQuestion.SetCorrectAnswer(_currentAnswer);
            label_CorrectAnswer.Text = $"Correct Answer: {_currentAnswer.Body}";
        }
    }
}
