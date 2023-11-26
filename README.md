# [emulair.com]()

## Details
Emulair is a front-end for Libretro cores, which now includes a web version! For more information about the project (such as how the code functions, why the project exists, who worked on it, etc.), check the [Wiki page](https://github.com/Emulair/Emulair-Web/wiki). To see our backlog, check the [Projects page](https://github.com/orgs/Emulair/projects/2).

## Philosophy
The web version of Emulair is a website created for users and developers so they can keep up with important news about our projects, find tutorials for how to use Emulair, read relevant documentation for how to contribute code and, in the future, run lightweight versions of some popular emulators directly from their web browsers.

## Product Vision (RO)
Dorim să dezvoltăm o platformă web captivantă și interactivă care să servească ca o prezentare extinsă pentru aplicația noastră mobilă, un emulator de jocuri pe telefon. Scopul nostru este să oferim o experiență unică utilizatorilor noștri, să promovăm interacțiunea și să facilităm prezentarea și explorarea funcționalităților aplicației noastre mobile. Prin intermediul acestei platforme web, dorim să evidențiem caracteristicile cheie, să oferim un spațiu pentru feedback și să încurajăm comunitatea să împărtășească experiențele lor.

## Product Features and Functionalities (RO)
Autentificare:
  - autentificare cu diferite niveluri de acces pentru admin, useri și writers

Sectiune de news + review-uri:
  - pagină dedicată pentru știri și recenzii de jocuri
  - sistem de rating și comentarii pentru recenzii
  - recomandări personalizate bazate pe preferințele utilizatorilor verificati

Conexiune cu baza de date de pe mobile:
  - sincronizare a progresului și a datelor între aplicația web și aplicația mobilă
  - acces la profilul personal și la setările de pe aplicația mobilă

Highlights:
  - pagină distinctă pentru evidențierea caracteristicilor cheie ale aplicației mobile
  - imagini și videoclipuri interactive care prezintă interfața și funcționalitățile aplicației

Pagina de prezentare:
  - design grafic captivant și animații interactive
  - detalii tehnice și inovații aduse de aplicația mobilă

Profile page:
  - personalizare avansată a profilului utilizatorului
  - încărcare de imagini și detalii despre experiența în utilizarea aplicației mobile

Stats page:
  - statistici detaliate despre activitatea utilizatorului, cum ar fi orele petrecute, jocurile preferate etc
  - grafice și diagrame pentru a vizualiza progresul în timp

Emulator calculator (opțional):
  - emulator de jocuri pe calculator pentru a testa funcționalitățile aplicației fără a o descărca pe dispozitivul mobil

Forum comunitar:
  - platformă de discuții pentru utilizatori pentru a împărtăși experiențe și sfaturi
  - moderare comunitară și sistem de notificări pentru discuții relevante

Evenimente live:
  - transmisiuni video live pentru evenimente legate de jocuri sau prezentări ale caracteristicilor noi
  - calendar de evenimente cu notificări pentru utilizatori

Sistem de recompense:
  - acordarea de recompense și insigne pentru realizări notabile în utilizarea aplicației
  - tablou de onoare pentru cei mai activi utilizatori

Secțiune de întrebări frecvente (FAQ):
  - pagină cu întrebări frecvente și răspunsuri utile pentru utilizatori
  - posibilitatea pentru utilizatori de a adăuga întrebări noi

## Non Functional Requirements (RO)
Performanță:
  - timpul de încărcare ar trebui să fie rapid pentru a asigura o experiență plăcută utilizatorilor
  - serverul ar trebui să ofere un timp de răspuns optim pentru a menține interacțiunea fluentă

Disponibilitate și fiabilitate:
  - vrem să asigurăm o disponibilitate înaltă pentru a minimaliza timpul de nefuncționare
  - implementarea unor mecanisme robuste pentru gestionarea erorilor și recuperarea rapidă este esențială

Securitate:
  - trebuie să implementăm un sistem sigur de autentificare și autorizare pentru a proteja datele și funcționalitățile critice
  - asigurarea protecției împotriva unor amenințări precum SQL injection și cross-site scripting este crucială

Ușurință în utilizare:
  - interfața trebuie să fie intuitivă și ușor de folosit pentru a oferi o experiență plăcută utilizatorilor
  - vom furniza o documentație clară și comprehensivă pentru a ajuta utilizatorii să exploreze și să înțeleagă funcționalitățile aplicației

Performanță tehnică:
  - codul sursă trebuie să fie eficient și optimizat pentru a minimiza utilizarea resurselor serverului
  - implementarea unor instrumente eficiente pentru monitorizarea performanței va contribui la identificarea rapidă a eventualelor probleme

Compatibilitate și portabilitate:
  - aplicația web trebuie să fie compatibilă cu cele mai recente versiuni ale principalelor browsere web
  - asigurarea accesibilitatii de pe diferite dispozitive, inclusiv desktop și dispozitive mobile

Mentenabilitate și extensibilitate:
  - implementarea unei arhitecturi modulare va facilita extinderea și mentenanța ulterioară a sistemului
  - furnizarea uneltelor eficiente de debug va simplifica procesul de identificare și remediere a problemelor

Securitatea datelor:
  - asigurarea criptarii datelor transferate între aplicația web și baza de date pentru a proteja confidențialitatea informațiilor utilizatorilor

Performanță a bazelor de date:
  - optimizarea interogărilor către baza de date va asigura o performanță eficientă
  - implementarea unor strategii eficiente pentru gestionarea creșterii volumului de date este necesară

## Customer Journey (RO)
Descoperire:
  - utilizatorul descoperă aplicația web prin intermediul motoarelor de căutare sau a recomandărilor
  - caută informații despre caracteristicile aplicației mobile și avantajele emulatorului de jocuri

Înregistrare și autentificare:
  - utilizatorul decide să se înregistreze pentru a beneficia de funcționalitățile complete
  - completează formularul de înregistrare și se autentifică

Explorarea highlights și pagina de prezentare:
  - utilizatorul navighează prin secțiunile de Highlights pentru a descoperi caracteristicile cheie ale aplicației mobile
  - accesează pagina de prezentare pentru a înțelege mai bine aspectele tehnice și inovațiile aduse

Sectiune de news + review-uri:
  - utilizatorul parcurge știrile și review-urile pentru a afla noutăți despre jocuri și experiențe ale altor utilizatori
  - lasă propriile review-uri și acordă rating-uri pentru jocurile testate

Profile și stats page:
  - utilizatorul vizitează propria pagină de profil pentru a personaliza detaliile și încărca imagini
  - explorează stats page pentru a vedea statistici detaliate despre activitatea sa în aplicație

Conexiune cu baza de date de pe mobile:
  - utilizatorul sincronizează datele și progresul său între aplicația web și aplicația mobilă
  - accesează jocurile preferate direct de pe dispozitivul mobil

Forum comunitar și evenimente live:
  - participă la discuții pe forumul comunitar, împărtășind experiențe și primind sfaturi de la alți utilizatori
  - participă la evenimente live pentru a urmări prezentări și transmisiuni video despre jocuri

Logout:
  - utilizatorul se deconectează și încheie sesiunea.

## User Personas (RO)
Alexandra "Gamer Passionat":
  - demografie:
    - vârstă: 25 ani
    - gen: feminin
    - ocupație: studentă
  - comportament:
    - joacă jocuri video în timpul liber și este pasionată de ultimele lansări
    - își dorește să împărtășească experiențele sale și să afle noutăți despre jocuri
    - apreciată de comunitatea de gameri
  - obiective:
    - Să descopere jocuri noi și să le testeze înainte de a le descărca
    - Să interacționeze cu alți gameri și să primească recomandări personalizate

Andrei "Tech Enthusiast":
  - demografie:
    - vârstă: 30 ani
    - gen: masculin
    - ocupație: dezvoltator software
  - comportament:
    - interesat de tehnologie și inovații în domeniul jocurilor
    - caută informații tehnice detaliate și vrea să înțeleagă funcționalitățile sub aspectul programării
    - participă la evenimente live și urmărește prezentările despre tehnologie
  - obiective:
    - să afle detalii tehnice despre emulator și funcționalitățile sale
    - să ofere feedback privind performanța și să contribuie la comunitatea de dezvoltatori

## User Stories (RO)
Autentificare și înregistrare:
  - ca un vizitator, vreau să pot să mă înregistrez pentru a crea un cont în aplicație
  - ca un utilizator înregistrat, vreau să pot să mă autentific cu adresa mea de e-mail și parola
  - ca un utilizator, vreau să primesc un mesaj de eroare clar dacă autentificarea nu reușește

Explorare și descoperire:
  - ca un utilizator, vreau să pot să navighez rapid și eficient prin secțiunile de highlights și să descopăr caracteristicile cheie ale aplicației
  - ca un vizitator, vreau să am acces la o pagină de prezentare a aplicației, unde pot înțelege detaliile tehnice și inovațiile aduse

Sectiune de news și review-uri:
  - ca un utilizator, vreau să citesc știri recente despre jocuri și să pot accesa recenzii ale altor utilizatori
  - ca un user verificat, vreau să pot adăuga un review pentru un joc și să ofer un rating
  - ca un user verificat, vreau să primesc recomandări personalizate bazate pe preferințele mele și recenziile pe care le-am adăugat

Profile și stats:
  - ca un user verificat, vreau să îmi personalizez profilul, să încarc imagini și să adaug detalii despre experiența mea în utilizarea aplicației
  - ca un user verificat, vreau să vizitez o pagină de statistici unde să pot vedea orele petrecute în aplicație, jocurile preferate, etc

Conexiune cu baza de date de pe mobile:
  - ca un user verificat, vreau să sincronizez datele și progresul meu între aplicația web și aplicația mobilă
  - ca un user verificat, vreau să pot accesa jocurile preferate direct de pe dispozitivul meu mobil după sincronizare

Forum comunitar și evenimente live:
  - ca un utilizator, vreau să pot să particip la discuții pe forumul comunitar, să împărtășesc experiențe și să primesc sfaturi de la alți utilizatori
  - ca un user verificat, vreau să particip la evenimente live și să urmăresc prezentări despre tehnologie și jocuri


## Activity Diagram (RO)
[TODO: ADD ACTIVITY DIAGRAM]
