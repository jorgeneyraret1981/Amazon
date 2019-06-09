using Microsoft.EntityFrameworkCore.Migrations;

namespace Amazon.Migrations
{
    public partial class UpdateCategoryColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "6fe7b296-d9ad-4b40-863c-08d6dbeaf65d",
            column: "Category",
            value: "Technology"
            );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "63302695-7322-4ae9-863d-08d6dbeaf65d",
            column: "Category",
            value: "Technology"
            );
            migrationBuilder.UpdateData(
           table: "Books",
           keyColumn: "BookId",
           keyValue: "c5ac8a9e-cc00-4dd7-863e-08d6dbeaf65d",
           column: "Category",
           value: "Technology"
           );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "08bec93b-f360-425f-863f-08d6dbeaf65d",
            column: "Category",
            value: "Technology"
            );
            migrationBuilder.UpdateData(
           table: "Books",
           keyColumn: "BookId",
           keyValue: "44fc76b5-91b6-4afc-8640-08d6dbeaf65d",
           column: "Category",
           value: "Education"
           );
            migrationBuilder.UpdateData(
            table: "Books",
            keyColumn: "BookId",
            keyValue: "25d4de87-f07a-44b9-8641-08d6dbeaf65d",
            column: "Category",
            value: "Education"
            );
            migrationBuilder.UpdateData(
           table: "Books",
           keyColumn: "BookId",
           keyValue: "c5a7850f-1adc-45c8-8642-08d6dbeaf65d",
           column: "Category",
           value: "Education"
           );
            migrationBuilder.UpdateData(
           table: "Books",
           keyColumn: "BookId",
           keyValue: "a773bfdf-7d10-4971-8643-08d6dbeaf65d",
           column: "Category",
           value: "Engineering"
           );
            migrationBuilder.UpdateData(
           table: "Books",
           keyColumn: "BookId",
           keyValue: "9dc9c607-a418-485a-8644-08d6dbeaf65d",
           column: "Category",
           value: "Engineering"
           );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
