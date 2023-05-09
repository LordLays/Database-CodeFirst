using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KlonPKP_CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class KlonPKP : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pasazerowie",
                columns: table => new
                {
                    ID_Pasażera = table.Column<int>(type: "int", nullable: false),
                    Imie = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Nazwisko = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: false),
                    Wiek = table.Column<byte>(type: "tinyint", nullable: false),
                    Ulica = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: false),
                    Nr_Domu = table.Column<short>(type: "smallint", nullable: false),
                    Nr_Mieszkania = table.Column<short>(type: "smallint", nullable: true),
                    Kod_pocztowy = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: false),
                    Miasto = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Kraj = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pasażer__ID_Pasażera", x => x.ID_Pasażera);
                });

            migrationBuilder.CreateTable(
                name: "Przewoznicy",
                columns: table => new
                {
                    Nazwa = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Przewoznik__Nazwa", x => x.Nazwa);
                });

            migrationBuilder.CreateTable(
                name: "Przystanki",
                columns: table => new
                {
                    ID_Przystanku = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Peron = table.Column<int>(type: "int", nullable: false),
                    Tor = table.Column<int>(type: "int", nullable: false),
                    Przyjazd = table.Column<TimeSpan>(type: "time", nullable: false),
                    Odjazd = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Przystanki__ID_Przystanku", x => x.ID_Przystanku);
                });

            migrationBuilder.CreateTable(
                name: "TypWagonu",
                columns: table => new
                {
                    Nazwa = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TypWagonu__Nazwa", x => x.Nazwa);
                });

            migrationBuilder.CreateTable(
                name: "Znizki",
                columns: table => new
                {
                    Nazwa = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    Opis = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Wartosc = table.Column<decimal>(type: "decimal(4,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Znizka__Nazwa", x => x.Nazwa);
                });

            migrationBuilder.CreateTable(
                name: "Pociagi",
                columns: table => new
                {
                    Kod_Pociagu = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    Nazwa = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Kategoria = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Przewoznik = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    PrzewoznikNazwa = table.Column<string>(type: "varchar(30)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Pociag__Kod_Pociagu", x => x.Kod_Pociagu);
                    table.ForeignKey(
                        name: "FK_Pociagi_Przewoznicy_PrzewoznikNazwa",
                        column: x => x.PrzewoznikNazwa,
                        principalTable: "Przewoznicy",
                        principalColumn: "Nazwa");
                });

            migrationBuilder.CreateTable(
                name: "Statusy",
                columns: table => new
                {
                    ID_Statusu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Opóźnienie = table.Column<TimeSpan>(type: "time", nullable: false),
                    Ukonczony = table.Column<bool>(type: "bit", nullable: false),
                    Poprzedni_Przystanek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nastepny_Przystanek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrzystankiID_Przystanku = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Status__ID_Statusu", x => x.ID_Statusu);
                    table.ForeignKey(
                        name: "FK_Statusy_Przystanki_PrzystankiID_Przystanku",
                        column: x => x.PrzystankiID_Przystanku,
                        principalTable: "Przystanki",
                        principalColumn: "ID_Przystanku");
                });

            migrationBuilder.CreateTable(
                name: "Przystanki_Pociagu",
                columns: table => new
                {
                    ID_Przystanku = table.Column<int>(type: "int", nullable: false),
                    Kod_Pociagu = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    Przyjazd = table.Column<TimeSpan>(type: "time", nullable: false),
                    Odjazd = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przystanki_Pociagu", x => new { x.ID_Przystanku, x.Kod_Pociagu });
                    table.ForeignKey(
                        name: "FK_Przystanki_Pociagu_Pociagi_Kod_Pociagu",
                        column: x => x.Kod_Pociagu,
                        principalTable: "Pociagi",
                        principalColumn: "Kod_Pociagu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Przystanki_Pociagu_Przystanki_ID_Przystanku",
                        column: x => x.ID_Przystanku,
                        principalTable: "Przystanki",
                        principalColumn: "ID_Przystanku",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wagony",
                columns: table => new
                {
                    Kod_Wagonu = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    Kod_Pociagu = table.Column<string>(type: "varchar(8)", unicode: false, maxLength: 8, nullable: false),
                    Typ_Wagonu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Nr_Wagonu = table.Column<int>(type: "int", nullable: false),
                    Ilosc_Miejsc = table.Column<int>(type: "int", nullable: false),
                    Pociag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypWagonu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PociagKod_Pociagu = table.Column<string>(type: "varchar(8)", nullable: true),
                    TypWagonuNazwa = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Wagon__Kod_Wagonu", x => x.Kod_Wagonu);
                    table.ForeignKey(
                        name: "FK_Wagony_Pociagi_PociagKod_Pociagu",
                        column: x => x.PociagKod_Pociagu,
                        principalTable: "Pociagi",
                        principalColumn: "Kod_Pociagu");
                    table.ForeignKey(
                        name: "FK_Wagony_TypWagonu_TypWagonuNazwa",
                        column: x => x.TypWagonuNazwa,
                        principalTable: "TypWagonu",
                        principalColumn: "Nazwa");
                });

            migrationBuilder.CreateTable(
                name: "Kursy",
                columns: table => new
                {
                    ID_Kursu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pociag = table.Column<int>(type: "int", unicode: false, maxLength: 8, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Czas_Podrozy = table.Column<TimeSpan>(type: "time", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusID_Statusu = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Kurs__ID_Kursu", x => x.ID_Kursu);
                    table.ForeignKey(
                        name: "FK_Kursy_Statusy_StatusID_Statusu",
                        column: x => x.StatusID_Statusu,
                        principalTable: "Statusy",
                        principalColumn: "ID_Statusu");
                });

            migrationBuilder.CreateTable(
                name: "Bilety",
                columns: table => new
                {
                    Nr_Biletu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pasazer = table.Column<int>(type: "int", nullable: false),
                    Kurs = table.Column<int>(type: "int", nullable: false),
                    Data_zakupu = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_podrozy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Czas_podrozy = table.Column<TimeSpan>(type: "time", nullable: false),
                    Typ_Wagonu = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Wagon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miejsce = table.Column<int>(type: "int", nullable: false),
                    Stacja_Poczatkowa = table.Column<int>(type: "int", nullable: false),
                    Stacja_Koncowa = table.Column<int>(type: "int", nullable: false),
                    Sprawdzony = table.Column<bool>(type: "bit", nullable: false),
                    Znizka = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: false),
                    Naleznosc = table.Column<int>(type: "int", nullable: false),
                    KursID_Kursu = table.Column<int>(type: "int", nullable: true),
                    PasazerID_Pasazera = table.Column<int>(type: "int", nullable: true),
                    PrzystankiID_Przystanku = table.Column<int>(type: "int", nullable: true),
                    WagonKod_Wagonu = table.Column<string>(type: "varchar(8)", nullable: true),
                    ZnizkaNazwa = table.Column<string>(type: "varchar(40)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Bilet__Nr_Biletu", x => x.Nr_Biletu);
                    table.ForeignKey(
                        name: "FK_Bilety_Kursy_KursID_Kursu",
                        column: x => x.KursID_Kursu,
                        principalTable: "Kursy",
                        principalColumn: "ID_Kursu");
                    table.ForeignKey(
                        name: "FK_Bilety_Pasazerowie_PasazerID_Pasazera",
                        column: x => x.PasazerID_Pasazera,
                        principalTable: "Pasazerowie",
                        principalColumn: "ID_Pasażera");
                    table.ForeignKey(
                        name: "FK_Bilety_Przystanki_PrzystankiID_Przystanku",
                        column: x => x.PrzystankiID_Przystanku,
                        principalTable: "Przystanki",
                        principalColumn: "ID_Przystanku");
                    table.ForeignKey(
                        name: "FK_Bilety_Wagony_WagonKod_Wagonu",
                        column: x => x.WagonKod_Wagonu,
                        principalTable: "Wagony",
                        principalColumn: "Kod_Wagonu");
                    table.ForeignKey(
                        name: "FK_Bilety_Znizki_ZnizkaNazwa",
                        column: x => x.ZnizkaNazwa,
                        principalTable: "Znizki",
                        principalColumn: "Nazwa");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilety_KursID_Kursu",
                table: "Bilety",
                column: "KursID_Kursu");

            migrationBuilder.CreateIndex(
                name: "IX_Bilety_PasazerID_Pasazera",
                table: "Bilety",
                column: "PasazerID_Pasazera");

            migrationBuilder.CreateIndex(
                name: "IX_Bilety_PrzystankiID_Przystanku",
                table: "Bilety",
                column: "PrzystankiID_Przystanku");

            migrationBuilder.CreateIndex(
                name: "IX_Bilety_WagonKod_Wagonu",
                table: "Bilety",
                column: "WagonKod_Wagonu");

            migrationBuilder.CreateIndex(
                name: "IX_Bilety_ZnizkaNazwa",
                table: "Bilety",
                column: "ZnizkaNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_Kursy_StatusID_Statusu",
                table: "Kursy",
                column: "StatusID_Statusu");

            migrationBuilder.CreateIndex(
                name: "IX_Pociagi_PrzewoznikNazwa",
                table: "Pociagi",
                column: "PrzewoznikNazwa");

            migrationBuilder.CreateIndex(
                name: "IX_Przystanki_Pociagu_Kod_Pociagu",
                table: "Przystanki_Pociagu",
                column: "Kod_Pociagu");

            migrationBuilder.CreateIndex(
                name: "IX_Statusy_PrzystankiID_Przystanku",
                table: "Statusy",
                column: "PrzystankiID_Przystanku");

            migrationBuilder.CreateIndex(
                name: "IX_Wagony_PociagKod_Pociagu",
                table: "Wagony",
                column: "PociagKod_Pociagu");

            migrationBuilder.CreateIndex(
                name: "IX_Wagony_TypWagonuNazwa",
                table: "Wagony",
                column: "TypWagonuNazwa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilety");

            migrationBuilder.DropTable(
                name: "Przystanki_Pociagu");

            migrationBuilder.DropTable(
                name: "Kursy");

            migrationBuilder.DropTable(
                name: "Pasazerowie");

            migrationBuilder.DropTable(
                name: "Wagony");

            migrationBuilder.DropTable(
                name: "Znizki");

            migrationBuilder.DropTable(
                name: "Statusy");

            migrationBuilder.DropTable(
                name: "Pociagi");

            migrationBuilder.DropTable(
                name: "TypWagonu");

            migrationBuilder.DropTable(
                name: "Przystanki");

            migrationBuilder.DropTable(
                name: "Przewoznicy");
        }
    }
}
