using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        public void AddAnswer(string body)
        {
            answers.Add(new Answer(body));
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

        public void SetCorrectAnswer(Answer correctAnwser)
        {
            foreach (Answer item in answers)
            {
                if (item == correctAnwser)
                    correctAnwser.IsCorrectAnswer = true;
                else item.IsCorrectAnswer = false;
            }
        }

        public string GetBodyOfCorrectAnswer()
        {
            return answers.Where(x => x.IsCorrectAnswer == true).Select(x => x.Body).FirstOrDefault();
        }
    }
}
