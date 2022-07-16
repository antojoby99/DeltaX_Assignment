﻿// <auto-generated />
using System;
using Add_Edit_Delete_Movie_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Add_Edit_Delete_Movie_API.Migrations
{
    [DbContext(typeof(Contextclass))]
    [Migration("20220716071236_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Add_Edit_Delete_Movie_API.Models.Movie", b =>
                {
                    b.Property<string>("MovieName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Actor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateofRelease")
                        .HasColumnType("datetime2");

                    b.Property<string>("Producer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("plot")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("poster")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("MovieName");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}