using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sieve.API.Models.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationUser = table.Column<string>(maxLength: 30, nullable: true),
                    EditionUser = table.Column<string>(maxLength: 30, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EditionDate = table.Column<DateTime>(nullable: true),
                    CardHolder = table.Column<string>(maxLength: 30, nullable: false),
                    CardNumber = table.Column<string>(maxLength: 19, nullable: false),
                    ShelfLife = table.Column<DateTime>(nullable: false),
                    CVV = table.Column<int>(nullable: false),
                    Limit = table.Column<double>(nullable: false),
                    Value = table.Column<double>(nullable: false),
                    Payday = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategorySection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationUser = table.Column<string>(maxLength: 30, nullable: true),
                    EditionUser = table.Column<string>(maxLength: 30, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EditionDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    SectionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySection", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategorySection_CategorySection_SectionId",
                        column: x => x.SectionId,
                        principalTable: "CategorySection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Identity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationUser = table.Column<string>(maxLength: 30, nullable: true),
                    EditionUser = table.Column<string>(maxLength: 30, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EditionDate = table.Column<DateTime>(nullable: true),
                    Username = table.Column<string>(maxLength: 30, nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 255, nullable: false),
                    Email = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Identity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationUser = table.Column<string>(maxLength: 30, nullable: true),
                    EditionUser = table.Column<string>(maxLength: 30, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EditionDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationUser = table.Column<string>(maxLength: 30, nullable: true),
                    EditionUser = table.Column<string>(maxLength: 30, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EditionDate = table.Column<DateTime>(nullable: true),
                    CNPJ = table.Column<string>(maxLength: 18, nullable: true),
                    CPF = table.Column<string>(maxLength: 14, nullable: true),
                    FirstName = table.Column<string>(maxLength: 30, nullable: true),
                    LastName = table.Column<string>(maxLength: 80, nullable: true),
                    CompanyName = table.Column<string>(maxLength: 80, nullable: true),
                    TrandingName = table.Column<string>(maxLength: 30, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 22, nullable: false),
                    Email = table.Column<string>(maxLength: 60, nullable: false),
                    Address = table.Column<string>(maxLength: 255, nullable: false),
                    Birthday = table.Column<DateTime>(nullable: true),
                    Service = table.Column<string>(maxLength: 80, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    ShippingTime = table.Column<TimeSpan>(nullable: false),
                    Obs = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationUser = table.Column<string>(maxLength: 30, nullable: true),
                    EditionUser = table.Column<string>(maxLength: 30, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EditionDate = table.Column<DateTime>(nullable: true),
                    CPF = table.Column<string>(maxLength: 14, nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 80, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 22, nullable: true),
                    Email = table.Column<string>(maxLength: 80, nullable: true),
                    Address = table.Column<string>(maxLength: 255, nullable: false),
                    Birthday = table.Column<DateTime>(nullable: true),
                    CardId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Client_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationUser = table.Column<string>(maxLength: 30, nullable: true),
                    EditionUser = table.Column<string>(maxLength: 30, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EditionDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Brand = table.Column<string>(maxLength: 30, nullable: false),
                    SectionId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_CategorySection_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "CategorySection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_CategorySection_SectionId",
                        column: x => x.SectionId,
                        principalTable: "CategorySection",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationUser = table.Column<string>(maxLength: 30, nullable: true),
                    EditionUser = table.Column<string>(maxLength: 30, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EditionDate = table.Column<DateTime>(nullable: true),
                    CTPS = table.Column<string>(maxLength: 14, nullable: false),
                    Salary = table.Column<double>(nullable: false),
                    CPF = table.Column<string>(maxLength: 14, nullable: false),
                    FirstName = table.Column<string>(maxLength: 30, nullable: false),
                    LastName = table.Column<string>(maxLength: 80, nullable: false),
                    Birthday = table.Column<DateTime>(nullable: true),
                    Address = table.Column<string>(maxLength: 255, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 22, nullable: true),
                    Email = table.Column<string>(maxLength: 14, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    JobRole = table.Column<string>(maxLength: 80, nullable: false),
                    IdentityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Identity_IdentityId",
                        column: x => x.IdentityId,
                        principalTable: "Identity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RIdentityRole",
                columns: table => new
                {
                    IdIdentity = table.Column<int>(nullable: false),
                    IdRole = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RIdentityRole", x => new { x.IdIdentity, x.IdRole });
                    table.ForeignKey(
                        name: "FK_RIdentityRole_Identity_IdIdentity",
                        column: x => x.IdIdentity,
                        principalTable: "Identity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RIdentityRole_Role_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Role",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationUser = table.Column<string>(maxLength: 30, nullable: true),
                    EditionUser = table.Column<string>(maxLength: 30, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EditionDate = table.Column<DateTime>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    ShippingData = table.Column<string>(maxLength: 255, nullable: true),
                    Value = table.Column<double>(nullable: false),
                    Shipment = table.Column<double>(nullable: false),
                    ClientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationUser = table.Column<string>(maxLength: 30, nullable: true),
                    EditionUser = table.Column<string>(maxLength: 30, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EditionDate = table.Column<DateTime>(nullable: true),
                    InitialDate = table.Column<DateTime>(nullable: false),
                    MinQnt = table.Column<int>(nullable: true),
                    Percentage = table.Column<double>(nullable: false),
                    MustHaveCard = table.Column<bool>(nullable: false),
                    ShelfLife = table.Column<DateTime>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discount_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RSupplierProduct",
                columns: table => new
                {
                    IdSupplier = table.Column<int>(nullable: false),
                    IdProduct = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RSupplierProduct", x => new { x.IdProduct, x.IdSupplier });
                    table.ForeignKey(
                        name: "FK_RSupplierProduct_Product_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Product",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RSupplierProduct_Suppliers_IdSupplier",
                        column: x => x.IdSupplier,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Storage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationUser = table.Column<string>(maxLength: 30, nullable: true),
                    EditionUser = table.Column<string>(maxLength: 30, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EditionDate = table.Column<DateTime>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false),
                    AvgPrice = table.Column<double>(nullable: false),
                    TotalQnt = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Storage_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ROrderProduct",
                columns: table => new
                {
                    IdOrder = table.Column<int>(nullable: false),
                    IdProduct = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ROrderProduct", x => new { x.IdOrder, x.IdProduct });
                    table.ForeignKey(
                        name: "FK_ROrderProduct_Orders_IdOrder",
                        column: x => x.IdOrder,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ROrderProduct_Product_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StorageEntry",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreationUser = table.Column<string>(maxLength: 30, nullable: true),
                    EditionUser = table.Column<string>(maxLength: 30, nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: true),
                    EditionDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(maxLength: 255, nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Type = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Batch = table.Column<string>(maxLength: 30, nullable: false),
                    ShelfLife = table.Column<DateTime>(nullable: false),
                    StorageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StorageEntry_Storage_StorageId",
                        column: x => x.StorageId,
                        principalTable: "Storage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cards_CardNumber",
                table: "Cards",
                column: "CardNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CategorySection_SectionId",
                table: "CategorySection",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Client_CPF",
                table: "Client",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_CardId",
                table: "Client",
                column: "CardId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_Email",
                table: "Client",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Discount_ProductId",
                table: "Discount",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CPF",
                table: "Employees",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CTPS",
                table: "Employees",
                column: "CTPS",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_IdentityId",
                table: "Employees",
                column: "IdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_Identity_Email",
                table: "Identity",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Identity_Username",
                table: "Identity",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ClientId",
                table: "Orders",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SectionId",
                table: "Product",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_RIdentityRole_IdRole",
                table: "RIdentityRole",
                column: "IdRole");

            migrationBuilder.CreateIndex(
                name: "IX_Role_Description",
                table: "Role",
                column: "Description",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ROrderProduct_IdProduct",
                table: "ROrderProduct",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_RSupplierProduct_IdSupplier",
                table: "RSupplierProduct",
                column: "IdSupplier");

            migrationBuilder.CreateIndex(
                name: "IX_Storage_ProductId",
                table: "Storage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StorageEntry_StorageId",
                table: "StorageEntry",
                column: "StorageId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CNPJ",
                table: "Suppliers",
                column: "CNPJ",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_CPF",
                table: "Suppliers",
                column: "CPF",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_Email",
                table: "Suppliers",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "RIdentityRole");

            migrationBuilder.DropTable(
                name: "ROrderProduct");

            migrationBuilder.DropTable(
                name: "RSupplierProduct");

            migrationBuilder.DropTable(
                name: "StorageEntry");

            migrationBuilder.DropTable(
                name: "Identity");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Storage");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Cards");

            migrationBuilder.DropTable(
                name: "CategorySection");
        }
    }
}
