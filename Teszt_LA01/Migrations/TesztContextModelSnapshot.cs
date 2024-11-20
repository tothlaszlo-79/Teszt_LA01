﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Teszt_LA01.Data;

#nullable disable

namespace Teszt_LA01.Migrations
{
    [DbContext(typeof(TesztContext))]
    partial class TesztContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Teszt_LA01.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Teszt 1",
                            Name = "Teszt 1"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "Teszt 2",
                            Name = "Teszt 2"
                        });
                });

            modelBuilder.Entity("Teszt_LA01.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "Teszt 1",
                            IsActive = true,
                            Name = "Teszt 1",
                            Price = 100
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "Teszt 2",
                            IsActive = true,
                            Name = "Teszt 2",
                            Price = 200
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Description = "Teszt 3",
                            IsActive = true,
                            Name = "Teszt 3",
                            Price = 300
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Description = "Teszt 4",
                            IsActive = true,
                            Name = "Teszt 4",
                            Price = 400
                        });
                });

            modelBuilder.Entity("Teszt_LA01.Models.Product", b =>
                {
                    b.HasOne("Teszt_LA01.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Teszt_LA01.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
