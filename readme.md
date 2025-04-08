# PingPong

## Projekt Beschreibung

PingPog ist ein Zwei-Spieler-Spiel, bei dem man gegen einen Freund eine Runde virtuelles PingPong spielen kann. Es gibt einen Ball und zwei Spielfiguren (Schläger), die jeweils von einem Spieler gesteuert werden. Die Spieler können ihre Schläger vertikal, also nach oben und unten, bewegen und müssen verhindern, dass der Ball hinter ihnen gegen die Wand prallt.

Ein Punkt wird erzielt, wenn der Ball die Wand hinter dem gegnerischen Spieler berührt. Um das Spiel spannender zu gestalten, erhöht sich die Geschwindigkeit des Balls nach einigen Sekunden, wodurch die Herausforderung steigt.

## Controls:

Player 1(links):
- up = w
- down = s
  
Player 2(rechts):
- up = Pfeiltaste oben
- down = Pfeiltaste unten

## 16.1 2024

- [x] Spieler erstellen
- [x] Ball erstellen
- [x] Spieler zum Bewegen bringen (nur Y Achse)
- [x] Ball Bewegung 


| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| -------------- | -------------------- | -------------- | -------------- | -------- |
| 1              |    Spiel läuft       |    nichts      | Spielfigur erstellen |    ja      |
| 2              |    Spiel läuft       |    nichts      | Ball erstellen |     ja     |
| 3 | Spiel läuft | Pfeil nach oben/unten / w/s geklickt | Spieler bewegt sich  |  ja  |
| 4              |    Ball berührt Spieler/ Wand       |  nichts        | Ball prallt ab               |     ja     |

Heute am 16.01 habe ich sehr viel programmiert. Ich habe angefangen die Spielobjekte einzufügen und begann sie zu programmieren, jedoch hat das nicht so gut geklappt. Danach habe ich mich im Internet informiert und habe über den Timer erfahren, der das Erstellen von Spiele einfacher macht und habe somit den Spieler zum Bewegen gebracht. Das war der leichte teil den das Abprallen vom Ball hat mich die meiste Zeit gekostet jedoch klappt es jetzt.


## 23.1.2024

- [ ] Startmenü erstellen
- [x] Punkte System GUI erstellen
- [x] Punktesystem programmieren
- [ ] Verschiedene Modus einfügen

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 5               |   Programm wird gestartet |     nichts        |    Hauptmenü            |     -     |
| 6               |   Spiel gestartet         |     nichts        |    Punkte GUI auf screen            |    ja      |
| 7 | Treffer erzielt | nicht | GUI Zahl wird updated | ja |
| 8               | Programm gestartet | nicht  |  Auswahl mit verschiedenen Modus              |      -    |

Heute am 23.01 habe ich meine App mit ein wenig GUI verbessert. Als Erstes habe ich einen Punktezähler gemacht und habe es auch codiert. Danach wollte ich einen Menu machen, hab den Design fertiggestellt und habe die einzelnen Buttons programmiert. Jedoch hat es nicht geklappt, weil sobald ich das Spiel gestartet habe, konnte ich die Spieler nicht mehr bewegen. Den Rest der Zeit habe ich genutzt, um den Fehler zu beheben und den GUI zu funktionieren zu bringen, aber mein Versuch ist gescheitert und ich habe mich entschlossen den Menu auszulassen und habe jetzt einfach einen Punktezähler für mein Spiel. Deshalb bin ich nicht sehr zufrieden mit dem, was ich heute erreicht habe.

## 30.1.2024

Heute am 23.01 habe ich meinen code ein wenig überarbeitet, da es nicht wirklich schön formuliert war und damit es einfacher zu lesen und verstehen ist. Danach habe ich meinen GitHub Account ein wenig überarbeitet, damit es einen guten Eindruck hinterlässt, wenn man es ansieht. Ich habe einen passenden Bio geschrieben und habe mein Profilbild gewechselt, so, dass es professioneller aussieh

## Reflexion

In dieser kurzen aber effektiven LP3 habe ich meinen Projekt, Pingpong Spiel, fertiggestellt. Am Anfang habe ich neue Sachen gelernt über WinForms, nämlich den Timer den man benutzen kann wie FPS, um die Spielobjekte gut zu bewegen. Danach ging es auch schon zum Coden, was mir dieses Mal viel Spass gemacht hat. Ich habe zuerst die einzelnen Spieler zum Bewegen gebracht, mit den Tasten, Pfeil nach oben, Pfeil nach unten, W und S. Doch das war das Leichte. Denn nun musste ich den Ball zum Bewegen bringen, welches ziemlich schwer wahr. Ich habe zuerst gemacht das der Ball einen random Start hat, also es bewegt sich zufällig nach oben links, unten rechts usw. Danach musste ich den bouncen machen, was mir an diesem Projekt am schwersten fiel. Für diese Logik habe ich fast die Hälfte des ersten Tages verbraucht. Nach dem endlich mein Spiel funktionierte, habe ich GUI hinzugefügt, doch leider hat das meinem Spiel neue Bugs gebracht und ich habe nicht herausgefunden, woran das lag. Damit zumindest mein Spiel funktioniert, habe ich den GUI danach entfernt und habe einfach einen Punktezähler hineingemacht. Zu meinem Verbesserungsvorschlag finde ich, dass ich mich jetzt ziemlich gut verbessert habe und ich denke, ich werde auch weiterhin konzentrierter arbeiten
