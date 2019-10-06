﻿// <auto-generated />
using System;
using Code_First_SqlServer_Web_Api.Dal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Code_First_SqlServer_Web_Api.Migrations
{
    [DbContext(typeof(EmployeeContext))]
    [Migration("20190922234154_Initial_Employees")]
    partial class Initial_Employees
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Code_First_SqlServer_Web_Api.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DataOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1L,
                            DataOfBirth = new DateTimeOffset(new DateTime(1991, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 1, 0, 0, 0)),
                            Email = "owamamwen@outlook.com",
                            FirstName = "Owamamwen",
                            Gender = "M",
                            LastName = "Ogunniyi",
                            PhoneNumber = "351-045-9350"
                        },
                        new
                        {
                            EmployeeId = 2L,
                            DataOfBirth = new DateTimeOffset(new DateTime(1973, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Email = "fede@gmail.com",
                            FirstName = "Federica",
                            Gender = "F",
                            LastName = "Dario",
                            PhoneNumber = "351-105-0380"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}