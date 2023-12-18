# Northwind Data Retrieval

## Om uppgiften

Hämta data från Northwind-databasen med både Entity Framework och SQL.

## Vad du ska göra

- [ ] Skapa ett nytt console-program i C#
- [ ] Koppla upp programmet mot Northwind-databasen
- [ ] Skapa en enkel navigation i programmet som gör att användaren kan välja mellan följande funktioner:

### Entity Framework: Console

- [ ] **Hämta alla kunder.**
  - Visa företagsnamn, land, region, telefonnummer och antal ordrar de har gjort.
  - Sortera på företagsnamn. Användaren ska kunna välja stigande eller fallande ordning.
  
- [ ] **Visa detaljer för vald kund.**
  - Användaren ska kunna välja en kund i listan. Alla fält (utom IDn) för kunden ska då visas, samt en lista på alla ordrar kunden har gjort.
  
- [ ] **Lägga till kund.**
  - Användaren ska kunna lägga till en kund och fylla i värden för alla kolumner utom IDn. ID behöver ni generera en slumpad sträng för (5 tecken lång). Om användaren inte fyller i ett värde ska `null` skickas till databasen, inte en tom sträng.

### SQL: Management Studio (SSMS) (Query-fil)

- [ ] **Hämta alla produkter med deras namn, pris och kategori namn.**
  - Sortera på kategorinamn och sedan produktnamn.
  
- [ ] **Hämta alla kunder och antal ordrar de gjort.**
  - Sortera fallande på antal ordrar.
  
- [ ] **Hämta alla anställda tillsammans med territoriet de har hand om.**
  - (EmployeeTerritories och Territories tabellerna)

### Extrautmaningar

- I console, när du listar kunder, skriv ut antal skickade och antal oskickade ordrar (där ShippedDate är null på de senare).
- I SSMS, istället för att skriva ut antal ordrar, skriv ut summan för deras totala ordervärde.
