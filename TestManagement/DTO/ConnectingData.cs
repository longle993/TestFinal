using System;
using System.Configuration;
using System.Data.Entity;

namespace TestManagement.DTO
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    internal class ConnectingData : DbContext
    {
        public ConnectingData() : base(ConfigurationManager.ConnectionStrings["Test"].ConnectionString)
        {
        }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Result> Results { get; set; }
        public DbSet<TestDetail> TestDetails { get; set; }
        public DbSet<TestTimes> TestTimes { get; set; }
        public DbSet<Question> Questions { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Test>().ToTable("Test");
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Subject>().ToTable("Subject");
            modelBuilder.Entity<Question>().ToTable("Question");

            modelBuilder.Entity<Answer>().ToTable("Answer");
            modelBuilder.Entity<Answer>()
                .HasKey(td => new { td.AnswerID, td.QuestionID });
            modelBuilder.Entity<Answer>()
                .Property(td => td.AnswerID)
                .HasColumnOrder(1);

            modelBuilder.Entity<Answer>()
                .Property(td => td.QuestionID)
                .HasColumnOrder(2);

            modelBuilder.Entity<TestDetail>().ToTable("TestDetail");
            modelBuilder.Entity<TestDetail>()
                .HasKey(td => new { td.TestID, td.QuestionID });

            modelBuilder.Entity<TestDetail>()
                .Property(td => td.TestID)
                .HasColumnOrder(1);

            modelBuilder.Entity<TestDetail>()
                .Property(td => td.QuestionID)
                .HasColumnOrder(2);

            modelBuilder.Entity<TestTimes>().ToTable("TestTimes");

            modelBuilder.Entity<Result>().ToTable("Result");
            base.OnModelCreating(modelBuilder);
        }

        private object Property(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
