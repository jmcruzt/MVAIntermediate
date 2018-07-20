using Microsoft.EntityFrameworkCore.Migrations;

namespace MVAIntermediate.Data.Migrations
{
    public partial class relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Order_No",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_Order_No",
                table: "OrderDetails",
                column: "Order_No");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_OrderMasters_Order_No",
                table: "OrderDetails",
                column: "Order_No",
                principalTable: "OrderMasters",
                principalColumn: "Order_No",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_OrderMasters_Order_No",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_Order_No",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "Order_No",
                table: "OrderDetails",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
