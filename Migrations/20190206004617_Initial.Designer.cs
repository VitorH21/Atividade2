﻿// <auto-generated />
using System;
using Atividade2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Atividade2.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("20190206004617_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("Atividade2.Agencia", b =>
                {
                    b.Property<int>("AgenciaId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BancoId");

                    b.HasKey("AgenciaId");

                    b.HasIndex("BancoId");

                    b.ToTable("Agencias");
                });

            modelBuilder.Entity("Atividade2.Banco", b =>
                {
                    b.Property<int>("BancoId")
                        .ValueGeneratedOnAdd();

                    b.HasKey("BancoId");

                    b.ToTable("Bancos");
                });

            modelBuilder.Entity("Atividade2.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("IdCliente");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Atividade2.ContaCorrente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AgenciaId");

                    b.Property<decimal>("Saldo");

                    b.Property<string>("Titular");

                    b.HasKey("Id");

                    b.HasIndex("AgenciaId");

                    b.ToTable("ContasCorrentes");
                });

            modelBuilder.Entity("Atividade2.ContaPoupanca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AgenciaId");

                    b.Property<DateTime>("DataAniversario");

                    b.Property<decimal>("Juros");

                    b.Property<decimal>("Saldo");

                    b.Property<string>("Titular");

                    b.HasKey("Id");

                    b.HasIndex("AgenciaId");

                    b.ToTable("ContasPoupanca");
                });

            modelBuilder.Entity("Atividade2.Solicitacao", b =>
                {
                    b.Property<int>("IdSolicitacao")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AgenciaId");

                    b.HasKey("IdSolicitacao");

                    b.HasIndex("AgenciaId");

                    b.ToTable("Solicitacoes");
                });

            modelBuilder.Entity("Atividade2.Agencia", b =>
                {
                    b.HasOne("Atividade2.Banco")
                        .WithMany("Agencias")
                        .HasForeignKey("BancoId");
                });

            modelBuilder.Entity("Atividade2.ContaCorrente", b =>
                {
                    b.HasOne("Atividade2.Agencia")
                        .WithMany("ContaCorrentes")
                        .HasForeignKey("AgenciaId");
                });

            modelBuilder.Entity("Atividade2.ContaPoupanca", b =>
                {
                    b.HasOne("Atividade2.Agencia")
                        .WithMany("ContaPoupancas")
                        .HasForeignKey("AgenciaId");
                });

            modelBuilder.Entity("Atividade2.Solicitacao", b =>
                {
                    b.HasOne("Atividade2.Agencia")
                        .WithMany("Solicitacoes")
                        .HasForeignKey("AgenciaId");
                });
#pragma warning restore 612, 618
        }
    }
}
