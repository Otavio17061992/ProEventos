﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProEventos.APIv5.Data;

namespace ProEventos.APIv5.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ProEventos.APIv5.Models.Eventos", b =>
                {
                    b.Property<string>("DataEvento")
                        .HasColumnType("TEXT");

                    b.Property<int>("EventoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImagemURL")
                        .HasColumnType("TEXT");

                    b.Property<string>("Local")
                        .HasColumnType("TEXT");

                    b.Property<string>("Lote")
                        .HasColumnType("TEXT");

                    b.Property<int>("QtdPessoas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tema")
                        .HasColumnType("TEXT");

                    b.ToTable("Eventos");
                });
#pragma warning restore 612, 618
        }
    }
}