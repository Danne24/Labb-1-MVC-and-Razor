using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb_1___MVC_and_Razor.Migrations
{
    public partial class FirstCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(nullable: false),
                    BookPublishedYear = table.Column<string>(nullable: false),
                    BookAuthor = table.Column<string>(nullable: false),
                    BookCurrentlyAvailableForRent = table.Column<bool>(nullable: false),
                    BookImageThmbnailUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFirstName = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerLastName = table.Column<string>(maxLength: 50, nullable: false),
                    CustomerAge = table.Column<int>(nullable: false),
                    CustomerGender = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "LibraryLoans",
                columns: table => new
                {
                    LibraryLoanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfLoan = table.Column<DateTime>(nullable: false),
                    LastDateToReturn = table.Column<DateTime>(nullable: false),
                    DateOfReturn = table.Column<DateTime>(nullable: false),
                    IsReturned = table.Column<bool>(nullable: false),
                    CustomerID = table.Column<int>(nullable: false),
                    BookID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryLoans", x => x.LibraryLoanID);
                    table.ForeignKey(
                        name: "FK_LibraryLoans_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibraryLoans_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "BookAuthor", "BookCurrentlyAvailableForRent", "BookImageThmbnailUrl", "BookPublishedYear", "BookTitle" },
                values: new object[,]
                {
                    { 1, "Frank Herbert", true, "\\images\\Dune.webp", "1965", "Dune" },
                    { 2, "Michael Crichton", true, "\\images\\Jurassic Park.webp", "1990", "Jurassic Park" },
                    { 3, "Robert Louis Stevenson", true, "\\images\\Treasure Island.jpg", "1883", "Treasure Island" },
                    { 4, "Jules Verne", true, "\\images\\Twenty Thousand Leagues Under the Sea.jpg", "1870", "Twenty Thousand Leagues Under the Sea" },
                    { 5, "Mary Shelley", true, "\\images\\Frankenstein.jpg", "1818", "Frankenstein" },
                    { 6, "Leo Tolstoy", true, "\\images\\War and peace.jpg", "1869", "War and Peace" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "CustomerAge", "CustomerFirstName", "CustomerGender", "CustomerLastName" },
                values: new object[,]
                {
                    { 1, 25, "Daniel", "Male", "Gyrén" },
                    { 2, 55, "Paul", "Male", "Foster" },
                    { 3, 31, "Gareth", "Male", "Archer" },
                    { 4, 20, "Jordan", "Male", "Humble" },
                    { 5, 35, "James", "Male", "Johnson" },
                    { 6, 35, "Janet", "Female", "Johnson" },
                    { 7, 41, "Morgan", "Male", "Karlsson" },
                    { 8, 52, "Ola-Conny", "Male", "Wallgren" }
                });

            migrationBuilder.InsertData(
                table: "LibraryLoans",
                columns: new[] { "LibraryLoanID", "BookID", "CustomerID", "DateOfLoan", "DateOfReturn", "IsReturned", "LastDateToReturn" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 9, 30, 2, 54, 0, 178, DateTimeKind.Local).AddTicks(1919), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 14, 2, 54, 0, 180, DateTimeKind.Local).AddTicks(6601) },
                    { 2, 2, 1, new DateTime(2022, 9, 30, 2, 54, 0, 180, DateTimeKind.Local).AddTicks(7482), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 14, 2, 54, 0, 180, DateTimeKind.Local).AddTicks(7504) },
                    { 3, 3, 1, new DateTime(2022, 9, 30, 2, 54, 0, 180, DateTimeKind.Local).AddTicks(7547), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 14, 2, 54, 0, 180, DateTimeKind.Local).AddTicks(7551) },
                    { 4, 4, 2, new DateTime(2022, 9, 30, 2, 54, 0, 180, DateTimeKind.Local).AddTicks(7572), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, new DateTime(2022, 11, 14, 2, 54, 0, 180, DateTimeKind.Local).AddTicks(7575) },
                    { 5, 5, 2, new DateTime(2022, 9, 30, 2, 54, 0, 180, DateTimeKind.Local).AddTicks(7593), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 14, 2, 54, 0, 180, DateTimeKind.Local).AddTicks(7596) },
                    { 6, 6, 2, new DateTime(2022, 9, 30, 2, 54, 0, 180, DateTimeKind.Local).AddTicks(7621), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2022, 11, 14, 2, 54, 0, 180, DateTimeKind.Local).AddTicks(7624) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibraryLoans_BookID",
                table: "LibraryLoans",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryLoans_CustomerID",
                table: "LibraryLoans",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibraryLoans");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
