﻿// <auto-generated />
using System;
using LuanAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LuanAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231201140426_PrimeiraMigration")]
    partial class PrimeiraMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("LuanAPI.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeMae")
                        .HasColumnType("longtext");

                    b.Property<string>("NomePai")
                        .HasColumnType("longtext");

                    b.Property<string>("Turma")
                        .HasColumnType("longtext");

                    b.Property<string>("Turno")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("LuanAPI.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeEscola")
                        .HasColumnType("longtext");

                    b.Property<string>("Turma")
                        .HasColumnType("longtext");

                    b.Property<string>("Turno")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });
#pragma warning restore 612, 618
        }
    }
}
