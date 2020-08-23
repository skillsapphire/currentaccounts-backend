﻿// <auto-generated />
using System;
using CurrentAccounts.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CurrentAccounts.Data.Migrations
{
    [DbContext(typeof(CurrentAccountsDbContext))]
    partial class CurrentAccountsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7");

            modelBuilder.Entity("CurrentAccounts.Core.Entity.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Balance")
                        .HasColumnType("TEXT");

                    b.Property<int>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("CurrentAccounts.Core.Entity.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CurrentAccounts.Core.Entity.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<int>("BankAccountId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BankAccountId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CurrentAccounts.Core.Entity.BankAccount", b =>
                {
                    b.HasOne("CurrentAccounts.Core.Entity.Customer", "Customer")
                        .WithMany("BankAccounts")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CurrentAccounts.Core.Entity.Transaction", b =>
                {
                    b.HasOne("CurrentAccounts.Core.Entity.BankAccount", "BankAccount")
                        .WithMany("Transactions")
                        .HasForeignKey("BankAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}