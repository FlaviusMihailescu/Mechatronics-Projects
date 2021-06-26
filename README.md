# BMS - Project

S-a realizat un sistem de tip interfon.
Pe partea de emdedded avem:
-interfata cu utilizatorul formată din tastatură și interfon
-sistemul de acționare al ușii automate dormat din motor DC, driver controlabil cu semnal PWM și butoane de tip push
-senzor de prezență în vederea închiderii în siguranță a ușii

Pe partea de Mobile avem:
-o aplicație implementată în Xamarin Android (limbaj C#) care permite controlul de la distanță a căii de acces în clădire
-de asemenea avem și un istoric al apelurilor 
-pentru conectare la aplicație avem un sistem de autentificare prin metoda 2FA (2 Factory Autentication) care conferă un plus de siguranță utilizatorilor
-tot aici există și funcționalitatea prin care userii își pot modifica parola pentru apartamentul personal, de asemenea în siguranță, prin metoda 2FA.

Pentru comunicare s-a folosit serviciul dedicat al bazei de date Firebase numit RealtimeDatabase, pentru a realiza o comunicare în timp real între partea de embedded a acestui proiect și aplicația Mobile.

Modul de funcționare a acestui proiect:
Un utilizator vine la interfon, tastează parola de la un anumit apartament (afisaj în timp real pe LCD). 
În funcție de răspunsul primit de la apartament (din buton sau din aplicația mobile), va primi un răspuns pe LCD, 
iar ușa se va deschide sau nu. Apelul este salvat în istoricul aplicației mobile la secțiunea "History". 
