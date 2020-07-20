# Rescue-Robot
In Fällen wie Naturkatastrophen oder schweren Industrieunfällen ist es meist dringend notwendig, verletzte Personen zu retten oder Gegenstände zu bergen.
Um dabei nicht andere Menschen den Risiken oder Gefahren auszusetzen, ist es sehr hilfreich, Roboter einzusetzen. In diesem Projekt soll ein "Rescue-Robot"
entwickelt werden, der bei einem Industrieunfall wie einer Explosion seinen Einsatz findet. Bei der Explosion wurden auch radioaktive Objekte auf dem Industriegelände verteilt.
Der Rescue-Robot soll sich autonom auf dem Industriegelände bewegen und sich über Radiosignale navigieren. Hindernisse wie Gesteinsbrocken oder Wasser sollen umfahren oder durchquert werden. Verletzte Personen sollen über den Rescue-Robot nach außen kommunizieren können. Zudem sollen auch radioaktive Gegenstände gesichert werden können.

# Produkteinsatz
Die Zielgruppe sind somit nicht nur das Industriegewerbe selbst, sondern auch Rettungsdienste und die direkten Angestellten der Industriefirma.
<img >
![Systemumgebung](Linkzumbild.png "Systemumgebung")
#
### Allgemeines zum Projekt
Die Übersicht über die geplante und getane Arbeit für jede Woche ist mit GitHub-Projects umgesetzt:  
[Project Boards][projects]

Die Allgemeine Übersicht über die gesamten Aufgaben ist auf [Trello][trello] zu finden.

#
### Requirements

| Category           | ID     | Requirement                                                                            |
|--------------------|--------|----------------------------------------------------------------------------------------|
| Fortbewegung       | FR1    | Fahrzeug muss sich an Land fortbewegen können                                          |
|                    | NFR1   | Fortbewegung muss über Ketten laufen                                                   |
|                    | FR2    | Fahrzeug muss sich auf der Wasseroberfläche fortbewegen können                         |
|                    | NFR2   | Fortbewegung muss über zwei Propeller laufen                                           |
| Gegenstände bergen | FR3    | Das Fahrzeug muss Gegenstände greifen können                                           |
|                    | NFR3.1 | Das Fahrzeug muss über einen beweglichen Greifer verfügen                              |
|                    | FR4    | Das Fahrzeug muss über einen verschließbaren Behälter verfügen                         |
|                    | NFR5   | Das Fahrzeug muss über einen offenen Korb verfügen                                     |
| Sensorik           | FR6    | Das Fahrzeug muss Radiosignalen folgen können                                          |
|                    | FR7    | Das Fahrzeug muss erkennen ob es im Wasser ist                                         |
|                    | NFR8   | Das Fahrzeug muss über geeignete Peripherie verfügen  um mit Menschen zu kommunizieren |



[projects]: https://github.com/BrunoBerger/Rescue-Robot/projects
[trello]: https://trello.com/b/mJtKk2EW/rescue-robot
