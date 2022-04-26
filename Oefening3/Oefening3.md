## Oefening 3 Sagas

In de vorige oefening werd een order van sales naar Billing en Shipping tegelijk gestuurd.  Nu willen we dat er pas geshipped word als de orderplaced (van Sales) afgehandeld is en de orderBilled (van Billing) ook. Alleen weten we niet wat de volgorde is waarin deze worden afgehandeld.

1.	Download de Solution
2.	Debug de Solution en verzend een order om te kijken wat er nu gebeurt
3.	Zorg ervoor dat OrderPlaced ook door de class ShipPolicy wordt gehandeld en logged in de Console. Hoe vaak wordt de order succesfully Shipped verzonden?
4.	Nu wordt in ShippingPolicyData Alleen de OrderId bewaard. Dit is de persistent Data die in de Saga mbv Data.OrderId gebruikt kan worden in bijvoorbeeld de methode ProcessOrder. Zorg mbv deze class dat er alleen 1 ShipOrder message wordt verzonden als zowel OrderPlaced en OrderBilled zijn afgehandeld.









