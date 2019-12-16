﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuestDS2.Data;

namespace QuestDS2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20191216212746_defined")]
    partial class defined
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuestDS2.Models.Jogador", b =>
                {
                    b.Property<int>("JogadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nacionalidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JogadorId");

                    b.ToTable("jogadors");
                });

            modelBuilder.Entity("QuestDS2.Models.Placar", b =>
                {
                    b.Property<int>("PlacarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("JogadorId")
                        .HasColumnType("int");

                    b.Property<int>("Pontos")
                        .HasColumnType("int");

                    b.HasKey("PlacarId");

                    b.HasIndex("JogadorId");

                    b.ToTable("placars");
                });

            modelBuilder.Entity("QuestDS2.Models.Placar", b =>
                {
                    b.HasOne("QuestDS2.Models.Jogador", "Jogador")
                        .WithMany()
                        .HasForeignKey("JogadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}