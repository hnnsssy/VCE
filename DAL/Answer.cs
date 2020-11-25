using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Answer
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public bool IsCorrect { get; set; }
        public int IdQuestion { get; set; }
        public Question Question { get; set; }
        public override string ToString()
        {
            return Body;
        }
    }
}
