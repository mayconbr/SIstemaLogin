﻿// <auto-generated />
using System;
using Login;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Login.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("latin1_swedish_ci")
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "latin1");

            modelBuilder.Entity("Login.Models.TableCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Login.Models.TableSubCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("Login.Models.TableSystem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DataDelete")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("System");
                });

            modelBuilder.Entity("Login.Models.TableType", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("DataDelete")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long?>("SystemId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SystemId");

                    b.ToTable("Type");
                });

            modelBuilder.Entity("Login.Models.TableUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("AddInfo")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("DateDelete")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Key")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Status")
                        .HasColumnType("tinyint(1)");

                    b.Property<long?>("SubCategoryId")
                        .HasColumnType("bigint");

                    b.Property<long?>("SystemId")
                        .HasColumnType("bigint");

                    b.Property<long?>("TypeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SubCategoryId");

                    b.HasIndex("SystemId");

                    b.HasIndex("TypeId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Login.Models.TableSubCategory", b =>
                {
                    b.HasOne("Login.Models.TableCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Login.Models.TableType", b =>
                {
                    b.HasOne("Login.Models.TableSystem", "System")
                        .WithMany()
                        .HasForeignKey("SystemId");

                    b.Navigation("System");
                });

            modelBuilder.Entity("Login.Models.TableUser", b =>
                {
                    b.HasOne("Login.Models.TableSubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId");

                    b.HasOne("Login.Models.TableSystem", "System")
                        .WithMany()
                        .HasForeignKey("SystemId");

                    b.HasOne("Login.Models.TableType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("SubCategory");

                    b.Navigation("System");

                    b.Navigation("Type");
                });
#pragma warning restore 612, 618
        }
    }
}
