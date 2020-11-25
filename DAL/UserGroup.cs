using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserGroup
    {
        public int IdUser { get; set; }
        public User User { get; set; }
        public int IdGroup { get; set; }
        public Group Group { get; set; }
    }
}
