﻿// <auto-generated />
using ApiChallenge.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ApiChallenge.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210721212056_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("ApiChallenge.Data.Cartao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cartao");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Numero = 1234567890
                        },
                        new
                        {
                            Id = 2,
                            Numero = 987654321
                        },
                        new
                        {
                            Id = 3,
                            Numero = 1234567899
                        },
                        new
                        {
                            Id = 4,
                            Numero = 1123456789
                        });
                });
#pragma warning restore 612, 618
        }
    }
}