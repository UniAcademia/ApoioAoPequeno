﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistemaDoacoes.Infra.Data;

namespace SistemaDoacoes.Infra.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200830135612_coluna Active")]
    partial class colunaActive
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SistemaDoacoes.Core.Aggregates.AuthAgg.Entities.Assisted", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ativo")
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("BornDate")
                        .HasColumnName("data_nascimennto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnName("cpf")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<bool>("Householder")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("chefe_familia")
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtdDependents")
                        .HasColumnName("qtd_dependentes")
                        .HasColumnType("int");

                    b.Property<int>("Schooling")
                        .HasColumnName("escolaridade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TB_ASSISTIDO");
                });

            modelBuilder.Entity("SistemaDoacoes.Core.Aggregates.AuthAgg.Entities.AssistedInstitution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ativo")
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnName("cnpj")
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.Property<string>("CorporateName")
                        .IsRequired()
                        .HasColumnName("razao_social")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FantasyName")
                        .IsRequired()
                        .HasColumnName("nome_fantasia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InstitutionType")
                        .HasColumnName("tipo_instituicao")
                        .HasColumnType("int");

                    b.Property<int>("QtdAssisted")
                        .HasColumnName("qtd_assistidos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TB_INSTITUICAO_ASSISTIDA");
                });

            modelBuilder.Entity("SistemaDoacoes.Core.Aggregates.AuthAgg.Entities.Donation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ativo")
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("IdDestination")
                        .HasColumnName("id_destino")
                        .HasColumnType("int");

                    b.Property<int>("IdOrigin")
                        .HasColumnName("id_origem")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnName("tipo")
                        .HasColumnType("int");

                    b.Property<int>("Value")
                        .HasColumnName("valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDestination");

                    b.HasIndex("IdOrigin");

                    b.ToTable("TB_DOACAO");
                });

            modelBuilder.Entity("SistemaDoacoes.Core.Aggregates.AuthAgg.Entities.Donor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ativo")
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("BornDate")
                        .HasColumnName("data_nascimennto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnName("cpf")
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Schooling")
                        .HasColumnName("escolaridade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TB_DOADOR");
                });

            modelBuilder.Entity("SistemaDoacoes.Core.Aggregates.AuthAgg.Entities.DonorInstitution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ativo")
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnName("cnpj")
                        .HasColumnType("nvarchar(14)")
                        .HasMaxLength(14);

                    b.Property<string>("CorporateName")
                        .IsRequired()
                        .HasColumnName("razao_social")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FantasyName")
                        .IsRequired()
                        .HasColumnName("nome_fantasia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_INSTITUICAO_DOADORA");
                });

            modelBuilder.Entity("SistemaDoacoes.Core.Aggregates.AuthAgg.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SistemaDoacoes.Core.Aggregates.AuthAgg.Entities.Donation", b =>
                {
                    b.HasOne("SistemaDoacoes.Core.Aggregates.AuthAgg.Entities.Assisted", "Assisted")
                        .WithMany("Donations")
                        .HasForeignKey("IdDestination")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDoacoes.Core.Aggregates.AuthAgg.Entities.AssistedInstitution", "AssistedInstitution")
                        .WithMany("Donations")
                        .HasForeignKey("IdDestination")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDoacoes.Core.Aggregates.AuthAgg.Entities.Donor", "Donor")
                        .WithMany("Donations")
                        .HasForeignKey("IdOrigin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistemaDoacoes.Core.Aggregates.AuthAgg.Entities.DonorInstitution", "DonorInstitution")
                        .WithMany("Donations")
                        .HasForeignKey("IdOrigin")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
