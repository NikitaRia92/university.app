﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using University.Infrastructure;

#nullable disable

namespace University.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("University.Domain.Models.ConfirmationEnrollment", b =>
                {
                    b.Property<string>("ApplicantCode")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<int>("ApplicationNumber")
                        .HasMaxLength(6)
                        .HasColumnType("int");

                    b.Property<DateTime>("DateSubmissionApplication")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 2, 19, 49, 4, 163, DateTimeKind.Local).AddTicks(3300));

                    b.Property<string>("FullNameOfApplicant")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("ApplicantCode");

                    b.ToTable("ConfirmationEnrollments");
                });

            modelBuilder.Entity("University.Domain.Models.Faculty", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("Code");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("University.Domain.Models.FormedGroup", b =>
                {
                    b.Property<int>("RegistryNumber")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(8)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RegistryNumber"), 1L, 1);

                    b.Property<string>("FacultyCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("GroupNumber")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<int>("NumberOfStudentsInAGroup")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("SpecialtyCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("RegistryNumber");

                    b.ToTable("FormedGroups");
                });

            modelBuilder.Entity("University.Domain.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourceNumber")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<string>("FacultyCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("GroupNumber")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<string>("SpecialtyCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("University.Domain.Models.Speciality", b =>
                {
                    b.Property<string>("Code")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<char>("LevelsOfStudyAtTheUniversity")
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("MinimumPassingScore")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("NumberOfFreeSeats")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSeats")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasMaxLength(6)
                        .HasColumnType("int");

                    b.Property<string>("ShortName")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("Code");

                    b.ToTable("Specialities");
                });

            modelBuilder.Entity("University.Domain.Models.Statement", b =>
                {
                    b.Property<string>("ApplicantCode")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<bool>("Confirmation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("DateSubmissionDocuments")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDateAcceptanceDocuments")
                        .HasColumnType("datetime2");

                    b.Property<string>("FacultyCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("FormOfEducation")
                        .HasColumnType("int");

                    b.Property<string>("FullNameOfApplicant")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("NumberOfPointsScore")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<bool>("SchoolCertificat")
                        .HasColumnType("bit");

                    b.Property<string>("SpecialtyCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.HasKey("ApplicantCode");

                    b.HasIndex("ApplicantCode")
                        .IsUnique();

                    b.ToTable("Statements");
                });

            modelBuilder.Entity("University.Domain.Models.Student", b =>
                {
                    b.Property<string>("StudentCode")
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("FacultyCode")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<int>("FormOfEducation")
                        .HasColumnType("int");

                    b.Property<string>("FullNameOfStudent")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime>("GraduationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GroupNumber")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<string>("SpecialtyCode")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<DateTime>("StudentEnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TuitionPayment")
                        .HasMaxLength(6)
                        .HasColumnType("int");

                    b.HasKey("StudentCode");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
