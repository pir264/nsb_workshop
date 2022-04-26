## Oefening 3 Sagas

In de oefening 2 werd een order van sales naar Billing en Shipping tegelijk gestuurd.  Nu willen we dat er pas geshipped word als de orderplaced (van Sales) afgehandeld is **en** de orderBilled (van Billing) ook. We weten echter niet wat de volgorde is waarin deze worden afgehandeld.

1.	Open de solution oefening3
2.	Zorg voor Multiple Startup projects: ClienUI,Billing en Sales en Shipping moeten bij debuggen gestart worden
3.	Debug de Solution en verzend een order om te kijken wat er nu gebeurt
4.	Zorg ervoor dat OrderPlaced ook door de class ShipPolicy wordt gehandeld en deze de methode ProcessOrder aanroept. Hoe vaak wordt de logmessage "Order [{message.OrderId}] Succesfully shipped." verzonden?
5.	Nu wordt in ShippingPolicyData.cs alleen de OrderId bewaard. Dit is de persistente data die in de Saga mbv Data.OrderId gebruikt kan worden in bijvoorbeeld de methode ProcessOrder. Zorg mbv de persistente data dat er alleen 1 ShipOrder message wordt verzonden als zowel OrderPlaced en OrderBilled zijn afgehandeld.









