using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibrary.Data.Migrations
{
    public partial class AddBorrowDateToPK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookBorrowerses",
                table: "BookBorrowerses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookBorrowerses",
                table: "BookBorrowerses",
                columns: new[] { "BookId", "BorrowerId", "BorrowDate" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BookBorrowerses",
                table: "BookBorrowerses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookBorrowerses",
                table: "BookBorrowerses",
                columns: new[] { "BookId", "BorrowerId" });
        }
    }
}
