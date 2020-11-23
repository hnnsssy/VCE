using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesigner
{
    [Serializable]
    public class Question
    {
        public string Body { get; set; }
        public BindingList<Answer> Answers { get { return answers; } }

        private BindingList<Answer> answers;

        public Question() { answers = new BindingList<Answer>(); }
        public Question(string body)
        {
            answers = new BindingList<Answer>();
            Body = body;
        }

        public void AddAnswer(string body, bool isCorrect)
        {
            answers.Add(new Answer(body, isCorrect));
        }

        public void AddAnswer(Answer answer)
        {
            answers.Add(answer);
        }

        public void RemoveAnswer(Answer answer)
        {
            answers.Remove(answer);
        }

        public void ResetBindings()
        {
            answers.ResetBindings();
        }
    }
}
