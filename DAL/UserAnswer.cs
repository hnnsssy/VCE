using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserAnswer
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }
        public int IdAnswer { get; set; }
        public Answer Answer { get; set; }
        public string Dt { get; set; }
    }
}
