﻿// <auto-generated />
using System;
using Application.AdmissionCommittee.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Application.AdmissionCommittee.Data.Migrations
{
    [DbContext(typeof(AdmissionCommitteeDbContext))]
    [Migration("20220509051220_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Application.AdmissionCommittee.Data.Applicant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("address");

                    b.Property<decimal>("AverageAttestRating")
                        .HasColumnType("numeric")
                        .HasColumnName("average_attest_rating");

                    b.Property<decimal>("CommonScore")
                        .HasColumnType("numeric")
                        .HasColumnName("common_score");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("description");

                    b.Property<int>("DirectorDecision")
                        .HasColumnType("integer")
                        .HasColumnName("director_decision");

                    b.Property<string>("DistanceApplicantWorkDescription")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("distance_applicant_work_description");

                    b.Property<string>("EducationDescription")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("education_description");

                    b.Property<DateTime>("EducationDocumentIssued")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("education_document_issued");

                    b.Property<string>("EducationDocumentNumber")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("education_document_number");

                    b.Property<string>("EducationDocumentSerial")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("education_document_serial");

                    b.Property<int>("EducationForm")
                        .HasColumnType("integer")
                        .HasColumnName("education_form");

                    b.Property<int>("EducationType")
                        .HasColumnType("integer")
                        .HasColumnName("education_type");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("family_name");

                    b.Property<int>("FinanceEducationType")
                        .HasColumnType("integer")
                        .HasColumnName("finance_education_type");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("first_name");

                    b.Property<bool>("FirstTimeInTechnicalSchool")
                        .HasColumnType("boolean")
                        .HasColumnName("first_time_in_technical_school");

                    b.Property<decimal>("LanguageRating")
                        .HasColumnType("numeric")
                        .HasColumnName("language_rating");

                    b.Property<decimal>("MathRating")
                        .HasColumnType("numeric")
                        .HasColumnName("math_rating");

                    b.Property<bool>("NeedDormitory")
                        .HasColumnType("boolean")
                        .HasColumnName("need_dormitory");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("phone");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("postal_code");

                    b.Property<DateTime>("Submitted")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("submitted");

                    b.Property<string>("SurName")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)")
                        .HasColumnName("sur_name");

                    b.HasKey("Id")
                        .HasName("pk_applicant");

                    b.ToTable("applicant", (string)null);
                });

            modelBuilder.Entity("Application.AdmissionCommittee.Data.ApplicantSpeciality", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("ApplicantId")
                        .HasColumnType("bigint")
                        .HasColumnName("applicant_id");

                    b.Property<long>("SpecialityId")
                        .HasColumnType("bigint")
                        .HasColumnName("speciality_id");

                    b.HasKey("Id")
                        .HasName("pk_applicant_speciality");

                    b.HasIndex("ApplicantId")
                        .HasDatabaseName("ix_applicant_speciality_applicant_id");

                    b.HasIndex("SpecialityId")
                        .HasDatabaseName("ix_applicant_speciality_speciality_id");

                    b.ToTable("applicant_speciality", (string)null);
                });

            modelBuilder.Entity("Application.Specialities.Data.Speciality", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("ApplicantId")
                        .HasColumnType("bigint")
                        .HasColumnName("applicant_id");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("code");

                    b.Property<int?>("EntranceTest")
                        .HasColumnType("integer")
                        .HasColumnName("entrance_test");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_speciality");

                    b.HasIndex("ApplicantId")
                        .HasDatabaseName("ix_speciality_applicant_id");

                    b.ToTable("speciality", null, t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("Application.Specialities.Data.Subject", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_subject");

                    b.ToTable("subject", null, t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("Application.AdmissionCommittee.Data.Applicant", b =>
                {
                    b.OwnsOne("Application.AdmissionCommittee.Data.ApplicantParent", "Father", b1 =>
                        {
                            b1.Property<long>("ApplicantId")
                                .HasColumnType("bigint")
                                .HasColumnName("id");

                            b1.Property<string>("FamilyName")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("character varying(200)")
                                .HasColumnName("father_family_name");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("character varying(200)")
                                .HasColumnName("father_first_name");

                            b1.Property<string>("HomePhone")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("character varying(20)")
                                .HasColumnName("father_home_phone");

                            b1.Property<string>("MobilePhone")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("character varying(20)")
                                .HasColumnName("father_mobile_phone");

                            b1.Property<string>("SurName")
                                .HasMaxLength(200)
                                .HasColumnType("character varying(200)")
                                .HasColumnName("father_sur_name");

                            b1.Property<string>("WorkDescription")
                                .IsRequired()
                                .HasMaxLength(1000)
                                .HasColumnType("character varying(1000)")
                                .HasColumnName("father_work_description");

                            b1.Property<string>("WorkPhone")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("character varying(20)")
                                .HasColumnName("father_work_phone");

                            b1.HasKey("ApplicantId");

                            b1.ToTable("applicant");

                            b1.WithOwner()
                                .HasForeignKey("ApplicantId")
                                .HasConstraintName("fk_applicant_applicant_id");
                        });

                    b.OwnsOne("Application.AdmissionCommittee.Data.ApplicantParent", "Mother", b1 =>
                        {
                            b1.Property<long>("ApplicantId")
                                .HasColumnType("bigint")
                                .HasColumnName("id");

                            b1.Property<string>("FamilyName")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("character varying(200)")
                                .HasColumnName("mother_family_name");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(200)
                                .HasColumnType("character varying(200)")
                                .HasColumnName("mother_first_name");

                            b1.Property<string>("HomePhone")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("character varying(20)")
                                .HasColumnName("mother_home_phone");

                            b1.Property<string>("MobilePhone")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("character varying(20)")
                                .HasColumnName("mother_mobile_phone");

                            b1.Property<string>("SurName")
                                .HasMaxLength(200)
                                .HasColumnType("character varying(200)")
                                .HasColumnName("mother_sur_name");

                            b1.Property<string>("WorkDescription")
                                .IsRequired()
                                .HasMaxLength(1000)
                                .HasColumnType("character varying(1000)")
                                .HasColumnName("mother_work_description");

                            b1.Property<string>("WorkPhone")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("character varying(20)")
                                .HasColumnName("mother_work_phone");

                            b1.HasKey("ApplicantId");

                            b1.ToTable("applicant");

                            b1.WithOwner()
                                .HasForeignKey("ApplicantId")
                                .HasConstraintName("fk_applicant_applicant_id");
                        });

                    b.OwnsOne("Application.AdmissionCommittee.Data.ApplicantPassport", "Passport", b1 =>
                        {
                            b1.Property<long>("ApplicantId")
                                .HasColumnType("bigint")
                                .HasColumnName("id");

                            b1.Property<DateTime>("IssueDate")
                                .HasColumnType("timestamp with time zone")
                                .HasColumnName("passport_issue_date");

                            b1.Property<string>("Issuer")
                                .IsRequired()
                                .HasMaxLength(2000)
                                .HasColumnType("character varying(2000)")
                                .HasColumnName("passport_issuer");

                            b1.Property<string>("IssuerCode")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("character varying(20)")
                                .HasColumnName("passport_issuer_code");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("character varying(20)")
                                .HasColumnName("passport_number");

                            b1.Property<string>("Serial")
                                .IsRequired()
                                .HasMaxLength(20)
                                .HasColumnType("character varying(20)")
                                .HasColumnName("passport_serial");

                            b1.Property<string>("Type")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("passport_type");

                            b1.HasKey("ApplicantId");

                            b1.ToTable("applicant");

                            b1.WithOwner()
                                .HasForeignKey("ApplicantId")
                                .HasConstraintName("fk_applicant_applicant_id");
                        });

                    b.OwnsOne("Application.AdmissionCommittee.Data.Statement", "Statement", b1 =>
                        {
                            b1.Property<long>("ApplicantId")
                                .HasColumnType("bigint")
                                .HasColumnName("id");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("text")
                                .HasColumnName("statement_name");

                            b1.Property<long>("Size")
                                .HasColumnType("bigint")
                                .HasColumnName("statement_size");

                            b1.HasKey("ApplicantId");

                            b1.ToTable("applicant");

                            b1.WithOwner()
                                .HasForeignKey("ApplicantId")
                                .HasConstraintName("fk_applicant_applicant_id");
                        });

                    b.Navigation("Father");

                    b.Navigation("Mother");

                    b.Navigation("Passport")
                        .IsRequired();

                    b.Navigation("Statement")
                        .IsRequired();
                });

            modelBuilder.Entity("Application.AdmissionCommittee.Data.ApplicantSpeciality", b =>
                {
                    b.HasOne("Application.AdmissionCommittee.Data.Applicant", "Applicant")
                        .WithMany("ApplicantSpecialities")
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_applicant_speciality_applicant_applicant_id");

                    b.HasOne("Application.Specialities.Data.Speciality", "Speciality")
                        .WithMany()
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_applicant_speciality_speciality_speciality_id");

                    b.Navigation("Applicant");

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("Application.Specialities.Data.Speciality", b =>
                {
                    b.HasOne("Application.AdmissionCommittee.Data.Applicant", null)
                        .WithMany("Specialities")
                        .HasForeignKey("ApplicantId")
                        .HasConstraintName("fk_speciality_applicant_applicant_id");
                });

            modelBuilder.Entity("Application.AdmissionCommittee.Data.Applicant", b =>
                {
                    b.Navigation("ApplicantSpecialities");

                    b.Navigation("Specialities");
                });
#pragma warning restore 612, 618
        }
    }
}
