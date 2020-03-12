using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebStudents.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Score> Scores { get; set; }

        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .ToTable("Student")
                .HasKey(s => s.Id);


            modelBuilder.Entity<Score>()
                .ToTable("Score")
                .HasKey(s => s.Id);

            modelBuilder.Entity<Score>()
                .HasOne(s => s.Student)
                .WithMany(sc => sc.Scores)
                .HasForeignKey(s => s.StudentId);

            modelBuilder.Entity<Score>()
                .HasOne(s => s.Subject)
                .WithMany(s => s.Scores)
                .HasForeignKey(k => k.SubjectId);

            modelBuilder.Entity<Subject>()
                .ToTable("Subject")
                .HasKey(s => s.Id);

        }
    }
}
