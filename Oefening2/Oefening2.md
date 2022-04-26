## Oefening 2 : publish naar een nieuw EndPoint

1.	Open de solution oefening2
2.	Zorg voor Multiple Startup projects: ClienUI,Billing en Sales en Shipping moeten bij debuggen gestart worden
    1.	Debug de Solution en plaats een order
    2.	Door welke handlers wordt de order nu afgehandeld?
3.	We willen nu dat een order na Sales zowel tegelijk naar Billing als naar Shipping wordt gestuurd en afgehandeld
    1.	Welk Messaging Concept hoort daar bij?
    2.	Welk Messaging Concept wordt nu door Sales gebruikt?
    3.	Verander de code zo dat de message door Sales naar Billing en Shipping wordt gestuurd en dit in de Console te zien is.

i.	HINT: De code van Billing En Shipping doen dan (ongeveer?) hetzelfde

ii.	HINT Waar staat in Salesg geconfigureerd dat een message naar Billing wordt verzonden? Is dit nog nodig?






