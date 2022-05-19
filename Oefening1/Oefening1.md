## Oefening 1: Krijg de basic solution draaiend en kijk hoe het werkt
1. Open de solution oefening1
2. Zet de volgende Startup projects: ClientUI, Billing en Sales
3. Debug de solution (F5)	
    1. Klik enkele keren op Place another order
    2. Welke message stuurt elk project?
    3. Welke message wordt gehandled door elk project?
    4. Welke Project Dependencies heeft elk project?
    5. Stop Debugging
3.	Recovering from failure: 
    1.	Start de solution zonder Debugging (Ctrl+F5)
    2.	Sluit het Billing Debug Window
    3.	Klik enkele keren op Place order
    4.	Wat heeft het sluiten van de Billing window voor effect op de Sales Window?
    5.	ReStart Billing door op het rechtermuis klik Billing project Debug > Start new instance. Wat gebeurt er nu?
4.	Retrying temporary exceprion
    1.	Start de solution zonder Debugging (Ctrl+F5)
    2.	Klik enkele keren op Create a temporary error
    3.	Wat gebeurt er als de exception optreedt?
    4.	Stop de Debugging
5.	Monitoring tool en exceptions
    1.	Zorg dat ook het Platform project wordt opgestart bij multiple startup project, deze start de website ServicePulse op
    2.	Start de solution zonder Debugging (Ctrl+F5)
    3.	Wacht tot de Website ServicePulse is opgestart. Dit is de lokale versie van de monitoring tool
        1.	Welke Endpoints zijn nu actief volgens de tool?
    4.	Klik op Create a fatal error
        1.	Welke soorten retries zie je in de Sales Console?
        2.	Wat gebeurt er in de ServicePulse Failed messages tab?
    5.	Sluit alle consoles / websites.
   
