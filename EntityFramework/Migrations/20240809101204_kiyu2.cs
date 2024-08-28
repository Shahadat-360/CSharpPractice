using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class kiyu2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrders_Customers_ProductId",
                table: "PurchaseOrders");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrders_CustomerId",
                table: "PurchaseOrders",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrders_Customers_CustomerId",
                table: "PurchaseOrders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseOrders_Customers_CustomerId",
                table: "PurchaseOrders");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseOrders_CustomerId",
                table: "PurchaseOrders");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseOrders_Customers_ProductId",
                table: "PurchaseOrders",
                column: "ProductId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
