﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proiect.Data;

#nullable disable

namespace Proiect.Migrations
{
    [DbContext(typeof(ProiectContext))]
    [Migration("20221228093533_GymCategory")]
    partial class GymCategory
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Proiect.Models.Borrowing", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("ClientID")
                        .HasColumnType("int");

                    b.Property<int?>("GymID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ClientID");

                    b.HasIndex("GymID");

                    b.ToTable("Borrowing");
                });

            modelBuilder.Entity("Proiect.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Proiect.Models.Client", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Proiect.Models.Gym", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int?>("TrainerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TrainerID");

                    b.ToTable("Gym");
                });

            modelBuilder.Entity("Proiect.Models.GymCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("GymID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("GymID");

                    b.ToTable("GymCategory");
                });

            modelBuilder.Entity("Proiect.Models.Trainer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Trainer");
                });

            modelBuilder.Entity("Proiect.Models.TrainerCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("TrainerID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("TrainerID");

                    b.ToTable("TrainerCategory");
                });

            modelBuilder.Entity("Proiect.Models.Borrowing", b =>
                {
                    b.HasOne("Proiect.Models.Client", "Client")
                        .WithMany("Borrowings")
                        .HasForeignKey("ClientID");

                    b.HasOne("Proiect.Models.Gym", "Gym")
                        .WithMany()
                        .HasForeignKey("GymID");

                    b.Navigation("Client");

                    b.Navigation("Gym");
                });

            modelBuilder.Entity("Proiect.Models.Gym", b =>
                {
                    b.HasOne("Proiect.Models.Trainer", "Trainer")
                        .WithMany("Gyms")
                        .HasForeignKey("TrainerID");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Proiect.Models.GymCategory", b =>
                {
                    b.HasOne("Proiect.Models.Category", "Category")
                        .WithMany("GymCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect.Models.Gym", "Gym")
                        .WithMany("GymCategories")
                        .HasForeignKey("GymID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Gym");
                });

            modelBuilder.Entity("Proiect.Models.TrainerCategory", b =>
                {
                    b.HasOne("Proiect.Models.Category", "Category")
                        .WithMany("TrainerCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Proiect.Models.Trainer", "Trainer")
                        .WithMany("TrainerCategories")
                        .HasForeignKey("TrainerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("Proiect.Models.Category", b =>
                {
                    b.Navigation("GymCategories");

                    b.Navigation("TrainerCategories");
                });

            modelBuilder.Entity("Proiect.Models.Client", b =>
                {
                    b.Navigation("Borrowings");
                });

            modelBuilder.Entity("Proiect.Models.Gym", b =>
                {
                    b.Navigation("GymCategories");
                });

            modelBuilder.Entity("Proiect.Models.Trainer", b =>
                {
                    b.Navigation("Gyms");

                    b.Navigation("TrainerCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
