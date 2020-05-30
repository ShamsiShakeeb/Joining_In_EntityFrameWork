﻿// <auto-generated />
using Joining_In_EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Joining_In_EF.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200530145149_DatabaseFile8")]
    partial class DatabaseFile8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Joining_In_EF.Models.Student", b =>
                {
                    b.Property<int>("Student_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Student_ID");

                    b.ToTable("student");
                });

            modelBuilder.Entity("Joining_In_EF.Models.Student_And_Subject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Student_ID")
                        .HasColumnType("int");

                    b.Property<int>("Subject_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Student_ID");

                    b.HasIndex("Subject_ID");

                    b.ToTable("Student_And_Subject");
                });

            modelBuilder.Entity("Joining_In_EF.Models.Subject", b =>
                {
                    b.Property<int>("Subject_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Subject_ID");

                    b.ToTable("subject");
                });

            modelBuilder.Entity("Joining_In_EF.Models.Student_And_Subject", b =>
                {
                    b.HasOne("Joining_In_EF.Models.Student", "Student")
                        .WithMany("Student_Join_Subject")
                        .HasForeignKey("Student_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Joining_In_EF.Models.Subject", "Subject")
                        .WithMany("Student_Join_Subject")
                        .HasForeignKey("Subject_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}