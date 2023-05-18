﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolApi.Models;

#nullable disable

namespace SchoolApi.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    [Migration("20230502114322_addData")]
    partial class addData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolApi.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Sections")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebSite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Schools");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Director = "Director1",
                            Name = "Eniso",
                            Rating = 3.5,
                            Sections = "IA,EI,GTE",
                            WebSite = "http://www.eniso.rnu.tn"
                        },
                        new
                        {
                            Id = 2,
                            Director = "Director2",
                            Name = "Enim",
                            Rating = 3.0,
                            Sections = "MECA,ENERG,TEXT",
                            WebSite = "https://enim.rnu.tn/"
                        },
                        new
                        {
                            Id = 3,
                            Director = "Director3",
                            Name = "School3",
                            Rating = 3.0,
                            Sections = "Sec1,Sec2,Sec3",
                            WebSite = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
