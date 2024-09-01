﻿// <auto-generated />
using System;
using Learnwise.MinimalApi.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Learnwise.MinimalApi.Migrations
{
    [DbContext(typeof(LearnwisePersistence))]
    partial class LearnwisePersistenceModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0-preview.7.24405.3");

            modelBuilder.Entity("Learnwise.MinimalApi.Links.Data.Link", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<Guid>("TaskId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TaskId");

                    b.ToTable("Links", (string)null);
                });

            modelBuilder.Entity("Learnwise.MinimalApi.Roadmaps.Data.Roadmap", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Finished")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Progress")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoadmapImage")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoadmapUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalElementsCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Roadmaps", (string)null);
                });

            modelBuilder.Entity("Learnwise.MinimalApi.Tasks.Data.Task", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<DateTimeOffset>("Deadline")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Priority")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Tasks", (string)null);
                });

            modelBuilder.Entity("Learnwise.MinimalApi.Links.Data.Link", b =>
                {
                    b.HasOne("Learnwise.MinimalApi.Tasks.Data.Task", "Task")
                        .WithMany("Links")
                        .HasForeignKey("TaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Task");
                });

            modelBuilder.Entity("Learnwise.MinimalApi.Tasks.Data.Task", b =>
                {
                    b.OwnsMany("Learnwise.MinimalApi.Tasks.Data.CodeSnippet", "CodeSnippets", b1 =>
                        {
                            b1.Property<Guid>("TaskId")
                                .HasColumnType("TEXT");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Code")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<DateTimeOffset>("CreatedAt")
                                .HasColumnType("TEXT");

                            b1.HasKey("TaskId", "Id");

                            b1.ToTable("Tasks");

                            b1.ToJson("CodeSnippets");

                            b1.WithOwner()
                                .HasForeignKey("TaskId");
                        });

                    b.OwnsMany("Learnwise.MinimalApi.Tasks.Data.Note", "Notes", b1 =>
                        {
                            b1.Property<Guid>("TaskId")
                                .HasColumnType("TEXT");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Content")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<DateTimeOffset>("CreatedAt")
                                .HasColumnType("TEXT");

                            b1.HasKey("TaskId", "Id");

                            b1.ToTable("Tasks");

                            b1.ToJson("Notes");

                            b1.WithOwner()
                                .HasForeignKey("TaskId");
                        });

                    b.Navigation("CodeSnippets");

                    b.Navigation("Notes");
                });

            modelBuilder.Entity("Learnwise.MinimalApi.Tasks.Data.Task", b =>
                {
                    b.Navigation("Links");
                });
#pragma warning restore 612, 618
        }
    }
}
