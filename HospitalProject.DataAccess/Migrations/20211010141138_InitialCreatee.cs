using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalProject.DataAccess.Migrations
{
    public partial class InitialCreatee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AileMedikalGecmisis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yakinlik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tani = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaniYili = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AileMedikalGecmisis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlkolKullanimis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GundeMiktar = table.Column<int>(type: "int", nullable: false),
                    MevcutDurum = table.Column<int>(type: "int", nullable: false),
                    BirakisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlkolKullanimis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Definition = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DonorMedikalGecmisis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastalikTedaviBozukluk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaniTarihi = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Durumu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ICD10Kodu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonorMedikalGecmisis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EkIslemlerMutasyons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(900)", maxLength: 900, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkIslemlerMutasyons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genderd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genderd", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenelBilgilers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ulke = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EtnikKoken = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    EgitimSeviyesi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Boy = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Kilo = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenelBilgilers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ilacs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IlacAdı = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Doz = table.Column<int>(type: "int", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullanımSekli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Siklik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MevcutDurum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilacs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImmunhistokimyaTests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Virus = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TestDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sonuc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImmunhistokimyaTests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "jinekolojikGecmiss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenstüralDurum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SonReglTarihi = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    Hamilelikler = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dogumlar = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jinekolojikGecmiss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KanserTedavisis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TedaviTipi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TedaviBaslangicBitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TedaviSonucu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TedaviUygulamaSekli = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KanserTedavisis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaddeKullanimis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GundeMiktar = table.Column<int>(type: "int", nullable: false),
                    MevcutDurum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaddeKullanimis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MetasazDurumus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MetastazOrganı = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LenfNoduIslemivarmı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LenfNoduMetastazvarmı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LenfNoduLokasyonu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UzakMetastazvarmı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UzakMetastazLokasyonu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MetasazDurumus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Notlars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(900)", maxLength: 900, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notlars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NumuneToplamaBilgisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToplamaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    ToplamaSaati = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnotomikBolge = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToplamaSekli = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumuneToplamaBilgisi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperasyonProsedurus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperasyonProsedurus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PatolojiDurumus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumuneToplamaSekli = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MikroskopikAnaliz = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatolojikTanı = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatolojiDurumus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SigaraKullanimis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GundeMiktar = table.Column<int>(type: "int", nullable: false),
                    MevcutDurum = table.Column<int>(type: "int", nullable: false),
                    BirakisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SigaraKullanimis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SosyalYasamOzellikleris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Meslek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CevreselMazuriyet = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosyalYasamOzellikleris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaniBilgileris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaniTarihi = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    KlinikTani = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ICD10TanıKodu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaniBilgileris", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TumorDurumus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TumorBolgesi = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    TumorBoyutu = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TNM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Evre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TumorTipi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TumorDurumus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ViralEnfeksiyons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Virus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TestDurumu = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Sonuc = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViralEnfeksiyons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenelBilgilerId = table.Column<int>(type: "int", nullable: false),
                    JinekolojikGecmisId = table.Column<int>(type: "int", nullable: false),
                    OperasyonProseduruId = table.Column<int>(type: "int", nullable: false),
                    PatolojiDurumuId = table.Column<int>(type: "int", nullable: false),
                    TumorDurumuId = table.Column<int>(type: "int", nullable: false),
                    EkislemlerId = table.Column<int>(type: "int", nullable: false),
                    NotlarId = table.Column<int>(type: "int", nullable: false),
                    GenderId = table.Column<int>(type: "int", nullable: false),
                    SosyalYasamOzellikleriId = table.Column<int>(type: "int", nullable: false),
                    SigaraKullanimiId = table.Column<int>(type: "int", nullable: false),
                    AlkolKullanimiId = table.Column<int>(type: "int", nullable: false),
                    MaddeKullanimiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Forms_AlkolKullanimis_AlkolKullanimiId",
                        column: x => x.AlkolKullanimiId,
                        principalTable: "AlkolKullanimis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forms_EkIslemlerMutasyons_EkislemlerId",
                        column: x => x.EkislemlerId,
                        principalTable: "EkIslemlerMutasyons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forms_Genderd_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genderd",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forms_GenelBilgilers_GenelBilgilerId",
                        column: x => x.GenelBilgilerId,
                        principalTable: "GenelBilgilers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forms_jinekolojikGecmiss_JinekolojikGecmisId",
                        column: x => x.JinekolojikGecmisId,
                        principalTable: "jinekolojikGecmiss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forms_MaddeKullanimis_MaddeKullanimiId",
                        column: x => x.MaddeKullanimiId,
                        principalTable: "MaddeKullanimis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forms_Notlars_NotlarId",
                        column: x => x.NotlarId,
                        principalTable: "Notlars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forms_OperasyonProsedurus_OperasyonProseduruId",
                        column: x => x.OperasyonProseduruId,
                        principalTable: "OperasyonProsedurus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forms_PatolojiDurumus_PatolojiDurumuId",
                        column: x => x.PatolojiDurumuId,
                        principalTable: "PatolojiDurumus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forms_SigaraKullanimis_SigaraKullanimiId",
                        column: x => x.SigaraKullanimiId,
                        principalTable: "SigaraKullanimis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forms_SosyalYasamOzellikleris_SosyalYasamOzellikleriId",
                        column: x => x.SosyalYasamOzellikleriId,
                        principalTable: "SosyalYasamOzellikleris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Forms_TumorDurumus_TumorDurumuId",
                        column: x => x.TumorDurumuId,
                        principalTable: "TumorDurumus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GenderId = table.Column<int>(type: "int", nullable: true),
                    FormId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUsers_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUsers_Genderd_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genderd",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FormAileMedikalGecmisis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    AileMedikalGecmisiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormAileMedikalGecmisis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormAileMedikalGecmisis_AileMedikalGecmisis_AileMedikalGecmisiId",
                        column: x => x.AileMedikalGecmisiId,
                        principalTable: "AileMedikalGecmisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormAileMedikalGecmisis_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormDonorMedikalGecmisis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    DonorMedikalGecmisiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormDonorMedikalGecmisis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormDonorMedikalGecmisis_DonorMedikalGecmisis_DonorMedikalGecmisiId",
                        column: x => x.DonorMedikalGecmisiId,
                        principalTable: "DonorMedikalGecmisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormDonorMedikalGecmisis_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormIlacs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    IlacId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormIlacs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormIlacs_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormIlacs_Ilacs_IlacId",
                        column: x => x.IlacId,
                        principalTable: "Ilacs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormImmunhistokimyas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    ImmunhistokimyaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormImmunhistokimyas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormImmunhistokimyas_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormImmunhistokimyas_ImmunhistokimyaTests_ImmunhistokimyaId",
                        column: x => x.ImmunhistokimyaId,
                        principalTable: "ImmunhistokimyaTests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormKanserTedavisis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    KanserTedavisiId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormKanserTedavisis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormKanserTedavisis_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormKanserTedavisis_KanserTedavisis_KanserTedavisiId",
                        column: x => x.KanserTedavisiId,
                        principalTable: "KanserTedavisis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormMetastazDurumus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    MetastazDurumuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormMetastazDurumus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormMetastazDurumus_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormMetastazDurumus_MetasazDurumus_MetastazDurumuId",
                        column: x => x.MetastazDurumuId,
                        principalTable: "MetasazDurumus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormNumuneToplamaBilgileri",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    NumuneToplamaBilgileriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormNumuneToplamaBilgileri", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormNumuneToplamaBilgileri_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormNumuneToplamaBilgileri_NumuneToplamaBilgisi_NumuneToplamaBilgileriId",
                        column: x => x.NumuneToplamaBilgileriId,
                        principalTable: "NumuneToplamaBilgisi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormTanıBilgileris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    TaniBilgileriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormTanıBilgileris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormTanıBilgileris_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormTanıBilgileris_TaniBilgileris_TaniBilgileriId",
                        column: x => x.TaniBilgileriId,
                        principalTable: "TaniBilgileris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FormViralEnfeksiyons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormId = table.Column<int>(type: "int", nullable: false),
                    ViralEnfeksiyonId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormViralEnfeksiyons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormViralEnfeksiyons_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormViralEnfeksiyons_ViralEnfeksiyons_ViralEnfeksiyonId",
                        column: x => x.ViralEnfeksiyonId,
                        principalTable: "ViralEnfeksiyons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    AppRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppRoles_AppRoleId",
                        column: x => x.AppRoleId,
                        principalTable: "AppRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserRoles_AppUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "Definition" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Member" }
                });

            migrationBuilder.InsertData(
                table: "ImmunhistokimyaTests",
                columns: new[] { "Id", "Sonuc", "TestDurumu", "Virus" },
                values: new object[,]
                {
                    { 2, null, null, "ER" },
                    { 3, null, null, "PR" },
                    { 4, null, null, "HER2/NEU" },
                    { 5, null, null, "MLH1" },
                    { 6, null, null, "PMS2" },
                    { 7, null, null, "MSH2" },
                    { 8, null, null, "MSH6" }
                });

            migrationBuilder.InsertData(
                table: "ViralEnfeksiyons",
                columns: new[] { "Id", "Sonuc", "TestDurumu", "Virus" },
                values: new object[,]
                {
                    { 2, null, null, "HIV1/2" },
                    { 3, null, null, "Hepatit A" },
                    { 4, null, null, "Hepatit B" },
                    { 5, null, null, "Hepatit C" },
                    { 6, null, null, "Sifliz" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_AppRoleId_AppUserId",
                table: "AppUserRoles",
                columns: new[] { "AppRoleId", "AppUserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_AppUserId",
                table: "AppUserRoles",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_FormId",
                table: "AppUsers",
                column: "FormId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_GenderId",
                table: "AppUsers",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_FormAileMedikalGecmisis_AileMedikalGecmisiId",
                table: "FormAileMedikalGecmisis",
                column: "AileMedikalGecmisiId");

            migrationBuilder.CreateIndex(
                name: "IX_FormAileMedikalGecmisis_FormId_AileMedikalGecmisiId",
                table: "FormAileMedikalGecmisis",
                columns: new[] { "FormId", "AileMedikalGecmisiId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormDonorMedikalGecmisis_DonorMedikalGecmisiId",
                table: "FormDonorMedikalGecmisis",
                column: "DonorMedikalGecmisiId");

            migrationBuilder.CreateIndex(
                name: "IX_FormDonorMedikalGecmisis_FormId_DonorMedikalGecmisiId",
                table: "FormDonorMedikalGecmisis",
                columns: new[] { "FormId", "DonorMedikalGecmisiId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormIlacs_FormId_IlacId",
                table: "FormIlacs",
                columns: new[] { "FormId", "IlacId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormIlacs_IlacId",
                table: "FormIlacs",
                column: "IlacId");

            migrationBuilder.CreateIndex(
                name: "IX_FormImmunhistokimyas_FormId_ImmunhistokimyaId",
                table: "FormImmunhistokimyas",
                columns: new[] { "FormId", "ImmunhistokimyaId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormImmunhistokimyas_ImmunhistokimyaId",
                table: "FormImmunhistokimyas",
                column: "ImmunhistokimyaId");

            migrationBuilder.CreateIndex(
                name: "IX_FormKanserTedavisis_FormId_KanserTedavisiId",
                table: "FormKanserTedavisis",
                columns: new[] { "FormId", "KanserTedavisiId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormKanserTedavisis_KanserTedavisiId",
                table: "FormKanserTedavisis",
                column: "KanserTedavisiId");

            migrationBuilder.CreateIndex(
                name: "IX_FormMetastazDurumus_FormId_MetastazDurumuId",
                table: "FormMetastazDurumus",
                columns: new[] { "FormId", "MetastazDurumuId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormMetastazDurumus_MetastazDurumuId",
                table: "FormMetastazDurumus",
                column: "MetastazDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_FormNumuneToplamaBilgileri_FormId_NumuneToplamaBilgileriId",
                table: "FormNumuneToplamaBilgileri",
                columns: new[] { "FormId", "NumuneToplamaBilgileriId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormNumuneToplamaBilgileri_NumuneToplamaBilgileriId",
                table: "FormNumuneToplamaBilgileri",
                column: "NumuneToplamaBilgileriId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_AlkolKullanimiId",
                table: "Forms",
                column: "AlkolKullanimiId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_EkislemlerId",
                table: "Forms",
                column: "EkislemlerId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_GenderId",
                table: "Forms",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_GenelBilgilerId",
                table: "Forms",
                column: "GenelBilgilerId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_JinekolojikGecmisId",
                table: "Forms",
                column: "JinekolojikGecmisId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_MaddeKullanimiId",
                table: "Forms",
                column: "MaddeKullanimiId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_NotlarId",
                table: "Forms",
                column: "NotlarId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_OperasyonProseduruId",
                table: "Forms",
                column: "OperasyonProseduruId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_PatolojiDurumuId",
                table: "Forms",
                column: "PatolojiDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_SigaraKullanimiId",
                table: "Forms",
                column: "SigaraKullanimiId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_SosyalYasamOzellikleriId",
                table: "Forms",
                column: "SosyalYasamOzellikleriId");

            migrationBuilder.CreateIndex(
                name: "IX_Forms_TumorDurumuId",
                table: "Forms",
                column: "TumorDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_FormTanıBilgileris_FormId_TaniBilgileriId",
                table: "FormTanıBilgileris",
                columns: new[] { "FormId", "TaniBilgileriId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormTanıBilgileris_TaniBilgileriId",
                table: "FormTanıBilgileris",
                column: "TaniBilgileriId");

            migrationBuilder.CreateIndex(
                name: "IX_FormViralEnfeksiyons_FormId_ViralEnfeksiyonId",
                table: "FormViralEnfeksiyons",
                columns: new[] { "FormId", "ViralEnfeksiyonId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FormViralEnfeksiyons_ViralEnfeksiyonId",
                table: "FormViralEnfeksiyons",
                column: "ViralEnfeksiyonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "FormAileMedikalGecmisis");

            migrationBuilder.DropTable(
                name: "FormDonorMedikalGecmisis");

            migrationBuilder.DropTable(
                name: "FormIlacs");

            migrationBuilder.DropTable(
                name: "FormImmunhistokimyas");

            migrationBuilder.DropTable(
                name: "FormKanserTedavisis");

            migrationBuilder.DropTable(
                name: "FormMetastazDurumus");

            migrationBuilder.DropTable(
                name: "FormNumuneToplamaBilgileri");

            migrationBuilder.DropTable(
                name: "FormTanıBilgileris");

            migrationBuilder.DropTable(
                name: "FormViralEnfeksiyons");

            migrationBuilder.DropTable(
                name: "AppRoles");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "AileMedikalGecmisis");

            migrationBuilder.DropTable(
                name: "DonorMedikalGecmisis");

            migrationBuilder.DropTable(
                name: "Ilacs");

            migrationBuilder.DropTable(
                name: "ImmunhistokimyaTests");

            migrationBuilder.DropTable(
                name: "KanserTedavisis");

            migrationBuilder.DropTable(
                name: "MetasazDurumus");

            migrationBuilder.DropTable(
                name: "NumuneToplamaBilgisi");

            migrationBuilder.DropTable(
                name: "TaniBilgileris");

            migrationBuilder.DropTable(
                name: "ViralEnfeksiyons");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "AlkolKullanimis");

            migrationBuilder.DropTable(
                name: "EkIslemlerMutasyons");

            migrationBuilder.DropTable(
                name: "Genderd");

            migrationBuilder.DropTable(
                name: "GenelBilgilers");

            migrationBuilder.DropTable(
                name: "jinekolojikGecmiss");

            migrationBuilder.DropTable(
                name: "MaddeKullanimis");

            migrationBuilder.DropTable(
                name: "Notlars");

            migrationBuilder.DropTable(
                name: "OperasyonProsedurus");

            migrationBuilder.DropTable(
                name: "PatolojiDurumus");

            migrationBuilder.DropTable(
                name: "SigaraKullanimis");

            migrationBuilder.DropTable(
                name: "SosyalYasamOzellikleris");

            migrationBuilder.DropTable(
                name: "TumorDurumus");
        }
    }
}
