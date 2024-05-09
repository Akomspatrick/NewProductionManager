using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductionManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class prod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AmplifierBoards",
                columns: table => new
                {
                    AmplifierBoardId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Brand = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HasRed = table.Column<int>(type: "int", nullable: false),
                    RedValue = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HasGreen = table.Column<int>(type: "int", nullable: false),
                    GreenValue = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HasBlack = table.Column<int>(type: "int", nullable: false),
                    BlackValue = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HasWhite = table.Column<int>(type: "int", nullable: false),
                    WhiteValue = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HasShield = table.Column<int>(type: "int", nullable: false),
                    ShieldValue = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmplifierBoards", x => new { x.AmplifierBoardId, x.Name });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LogSummarys",
                columns: table => new
                {
                    LogSummaryId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Stage = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    StopTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NoOfItemsProcessed = table.Column<int>(type: "int", nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogSummarys", x => x.LogSummaryId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ModelVersions",
                columns: table => new
                {
                    ModelVersionId = table.Column<int>(type: "int", nullable: false),
                    ModelName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VersionDescription = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModelVersionName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModelVersionGroupName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultTestingMode = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Timestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    NominalOutput = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    NominalOutputPercentage = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    NonlinearityPercentage = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    MinimumDeadLoad = table.Column<int>(type: "int", nullable: true),
                    vMin = table.Column<decimal>(type: "decimal(11,1)", precision: 11, scale: 1, nullable: false),
                    nMax = table.Column<int>(type: "int", nullable: true),
                    SafeLoad = table.Column<int>(type: "int", nullable: true),
                    UltimateLoad = table.Column<int>(type: "int", nullable: true),
                    ShellMaterialName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Alloy = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DefaultCableLength = table.Column<int>(type: "int", nullable: true),
                    NumberOfGauges = table.Column<int>(type: "int", nullable: true),
                    Resistance = table.Column<int>(type: "int", nullable: true),
                    CCNumber = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccuracyClass = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Application = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TemperingHardnessLow = table.Column<int>(type: "int", nullable: true),
                    TemperingHardnessHigh = table.Column<int>(type: "int", nullable: true),
                    NTEPCertificationId = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NTEPCertificationTimestamp = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    OIMLCertificationId = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OIMLCertificationTimestamp = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    TestPointDirection = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModelVersions", x => new { x.ModelVersionId, x.ModelName });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductAdditionalInfos",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductAdditionalInfoId = table.Column<int>(type: "int", nullable: false),
                    InputVoltage = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    CableLenght = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    CableLenghtUnit = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAdditionalInfos", x => x.ProductId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductCertificateTypes",
                columns: table => new
                {
                    CertifcateType = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(160)", maxLength: 160, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCertificateTypes", x => x.CertifcateType);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductStages",
                columns: table => new
                {
                    Stage = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StageDescription = table.Column<string>(type: "varchar(160)", maxLength: 160, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    StageNo = table.Column<int>(type: "int", nullable: false),
                    StageBarcode = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SaveBarCode = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SaveAndEndBarCode = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStages", x => x.Stage);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ReferenceStandards",
                columns: table => new
                {
                    RefStandardManufacturer = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefStandardModelName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefStandardSerialNo = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    B0 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    B1 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    B2 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    B3 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    B4 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceStandards", x => new { x.RefStandardManufacturer, x.RefStandardModelName, x.RefStandardSerialNo });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShuntResistors",
                columns: table => new
                {
                    Value = table.Column<decimal>(type: "decimal(10,0)", precision: 10, scale: 0, nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShuntResistors", x => x.Value);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Testers",
                columns: table => new
                {
                    TesterName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NistTraceAble = table.Column<int>(type: "int", nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testers", x => x.TesterName);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TrimmingResistors",
                columns: table => new
                {
                    Value = table.Column<decimal>(type: "decimal(10,0)", precision: 10, scale: 0, nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrimmingResistors", x => x.Value);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "LogDetails",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    LogSummaryId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogDetails", x => new { x.ProductId, x.LogSummaryId });
                    table.ForeignKey(
                        name: "FK_LogDetails_LogSummarys_LogSummaryId",
                        column: x => x.LogSummaryId,
                        principalTable: "LogSummarys",
                        principalColumn: "LogSummaryId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DefectTypes",
                columns: table => new
                {
                    DefectName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Stage = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefectDescription = table.Column<string>(type: "varchar(160)", maxLength: 160, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TriggerPercentage = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    MinTotalProductInBatchB4Trigger = table.Column<int>(type: "int", nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefectTypes", x => new { x.DefectName, x.Stage });
                    table.ForeignKey(
                        name: "FK_DefectTypes_ProductStages_Stage",
                        column: x => x.Stage,
                        principalTable: "ProductStages",
                        principalColumn: "Stage",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ModelVersionId = table.Column<int>(type: "int", nullable: false),
                    ModelName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Stage = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SubStage = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InvoiceId = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SalesOrderId = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CableLength = table.Column<int>(type: "int", nullable: false),
                    InspectionResult = table.Column<int>(type: "int", nullable: false),
                    DefaultTestingMode = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModelTypeGroupName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UsedTestingMode = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ThermexPurcharseOrderNo = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MachiningPurcharseOrderNo = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SteelPurcharseOrderNo = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BatcNo = table.Column<int>(type: "int", nullable: false),
                    LoadDirection = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProductStageStage = table.Column<string>(type: "varchar(32)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_ModelVersions_ModelVersionId_ModelName",
                        columns: x => new { x.ModelVersionId, x.ModelName },
                        principalTable: "ModelVersions",
                        principalColumns: new[] { "ModelVersionId", "ModelName" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductStages_ProductStageStage",
                        column: x => x.ProductStageStage,
                        principalTable: "ProductStages",
                        principalColumn: "Stage");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ReferenceCellCalibrations",
                columns: table => new
                {
                    Weight = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RefStandardManufacturer = table.Column<string>(type: "varchar(32)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefStandardModelName = table.Column<string>(type: "varchar(32)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefStandardSerialNo = table.Column<string>(type: "varchar(32)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LowMeasuredPosition = table.Column<decimal>(type: "decimal(30,10)", precision: 30, scale: 10, nullable: false),
                    LowCurrent = table.Column<decimal>(type: "decimal(30,10)", precision: 30, scale: 10, nullable: false),
                    HighMeasuredPosition = table.Column<decimal>(type: "decimal(30,10)", precision: 30, scale: 10, nullable: false),
                    HighCurrent = table.Column<decimal>(type: "decimal(30,10)", precision: 30, scale: 10, nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceCellCalibrations", x => x.Weight);
                    table.ForeignKey(
                        name: "FK_ReferenceCellCalibrations_ReferenceStandards_RefStandardManu~",
                        columns: x => new { x.RefStandardManufacturer, x.RefStandardModelName, x.RefStandardSerialNo },
                        principalTable: "ReferenceStandards",
                        principalColumns: new[] { "RefStandardManufacturer", "RefStandardModelName", "RefStandardSerialNo" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DefectTypeSolutions",
                columns: table => new
                {
                    DefectName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Stage = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Timestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Solution = table.Column<string>(type: "varchar(264)", maxLength: 264, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefectTypeSolutions", x => new { x.DefectName, x.Stage, x.Timestamp });
                    table.ForeignKey(
                        name: "FK_DefectTypeSolutions_DefectTypes_DefectName_Stage",
                        columns: x => new { x.DefectName, x.Stage },
                        principalTable: "DefectTypes",
                        principalColumns: new[] { "DefectName", "Stage" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "NonConformanceLogs",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ModelVersionId = table.Column<int>(type: "int", nullable: false),
                    Stage = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WhenItOccurred = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModelName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BatcNo = table.Column<int>(type: "int", nullable: false),
                    DefectName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LogByUserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Status = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Solution = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    WhenItWasResolved = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ResolvedByUserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Comment = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NonConformanceLogs", x => new { x.ProductId, x.ModelVersionId, x.Stage, x.WhenItOccurred });
                    table.ForeignKey(
                        name: "FK_NonConformanceLogs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductCablingEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCablingEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductCablingEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductCertificates",
                columns: table => new
                {
                    ProductCertificateId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CertifcateType = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    JsonData = table.Column<string>(type: "varchar(2500)", maxLength: 2500, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Timestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCertificates", x => new { x.ProductCertificateId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ProductCertificates_ProductCertificateTypes_CertifcateType",
                        column: x => x.CertifcateType,
                        principalTable: "ProductCertificateTypes",
                        principalColumn: "CertifcateType",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCertificates_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductFinalUnits",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InputUnit = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OuputUnits = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IndicatorType = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IndicatorChannel = table.Column<int>(type: "int", nullable: false),
                    IndicatorSerialNo = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GradSize = table.Column<int>(type: "int", nullable: false),
                    PinSize = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    Division = table.Column<int>(type: "int", nullable: false),
                    LowWeight = table.Column<decimal>(type: "decimal(10,0)", precision: 10, scale: 0, nullable: false),
                    HighWeight = table.Column<decimal>(type: "decimal(10,0)", precision: 10, scale: 0, nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFinalUnits", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductFinalUnits_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductFinalVerifiationEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    VerificationResult = table.Column<int>(type: "int", nullable: false),
                    ReferenceSerial = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TesterName = table.Column<string>(type: "varchar(32)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CalibratedOutput = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    PercentNonlinearity = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutZeroPoint = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint1 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint1 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint1 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint2 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint2 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint2 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint3 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint3 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint3 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint4 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint4 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint4 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint5 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint5 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint5 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint6 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint6 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint6 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint7 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint7 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint7 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint8 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint8 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint8 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint9 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint9 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint9 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint10 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint10 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint10 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFinalVerifiationEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductFinalVerifiationEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFinalVerifiationEvents_Testers_TesterName",
                        column: x => x.TesterName,
                        principalTable: "Testers",
                        principalColumn: "TesterName",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductFinishedEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFinishedEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductFinishedEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductGaugeEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    GuageModel = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuageLotNo = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGaugeEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductGaugeEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductGaugeInspectionEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InspectionResult = table.Column<int>(type: "int", nullable: false),
                    DefectName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GaugeFailed = table.Column<int>(type: "int", nullable: false),
                    GaugePassed = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGaugeInspectionEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductGaugeInspectionEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductInitialUnits",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InputUnits = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OutputUnits = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInitialUnits", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductInitialUnits_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductInitialVerificationEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    VerificationResult = table.Column<int>(type: "int", nullable: false),
                    ReferenceSerial = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TesterName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CalibratedOutput = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    PercentNonlinearity = table.Column<decimal>(type: "decimal(36,12)", precision: 36, scale: 12, nullable: false),
                    DutZeroPoint = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint1 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint1 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint1 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint2 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint2 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint2 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint3 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint3 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint3 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint4 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint4 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint4 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint5 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint5 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint5 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint6 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint6 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint6 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint7 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint7 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint7 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint8 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint8 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint8 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint9 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint9 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint9 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    RefPoint10 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    ForcePoint10 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    DutPoint10 = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInitialVerificationEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductInitialVerificationEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInitialVerificationEvents_Testers_TesterName",
                        column: x => x.TesterName,
                        principalTable: "Testers",
                        principalColumn: "TesterName",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductInventoryEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInventoryEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductInventoryEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductLabellingEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductLabellingEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductLabellingEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductMovingEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    SourceStage = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DestinationStage = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MovingNotes = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMovingEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductMovingEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductPictures",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Stage = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FileName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LocalPathName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BasePath = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(160)", maxLength: 160, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPictures", x => new { x.ProductId, x.Timestamp });
                    table.ForeignKey(
                        name: "FK_ProductPictures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductReceptionEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Notes = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductReceptionEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductReceptionEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductResistorInstallationEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductResistorInstallationEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductResistorInstallationEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductSealingEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSealingEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductSealingEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductShippingEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductShippingEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductShippingEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductSurfacePreparationEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    InspectionResult = table.Column<int>(type: "int", nullable: false),
                    DefectName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSurfacePreparationEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductSurfacePreparationEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductVersionChangedEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PrevModelVersionId = table.Column<int>(type: "int", nullable: false),
                    PrevModelName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CurrentModelVersionId = table.Column<int>(type: "int", nullable: false),
                    CurrentPrevModelName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVersionChangedEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductVersionChangedEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductWiringEvents",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductWiringEvents", x => new { x.ProductId, x.TimeStamp });
                    table.ForeignKey(
                        name: "FK_ProductWiringEvents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Timestamp = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    RefStandardSerialNo = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefStandardManufacturer = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RefStandardModelName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(32)", maxLength: 32, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExcitationResistance = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    SignalResistance = table.Column<decimal>(type: "decimal(18,6)", precision: 18, scale: 6, nullable: false),
                    GuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => new { x.Timestamp, x.ProductId, x.RefStandardSerialNo, x.RefStandardManufacturer, x.RefStandardModelName });
                    table.ForeignKey(
                        name: "FK_Tests_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tests_ReferenceStandards_RefStandardSerialNo_RefStandardManu~",
                        columns: x => new { x.RefStandardSerialNo, x.RefStandardManufacturer, x.RefStandardModelName },
                        principalTable: "ReferenceStandards",
                        principalColumns: new[] { "RefStandardManufacturer", "RefStandardModelName", "RefStandardSerialNo" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_DefectTypes_Stage",
                table: "DefectTypes",
                column: "Stage");

            migrationBuilder.CreateIndex(
                name: "IX_LogDetails_LogSummaryId",
                table: "LogDetails",
                column: "LogSummaryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCertificates_CertifcateType",
                table: "ProductCertificates",
                column: "CertifcateType");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCertificates_ProductId",
                table: "ProductCertificates",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFinalVerifiationEvents_TesterName",
                table: "ProductFinalVerifiationEvents",
                column: "TesterName");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInitialVerificationEvents_TesterName",
                table: "ProductInitialVerificationEvents",
                column: "TesterName");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ModelVersionId_ModelName",
                table: "Products",
                columns: new[] { "ModelVersionId", "ModelName" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductStageStage",
                table: "Products",
                column: "ProductStageStage");

            migrationBuilder.CreateIndex(
                name: "IX_ReferenceCellCalibrations_RefStandardManufacturer_RefStandar~",
                table: "ReferenceCellCalibrations",
                columns: new[] { "RefStandardManufacturer", "RefStandardModelName", "RefStandardSerialNo" });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_ProductId",
                table: "Tests",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_RefStandardSerialNo_RefStandardManufacturer_RefStandar~",
                table: "Tests",
                columns: new[] { "RefStandardSerialNo", "RefStandardManufacturer", "RefStandardModelName" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmplifierBoards");

            migrationBuilder.DropTable(
                name: "DefectTypeSolutions");

            migrationBuilder.DropTable(
                name: "LogDetails");

            migrationBuilder.DropTable(
                name: "NonConformanceLogs");

            migrationBuilder.DropTable(
                name: "ProductAdditionalInfos");

            migrationBuilder.DropTable(
                name: "ProductCablingEvents");

            migrationBuilder.DropTable(
                name: "ProductCertificates");

            migrationBuilder.DropTable(
                name: "ProductFinalUnits");

            migrationBuilder.DropTable(
                name: "ProductFinalVerifiationEvents");

            migrationBuilder.DropTable(
                name: "ProductFinishedEvents");

            migrationBuilder.DropTable(
                name: "ProductGaugeEvents");

            migrationBuilder.DropTable(
                name: "ProductGaugeInspectionEvents");

            migrationBuilder.DropTable(
                name: "ProductInitialUnits");

            migrationBuilder.DropTable(
                name: "ProductInitialVerificationEvents");

            migrationBuilder.DropTable(
                name: "ProductInventoryEvents");

            migrationBuilder.DropTable(
                name: "ProductLabellingEvents");

            migrationBuilder.DropTable(
                name: "ProductMovingEvents");

            migrationBuilder.DropTable(
                name: "ProductPictures");

            migrationBuilder.DropTable(
                name: "ProductReceptionEvents");

            migrationBuilder.DropTable(
                name: "ProductResistorInstallationEvents");

            migrationBuilder.DropTable(
                name: "ProductSealingEvents");

            migrationBuilder.DropTable(
                name: "ProductShippingEvents");

            migrationBuilder.DropTable(
                name: "ProductSurfacePreparationEvents");

            migrationBuilder.DropTable(
                name: "ProductVersionChangedEvents");

            migrationBuilder.DropTable(
                name: "ProductWiringEvents");

            migrationBuilder.DropTable(
                name: "ReferenceCellCalibrations");

            migrationBuilder.DropTable(
                name: "ShuntResistors");

            migrationBuilder.DropTable(
                name: "Tests");

            migrationBuilder.DropTable(
                name: "TrimmingResistors");

            migrationBuilder.DropTable(
                name: "DefectTypes");

            migrationBuilder.DropTable(
                name: "LogSummarys");

            migrationBuilder.DropTable(
                name: "ProductCertificateTypes");

            migrationBuilder.DropTable(
                name: "Testers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ReferenceStandards");

            migrationBuilder.DropTable(
                name: "ModelVersions");

            migrationBuilder.DropTable(
                name: "ProductStages");
        }
    }
}
