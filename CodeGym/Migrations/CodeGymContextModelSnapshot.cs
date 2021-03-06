﻿// <auto-generated />
using System;
using CodeGym.Models.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeGym.Migrations
{
    [DbContext(typeof(CodeGymContext))]
    partial class CodeGymContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeGym.Models.Core.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int>("DurationInHours");

                    b.Property<int>("Level");

                    b.Property<string>("Prerequisites");

                    b.Property<string>("Syllabus");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CodeGym.Models.Core.CourseEdition", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cost");

                    b.Property<long>("CourseId");

                    b.Property<DateTime>("EndDate");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseEditions");
                });

            modelBuilder.Entity("CodeGym.Models.Core.Enrollment", b =>
                {
                    b.Property<long>("CourseEditionId");

                    b.Property<long>("StudentId");

                    b.Property<DateTime>("EnrollmentDate");

                    b.Property<int>("Score");

                    b.HasKey("CourseEditionId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("CodeGym.Models.Core.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Email");

                    b.Property<string>("Lastname");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CodeGym.Models.Core.CourseEdition", b =>
                {
                    b.HasOne("CodeGym.Models.Core.Course", "Course")
                        .WithMany("Editions")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CodeGym.Models.Core.Enrollment", b =>
                {
                    b.HasOne("CodeGym.Models.Core.CourseEdition", "CourseEdition")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseEditionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeGym.Models.Core.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
