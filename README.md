# CarRentSystem

## **Quality Gate**

[![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=EricLue_CarRentSystem&metric=ncloc)](https://sonarcloud.io/dashboard?id=EricLue_CarRentSystem)

[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=EricLue_CarRentSystem&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=EricLue_CarRentSystem)

[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=EricLue_CarRentSystem&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=EricLue_CarRentSystem)

[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=EricLue_CarRentSystem&metric=security_rating)](https://sonarcloud.io/dashboard?id=EricLue_CarRentSystem)

[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=EricLue_CarRentSystem&metric=bugs)](https://sonarcloud.io/dashboard?id=EricLue_CarRentSystem)

[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=EricLue_CarRentSystem&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=EricLue_CarRentSystem)



Testat Software_Architektur_und_Design

4.1.1 Context

4.1.2 Containers

4.1.3 Components

4.1.4 Classes



4.2 Big Picture





5.1 Domain Model

![DomainModel](C:\Users\ericm\Documents\10_Studium\4_SEM\SOFT_ARCHITEKTUR_DESIGN\Testat\mkdocs\docs\DomainModel.jpg)



5.1 Use Cases

| ROLE           | GOAL                                                         | REASON                                                       |
| :------------- | ------------------------------------------------------------ | ------------------------------------------------------------ |
| Sachbearbeiter | Kunde mit Name und Adresse erfassen/löschen/bearbeiten       | Kundendaten können effizient erstellt bearbeitet und genutzt werden |
| Sachbearbeiter | Kunde anhand Namen und Kundennummer suchen                   | Schnelles darstellen der Kundendaten im Falle von Nachfragen |
| Sachbearbeiter | Autos verwalten und suchen                                   | Bestand der Autos ist stetig aktuell                         |
| Sachbearbeiter | Autos einer bestimmten Klasse, Marke und Typ zuordnen        | Eindeutige Identifikation der Autos gewährleisten            |
| Sachbearbeiter | Tagesgebühr pro Auto festlegen                               | Transparenz gegenüber dem Kunden gewährleisten und auf aktuelle Nachfrage reagieren |
| Kunde          | Kunde kann Reservation tätigen, indem bestimmte Klasse ausgewählt und Start- sowie Enddatum gesetzt wird | Gesamtkosten können errechnet und Reservationsnummer festgelegt werden |
| Kunde          | Kunde holt Auto ab                                           | Reservation wird in gültigen Mietvertrag umgewandelt         |