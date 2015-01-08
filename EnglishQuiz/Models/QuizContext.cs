using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EnglishQuiz.Models
{
    public class QuizContext : DbContext
    {
        public QuizContext() : base ("DefaultConnection")
        {
        }

        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DbInitializer());
        }
    }
}