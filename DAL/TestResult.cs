using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TestResult
    {
        public int Id { get; set; }
        public Test Test { get; set; }
        public User User { get; set; }
        public string Result { get; set; }
        public override string ToString()
        {
            return User.Name;
        }
    }
}
