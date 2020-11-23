using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesigner
{
    [Serializable]
    public class Test
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public TimeSpan TimeToComplete { get; set; }
        public BindingList<Question> Questions { get { return questions; } }

        private BindingList<Question> questions;

        public Test() { questions = new BindingList<Question>(); }
        public Test(string title, string author, TimeSpan timeToComplete)
        {
            questions = new BindingList<Question>();
            Title = title;
            Author = author;
            TimeToComplete = timeToComplete;
        }

        public void AddQuestion(string body)
        {
            questions.Add(new Question(body));
        }

        public void RemoveQuestion(Question question)
        {
            questions.Remove(question);
        }

        public void ResetBindings()
        {
            questions.ResetBindings();
        }
    }
}
