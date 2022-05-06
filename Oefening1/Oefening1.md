## Oefening 1: Krijg de basic solution draaiend en kijk hoe het werkt
1. Open de solution oefening1
2. Zorg  voor Multiple Startup projects: ClienUI,Billing en Sales moeten bij debuggen gestart worden
3. Debug de Solution (F5)	
    1. Klik enkele keren op Place another order
    2. Welke message stuurt elk project?
    3. Welke message wordt gehandled door elk project?
    4. Welke Project Dependencies heeft elk project?
    5. Stop Debugging
3.	Recovering from failure: 
    1.	Start de solution zonder Debugging (Ctrl+F5)
    2.	Sluit het Billing Debug Window
    3.	Klik enkele keren op Place another order
    4.	Wat heeft het sluiten van de Billing window voor effect op de Sales Window?
    5.	ReStart Billing door op het rechtermuis klik Billing project Debug > Start new instance. Wat gebeurt er nu?
4.	Transient failures 
    1.	Open PlaceOrderHandler.cs in Sales en uncomment onderstaand stukje code onder region ThrowTransientException
```csharp
// Uncomment to test throwing transient exceptions 
//if (random.Next(0, 5) == 0) 
//{ 
// throw new Exception("Oops"); 
//}
```
   2.	Start de solution zonder Debugging (Ctrl+F5)
   3.	Klik enkele keren op Place another order
   4.	Wat gebeurt er als de exception optreedt?
   5.	Stop de Debugging en comment de eerdere code weer uit
5.	Monitoring tool en exceptions
   1.	Open PlaceOrderHandler.cs in Sales en uncomment onderstaand stukje code onder region ThrowFatalException
```csharp
// Uncomment to test throwing fatal exceptions 
//throw new Exception("BOOM");
```
   2.	Open  Program.cs  In het platform project
   3.	Uncomment
```csharp
static void Main() { 
Console.Title = "Particular Service Platform Launcher"; 
// Particular.PlatformLauncher.Launch(); 
}
```
   4.	Start de solution zonder Debugging (Ctrl+F5)
   5.	Wacht tot de Website ServicePulse is opgestart. Dit is de lokale versie van de monitoring tool
        1.	Welke Endpoints zijn nu actief volgens de tool?
   6.	Plaats nog een order in de clientUI
        1.	Welke soorten retries zie je in de Sales Console?
        2.	Wat gebeurt er in de ServicePulse Failed messages tab?
   7.	Sluit alle consoles / websites.
   8.	Repareer de Eerdere Exceptie en start de solution  weer zonder Debugging (Ctrl+F5)
        1.	Retry de laatste error in de ServicePulse Failed Messages.

