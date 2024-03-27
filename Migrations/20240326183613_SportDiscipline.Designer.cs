﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WWW_APP_PROJECT.Models.Data;

#nullable disable

namespace WWW_APP_PROJECT.Migrations
{
    [DbContext(typeof(TournamentContext))]
    [Migration("20240326183613_SportDiscipline")]
    partial class SportDiscipline
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WWW_APP_PROJECT.Models.SportDiscipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DisciplineName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("SportsDisciplines");
                });

            modelBuilder.Entity("WWW_APP_PROJECT.Models.Tournament", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("SportDisciplineId")
                        .HasColumnType("int");

                    b.Property<string>("TourmanentName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("TournamentEndDate")
                        .IsRequired()
                        .HasColumnType("Date");

                    b.Property<int>("TournamentFormat")
                        .HasColumnType("int");

                    b.Property<string>("TournamentPlace")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("TournamentStartDate")
                        .IsRequired()
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.HasIndex("SportDisciplineId");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("WWW_APP_PROJECT.Models.Tournament", b =>
                {
                    b.HasOne("WWW_APP_PROJECT.Models.SportDiscipline", "SportDiscipline")
                        .WithMany("Tournaments")
                        .HasForeignKey("SportDisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SportDiscipline");
                });

            modelBuilder.Entity("WWW_APP_PROJECT.Models.SportDiscipline", b =>
                {
                    b.Navigation("Tournaments");
                });
#pragma warning restore 612, 618
        }
    }
}
