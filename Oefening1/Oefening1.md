## Oefening 1: Krijg de basic solution draaiend en kijk hoe het werkt
1. Download de solution … van Github en open de solution
2. Debug de Solution (F5)	
a.	Klik enkele keren op Place another order
b.	Welke message stuurt elk project?
c.	Welke message wordt gehandled door elk project?
d.	Welke Project Dependencies heeft elk project?
e.	Welke Transport gebruikt het project?
f.	Stop Debugging
3.	Recovering from failure: 
a.	Start de solution zonder Debugging (Ctrl+F5)
b.	Sluit het Billing Debug Window
c.	Klik enkele keren op Place another order
d.	Wat heeft het sluiten van de Billing window op de Sales Window?
e.	ReStart Billing door op het rechtermuis klik Billing project Debug > Start new instance. Wat gebeurt er nu?
4.	Transient failures 
a.	Open PlaceOrderHandler.cs in Sales en uncomment onderstaand stukje code onder region ThrowTransientException
```csharp
// Uncomment to test throwing transient exceptions 
//if (random.Next(0, 5) == 0) 
//{ 
// throw new Exception("Oops"); 
//}
```
b.	Start de solution zonder Debugging (Ctrl+F5)
c.	Klik enkele keren op Place another order
d.	Wat gebeurt er als de exception optreedt?
e.	Stop de Debugging en comment de eerdere code weer uit
5.	Monitoring tool en exceptions
a.	Open PlaceOrderHandler.cs in Sales en uncomment onderstaand stukje code onder region ThrowFatalException
```csharp
// Uncomment to test throwing fatal exceptions //throw new Exception("BOOM");
```
b.	Open  Program.cs  In het platform project
c.	Uncomment
```csharp
static void Main() { 
Console.Title = "Particular Service Platform Launcher"; 
// Particular.PlatformLauncher.Launch(); 
}
```
d.	Start de solution zonder Debugging (Ctrl+F5)
e.	Wacht tot de Website ServicePulse is opgestart. Dit is de lokale versie van de monitoring tool
i.	Welke Endpoints zijn nu actief volgens de tool?
f.	Plaats nog een order in de clientUI
i.	Welke soorten retries zie je in de Sales Consoles?
ii.	Wat gebeurt er in de ServicePulse Failed messages tab?
g.	Sluit alle consoles / websites.
h.	Repareer de Eerdere Exceptie en start de solution  weer zonder Debugging (Ctrl+F5)
i.	Retry de laatste error in de ServicePulse Failed Messages.

