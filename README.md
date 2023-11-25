# [emulair.com]()

## Details
Emulair is a front-end for Libretro cores, which now includes a web version! For more information about the project (such as how the code functions, why the project exists, who worked on it, etc.), check the [Wiki page](https://github.com/Emulair/Emulair-Web/wiki). To see our backlog, check the [Projects page](https://github.com/orgs/Emulair/projects/2).

## Philosophy
The web version of Emulair is a website created for users and developers so they can keep up with important news about our projects, find tutorials for how to use Emulair, read relevant documentation for how to contribute code and, in the future, run lightweight versions of some popular emulators directly from their web browsers.

## Product Vision
Dorim să dezvoltăm o platformă web captivantă și interactivă care să servească ca o prezentare extinsă pentru aplicația noastră mobilă, un emulator de jocuri pe telefon. Scopul nostru este să oferim o experiență unică utilizatorilor noștri, să promovăm interacțiunea și să facilităm prezentarea și explorarea funcționalităților aplicației noastre mobile. Prin intermediul acestei platforme web, dorim să evidențiem caracteristicile cheie, să oferim un spațiu pentru feedback și să încurajăm comunitatea să împărtășească experiențele lor.

## Product features and functionalities 
Autentificare:
  - Autentificare cu diferite niveluri de acces pentru Admin, Useri și Writere.
Sectiune de News + Review-uri:
  - Pagină dedicată pentru știri și recenzii de jocuri.
  - Sistem de rating și comentarii pentru recenzii.
  - Recomandări personalizate bazate pe preferințele utilizatorilor verificati.
Conexiune cu Baza de Date de pe Mobile:
  - Sincronizare a progresului și a datelor între aplicația web și aplicația mobilă.
  - Acces la profilul personal și la setările de pe aplicația mobilă.
Highlights:
  - Pagină distinctă pentru evidențierea caracteristicilor cheie ale aplicației mobile.
  - Imagini și videoclipuri interactive care prezintă interfața și funcționalitățile aplicației.
Pagina de Prezentare:
  - Design grafic captivant și animații interactive.
  - Detalii tehnice și inovații aduse de aplicația mobilă.
Profile Page:
  - Personalizare avansată a profilului utilizatorului.
  - Încărcare de imagini și detalii despre experiența în utilizarea aplicației mobile.
Stats Page:
  - Statistici detaliate despre activitatea utilizatorului, cum ar fi orele petrecute, jocurile preferate etc.
  - Grafice și diagrame pentru a vizualiza progresul în timp.
Emulator Calculator (Opțional):
  - Emulator de jocuri pe calculator pentru a testa funcționalitățile aplicației fără a descărca pe dispozitivul mobil.
Forum Comunitar:
  - Platformă de discuții pentru utilizatori pentru a împărtăși experiențe, sfaturi și povești de succes.
  - Moderare comunitară și sistem de notificări pentru discuții relevante.
Evenimente Live:
  - Transmisiuni video live pentru evenimente legate de jocuri sau prezentări ale caracteristicilor noi.
  - Calendar de evenimente cu notificări pentru utilizatori.
Sistem de Recompense:
  - Acordarea de recompense și insigne pentru realizări notabile în utilizarea aplicației.
  - Tablou de onoare pentru cei mai activi utilizatori.
Secțiune de Întrebări Frecvente (FAQ):
  - Pagină cu întrebări frecvente și răspunsuri utile pentru utilizatori.
  - Posibilitatea pentru utilizatori de a adăuga întrebări noi.

## Non functional-requirements
Performanță:
  - Timpul de încărcare ar trebui să fie rapid pentru a asigura o experiență plăcută utilizatorilor.
  - Serverul ar trebui să ofere un timp de răspuns optim pentru a menține interacțiunea fluentă.
Disponibilitate și Fiabilitate:
  - Vrem să asigurăm o disponibilitate înaltă pentru a minimaliza timpul de nefuncționare.
  - Implementarea unor mecanisme robuste pentru gestionarea erorilor și recuperarea rapidă este esențială.
Securitate:
  - Trebuie să implementăm un sistem sigur de autentificare și autorizare pentru a proteja datele și funcționalitățile critice.
  - Asigurarea protecției împotriva unor amenințări precum SQL injection și cross-site scripting este crucială.
Ușurință în Utilizare:
  - Interfața trebuie să fie intuitivă și ușor de folosit pentru a oferi o experiență plăcută utilizatorilor.
  - Vom furniza o documentație clară și comprehensivă pentru a ajuta utilizatorii să exploreze și să înțeleagă funcționalitățile aplicației.
Performanță Tehnică:
  - Codul sursă trebuie să fie eficient și optimizat pentru a minimiza utilizarea resurselor serverului.
  - Implementarea unor instrumente eficiente pentru monitorizarea performanței va contribui la identificarea rapidă a eventualelor probleme.
Compatibilitate și Portabilitate:
  - Aplicația web trebuie să fie compatibilă cu cele mai recente versiuni ale principalelor browsere web.
  - Asigurarea accesibilitatii de pe diferite dispozitive, inclusiv desktop și dispozitive mobile.
Mentenabilitate și Extensibilitate:
  - Implementarea unei arhitecturi modulare va facilita extinderea și mentenanța ulterioară a sistemului.
  - Furnizarea uneltelor eficiente de debug va simplifica procesul de identificare și remediere a problemelor.
Securitatea Datelor:
  - Asigurarea criptarii datelor transferate între aplicația web și baza de date pentru a proteja confidențialitatea informațiilor utilizatorilor.
Performanță a Bazelor de Date:
  - Optimizarea interogărilor către baza de date va asigura o performanță eficientă.
  - Implementarea unor strategii eficiente pentru gestionarea creșterii volumului de date este necesară.

## Customer journey 
User journey map 
Descoperire:
  - Utilizatorul descoperă aplicația web prin intermediul motoarelor de căutare sau a recomandărilor.
  - Caută informații despre caracteristicile aplicației mobile și avantajele emulatorului de jocuri.
Înregistrare și Autentificare:
  - Utilizatorul decide să se înregistreze pentru a beneficia de funcționalitățile complete.
  - Completează formularul de înregistrare și se autentifică.
Explorarea Highlights și Pagina de Prezentare:
  - Utilizatorul navighează prin secțiunile de Highlights pentru a descoperi caracteristicile cheie ale aplicației mobile.
  - Accesează pagina de prezentare pentru a înțelege mai bine aspectele tehnice și inovațiile aduse.
Sectiune de News + Review-uri:
  - Utilizatorul parcurge știrile și review-urile pentru a afla noutăți despre jocuri și experiențe ale altor utilizatori.
  - Lasă propriile review-uri și acordă rating-uri pentru jocurile testate.
Profile și Stats Page:
  - Utilizatorul vizitează propria pagină de profil pentru a personaliza detaliile și încărca imagini.
  - Explorează Stats Page pentru a vedea statistici detaliate despre activitatea sa în aplicație.
Conexiune cu Baza de Date de pe Mobile:
  - Utilizatorul sincronizează datele și progresul său între aplicația web și aplicația mobilă.
  - Accesează jocurile preferate direct de pe dispozitivul mobil.
Forum Comunitar și Evenimente Live:
  - Participă la discuții pe Forumul Comunitar, împărtășind experiențe și primind sfaturi de la alți utilizatori.
  - Participă la evenimente live pentru a urmări prezentări și transmisiuni video despre jocuri.
Logout:
  - Utilizatorul se deconectează și încheie sesiunea.

Alexandra "Gamer Passionat"
  - Demografie:
    - Vârstă: 25 ani
    - Gen: Feminin
    - Ocupație: Studentă
  - Comportament:
    - Joacă jocuri video în timpul liber și este pasionată de ultimele lansări.
    - Își dorește să împărtășească experiențele sale și să afle noutăți despre jocuri.
    - Apreciată de comunitatea de gameri.
  - Obiective:
    - Să descopere jocuri noi și să le testeze înainte de a le descărca.
    - Să interacționeze cu alți gameri și să primească recomandări personalizate.
Andrei "Tech Enthusiast"
  - Demografie:
    - Vârstă: 30 ani
    - Gen: Masculin
    - Ocupație: Dezvoltator Software
  - Comportament:
    - Interesat de tehnologie și inovații în domeniul jocurilor.
    - Caută informații tehnice detaliate și vrea să înțeleagă funcționalitățile sub aspectul programării.
    - Participă la evenimente live și urmărește prezentările despre tehnologie.
  - Obiective:
    - Să afle detalii tehnice despre emulator și funcționalitățile sale.
    - Să ofere feedback privind performanța și să contribuie la comunitatea de dezvoltatori.

## Activity diagram

## User stories
Autentificare și Înregistrare:
  - Ca un vizitator, vreau să pot să mă înregistrez pentru a crea un cont în aplicație.
  - Ca un utilizator înregistrat, vreau să pot să mă autentific cu adresa mea de e-mail și parola.
  - Ca un utilizator, vreau să primesc un mesaj de eroare clar dacă autentificarea nu reușește.
Explorare și Descoperire:
  - Ca un utilizator, vreau să pot să navighez rapid și eficient prin secțiunile de Highlights și să descopăr caracteristicile cheie ale aplicației.
  - Ca un vizitator, vreau să am acces la o pagină de prezentare a aplicației, unde pot înțelege detaliile tehnice și inovațiile aduse.
Sectiune de News și Review-uri:
  - Ca un utilizator, vreau să citesc știri recente despre jocuri și să pot accesa recenzii ale altor utilizatori.
  - Ca un User Verified, vreau să pot adăuga un review pentru un joc și să ofer un rating.
  - Ca un User Verified, vreau să primesc recomandări personalizate bazate pe preferințele mele și recenziile pe care le-am adăugat.
Profile și Stats:
  - Ca un User Verified, vreau să îmi personalizez profilul, să încarc imagini și să adaug detalii despre experiența mea în utilizarea aplicației.
  - Ca un User Verified, vreau să vizitez o pagină de statistici unde să pot vedea orele petrecute în aplicație, jocurile preferate, etc.
Conexiune cu Baza de Date de pe Mobile:
  - Ca un User Verified, vreau să sincronizez datele și progresul meu între aplicația web și aplicația mobilă.
  - Ca un User Verified, vreau să pot accesa jocurile preferate direct de pe dispozitivul meu mobil după sincronizare.
Forum Comunitar și Evenimente Live:
  - Ca un utilizator, vreau să pot să particip la discuții pe Forumul Comunitar, să împărtășesc experiențe și să primesc sfaturi de la alți utilizatori.
  - Ca un User Verified, vreau să particip la evenimente live și să urmăresc prezentări despre tehnologie și jocuri.

## Added Features
[TODO: ADD FEATURES WHEN FINISHED]

## Upcoming Features
[TODO: ADD UPCOMING FEATURES]

## Dropped Features
[TODO: ADD FEATURES IF DROPPED]