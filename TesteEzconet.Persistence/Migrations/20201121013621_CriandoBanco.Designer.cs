﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteEzconet.Persistence;

namespace TesteEzconet.Persistence.Migrations
{
    [DbContext(typeof(TesteEzconetContext))]
    [Migration("20201121013621_CriandoBanco")]
    partial class CriandoBanco
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("TesteEzconet.Domain.Models.Sexo", b =>
                {
                    b.Property<int>("SexoId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("SexoId");

                    b.ToTable("Sexos");
                });

            modelBuilder.Entity("TesteEzconet.Domain.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Senha")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("SexoId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("TesteEzconet.Domain.Models.Sexo", b =>
                {
                    b.HasOne("TesteEzconet.Domain.Models.Usuario", "User")
                        .WithOne("SexoUsuario")
                        .HasForeignKey("TesteEzconet.Domain.Models.Sexo", "SexoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TesteEzconet.Domain.Models.Usuario", b =>
                {
                    b.Navigation("SexoUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
