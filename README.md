# EducationalPlatform

Am realizat o aplicatie care gestioneaza o platforma educationala pentru o scoala.
Aplicatia este creata folosind limbajul C#, WPF si SQLServer 2019. Aceasta
este structurata pe modelul MVVM.
Aplicatia are 4 tipuri de utilizatori:
• administratorii aplicatiei,
• profesorii,
• dirigintii
• elevii.
I. Administratorul este cel care se ocupa de introducerea, modificarea si stergerea elevilor,
a profesorilor, a materiilor. Tot el va fi cel care va realiza cuplajele dintre clase, profesor si
materie. 
II. Profesorul poate avea doua roluri: de profesor obisnuit si de diriginte. In calitate de
profesor obisnuit poate avea acces doar la clasele la care preda si la materiile pe care le
preda. Acesta va putea efectua urmatoarele operatii:
a. Vizualizare, adaugare si motivare de absente;
b. Vizualizare, adaugare si anulare de note;
c. Vizualizare, adaugare si stergere de material didactic: lectii si teste
d. Calcularea mediilor
Media nu poate fi incheiata decat daca sunt cel putin 3 note si teza trecute. O nota nu va mai
putea fi anulata dupa ce a fost incheiata media.
III. In plus fata de actiunile profesorului, dirigintele poate efectua urmatoarele operatiuni:
a. Motivare absente pentru elevii la clasa la care este diriginte, indiferent de materie
b. Vizualizare total absente pe clasa + numarul lor
c. Vizualizare absente nemotivate pe clasa + numarul lor
d. Vizualizare totalul absentelor unui elev + numarul lor
e. Vizualizare absente nemotivate ale unui elev + numarul lor
f. Vizualizare medii finale ale unui elev 
g. Vizualizarea ierarhiei pe clasa in functie de medie
h. Vizualizare premianti 
i. Afisare elevi in situatia de exmatriculare datorita absentelor
IV. Elevul are posibilitatea de a vedea:
a. Materialul didactic de la fiecare materie de la clasa lui.
b. Notele de la fiecare materie
c. Absentele de la fiecare materie
d. Mediile de la fiecare materie + media generala 
