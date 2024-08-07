﻿// <auto-generated />
using System;
using AP.MyGameStore.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MyGameStore.Migrations
{
    [DbContext(typeof(MyGameStoreContext))]
    [Migration("20220224164411_Seeding")]
    partial class Seeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyGameStore.Model.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("EmailAddress");

                    b.Property<int>("EmployerId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.HasIndex("EmployerId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("tblPeople", "Person");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "a@b.com",
                            EmployerId = -1,
                            FirstName = "Sven",
                            Gender = 1,
                            LastName = "Mariën"
                        });
                });

            modelBuilder.Entity("MyGameStore.Model.Store", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Addition")
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(60)")
                        .HasColumnName("Place");

                    b.Property<bool>("IsFranchiseStore")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Zipcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("tblStores", "Store");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Addition = "",
                            City = "Antwerp",
                            IsFranchiseStore = false,
                            Name = "ABC",
                            Number = "10A",
                            Street = "Ellerman",
                            Zipcode = "2000"
                        });
                });

            modelBuilder.Entity("MyGameStore.Model.Person", b =>
                {
                    b.HasOne("MyGameStore.Model.Store", "Employer")
                        .WithMany("Employees")
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employer");
                });

            modelBuilder.Entity("MyGameStore.Model.Store", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
