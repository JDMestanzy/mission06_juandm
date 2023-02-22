﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mission06_juandm.Models;

namespace mission06_juandm.Migrations
{
    [DbContext(typeof(MovieInfoContext))]
    partial class MovieInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("mission06_juandm.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Director")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            CategoryID = 1,
                            Director = "James Cameron",
                            Edited = false,
                            Rating = 2,
                            Title = "Avatar",
                            Year = 2009
                        },
                        new
                        {
                            MovieID = 2,
                            CategoryID = 2,
                            Director = "Ryan Little",
                            Edited = false,
                            Rating = 2,
                            Title = "Forever Strong",
                            Year = 2008
                        },
                        new
                        {
                            MovieID = 3,
                            CategoryID = 3,
                            Director = "Ryan Coogler",
                            Edited = false,
                            Rating = 2,
                            Title = "Creed",
                            Year = 2015
                        });
                });

            modelBuilder.Entity("mission06_juandm.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryID = 1,
                            CategoryName = "Science Fiction"
                        },
                        new
                        {
                            CategoryID = 2,
                            CategoryName = "Sports Drama"
                        },
                        new
                        {
                            CategoryID = 3,
                            CategoryName = "Action"
                        },
                        new
                        {
                            CategoryID = 4,
                            CategoryName = "Other"
                        });
                });

            modelBuilder.Entity("mission06_juandm.Models.ApplicationResponse", b =>
                {
                    b.HasOne("mission06_juandm.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
