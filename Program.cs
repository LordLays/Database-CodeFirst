namespace KlonPKP_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*CREATE DATABASE SOOKK;
             CREATE TABLE Pasażer (
              ID_Pasażera INT NOT NULL PRIMARY KEY,
              Imie NVARCHAR(50) NOT NULL,
              Nazwisko NVARCHAR(50) NOT NULL,
              Email NVARCHAR(80) NOT NULL,
              Wiek TINYINT NOT NULL,
              Ulica NVARCHAR(60) NOT NULL,
              Nr_Domu SMALLINT NOT NULL,
              Nr_Mieszkania SMALLINT,
              Kod_pocztowy NVARCHAR(11) NOT NULL,
              Miasto NVARCHAR(30) NOT NULL,
              Kraj NVARCHAR(40) NOT NULL
            );

            --Zniżka
            CREATE TABLE Zniżka (
              Nazwa NVARCHAR(40) NOT NULL PRIMARY KEY,
              Opis NVARCHAR(255),
              Wartość DECIMAL(4,2) NOT NULL
            );

            --Typ_Wagonu
            CREATE TABLE Typ_Wagonu (
              Nazwa nvarchar(50) NOT NULL PRIMARY KEY,
              Cena decimal(5,2) NOT NULL
            );

            --Kategoria_Pociagu
            CREATE TABLE Kategoria_Pociagu (
              Nazwa nvarchar(30) NOT NULL PRIMARY KEY
            );

            --Przewoznik
            CREATE TABLE Przewoznik (
              Nazwa nvarchar(30) NOT NULL PRIMARY KEY
            );

            --Pociag
            CREATE TABLE Pociag (
              Kod_Pociagu nvarchar(8) NOT NULL PRIMARY KEY,
              Nazwa nvarchar(30) NOT NULL,
              Kategoria nvarchar(30) NOT NULL REFERENCES Kategoria_Pociagu(Nazwa) ON UPDATE CASCADE,
              Przewoznik nvarchar(30) NOT NULL REFERENCES Przewoznik(Nazwa) ON UPDATE CASCADE
            );

            --Wagon
            CREATE TABLE Wagon (
              Kod_Wagonu nvarchar(8) NOT NULL PRIMARY KEY,
              Kod_Pociagu nvarchar(8) NOT NULL REFERENCES Pociag(Kod_Pociagu) ON UPDATE CASCADE,
              Typ_Wagonu nvarchar(50) NOT NULL REFERENCES Typ_Wagonu(Nazwa) ON UPDATE CASCADE,
              Nr_Wagonu int NOT NULL UNIQUE,
              Ilosc_Miejsc int NOT NULL
            );

            --Przystanki
            CREATE TABLE Przystanki (
              ID_Przystanku INT NOT NULL PRIMARY KEY,
              Nazwa NVARCHAR(30) NOT NULL,
              Peron TINYINT NOT NULL,
              Tor TINYINT NOT NULL,
              Przyjazd TIME NOT NULL,
              Odjazd TIME NOT NULL
            );

            --Przystanki_Pociagu
            CREATE TABLE Przystanki_Pociagu (
              ID_Przystanku int NOT NULL REFERENCES Przystanki(ID_Przystanku),
              Kod_Pociagu nvarchar(8) NOT NULL REFERENCES Pociag(Kod_Pociagu),
              CONSTRAINT PK_Przystanki_Pociagu PRIMARY KEY (ID_Przystanku, Kod_Pociagu),
              Przyjazd time NOT NULL,
              Odjazd time NOT NULL
            );

            --Status
            CREATE TABLE Status (
              ID_Statusu int NOT NULL PRIMARY KEY,
              Poprzedni_Przystanek int NOT NULL REFERENCES Przystanki(ID_Przystanku) ON UPDATE CASCADE,
              Nastepny_Przystanek int NOT NULL REFERENCES Przystanki(ID_Przystanku),
              Opóźnienie time NOT NULL,
              Ukonczony bit NOT NULL
            );

            --Kurs
            CREATE TABLE Kurs (
              ID_Kursu INT NOT NULL PRIMARY KEY,
              Pociąg NVARCHAR(8) NOT NULL REFERENCES Pociag(Kod_Pociagu) ON UPDATE CASCADE,
              [Status] INT NOT NULL REFERENCES Status(ID_Statusu) ON UPDATE CASCADE,
              Czas_Podróży TIME NOT NULL,
              [Data] DATETIME NOT NULL
            );

            --Bilety
            CREATE TABLE Bilety (
              Nr_Biletu INT NOT NULL PRIMARY KEY,
              Pasażer INT NOT NULL REFERENCES Pasażer(ID_Pasażera),
              Kurs INT NOT NULL REFERENCES Kurs(ID_Kursu),
              Data_zakupu DATETIME NOT NULL,
              Data_podróży DATETIME NOT NULL,
              Czas_podróży TIME NOT NULL,
              Typ_Wagonu NVARCHAR(50) NOT NULL REFERENCES Typ_Wagonu(Nazwa) ON UPDATE CASCADE,
              Nr_Wagon INT NOT NULL REFERENCES Wagon(Nr_Wagonu),
              Miejsce TINYINT NOT NULL UNIQUE,
              Stacja_Początkowa INT NOT NULL REFERENCES Przystanki(ID_Przystanku),
              Stacja_Końcowa INT NOT NULL REFERENCES Przystanki(ID_Przystanku)  ON UPDATE CASCADE,
              Sprawdzony BIT NOT NULL,
              Zniżka NVARCHAR(40) NOT NULL REFERENCES Zniżka(Nazwa),
              Należność DECIMAL(6,2) NOT NULL
            ); Tranfsorm to database code first*/

            
            Console.WriteLine();

        }
    }
}