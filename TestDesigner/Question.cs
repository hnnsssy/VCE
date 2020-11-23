using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesigner
{
    [Serializable]
    public class Question
    {
        public string Body { get; set; }
        public List<Answer> Answers { get { return answers; } }

        private List<Answer> answers;

        public Question() { answers = new List<Answer>(); }
        public Question(string body)
        {
            answers = new List<Answer>();
            Body = body;
        }
    }
}
