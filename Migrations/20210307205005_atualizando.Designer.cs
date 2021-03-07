﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Data;

namespace api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210307205005_atualizando")]
    partial class atualizando
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("api.Models.Computer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250) CHARACTER SET utf8mb4");

                    b.Property<string>("Hd")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4");

                    b.Property<string>("MemoriaRam")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4");

                    b.Property<string>("PlacaMae")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4");

                    b.Property<string>("VelocidadeProcessador")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Computers");
                });

            modelBuilder.Entity("api.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60) CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });
#pragma warning restore 612, 618
        }
    }
}