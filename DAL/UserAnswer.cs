using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserAnswer
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Answer Answer { get; set; }
        public string Dt { get; set; }
    }
}
