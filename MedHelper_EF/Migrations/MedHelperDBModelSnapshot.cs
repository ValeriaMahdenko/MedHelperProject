﻿// <auto-generated />
using System;
using MedHelper_EF.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MedHelper_EF.Migrations
{
    [DbContext(typeof(MedHelperDB))]
    partial class MedHelperDBModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MedHelper_EF.Models.Composition", b =>
                {
                    b.Property<int>("CompositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("CompositionID");

                    b.ToTable("Compositions");
                });

            modelBuilder.Entity("MedHelper_EF.Models.Contraindication", b =>
                {
                    b.Property<int>("ContraindicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.HasKey("ContraindicationID");

                    b.ToTable("Contraindications");
                });

            modelBuilder.Entity("MedHelper_EF.Models.Disease", b =>
                {
                    b.Property<int>("DiseaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("DiseaseID");

                    b.ToTable("Diseases");
                });

            modelBuilder.Entity("MedHelper_EF.Models.Doctor", b =>
                {
                    b.Property<int>("DoctorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Pass")
                        .HasColumnType("text");

                    b.HasKey("DoctorID");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("MedHelper_EF.Models.Medicine", b =>
                {
                    b.Property<int>("MedicineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("pharmacotherapeuticGroup")
                        .HasColumnType("text");

                    b.HasKey("MedicineID");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("MedHelper_EF.Models.MedicineComposition", b =>
                {
                    b.Property<int>("MedicineCompositionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CompositionID")
                        .HasColumnType("integer");

                    b.Property<int>("MedicineID")
                        .HasColumnType("integer");

                    b.HasKey("MedicineCompositionID");

                    b.HasIndex("CompositionID");

                    b.HasIndex("MedicineID");

                    b.ToTable("MedicineComposition");
                });

            modelBuilder.Entity("MedHelper_EF.Models.MedicineContraindication", b =>
                {
                    b.Property<int>("MedicineContraindicationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ContraindicationID")
                        .HasColumnType("integer");

                    b.Property<int>("MedicineID")
                        .HasColumnType("integer");

                    b.HasKey("MedicineContraindicationID");

                    b.HasIndex("ContraindicationID");

                    b.HasIndex("MedicineID");

                    b.ToTable("MedicineContraindication");
                });

            modelBuilder.Entity("MedHelper_EF.Models.MedicineInteraction", b =>
                {
                    b.Property<int>("MedicineInteractionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CompositionID")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("MedicineID")
                        .HasColumnType("integer");

                    b.HasKey("MedicineInteractionID");

                    b.HasIndex("CompositionID");

                    b.HasIndex("MedicineID");

                    b.ToTable("MedicineInteraction");
                });

            modelBuilder.Entity("MedHelper_EF.Models.Patient", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DoctorID")
                        .HasColumnType("integer");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("PatientID");

                    b.HasIndex("DoctorID");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("MedHelper_EF.Models.PatientDisease", b =>
                {
                    b.Property<int>("PatientDiseaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("DiseaseID")
                        .HasColumnType("integer");

                    b.Property<int>("PatientID")
                        .HasColumnType("integer");

                    b.HasKey("PatientDiseaseID");

                    b.HasIndex("DiseaseID");

                    b.HasIndex("PatientID");

                    b.ToTable("PatientDisease");
                });

            modelBuilder.Entity("MedHelper_EF.Models.PatientMedicine", b =>
                {
                    b.Property<int>("PatientMedicineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("MedicineID")
                        .HasColumnType("integer");

                    b.Property<int>("PatientID")
                        .HasColumnType("integer");

                    b.HasKey("PatientMedicineID");

                    b.HasIndex("MedicineID");

                    b.HasIndex("PatientID");

                    b.ToTable("PatientMedicine");
                });

            modelBuilder.Entity("MedHelper_EF.Models.MedicineComposition", b =>
                {
                    b.HasOne("MedHelper_EF.Models.Composition", "Composition")
                        .WithMany("MedicineCompositions")
                        .HasForeignKey("CompositionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedHelper_EF.Models.Medicine", "Medicine")
                        .WithMany("MedicineCompositions")
                        .HasForeignKey("MedicineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Composition");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("MedHelper_EF.Models.MedicineContraindication", b =>
                {
                    b.HasOne("MedHelper_EF.Models.Contraindication", "Contraindication")
                        .WithMany("MedicineContraindications")
                        .HasForeignKey("ContraindicationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedHelper_EF.Models.Medicine", "Medicine")
                        .WithMany("MedicineContraindications")
                        .HasForeignKey("MedicineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contraindication");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("MedHelper_EF.Models.MedicineInteraction", b =>
                {
                    b.HasOne("MedHelper_EF.Models.Composition", "Composition")
                        .WithMany("MedicineInteractions")
                        .HasForeignKey("CompositionID");

                    b.HasOne("MedHelper_EF.Models.Medicine", "Medicine")
                        .WithMany("MedicineInteractions")
                        .HasForeignKey("MedicineID");

                    b.Navigation("Composition");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("MedHelper_EF.Models.Patient", b =>
                {
                    b.HasOne("MedHelper_EF.Models.Doctor", "Doctor")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("MedHelper_EF.Models.PatientDisease", b =>
                {
                    b.HasOne("MedHelper_EF.Models.Disease", "Disease")
                        .WithMany("PatientDiseases")
                        .HasForeignKey("DiseaseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedHelper_EF.Models.Patient", "Patient")
                        .WithMany("PatientDiseases")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Disease");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("MedHelper_EF.Models.PatientMedicine", b =>
                {
                    b.HasOne("MedHelper_EF.Models.Medicine", "Medicine")
                        .WithMany("PatientMedicines")
                        .HasForeignKey("MedicineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MedHelper_EF.Models.Patient", "Patient")
                        .WithMany("PatientMedicines")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("MedHelper_EF.Models.Composition", b =>
                {
                    b.Navigation("MedicineCompositions");

                    b.Navigation("MedicineInteractions");
                });

            modelBuilder.Entity("MedHelper_EF.Models.Contraindication", b =>
                {
                    b.Navigation("MedicineContraindications");
                });

            modelBuilder.Entity("MedHelper_EF.Models.Disease", b =>
                {
                    b.Navigation("PatientDiseases");
                });

            modelBuilder.Entity("MedHelper_EF.Models.Doctor", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("MedHelper_EF.Models.Medicine", b =>
                {
                    b.Navigation("MedicineCompositions");

                    b.Navigation("MedicineContraindications");

                    b.Navigation("MedicineInteractions");

                    b.Navigation("PatientMedicines");
                });

            modelBuilder.Entity("MedHelper_EF.Models.Patient", b =>
                {
                    b.Navigation("PatientDiseases");

                    b.Navigation("PatientMedicines");
                });
#pragma warning restore 612, 618
        }
    }
}
