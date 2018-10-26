﻿// <auto-generated />
using System;
using CrudCharts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CrudCharts.Migrations
{
    [DbContext(typeof(TreinamentoContext))]
    partial class TreinamentoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-preview1-35029")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CrudCharts.Models.Login", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Senha");

                    b.Property<string>("Usuario")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("CrudCharts.Models.PedidoFrete", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int?>("Status");

                    b.Property<string>("UfDestino");

                    b.Property<string>("UfOrigem");

                    b.HasKey("Id");

                    b.ToTable("PedidoFrete");
                });

            modelBuilder.Entity("CrudCharts.Models.Rotas", b =>
                {
                    b.Property<int>("Id");

                    b.Property<double>("Distancia");

                    b.Property<double?>("Preco");

                    b.Property<string>("UfDestino")
                        .IsRequired();

                    b.Property<string>("UfOrigem")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Rotas");
                });
#pragma warning restore 612, 618
        }
    }
}
