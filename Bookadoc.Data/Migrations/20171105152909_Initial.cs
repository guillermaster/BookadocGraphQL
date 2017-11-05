using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Bookadoc.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Countries",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Countries", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Degrees",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Degrees", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Diseases",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Diseases", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Specialities",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Specialities", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        Height = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
            //        Weight = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Active = table.Column<bool>(type: "bit", nullable: false),
            //        Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserTypeId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "States",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        CountryId = table.Column<int>(type: "int", nullable: true),
            //        IdCountry = table.Column<int>(type: "int", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_States", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_States_Countries_CountryId",
            //            column: x => x.CountryId,
            //            principalTable: "Countries",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DoctorDegree",
            //    columns: table => new
            //    {
            //        DoctorId = table.Column<int>(type: "int", nullable: false),
            //        DegreeId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DoctorDegree", x => new { x.DoctorId, x.DegreeId });
            //        table.ForeignKey(
            //            name: "FK_DoctorDegree_Degrees_DegreeId",
            //            column: x => x.DegreeId,
            //            principalTable: "Degrees",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_DoctorDegree_Users_DoctorId",
            //            column: x => x.DoctorId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "DoctorSpeciality",
            //    columns: table => new
            //    {
            //        DoctorId = table.Column<int>(type: "int", nullable: false),
            //        SpecialityId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_DoctorSpeciality", x => new { x.DoctorId, x.SpecialityId });
            //        table.ForeignKey(
            //            name: "FK_DoctorSpeciality_Users_DoctorId",
            //            column: x => x.DoctorId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_DoctorSpeciality_Specialities_SpecialityId",
            //            column: x => x.SpecialityId,
            //            principalTable: "Specialities",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PatientDiseaseHistory",
            //    columns: table => new
            //    {
            //        PatientId = table.Column<int>(type: "int", nullable: false),
            //        DiseaseId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PatientDiseaseHistory", x => new { x.PatientId, x.DiseaseId });
            //        table.ForeignKey(
            //            name: "FK_PatientDiseaseHistory_Diseases_DiseaseId",
            //            column: x => x.DiseaseId,
            //            principalTable: "Diseases",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_PatientDiseaseHistory_Users_PatientId",
            //            column: x => x.PatientId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Phones",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        Number = table.Column<int>(type: "int", nullable: false),
            //        Type = table.Column<int>(type: "int", nullable: false),
            //        UserId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Phones", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Phones_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Cities",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        IdCountry = table.Column<int>(type: "int", nullable: false),
            //        IdState = table.Column<int>(type: "int", nullable: false),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        StateId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Cities", x => x.Id);
            //        table.ForeignKey(
            //            name: "ForeignKey_City_Country",
            //            column: x => x.IdCountry,
            //            principalTable: "Countries",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_Cities_States_StateId",
            //            column: x => x.StateId,
            //            principalTable: "States",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Addresses",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false),
            //        CityId = table.Column<int>(type: "int", nullable: true),
            //        IdCity = table.Column<int>(type: "int", nullable: false),
            //        MainLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        PostCode = table.Column<int>(type: "int", nullable: false),
            //        SecondaryLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserId = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Addresses", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Addresses_Cities_CityId",
            //            column: x => x.CityId,
            //            principalTable: "Cities",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK_Addresses_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Addresses_CityId",
            //    table: "Addresses",
            //    column: "CityId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Addresses_UserId",
            //    table: "Addresses",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cities_IdCountry",
            //    table: "Cities",
            //    column: "IdCountry");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Cities_StateId",
            //    table: "Cities",
            //    column: "StateId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DoctorDegree_DegreeId",
            //    table: "DoctorDegree",
            //    column: "DegreeId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_DoctorSpeciality_SpecialityId",
            //    table: "DoctorSpeciality",
            //    column: "SpecialityId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PatientDiseaseHistory_DiseaseId",
            //    table: "PatientDiseaseHistory",
            //    column: "DiseaseId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Phones_UserId",
            //    table: "Phones",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_States_CountryId",
            //    table: "States",
            //    column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Addresses");

            //migrationBuilder.DropTable(
            //    name: "DoctorDegree");

            //migrationBuilder.DropTable(
            //    name: "DoctorSpeciality");

            //migrationBuilder.DropTable(
            //    name: "PatientDiseaseHistory");

            //migrationBuilder.DropTable(
            //    name: "Phones");

            //migrationBuilder.DropTable(
            //    name: "Cities");

            //migrationBuilder.DropTable(
            //    name: "Degrees");

            //migrationBuilder.DropTable(
            //    name: "Specialities");

            //migrationBuilder.DropTable(
            //    name: "Diseases");

            //migrationBuilder.DropTable(
            //    name: "Users");

            //migrationBuilder.DropTable(
            //    name: "States");

            //migrationBuilder.DropTable(
            //    name: "Countries");
        }
    }
}
