﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shope.DAL;

#nullable disable

namespace Shope.DAL.Migrations
{
    [DbContext(typeof(ShopeContext))]
    partial class ShopeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shop.DAL.Product", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ApprovedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EditBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EditDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NextRevieweDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReviewedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RevisionNum")
                        .HasColumnType("int");

                    b.Property<byte[]>("UploadFiles")
                        .HasColumnType("varbinary(max)");

                    b.Property<DateTime?>("VersionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("VersionNum")
                        .HasColumnType("int");

                    b.HasKey("Code");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Shop.DAL.Product_Version", b =>
                {
                    b.Property<long>("Product_Version_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Product_Version_Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("FileUp")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("ItemNo")
                        .HasColumnType("int");

                    b.Property<DateTime?>("VersionDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Product_Version_Id");

                    b.HasIndex("Code");

                    b.ToTable("Product_Version");
                });

            modelBuilder.Entity("Shop.DAL.Product_Version", b =>
                {
                    b.HasOne("Shop.DAL.Product", "Product")
                        .WithMany("Product_Version")
                        .HasForeignKey("Code")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Shop.DAL.Product", b =>
                {
                    b.Navigation("Product_Version");
                });
#pragma warning restore 612, 618
        }
    }
}