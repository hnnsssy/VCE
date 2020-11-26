using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWrappersLib
{
    [Serializable]
    public class TestWrap
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<QuestionWrap> Questions { get; set; }
        public TestWrap() { Questions = new List<QuestionWrap>(); }
        public override string ToString()
        {
            return Title;
        }
    }

    [Serializable]
    public class QuestionWrap
    {
        public string Body { get; set; }
        public List<AnswerWrap> Answers { get; set; }
        public QuestionWrap() { Answers = new List<AnswerWrap>(); }
    }

    [Serializable]
    public class AnswerWrap
    {
        public string Answer { get; set; }
        public AnswerWrap() { }
    }
}
