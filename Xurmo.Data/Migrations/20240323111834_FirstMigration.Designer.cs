﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Xurmo.Data.AddDbContext;

#nullable disable

namespace Xurmo.Data.Migrations
{
    [DbContext(typeof(XurmoDbContext))]
    [Migration("20240323111834_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Xurmo.Domain.Entities.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8383),
                            IsDeleted = false,
                            Name = "Fruits"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8387),
                            IsDeleted = false,
                            Name = "DairyProducts"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8389),
                            IsDeleted = false,
                            Name = "Sweets"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8390),
                            IsDeleted = false,
                            Name = "MeatProducts"
                        });
                });

            modelBuilder.Entity("Xurmo.Domain.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("User_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("User_id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Xurmo.Domain.Entities.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<decimal>("Amount")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Xurmo.Domain.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CadegoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("CadegoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CadegoryId = 1L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8550),
                            Description = "This is Apple",
                            IsDeleted = false,
                            Name = "Apple",
                            Price = 12990m
                        },
                        new
                        {
                            Id = 2L,
                            CadegoryId = 1L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8552),
                            Description = "This is Fig",
                            IsDeleted = false,
                            Name = "Fig",
                            Price = 32990m
                        },
                        new
                        {
                            Id = 3L,
                            CadegoryId = 1L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8554),
                            Description = "This is Pear",
                            IsDeleted = false,
                            Name = "Pear",
                            Price = 19990m
                        },
                        new
                        {
                            Id = 4L,
                            CadegoryId = 2L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8556),
                            Description = "This is Carrot",
                            IsDeleted = false,
                            Name = "Carrot",
                            Price = 4990m
                        },
                        new
                        {
                            Id = 5L,
                            CadegoryId = 2L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8558),
                            Description = "This is Potatoes",
                            IsDeleted = false,
                            Name = "Potatoes",
                            Price = 6990m
                        },
                        new
                        {
                            Id = 6L,
                            CadegoryId = 3L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8559),
                            Description = "This is Chocolate Nestle",
                            IsDeleted = false,
                            Name = "ChocolateNestle",
                            Price = 10990m
                        },
                        new
                        {
                            Id = 7L,
                            CadegoryId = 3L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8563),
                            Description = "This is Cace",
                            IsDeleted = false,
                            Name = "Cake",
                            Price = 129990m
                        },
                        new
                        {
                            Id = 8L,
                            CadegoryId = 4L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8565),
                            Description = "This is Mutton",
                            IsDeleted = false,
                            Name = "Mutton",
                            Price = 100990m
                        },
                        new
                        {
                            Id = 9L,
                            CadegoryId = 4L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8567),
                            Description = "This is Beef",
                            IsDeleted = false,
                            Name = "Beef",
                            Price = 105990m
                        },
                        new
                        {
                            Id = 10L,
                            CadegoryId = 4L,
                            CreatedAt = new DateTime(2024, 3, 23, 11, 18, 34, 478, DateTimeKind.Utc).AddTicks(8568),
                            Description = "This is Sausage",
                            IsDeleted = false,
                            Name = "Sausage",
                            Price = 72990m
                        });
                });

            modelBuilder.Entity("Xurmo.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Xurmo.Domain.Entities.Order", b =>
                {
                    b.HasOne("Xurmo.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("User_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Xurmo.Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("Xurmo.Domain.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Xurmo.Domain.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Xurmo.Domain.Entities.Product", b =>
                {
                    b.HasOne("Xurmo.Domain.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CadegoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Xurmo.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Xurmo.Domain.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}