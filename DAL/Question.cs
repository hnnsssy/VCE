using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string IdTest { get; set; }
        public Test Test { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
