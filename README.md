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

## Oefening 2 : publish naar een nieuw EndPoint

1.	Download de solution ..
a.	Debug de Solution en plaats een order
b.	Door welke handlers wordt de order nu afgehandeld?

2.	We willen nu dat een order na Sales zowel tegelijk naar Billing als naar Shipping wordt gestuurd en afgehandeld
a.	Welk Messaging Concept hoort daar bij?
b.	Welk Messaging Concept wordt nu door Sales gebruikt?
c.	Verander de code zo dat de message door Sales naar Billing en Shipping wordt gestuurd en dit in de Console te zien is.
i.	HINT: De code van Billing En Shipping doen dan (ongeveer?) hetzelfde
ii.	HINT Waar staat in Sales Geconfigureerd dat een message naar Billing wordt verzonden? Is dit nog nodig?

## Oefening 3 Sagas

In de vorige oefening werd een order van sales naar Billing en Shipping tegelijk gestuurd.  Nu willen we dat er pas geshipped word als de orderplaced (van Sales) afgehandeld is en de orderBilled (van Billing) ook. Alleen weten we niet wat de volgorde is waarin deze worden afgehandeld.

1.	Download de Solution
2.	Debug de Solution en verzend een order om te kijken wat er nu gebeurt
3.	Zorg ervoor dat OrderPlaced ook door de class ShipPolicy wordt gehandeld en logged in de Console. Hoe vaak wordt de order succesfully Shipped verzonden?
4.	Nu wordt in ShippingPolicyData Alleen de OrderId bewaard. Dit is de persistent Data die in de Saga mbv Data.OrderId gebruikt kan worden in bijvoorbeeld de methode ProcessOrder. Zorg mbv deze class dat er alleen 1 ShipOrder message wordt verzonden als zowel OrderPlaced en OrderBilled zijn afgehandeld.









