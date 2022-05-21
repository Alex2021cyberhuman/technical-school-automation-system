using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Application.Data.Migrations
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
                name: "speciality",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    entrance_test = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_speciality", x => x.id);
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

            migrationBuilder.CreateTable(
                name: "group",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    speciality_id = table.Column<long>(type: "bigint", nullable: false),
                    education_form = table.Column<int>(type: "integer", nullable: false),
                    finance_education_type = table.Column<int>(type: "integer", nullable: false),
                    students_count = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_group", x => x.id);
                    table.ForeignKey(
                        name: "fk_group_speciality_speciality_id",
                        column: x => x.speciality_id,
                        principalTable: "speciality",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subject",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    speciality_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_subject", x => x.id);
                    table.ForeignKey(
                        name: "fk_subject_speciality_speciality_id",
                        column: x => x.speciality_id,
                        principalTable: "speciality",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "student",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    family_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    sur_name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    date_of_birth = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    applicant_id = table.Column<long>(type: "bigint", nullable: false),
                    group_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_student", x => x.id);
                    table.ForeignKey(
                        name: "fk_student_applicant_applicant_id",
                        column: x => x.applicant_id,
                        principalTable: "applicant",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_student_group_group_id",
                        column: x => x.group_id,
                        principalTable: "group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "subject_semesters",
                columns: table => new
                {
                    subject_id = table.Column<long>(type: "bigint", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    number = table.Column<int>(type: "integer", nullable: false),
                    hours = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_subject_semesters", x => new { x.subject_id, x.id });
                    table.ForeignKey(
                        name: "fk_subject_semesters_subject_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "teacher_load",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    subject_id = table.Column<long>(type: "bigint", nullable: false),
                    group_id = table.Column<long>(type: "bigint", nullable: false),
                    teacher_id = table.Column<long>(type: "bigint", nullable: false),
                    kind = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_teacher_load", x => x.id);
                    table.ForeignKey(
                        name: "fk_teacher_load_group_group_id",
                        column: x => x.group_id,
                        principalTable: "group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_teacher_load_subject_subject_id",
                        column: x => x.subject_id,
                        principalTable: "subject",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_teacher_load_user_teacher_id",
                        column: x => x.teacher_id,
                        principalTable: "user",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "proofreading_teacher_load",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    teacher_load_id = table.Column<long>(type: "bigint", nullable: false),
                    month = table.Column<int>(type: "integer", nullable: false),
                    year = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_proofreading_teacher_load", x => x.id);
                    table.ForeignKey(
                        name: "fk_proofreading_teacher_load_teacher_load_teacher_load_id",
                        column: x => x.teacher_load_id,
                        principalTable: "teacher_load",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "teacher_load_semesters",
                columns: table => new
                {
                    teacher_load_id = table.Column<long>(type: "bigint", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    number = table.Column<int>(type: "integer", nullable: false),
                    hours = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_teacher_load_semesters", x => new { x.teacher_load_id, x.id });
                    table.ForeignKey(
                        name: "fk_teacher_load_semesters_teacher_load_teacher_load_id",
                        column: x => x.teacher_load_id,
                        principalTable: "teacher_load",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "proofreading_teacher_day",
                columns: table => new
                {
                    proofreading_teacher_load_id = table.Column<long>(type: "bigint", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    number = table.Column<int>(type: "integer", nullable: false),
                    hours = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_proofreading_teacher_day", x => new { x.proofreading_teacher_load_id, x.id });
                    table.ForeignKey(
                        name: "fk_proofreading_teacher_day_proofreading_teacher_load_proofrea",
                        column: x => x.proofreading_teacher_load_id,
                        principalTable: "proofreading_teacher_load",
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

            migrationBuilder.CreateIndex(
                name: "ix_group_speciality_id",
                table: "group",
                column: "speciality_id");

            migrationBuilder.CreateIndex(
                name: "ix_proofreading_teacher_load_teacher_load_id",
                table: "proofreading_teacher_load",
                column: "teacher_load_id");

            migrationBuilder.CreateIndex(
                name: "ix_proofreading_teacher_load_year_month",
                table: "proofreading_teacher_load",
                columns: new[] { "year", "month" });

            migrationBuilder.CreateIndex(
                name: "ix_student_applicant_id",
                table: "student",
                column: "applicant_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_student_group_id",
                table: "student",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "ix_subject_speciality_id",
                table: "subject",
                column: "speciality_id");

            migrationBuilder.CreateIndex(
                name: "ix_teacher_load_group_id",
                table: "teacher_load",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "ix_teacher_load_subject_id",
                table: "teacher_load",
                column: "subject_id");

            migrationBuilder.CreateIndex(
                name: "ix_teacher_load_teacher_id",
                table: "teacher_load",
                column: "teacher_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "applicant_speciality");

            migrationBuilder.DropTable(
                name: "proofreading_teacher_day");

            migrationBuilder.DropTable(
                name: "student");

            migrationBuilder.DropTable(
                name: "subject_semesters");

            migrationBuilder.DropTable(
                name: "teacher_load_semesters");

            migrationBuilder.DropTable(
                name: "proofreading_teacher_load");

            migrationBuilder.DropTable(
                name: "applicant");

            migrationBuilder.DropTable(
                name: "teacher_load");

            migrationBuilder.DropTable(
                name: "group");

            migrationBuilder.DropTable(
                name: "subject");

            migrationBuilder.DropTable(
                name: "speciality");
        }
    }
}
