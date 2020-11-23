using System;
using System.Collections.Generic;
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
        public List<Question> Questions { get { return questions; } }

        private List<Question> questions;

        public Test() { questions = new List<Question>(); }
        public Test(string title, string author, TimeSpan timeToComplete)
        {
            questions = new List<Question>();
            Title = title;
            Author = author;
            TimeToComplete = timeToComplete;
        }
    }
}
