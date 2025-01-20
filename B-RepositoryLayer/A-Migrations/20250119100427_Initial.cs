using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace B_RepositoryLayer.AMigrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Channels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Channel_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Channels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Governorates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Governorate_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Netwoek_Element_Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Netwoek_element_Type_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Network_Element_Type_Parent_Id = table.Column<int>(type: "int", nullable: true),
                    Network_Element_Type_ParentId = table.Column<int>(type: "int", nullable: true),
                    Network_Element_Hierarchy_Path_Key = table.Column<int>(type: "int", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Netwoek_Element_Types", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Netwoek_Element_Types_Netwoek_Element_Types_Network_Element_Type_ParentId",
                        column: x => x.Network_Element_Type_ParentId,
                        principalTable: "Netwoek_Element_Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Network_Elements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Network_Element_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Network_Element_Type_Id = table.Column<int>(type: "int", nullable: false),
                    Parent_Network_Element_Id = table.Column<int>(type: "int", nullable: true),
                    Parent_Network_ElementId = table.Column<int>(type: "int", nullable: true),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Network_Elements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Network_Elements_Network_Elements_Parent_Network_ElementId",
                        column: x => x.Parent_Network_ElementId,
                        principalTable: "Network_Elements",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProblemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Problem_Type_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProblemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sector_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GovernrateId = table.Column<int>(type: "int", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sectors_Governorates_GovernrateId",
                        column: x => x.GovernrateId,
                        principalTable: "Governorates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cutting_Down_A",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cutting_Down_Cabin_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProblemTypeId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    lsplanned = table.Column<bool>(type: "bit", nullable: false),
                    lsGlobal = table.Column<bool>(type: "bit", nullable: false),
                    PlannedStartoTS = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlannedendDTs = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cutting_Down_A", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cutting_Down_A_ProblemTypes_ProblemTypeId",
                        column: x => x.ProblemTypeId,
                        principalTable: "ProblemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cutting_Down_A_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cutting_Down_A_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Cutting_Down_B",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cutting_Down_Cable_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProblemTypeId = table.Column<int>(type: "int", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    lsplanned = table.Column<bool>(type: "bit", nullable: false),
                    lsGlobal = table.Column<bool>(type: "bit", nullable: false),
                    PlannedStartoTS = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PlannedendDTs = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cutting_Down_B", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cutting_Down_B_ProblemTypes_ProblemTypeId",
                        column: x => x.ProblemTypeId,
                        principalTable: "ProblemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cutting_Down_B_Users_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cutting_Down_B_Users_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zone_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SectorId = table.Column<int>(type: "int", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zones_Sectors_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZoneId = table.Column<int>(type: "int", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Station_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tower",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tower_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StationId = table.Column<int>(type: "int", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tower", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tower_Stations_StationId",
                        column: x => x.StationId,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cabins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cabin_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TowerId = table.Column<int>(type: "int", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cabins_Tower_TowerId",
                        column: x => x.TowerId,
                        principalTable: "Tower",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cable_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CabinId = table.Column<int>(type: "int", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cables_Cabins_CabinId",
                        column: x => x.CabinId,
                        principalTable: "Cabins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Block_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CableId = table.Column<int>(type: "int", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blocks_Cables_CableId",
                        column: x => x.CableId,
                        principalTable: "Cables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Building_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlockId = table.Column<int>(type: "int", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Buildings_Blocks_BlockId",
                        column: x => x.BlockId,
                        principalTable: "Blocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Flats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flat_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flats_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlatId = table.Column<int>(type: "int", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false),
                    Meter_Key = table.Column<int>(type: "int", nullable: false),
                    Paiet_Key = table.Column<int>(type: "int", nullable: false),
                    _created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _updated_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_Buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "Buildings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Subscriptions_Flats_FlatId",
                        column: x => x.FlatId,
                        principalTable: "Flats",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blocks_CableId",
                table: "Blocks",
                column: "CableId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_BlockId",
                table: "Buildings",
                column: "BlockId");

            migrationBuilder.CreateIndex(
                name: "IX_Cabins_TowerId",
                table: "Cabins",
                column: "TowerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cables_CabinId",
                table: "Cables",
                column: "CabinId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ZoneId",
                table: "Cities",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_A_CreatedUserId",
                table: "Cutting_Down_A",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_A_ProblemTypeId",
                table: "Cutting_Down_A",
                column: "ProblemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_A_UpdatedUserId",
                table: "Cutting_Down_A",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_B_CreatedUserId",
                table: "Cutting_Down_B",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_B_ProblemTypeId",
                table: "Cutting_Down_B",
                column: "ProblemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cutting_Down_B_UpdatedUserId",
                table: "Cutting_Down_B",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Flats_BuildingId",
                table: "Flats",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Netwoek_Element_Types_Network_Element_Type_ParentId",
                table: "Netwoek_Element_Types",
                column: "Network_Element_Type_ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Network_Elements_Parent_Network_ElementId",
                table: "Network_Elements",
                column: "Parent_Network_ElementId");

            migrationBuilder.CreateIndex(
                name: "IX_Sectors_GovernrateId",
                table: "Sectors",
                column: "GovernrateId");

            migrationBuilder.CreateIndex(
                name: "IX_Stations_CityId",
                table: "Stations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_BuildingId",
                table: "Subscriptions",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_FlatId",
                table: "Subscriptions",
                column: "FlatId");

            migrationBuilder.CreateIndex(
                name: "IX_Tower_StationId",
                table: "Tower",
                column: "StationId");

            migrationBuilder.CreateIndex(
                name: "IX_Zones_SectorId",
                table: "Zones",
                column: "SectorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Channels");

            migrationBuilder.DropTable(
                name: "Cutting_Down_A");

            migrationBuilder.DropTable(
                name: "Cutting_Down_B");

            migrationBuilder.DropTable(
                name: "Netwoek_Element_Types");

            migrationBuilder.DropTable(
                name: "Network_Elements");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "ProblemTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Flats");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Blocks");

            migrationBuilder.DropTable(
                name: "Cables");

            migrationBuilder.DropTable(
                name: "Cabins");

            migrationBuilder.DropTable(
                name: "Tower");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "Sectors");

            migrationBuilder.DropTable(
                name: "Governorates");
        }
    }
}
