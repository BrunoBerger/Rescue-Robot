# Subsystem

| Subsystem | Beschreibung über\.\.\.                                      |   |
|--------------------|--------------------------------------------------------------|---|
| Objektbergung      | Aktivitätsdiagramm \+ Sequenzdiagramm                        |   |
| Greifen            | Aktivitäts\- und Klassendiagramm ergänzen \+ Sequenzdiagramm |   |
| Signalverfolgung   | Sequenzdiagramm                                              |   |
| Navigation         | Sequenzdiagramm                                              |   |
| Kommunikation      | Aktivitäts-/ Sequenzdiagramm                                 |   |


## Gesprächsprotokoll 22.07.2020
#
### SUBSYSTEM: OBJEKTBERGUNG

Geigerzähler
- Objekterkennung
- Radioaktivität messen
- Objekt einsammeln (Greifen, Box öffnen, in Box legen, Box schließen) -> siehe B)

#
### SUBSYSTEM : GREIFEN 	
(weiteres SUBSYSTEM von OBJEKTBERGUNG)
(Vorschlag als Klassendiagramm mit Attributen und Funktionen, Greifen wurde schon mit Aktivitätsdiagramm beschrieben -> Stützen + Box noch ergänzen)

Greifer
- Startpunkt
- Zielpunkt
- Greifarm ausfahren
- greifen
- Objektgewicht prüfen
	- gewicht ok -> greifen und in Box legen
	- gewicht nok -> Error Message
	
Stützklappe
- ausfahren
- einfahren

Boxklappe
- ausfahren
- einfahren

#
### SUBSYSTEM: Radiosignalverfolgung

Ziel
Radiosignal
- ID-no
- koordinaten
- sendet

Roboter-Standort
- eigene Position erfassen
- Radiosignalverfolgung (4 Antennen)
 - abfragen
 - empfangen
 - verfolgen
 - erreicht
 - erneut abfragen ...
- Standorterkennung (Eckpunkte, Senden von Info -> Sequenzdiagramm)	

#
### SUBSYSTEM: Navigation

Wasserantrieb
- Propeller an 
- Lenkung über Ruder

Kettenantrieb
- Motoren an
- fahren
- lenken
- drehen

Hindernis
- Hindernis erkennen (Wand / Gesteinsbrocken / Wasser)
- steuerung motoren (drehen, li/re fahren)
- Kettensteuerung
- Propellersteuerung

#
### SUBSYSTEM: Kommunikation

Personerkennung
- über kamera

Kommunikation
- sendeNachricht über Lautsprecher
- empfange Nachricht über Mikrofon
