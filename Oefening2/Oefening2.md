## Oefening 2 : Publish naar een nieuw endPoint

In deze oefening behandelen we de Send & Command en Publish en Subscribe patterns

1.	Open de solution oefening2
1.  We kijken nu eerst wat de huidige werking is

    1.  Zorg voor multiple startup projects: ClientUI, Billing en Sales en Shipping moeten bij debuggen gestart worden.
    2.	Debug de Solution en plaats een order
    3.	Door welke handlers wordt de order nu afgehandeld?
    4.	Welk [messaging concept](https://docs.particular.net/nservicebus/concepts/) wordt nu door Sales gebruikt?
3.	We willen nu dat een order na Sales tegelijk naar Billing als naar Shipping wordt gestuurd en afgehandeld
    1.	Welk [messaging concept](https://docs.particular.net/nservicebus/concepts/) hoort daar bij?
    3.	Verander de code zo dat de message door Sales naar Billing en Shipping wordt gestuurd en dit in de Console te zien is.

i.	HINT: De code van Billing en Shipping doen dan (ongeveer?) hetzelfde

ii.	HINT Waar staat in Sales geconfigureerd dat een message naar Billing wordt verzonden? Is dit nog nodig?


### Gists

Send Command & Reply: https://gist.github.com/pir264/1ddd465e94cd54daf1ff754546771b8c

Publish event & subscribe: https://gist.github.com/pir264/d5fc485db380c07303c7f15778f50ecb






