using Microsoft.EntityFrameworkCore.Migrations;

namespace BookLibrary.Data.Migrations
{
    public partial class AddMovieTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Director_DirectorId",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieBorrowers_Borrowers_BorrowerId",
                table: "MovieBorrowers");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieBorrowers_Movie_MovieId",
                table: "MovieBorrowers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieBorrowers",
                table: "MovieBorrowers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Director",
                table: "Director");

            migrationBuilder.RenameTable(
                name: "MovieBorrowers",
                newName: "MovieBorrowerses");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.RenameTable(
                name: "Director",
                newName: "Directors");

            migrationBuilder.RenameIndex(
                name: "IX_MovieBorrowers_BorrowerId",
                table: "MovieBorrowerses",
                newName: "IX_MovieBorrowerses_BorrowerId");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_DirectorId",
                table: "Movies",
                newName: "IX_Movies_DirectorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieBorrowerses",
                table: "MovieBorrowerses",
                columns: new[] { "MovieId", "BorrowerId", "BorrowDate" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Directors",
                table: "Directors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieBorrowerses_Borrowers_BorrowerId",
                table: "MovieBorrowerses",
                column: "BorrowerId",
                principalTable: "Borrowers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieBorrowerses_Movies_MovieId",
                table: "MovieBorrowerses",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Directors_DirectorId",
                table: "Movies",
                column: "DirectorId",
                principalTable: "Directors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieBorrowerses_Borrowers_BorrowerId",
                table: "MovieBorrowerses");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieBorrowerses_Movies_MovieId",
                table: "MovieBorrowerses");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Directors_DirectorId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieBorrowerses",
                table: "MovieBorrowerses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Directors",
                table: "Directors");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.RenameTable(
                name: "MovieBorrowerses",
                newName: "MovieBorrowers");

            migrationBuilder.RenameTable(
                name: "Directors",
                newName: "Director");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_DirectorId",
                table: "Movie",
                newName: "IX_Movie_DirectorId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieBorrowerses_BorrowerId",
                table: "MovieBorrowers",
                newName: "IX_MovieBorrowers_BorrowerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieBorrowers",
                table: "MovieBorrowers",
                columns: new[] { "MovieId", "BorrowerId", "BorrowDate" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Director",
                table: "Director",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Director_DirectorId",
                table: "Movie",
                column: "DirectorId",
                principalTable: "Director",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieBorrowers_Borrowers_BorrowerId",
                table: "MovieBorrowers",
                column: "BorrowerId",
                principalTable: "Borrowers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieBorrowers_Movie_MovieId",
                table: "MovieBorrowers",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
