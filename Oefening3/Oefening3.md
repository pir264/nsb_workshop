## Oefening 3 Sagas

Het doel van deze oefening is kennis te maken met sagas en hoe je data persistentie kan gebruiken.

In oefening 2 werd een order van Sales naar Billing en Shipping tegelijk gestuurd.  Nu willen we dat er pas geshipped word als de orderplaced (van Sales) afgehandeld is **en** de orderBilled (van Billing) ook. We weten echter niet wat de volgorde is waarin deze worden afgehandeld.

1.	Open de solution oefening3
2.	Zorg voor Multiple Startup projects: ClientUI, Billing en Sales en Shipping moeten bij debuggen gestart worden
3.	Debug de Solution en verzend een order om te kijken wat er nu gebeurt
4.	Zorg ervoor dat OrderPlaced ook door de class ShipPolicy wordt gehandeld en deze de methode ProcessOrder aanroept. 
     1.	Hoe vaak wordt de logmessage "Order [{message.OrderId}] Succesfully shipped." verzonden? >>[Antwoord](https://gist.github.com/pir264/7bf1bc6c6e185a03fd9b0c2695d560c8)

Nu wordt in ShippingPolicyData.cs alleen de [OrderId](https://github.com/pir264/nsb_workshop/blob/db103f45522ab4a6e6b98b6c8e96a1460e7b6b12/Oefening3/Shipping/ShippingPolicyData.cs#L7) bewaard. Dit is de persistente data die in de Saga mbv Data.OrderId gebruikt kan worden in bijvoorbeeld de methode ProcessOrder. 

5.	Zorg met een uitbreiding van de Saga state ervoor dat er alleen een ShipOrder message wordt verzonden als zowel OrderPlaced en OrderBilled zijn afgehandeld.

### Gists

Saga https://gist.github.com/pir264/391699798a206c81a3b88180ba098669









