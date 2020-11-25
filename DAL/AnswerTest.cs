using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AnswerTest
    {
        public int Id { get; set; }
        public int IdGroup { get; set; }
        public Group Group { get; set; }
        public int IdTest { get; set; }
        public Test Test { get; set; }
    }
}
