﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mvccccccccccccccccc.Models;

namespace mvccccccccccccccccc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210208140822_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("mvccccccccccccccccc.Models.student", b =>
                {
                    b.Property<int>("studentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("CIN")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("FirstName")
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("Varchar(100)");

                    b.HasKey("studentID");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
