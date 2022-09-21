﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portfolio.Data;

#nullable disable

namespace Portfolio.Data.Migrations
{
    [DbContext(typeof(PortfolioContext))]
    [Migration("20220921075143_added more seed data")]
    partial class addedmoreseeddata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.9");

            modelBuilder.Entity("ExperienceTag", b =>
                {
                    b.Property<int>("ExperiencesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ExperiencesId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("ExperienceTag");

                    b.HasData(
                        new
                        {
                            ExperiencesId = 1,
                            TagsId = 1
                        },
                        new
                        {
                            ExperiencesId = 1,
                            TagsId = 4
                        },
                        new
                        {
                            ExperiencesId = 1,
                            TagsId = 5
                        },
                        new
                        {
                            ExperiencesId = 2,
                            TagsId = 1
                        },
                        new
                        {
                            ExperiencesId = 2,
                            TagsId = 5
                        },
                        new
                        {
                            ExperiencesId = 2,
                            TagsId = 7
                        });
                });

            modelBuilder.Entity("Portfolio.Data.Entities.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartedAt")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                            Name = "Goudkoorts //als dat werkt",
                            StartedAt = new DateTime(2018, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Name = "Portfolio",
                            StartedAt = new DateTime(2022, 9, 21, 9, 51, 43, 252, DateTimeKind.Local).AddTicks(9700)
                        });
                });

            modelBuilder.Entity("Portfolio.Data.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("YearStarted")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "C#",
                            YearStarted = 2017
                        },
                        new
                        {
                            Id = 2,
                            Name = "HTML5",
                            YearStarted = 2016
                        },
                        new
                        {
                            Id = 3,
                            Name = "CSS3",
                            YearStarted = 2016
                        },
                        new
                        {
                            Id = 4,
                            Name = ".Net",
                            YearStarted = 2017
                        },
                        new
                        {
                            Id = 5,
                            Name = ".Net Core",
                            YearStarted = 2019
                        },
                        new
                        {
                            Id = 6,
                            Name = "Angular",
                            YearStarted = 2021
                        },
                        new
                        {
                            Id = 7,
                            Name = "Blazor",
                            YearStarted = 2022
                        });
                });

            modelBuilder.Entity("ExperienceTag", b =>
                {
                    b.HasOne("Portfolio.Data.Entities.Experience", null)
                        .WithMany()
                        .HasForeignKey("ExperiencesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Portfolio.Data.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
