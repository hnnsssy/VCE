using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesigner
{
    [Serializable]
    public class Answer
    {
        public string Body { get; set; }
        public bool IsCorrectAnswer { get; set; }

        public Answer() { }
        public Answer(string body, bool isCorrectAnswer) 
        {
            Body = body;
            IsCorrectAnswer = isCorrectAnswer;
        }
    }
}
