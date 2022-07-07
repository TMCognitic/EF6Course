﻿// <auto-generated />
using System;
using EF6Course.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF6Course.Context.Migrations
{
    [DbContext(typeof(UniversiteContext))]
    partial class UniversiteContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EF6Course.Entities.Cour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Periode")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.HasKey("Id");

                    b.ToTable("Cour", (string)null);
                });

            modelBuilder.Entity("EF6Course.Entities.Etudiant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateInscription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Date")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(384)
                        .HasColumnType("nvarchar(384)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Resultat")
                        .HasColumnType("int");

                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("SectionId");

                    b.ToTable("Etudiant", (string)null);

                    b.HasCheckConstraint("CK_Etudiant_Resultat", "(Resultat BETWEEN 0 AND 20)");
                });

            modelBuilder.Entity("EF6Course.Entities.Inscription", b =>
                {
                    b.Property<int>("EtudiantId")
                        .HasColumnType("int");

                    b.Property<int>("CourId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("EtudiantId", "CourId", "Year");

                    b.HasIndex("CourId");

                    b.ToTable("Inscription", (string)null);
                });

            modelBuilder.Entity("EF6Course.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Section", (string)null);
                });

            modelBuilder.Entity("EF6Course.Entities.Etudiant", b =>
                {
                    b.HasOne("EF6Course.Entities.Section", "Section")
                        .WithMany("Etudiants")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Section");
                });

            modelBuilder.Entity("EF6Course.Entities.Inscription", b =>
                {
                    b.HasOne("EF6Course.Entities.Cour", null)
                        .WithMany()
                        .HasForeignKey("CourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF6Course.Entities.Etudiant", null)
                        .WithMany()
                        .HasForeignKey("EtudiantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF6Course.Entities.Section", b =>
                {
                    b.Navigation("Etudiants");
                });
#pragma warning restore 612, 618
        }
    }
}
