﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PontoEletronicoMVC.Models;

namespace PontoEletronicoMVC.Migrations
{
    [DbContext(typeof(PontoEletronicoMVCContext))]
    [Migration("20190210054336_PontoRegistro2")]
    partial class PontoRegistro2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PontoEletronicoMVC.Models.RegistroPonto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Entrada");

                    b.Property<DateTime>("Saida");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("RegistroPonto");
                });

            modelBuilder.Entity("PontoEletronicoMVC.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Departamento");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<TimeSpan>("EntryAm");

                    b.Property<TimeSpan>("EntryPm");

                    b.Property<TimeSpan>("ExitAm");

                    b.Property<TimeSpan>("ExitPm");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("PontoEletronicoMVC.Models.RegistroPonto", b =>
                {
                    b.HasOne("PontoEletronicoMVC.Models.Usuario", "Usuario")
                        .WithMany("Pontos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}