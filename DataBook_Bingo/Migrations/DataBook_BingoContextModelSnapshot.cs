﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataBook_Bingo.Migrations
{
    [DbContext(typeof(DataBook_BingoContext))]
    partial class DataBook_BingoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataBook_Bingo.Models.Aldeia", b =>
                {
                    b.Property<int>("IdAldeia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("ImgAldeia")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NomeAldeia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaisAldeia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAldeia");

                    b.ToTable("Aldeia");
                });

            modelBuilder.Entity("DataBook_Bingo.Models.Clas", b =>
                {
                    b.Property<int>("IdClas")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("ImageClas")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NomeClas")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdClas");

                    b.ToTable("Cla");
                });

            modelBuilder.Entity("DataBook_Bingo.Models.Organizacao", b =>
                {
                    b.Property<int>("IdOrganizacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("ImgOrganizacao")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Limite")
                        .HasColumnType("int");

                    b.Property<string>("NomeOrganizacao")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdOrganizacao");

                    b.ToTable("Organizacao");
                });

            modelBuilder.Entity("DataBook_Bingo.Models.Shinobi", b =>
                {
                    b.Property<int>("IdShinobi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Aldeia_Id")
                        .HasColumnType("int");

                    b.Property<int>("Cla_Id")
                        .HasColumnType("int");

                    b.Property<string>("Elemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Especialidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Graduacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ImagemShinobi")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("NomeShinobi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Organizacao_Id")
                        .HasColumnType("int");

                    b.Property<string>("Renegado")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Vivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("IdShinobi");

                    b.HasIndex("Aldeia_Id");

                    b.HasIndex("Cla_Id");

                    b.HasIndex("Organizacao_Id");

                    b.ToTable("Shinobi");
                });

            modelBuilder.Entity("DataBook_Bingo.Models.Usuarios", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SenhaUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("DataBook_Bingo.Models.Shinobi", b =>
                {
                    b.HasOne("DataBook_Bingo.Models.Aldeia", "Aldeia")
                        .WithMany()
                        .HasForeignKey("Aldeia_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBook_Bingo.Models.Clas", "Clas")
                        .WithMany()
                        .HasForeignKey("Cla_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBook_Bingo.Models.Organizacao", "Organizacao")
                        .WithMany()
                        .HasForeignKey("Organizacao_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
