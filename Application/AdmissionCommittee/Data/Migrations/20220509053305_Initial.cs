using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Application.AdmissionCommittee.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "applicant",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    submitted = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    first_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    family_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    sur_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    date_of_birth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    description = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    language_rating = table.Column<decimal>(type: "numeric", nullable: false),
                    math_rating = table.Column<decimal>(type: "numeric", nullable: false),
                    average_attest_rating = table.Column<decimal>(type: "numeric", nullable: false),
                    common_score = table.Column<decimal>(type: "numeric", nullable: false),
                    education_type = table.Column<int>(type: "integer", nullable: false),
                    education_description = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    education_document_serial = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    education_document_number = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    education_document_issued = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    education_form = table.Column<int>(type: "integer", nullable: false),
                    first_time_in_technical_school = table.Column<bool>(type: "boolean", nullable: false),
                    need_dormitory = table.Column<bool>(type: "boolean", nullable: false),
                    finance_education_type = table.Column<int>(type: "integer", nullable: false),
                    address = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    postal_code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    mother_first_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    mother_family_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    mother_sur_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    mother_work_description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    mother_mobile_phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    mother_work_phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    mother_home_phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    father_first_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    father_family_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    father_sur_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    father_work_description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    father_mobile_phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    father_work_phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    father_home_phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    distance_applicant_work_description = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    director_decision = table.Column<int>(type: "integer", nullable: false),
                    statement_size = table.Column<long>(type: "bigint", nullable: false),
                    statement_name = table.Column<string>(type: "text", nullable: false),
                    passport_serial = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    passport_number = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    passport_issuer = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: false),
                    passport_issuer_code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    passport_type = table.Column<string>(type: "text", nullable: false),
                    passport_issue_date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_applicant", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "applicant_speciality",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    applicant_id = table.Column<long>(type: "bigint", nullable: false),
                    speciality_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_applicant_speciality", x => x.id);
                    table.ForeignKey(
                        name: "fk_applicant_speciality_applicant_applicant_id",
                        column: x => x.applicant_id,
                        principalTable: "applicant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_applicant_speciality_speciality_speciality_id",
                        column: x => x.speciality_id,
                        principalTable: "speciality",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_applicant_speciality_applicant_id",
                table: "applicant_speciality",
                column: "applicant_id");

            migrationBuilder.CreateIndex(
                name: "ix_applicant_speciality_speciality_id",
                table: "applicant_speciality",
                column: "speciality_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "applicant_speciality");

            migrationBuilder.DropTable(
                name: "applicant");
        }
    }
}
