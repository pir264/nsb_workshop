## Oefening 1: Krijg de basic solution draaiend en kijk hoe het werkt

Doel van deze oefening is een algemeen beeld te krijgen van NServicebus en de oefen applicatie

1. Open de solution oefening1
    1. Wat valt je op aan de project dependencies >>[Antwoord](https://gist.github.com/pir264/95d12254138292565e533b5a21ae20bb)
3. Zet de volgende projecten als multiple startup: ClientUI, Billing en Sales
    1. Voor VsCode kies Debug All
4. Debug de solution (F5)	
    1. Klik enkele keren op **Place order**
    2. Welke message stuurt elk project? (Dit wordt in de Console of Client UI getoond) >>[Antwoord](https://gist.github.com/pir264/272403fa1d39d3e8d7186733e12506d8)
    4. Welke message wordt gehandled door elk project? (Dit wordt in de Console getoond) >>[Antwoord](https://gist.github.com/pir264/a626f0b047b8738f3802cfacd864a263)
    5. Stop Debugging
5.	We bekijken nu de feature recovering from failure: Wat gebeurt er als een NServicebus handler tijdelijk niet beschikbaar is
    1.	Start de solution zonder Debugging (Ctrl+F5)
    2.	Sluit het Billing Debug Window
    3.	Klik enkele keren op **Place order**
    4.	Wat heeft het sluiten van de Billing window voor effect op de Sales project? Kan deze nog steeds messages versturen? >>[Antwoord](https://gist.github.com/pir264/fd61981c6cce11aee11ab4b8180dd5fb)
    5.	ReStart Billing door op het rechtermuis klik Billing project Debug > Start new instance. Wat gebeurt er nu? >>[Antwoord](https://gist.github.com/pir264/87b4eebeab382b53c16003f5d84c5c3d)
6.	We bekijken nu de feature retrying temporary exceptions : Wat gebeurt er als een NServicebus handler een andere handler niet kan bereiken
    1.	Start de solution zonder Debugging (Ctrl+F5)
    2.	Klik enkele keren op Create a temporary error, rechts naast de knop staat uitgelegd wat de knop doet
    3.	Wat gebeurt er als de exception optreedt? Dit kun je zien in de Console messages. De foutmelding zelf is niet interessant >> [Antwoord](https://gist.github.com/pir264/3d69335cab6f8a86d3a7c781a66bb2cd)
    4.	Stop de Debugging
7.	We bekijken nu een gedeelte van de monitoring tool van Nservicebus. Voor dit stukje heb je een developer license nodig
    1.	Zorg dat ook het Platform project wordt opgestart bij multiple startup project, deze start de website ServicePulse op. 
        1.	Voor VsCode Kies Debug All + PlatForm
    3.	Start de solution zonder Debugging (Ctrl+F5)
    4.	Wacht tot de website ServicePulse is opgestart. Dit is de lokale versie van de monitoring tool. Dit kan even duren
        1.	Welke Endpoints zijn nu actief volgens de tool?
    5.	Klik op Create a fatal error
        1.	Welke soorten retries zie je in de Sales Console? Deze worden net na de fail error log message getoond
        2.	Wat gebeurt er in de ServicePulse Failed messages tab?
    6.	Sluit alle consoles / websites.
   
