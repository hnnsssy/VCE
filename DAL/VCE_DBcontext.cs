using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VCE_DBcontext : DbContext
    {
        public VCE_DBcontext() { }
        public VCE_DBcontext(string conStr) : base(conStr) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<SageBook>().HasKey(sb => new { sb.SageId, sb.BookId });
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserAnswer> UserAnswers { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<GroupTest> AnswerTests { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
