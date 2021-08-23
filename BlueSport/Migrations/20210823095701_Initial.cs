using Microsoft.EntityFrameworkCore.Migrations;

namespace BlueSport.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BannerTypes",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerTypes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false),
                    parentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    alt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    typeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.id);
                    table.ForeignKey(
                        name: "FK_Banners_BannerTypes_typeId",
                        column: x => x.typeId,
                        principalTable: "BannerTypes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    priceCurrent = table.Column<int>(type: "int", nullable: false),
                    priceOld = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    saleOff = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    brandId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    isSoldOut = table.Column<bool>(type: "bit", nullable: false),
                    installment = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_brandId",
                        column: x => x.brandId,
                        principalTable: "Brands",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SizeMapColors",
                columns: table => new
                {
                    sizeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    colorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeMapColors", x => new { x.colorId, x.sizeId });
                    table.ForeignKey(
                        name: "FK_SizeMapColors_Colors_colorId",
                        column: x => x.colorId,
                        principalTable: "Colors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizeMapColors_Sizes_sizeId",
                        column: x => x.sizeId,
                        principalTable: "Sizes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    topicId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cusEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cusPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.id);
                    table.ForeignKey(
                        name: "FK_Contacts_Topics_topicId",
                        column: x => x.topicId,
                        principalTable: "Topics",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    productId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    detail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    productId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    alt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductMapCates",
                columns: table => new
                {
                    productId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    cateId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMapCates", x => new { x.productId, x.cateId });
                    table.ForeignKey(
                        name: "FK_ProductMapCates_Categories_cateId",
                        column: x => x.cateId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMapCates_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMapSizes",
                columns: table => new
                {
                    productId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sizeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMapSizes", x => new { x.productId, x.sizeId });
                    table.ForeignKey(
                        name: "FK_ProductMapSizes_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductMapSizes_Sizes_sizeId",
                        column: x => x.sizeId,
                        principalTable: "Sizes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    productId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.id);
                    table.ForeignKey(
                        name: "FK_Promotions_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PromotionDetails",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    info = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isOnline = table.Column<bool>(type: "bit", nullable: false),
                    isMore = table.Column<bool>(type: "bit", nullable: false),
                    promotionId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionDetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_PromotionDetails_Promotions_promotionId",
                        column: x => x.promotionId,
                        principalTable: "Promotions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Banners_typeId",
                table: "Banners",
                column: "typeId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_topicId",
                table: "Contacts",
                column: "topicId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_productId",
                table: "ProductDetails",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_productId",
                table: "ProductImages",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMapCates_cateId",
                table: "ProductMapCates",
                column: "cateId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductMapSizes_sizeId",
                table: "ProductMapSizes",
                column: "sizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_brandId",
                table: "Products",
                column: "brandId");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionDetails_promotionId",
                table: "PromotionDetails",
                column: "promotionId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_productId",
                table: "Promotions",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeMapColors_sizeId",
                table: "SizeMapColors",
                column: "sizeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductMapCates");

            migrationBuilder.DropTable(
                name: "ProductMapSizes");

            migrationBuilder.DropTable(
                name: "PromotionDetails");

            migrationBuilder.DropTable(
                name: "SizeMapColors");

            migrationBuilder.DropTable(
                name: "BannerTypes");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
