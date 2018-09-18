using CodeGym.Models.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGym.Models.EF
{
    public class CodeGymContext : DbContext
    {
        public CodeGymContext(DbContextOptions<CodeGymContext> options) :base (options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
                .HasKey(e => new { e.CourseEditionId, e.StudentID });

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.CourseEdition)
                .WithMany(c => c.Enrollments)
                .HasForeignKey(e => e.CourseEditionId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(s => s.Enrollments)
                .HasForeignKey(e => e.StudentID);

        }
    }
}
