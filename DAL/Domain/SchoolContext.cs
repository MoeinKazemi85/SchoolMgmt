using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Domain
{
    public partial class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("name=SchoolContext")
        {
        }

        public virtual DbSet<CourseRegisteration> CourseRegisterations { get; set; }
        public virtual DbSet<Cours> Courses { get; set; }
        public virtual DbSet<FeePayment> FeePayments { get; set; }
        public virtual DbSet<Semester> Semesters { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(e => e.CourseRegisterations)
                .WithRequired(e => e.Student)
                .HasForeignKey(e => e.StudentID);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.FeePayments)
                .WithRequired(e => e.Student)
                .HasForeignKey(e => e.StudentID);
        }
    }
}
