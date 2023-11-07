# Lab10---Anropa-databasen
* Skapa ett nytt console-program i C#
* Koppla upp programmet mot northwind databasen
* Skapa en enkel navigation i programmet som gör att användaren kan välja mellan följande funktioner:

**Entity framwork : Consol**

* Hämta alla kunder. Visa företagsnamn, land, region, telefonnummer och antal ordrar de har
*Sortera på företagsnamn. Användaren ska kunna välja stigande eller fallande ordning.
    
* Användaren ska kunna välja en kund i listan. Alla fält (utom IDn) för kunden ska då visas samt en lista på alla ordrar kunden har gjort.
* Lägga till kund. Användaren ska kunna lägga till en kund och fylla i värden för alla kolumner utom IDn. iD behöver ni generera en slumpad sträng för (5 tecken lång). Om användaren inte fyller i ett värde ska ********null******** skickas till databasen, inte en tom sträng.

* Ni ska även skapa en fil med querys i SSMS för följande funktioner:

**SQL : Management Studio (SSMS) (Query-fil)**

* Hämta alla produkter med deras namn, pris och kategori namn. Sortera på kategori namn och sen produkt namn
* Hämta alla kunder och antal ordrar de gjort. Sortera fallande på antal ordrar.
* Hämta alla anställda tillsammans med territorie de har hand om (EmployeeTerritories och Territories tabellerna)
