using System;

namespace StringCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encoding needed for russian characters
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string toCheck = "Jeszcze coś takiego, o (skopiowana cała wikipedia :U):\n" +
                "\n" +
                "Tragedia na Przełęczy Diatłowa wydarzyła się w nocy, 2 lutego 1959, na wschodnim stoku góry Cholat Sjakl (Холат Сяхл) w północnej części Uralu. Dziewięcioro uczestników studenckiej wyprawy w góry Uralu poniosło śmierć w niewyjaśnionych ostatecznie do dziś okolicznościach. Na cześć przywódcy wyprawy, Igora Diatłowa, przełęcz, gdzie doszło do tragedii, nazwano Przełęczą Diatłowa.\n" +
                "Spis treści\n" +
                "\n" +
                "1 Ekspedycja\n" +
                "2 Tragedia na przełęczy\n" +
                "3 Hipotezy\n" +
                "4 Linki zewnętrzne\n" +
                "\n" +
                "Ekspedycja\n" +
                "\n" +
                "25 stycznia 1959 roku grupa dziewięciu studentów Politechniki Uralskiej w Jekaterynburgu wyruszyła na narciarską wyprawę w północną część Uralu, w towarzystwie doświadczonego 37-letniego przewodnika Aleksandra Zołotarewa. Celem wyprawy był szczyt Otorten; planowana trasa w porze zimowej oznaczona była jako trasa trzeciej, najtrudniejszej, kategorii. Wszyscy uczestnicy wyprawy mieli duże doświadczenie w podobnych wyprawach i byli przygotowani na niezwykle surowe warunki, jakie oczekiwały ich zimą w górach Uralu; Igor Diatłow planował wyprawę do Arktyki i traktował wypady podobne do wyprawy w okolice Otortenu jako przygotowanie do arktycznej podróży.\n" +
                "Ludmiła Dubinina żegna chorego Jurija Judina. Z lewej Igor Diatłow; z prawej Aleksander Zołotarew\n" +
                "Grupa Diatłowa rozbija swoje ostatnie obozowisko\n" +
                "\n" +
                "W skład ekspedycji wchodzili:\n" +
                "\n" +
                "Igor Diatłow (Игорь Дятлов) - student wydziału radiowego, 23 lata\n" +
                "Zinajda Kołmogorowa (Зинаида Колмогорова) - studentka wydziału radiowego, 22 lata;\n" +
                "Ludmiła Dubinina (Людмила Дубинина) - studentka ekonomii, 21 lat;\n" +
                "Aleksander Kolewatow (Александр Колеватов) - student wydziału geotechnicznego, 25 lat;\n" +
                "Rustem Słobodin (Рустем Слободин) - student wydziału inżynierskiego, 23 lata;\n" +
                "Jurij Krywoniszenko (Юрий Кривонищенко) - student wydziału inżynierskiego, 24 lata;\n" +
                "Jurij Doroszenko (Юрий Дорошенко) - student ekonomii, 21 lat;\n" +
                "Nikołaj Thibeaux-Brignolle (Николай Тибо-Бриньоль) - student wydziału inżynierskiego, 24 lata;\n" +
                "Semjon Zołotarew (Семён Золотарев) - przewodnik, 37 lat;\n" +
                "Jurij Judin (Юрий Юдин) - student ekonomii\n" +
                "\n" +
                "25 stycznia wieczorem ekspedycja dotarła pociągiem do miasta Iwdiel w obwodzie swierdłowskim. Następnego dnia ciężarówka zabrała studentów do miejscowości Wiżaj - najdalej wysuniętej na północ zamieszkanej osady w tym rejonie. Po przenocowaniu, 27 stycznia wyprawa wyruszyła w stronę góry Otorten. Następnego dnia Jurij Judin zachorował i musiał zawrócić do Wiżaju, podczas gdy reszta kontynuowała wyprawę; jak się wkrótce okazało, Judin był jedynym członkiem wyprawy, który pozostał przy życiu.\n" +
                "\n" +
                "31 stycznia ekspedycja, maszerując wzdłuż rzeki, dotarła na krawędź piętra wysokogórskiego. Członkowie wyprawy zbudowali mały schron, gdzie pozostawili zapasy żywności na drogę powrotną, po czym kontynuowali podróż. Wieczorem 1 lutego dotarli na zbocze góry Cholat Sjakl. Pierwotnie wyprawa planowała ominąć tę górę i przejść przez położoną nieopodal przełęcz; jednak z uwagi na pogarszającą się pogodę, zboczyli z kursu i znaleźli się na zboczu góry, gdzie postanowili rozbić obóz i przeczekać złe warunki atmosferyczne. Cholat Sjakl w języku miejscowego ludu Mansów oznacza dosłownie \"Górę Umarłych\"; nazwa ta miała się okazać bardzo ponurą przepowiednią.\n" +
                "Tragedia na przełęczy\n" +
                "\n" +
                "Zgodnie z wcześniejszymi ustaleniami Diatłow po powrocie z góry Otorten miał wysłać znajomym telegram z zawiadomieniem o sukcesie wyprawy; według planu ekspedycji, mieli powrócić do Wiżaju najdalej 12 lutego. Gdy do 20 lutego nie doczekano się żadnych wieści, Politechnika na żądanie rodzin uczestników wyprawy wysłała pod górę Otorten ekspedycję ratunkową.\n" +
                "\n" +
                "26 lutego ekspedycja natrafiła na namiot wyprawy Diatłowa. Był poważnie uszkodzony, jego powierzchnia rozcięta - jak potem ustalono - od wewnątrz; od namiotu prowadziły ślady stóp, kierujące się w stronę przeciwnego brzegu przełęczy i odległych o mniej więcej półtora kilometra sosen na krawędzi lasu, jednak po 500 metrach ślady te zniknęły pod śniegiem.\n" +
                "\n" +
                "Gdy ratownicy dotarli do sosen, odnaleźli pod nimi szczątki małego ogniska oraz zwłoki Krywoniszenki i Doroszenki, bose i ubrane jedynie w bieliznę. Podczas drogi powrotnej do namiotu odnaleziono w śniegu kolejno ciała Diatłowa (300 m od sosen), Słobodina (480 m) i Kołmogorowej (630 m); pozy, w jakich ich znaleziono, wskazywały, że próbowali oni powrócić do namiotu. Badania ciał wskazały, że wszystkie pięć osób zmarło z powodu hipotermii - zamarzło na śmierć. Jedna z osób miała lekko pękniętą czaszkę, jednak zdaniem anatomopatologów nie było to obrażenie zagrażające życiu.\n" +
                "Uszkodzony namiot znaleziony przez ekipę ratowniczą\n" +
                "\n" +
                "Po długich poszukiwaniach, 4 maja w położonym nieopodal jarze odnaleziono pod warstwą śniegu cztery pozostałe ciała. W tym przypadku zwłoki miały poważne obrażenia: Thibeaux-Brignolle miał strzaskaną czaszkę, zaś Zołotarew i Dubinina zmiażdżone klatki piersiowe (jak opisali patomorfolodzy, obrażenia przypominały te odnoszone podczas wypadków drogowych); dodatkowo brakowało języka i części twarzy Dubininy.\n" +
                "\n" +
                "Ślady wskazywały, że członkowie ekspedycji byli zmuszeni nagle opuścić namiot; pomimo że temperatura tamtej nocy wynosiła między -15 a -18 st.Celsjusza, część z nich była częściowo rozebrana, niektórzy byli boso bądź mieli założony tylko jeden but. W maju 1959 śledztwo w sprawie dramatu na przełęczy umorzono; według ustaleń organów śledczych, w tym czasie w rejonie przełęczy nie stwierdzono przebywania nikogo innego poza członkami ekspedycji. Według oficjalnej wersji, przyczyną śmierci członków wyprawy było \"działanie nieznanej siły\".\n" +
                "Hipotezy\n" +
                "\n" +
                "Wokół tragedii na przełęczy Diatłowa narosło wiele hipotez i teorii spiskowych. Członkowie rodzin ofiar założyli specjalną fundację, której celem jest ustalenie prawdy o tragicznych wydarzeniach w nocy 2 lutego 1959.\n" +
                "\n" +
                "Udało się ustalić w przybliżeniu chronologię zdarzeń. Nad ranem 2 lutego 1959 grupa wędrowców nagle, w pośpiechu opuściła namiot; zamiast rozwiązać go, przecięła jego bok. Studenci i przewodnik - część z nich ubrana, część w strojach mniej lub bardziej niekompletnych - dotarła do rosnącej około 1.5 km od namiotu wielkiej sosny, na krawędzi lasu, nieco poniżej namiotu. Pozostali tam przez około dwie godziny, rozpalając ognisko; kompletnie ubrani wędrowcy pożyczyli niektóre części garderoby niekompletnie ubranym. Połamane gałęzie wskazywały, że studenci wspinali się na sosnę, prawdopodobnie by zobaczyć, co dzieje się z porzuconym namiotem; być może, lekkie pęknięcie czaszki jednego z nich było spowodowane upadkiem.\n" +
                "\n" +
                "Gdy Kriwoniszenko i Doroszenko zmarli z wyziębienia, Diatłow, Kołmogorowa i Słobodin podjęli próbę dotarcia do namiotu; cała trójka zamarzła po drodze. Pozostali, po zabraniu umarłym niezbędnych części odzieży (Dubinina miała stopy owinięte spodniami Kriwoniszenki), zdecydowali się skryć głębiej w lesie, gdzie, błądząc w mroku, wpadli do jaru. Thibeaux-Brignolle zginął od razu; wkrótce po nim na skutek wychłodzenia i odniesionych obrażeń zmarła Dubinina. Zołotarew, by ogrzać się, zabrał jej kurtkę; wkrótce jednak podzielił jej los. Niedługo potem z wyziębienia zmarł Kolewatow.\n" +
                "\n" +
                "Nie udało się ustalić, dlaczego grupa doświadczonych i niejednokrotnie już podróżujących w podobnych warunkach wspinaczy nagle opuściła namiot i dlaczego przez mniej więcej dwie godziny nie odważyła się do niego powrócić. Pojawiło się kilka hipotez na ten temat.\n" +
                "\n" +
                "Atak Mansów. Mansowie, poirytowani faktem, że wędrowcy wkroczyli na ich tereny, mogli w nocy zaatakować obozowisko, by przegonić intruzów. Jednak wcześniej podobnych zachowań w tym rejonie nie stwierdzano; Mansowie generalnie nie przejawiali agresji wobec nieuzbrojonych obcych wędrujących przez ich tereny, a dodatkowo nie stwierdzono żadnych śladów, wskazujących na to, że tragicznej nocy na przełęczy był ktokolwiek inny poza ekspedycją Diatłowa.\n" +
                "Lawina. Członkowie ekspedycji, słysząc w nocy podejrzany hałas, mogli uznać go za dźwięki nadchodzącej lawiny i w pośpiechu opuścić namiot. W powiązaniu z inną teorią, uważano, że nad obozowiskiem mógł w nocy przelecieć wojskowy samolot odrzutowy; hałas silnika mógł być błędnie zinterpretowany jako huk schodzącej lawiny. Jednak stok, na którym ekspedycja rozbiła namiot, był o wiele zbyt płaski, by mogła z niego zejść lawina; Diatłow i Zołotarew - doświadczeni przewodnicy wysokogórscy - ustawili namiot ekspedycji w miejscu, gdzie zagrożenia lawinowego teoretycznie nie było. W miejscu tragedii nie było też żadnych śladów, wskazujących na zejście lawiny.\n" +
                "Wojskowe eksperymenty lub ćwiczenia. Członkowie innej ekspedycji, przebywającej w tym czasie 50 kilometrów na południe od przełęczy, opowiadali o dziwnych pomarańczowych kulach, jakie widzieli na niebie na północ od swojej pozycji (mniej więcej w rejonie Góry Śmierci). Dodatkowo, ubrania niektórych ofiar wykazywały znaczną radioaktywność; członkowie rodzin ofiar twierdzili, że oddane im ciała miały nietypowy, pomarańczowy odcień skóry, a w rejonie Cholat Sjakl znaleziono sporo części jakiegoś tajemniczego urządzenia. Przyczyniło się to do powstania hipotezy, jakoby w rejonie góry Otorten wojsko prowadziło loty ćwiczebne bądź testowało nowe samoloty odrzutowe bądź nowe rodzaje broni, co przyczyniło się do tragedii.\n" +
                "\n" +
                "Teoria ta została odrzucona przez wojskowych: choć obecnie nad rejonem Cholat Sjakl przebiega cywilny korytarz powietrzny, w 1959 roku nie był on jeszcze wytyczony. Północny Ural leżał w głębi terytorium ZSRR i w jego pobliżu nie było żadnych baz lotniczych; rozmieszczone były one bliżej granic Związku Radzieckiego, by w razie zagrożenia móc je odeprzeć, nim dosięgnie ono terytorium ZSRR. Najbliższa baza lotnicza znajdowała się w pobliżu Swierdłowska, ponad 600 km od miejsca tragedii; stacjonujące tam wówczas samoloty Jak-9 i MiG-15 nie mają wystarczającego zasięgu, by dotrzeć w rejon góry Otorten i powrócić do bazy. W miejscowości Iwdiel znajdowały się samoloty, ale były to cywilne maszyny An-2. Poligon, gdzie Armia Czerwona testowała nowe samoloty, mieścił się w miasteczku Żukowskie pod Moskwą; nowe rodzaje uzbrojenia testowano zaś we Władymirowce pod Astrachaniem. Wojsko nie prowadziło żadnych testów w trudno dostępnych rejonach Uralu, gdzie odzyskanie ewentualnych szczątków maszyny bądź pocisku byłoby niezwykle trudne i kosztowne. Radioaktywność obecna na ubraniach niektórych ofiar mogła być efektem przypadkowego skażenia na Politechnice Uralskiej; źródłem skażenia był potas-40,[potrzebne źródło] rzadki izotop promieniotwórczy nie stosowany do celów wojskowych. Tajemniczy odcień skóry ofiar, o jakim mówili członkowie ich rodzin, mógł być efektem oparzenia słonecznego lub zmian pośmiertnych; tajemnicze części urządzenia odnalezione na górze okazały się częściami starej, nieużywanej od lat wieży radarowej.\n" +
                "\n" +
                "Uszkodzenie twarzy Dubininy przypisano działaniom drapieżników, np. lisów.\n" +
                "\n" +
                "Nie ustalono, w jaki sposób powstały obrażenia trzech ofiar znalezionych w jarze; był on o wiele zbyt płytki (4-6 m), by przy wpadnięciu do niego, ofiary mogły doznać takich obrażeń (strzaskanie czaszki i zmiażdżenie klatek piersiowych), nie mogły one również być efektem np. pobicia przez nieznane osoby.\n" +
                "\n" +
                "Do dziś oficjalnie nie ustalono, dlaczego w środku nocy ofiary opuściły namiot, co powoduje, że wciąż pojawiają się nowe teorie spiskowe, zakładające np. działanie istot pozaziemskich. Pojawiła się też duża ilość informacji o rzekomym utajnieniu części dokumentów dotyczących dramatu na przełęczy i o zamknięciu terenu, gdzie doszło do tragedii, przed osobami postronnymi. W rzeczywistości całość dokumentacji wypadku na przełęczy była i jest dostępna; teren zaś zamknięto z obawy przed innymi podobnymi zdarzeniami.\n" +
                "\n" +
                "W roku 1967 Jurij Jarowoj, dziennikarz ze Swierdłowska, napisał książkę \"Najwyższy stopień trudności\", opartą na tragedii. Zebrał on również spory zbiór dokumentów i zdjęć związanych ze sprawą. Gdy w roku 1980 zginął w wypadku drogowym, jego zbiory zaginęły, co spowodowało pojawienie się kolejnych spiskowych teorii, choć jak się okazało same okoliczności wypadku nie budziły wątpliwości, a zawartość mieszkania mieszkającego samotnie Jarowoja po jego śmierci po prostu wywieziono w całości na wysypisko śmieci.\n" +
                "\n" +
                "0 0\n" +
                "NieznanyWamWszystkim\n" +
                "NieznanyWamWszystkim  odpowiedział(a) 13.03.2014 o 18:04\n" +
                "Michael Joseph Jackson (ur. 29 sierpnia 1958 w Gary w stanie Indiana, zm. 25 czerwca 2009 w Los Angeles) – amerykański muzyk, artysta estradowy, tancerz, kompozytor, autor tekstów i filantrop[3], którego kariera i życie osobiste stały się ważną częścią kultury masowej ostatnich czterech dekad. Znany jako jeden z najlepszych wykonawców muzyki pop i jeden z najpopularniejszych muzyków w historii[4], nazywany „Królem Popu”[5][6].\n" +
                "Do jego dokonań w przemyśle muzycznym zalicza się rewolucyjne podejście do teledysków[4] (zapoczątkowane przez wideoklip do piosenki „Thriller” z 1983) oraz zdominowanie rynku muzyki popularnej w latach 80. XX wieku[7]. Był ponadto pierwszym czarnoskórym artystą, który uzyskał silne poparcie w telewizji, w szczególności MTV, która z korzyścią dla obu stron promowała jego pionierskie wideoklipy do piosenek Thriller czy Billie Jean[8]. Spopularyzował też skomplikowane ruchy taneczne, takie jak moonwalk i robot dance[9].\n" +
                "Karierę muzyczną rozpoczął w wieku 7 lat, jako wokalista rodzinnego zespołu The Jackson 5. Pierwszy solowy album Got to Be There wydał w 1971, będąc jeszcze członkiem grupy[10], z którą ostatecznie się rozstał w roku 1984[11]. Pełną karierę solową artysta rozpoczął w 1979, zaś jej szczyt przypadł na przełom lat 80. i 90. XX wieku, po wydaniu albumu Thriller, którego światowa sprzedaż wynosi ponad 100 mln egzemplarzy[12][13]. Po Thrillerze Jackson wydawał kolejne albumy osiągające wysokie pozycje na listach przebojów i sprzedaży: Bad (1987), Dangerous (1991), HIStory (1995) oraz Invincible (2001).\n" +
                "W swojej karierze otrzymał 13 nagród Grammy[14] (jak również Grammy Legend Award oraz – pośmiertnie – Grammy Lifetime Achievement Award), a 13 spośród jego singli uplasowało się na pierwszych miejscach list przebojów w Stanach Zjednoczonych[15]. W listopadzie 2006 Raymone Bain, rzeczniczka prasowa Jacksona, ogłosiła, że Michael Jackson sprzedał ponad 750 mln egzemplarzy płyt na świecie[16].\n" +
                "Od 1988 do 2005 Jackson mieszkał w swojej posiadłości w Kalifornii, zwanej Neverland Ranch, gdzie zbudował park rozrywki i prywatne zoo, często odwiedzane przez dzieci. W 1993 artysta został oskarżony o molestowanie nieletnich. Wątek związku Michaela Jacksona z dziećmi pojawił się ponownie w 2003, po emisji dokumentu Living with Michael Jackson, jednak w 2005 został uniewinniony z wszystkich zarzutów. Jackson miał troje dzieci: Michaela Josepha Jacksona Juniora (znanego jako „Prince”), Paris Michael Katherine Jackson oraz Prince’a Michaela Jacksona (znanego jako „Blanket”).\n" +
                "Zmarł 25 czerwca 2009, w wieku 50 lat, wskutek „nagłego zatrzymania akcji serca”[17].\n" +
                "Spis treści [ukryj] \n" +
                "1 Życiorys\n" +
                "1.1 1958-1977: Dzieciństwo i początki kariery\n" +
                "1.2 1979-1981: Okres Off the Wall\n" +
                "1.3 1982-1986: Okres Thrillera\n" +
                "1.4 1987-1989: Okres Bad\n" +
                "1.5 1990-1994: Okres Dangerous\n" +
                "1.6 1995-2000: Okres HIStory i Blood on the Dance Floor\n" +
                "1.7 2001-2003: Okres Invincible\n" +
                "1.8 2003-2006: Proces, uniewinnienie i następstwa\n" +
                "1.9 2006-2009: Visionary – This Is It\n" +
                "1.10 Śmierć\n" +
                "1.10.1 Wyniki autopsji\n" +
                "1.10.2 Reakcje\n" +
                "1.10.3 Testament\n" +
                "1.10.4 Uroczystości żałobne\n" +
                "2 Wpływ\n" +
                "2.1 Teledyski i MTV\n" +
                "2.2 Legenda Thrillera\n" +
                "2.3 Styl i występy\n" +
                "2.4 Nagrody i uznanie\n" +
                "2.5 Firma Michaela Jacksona\n" +
                "3 Michael Jackson i inni\n" +
                "4 Tematyka tekstów\n" +
                "5 Dyskografia\n" +
                "5.1 Albumy studyjne\n" +
                "6 Filmografia\n" +
                "6.1 Filmy\n" +
                "6.1.1 Dubbing\n" +
                "6.2 Telewizja\n" +
                "7 Gry wideo i rozrywka\n" +
                "8 Przypisy\n" +
                "9 Linki zewnętrzne\n" +
                "Życiorys[edytuj | edytuj kod]\n" +
                "\n" +
                "1958-1977: Dzieciństwo i początki kariery[edytuj | edytuj kod]\n" +
                "\n" +
                "\n" +
                "Rodzinny dom Michaela Jacksona w Gary oraz pamiątki pozostawione przez fanów po jego śmierci\n" +
                "Michael Jackson urodził się w Gary w stanie Indiana. Był siódmym z dziewięciorga dzieci, a zarazem piątym z sześciu synów w robotniczej rodzinie Josepha i Katherine Jackson. Katherine, będąca Świadkiem Jehowy, wychowywała dzieci w swej wierze bez udziału ojca. W wieku 17 lat Michael Jackson został ochrzczonym Świadkiem Jehowy. Według wywiadów udzielonych po latach przez samego Michaela, ojciec, który był późniejszym menadżerem ich zespołu muzycznego, potrafił być bezwzględny w dyscyplinie narzucanej dzieciom i nie powstrzymywał się od przemocy fizycznej wobec nich. Sam ojciec Jacksona, Joe, przyznał w 2003 roku, że regularnie bił Michaela[18].\n" +
                "Michael Jackson ujawnił swój talent muzyczny w bardzo wczesnym wieku. W 1964 roku, wraz z bratem Marlonem przyłączył się do nowo założonego przez braci Jackie, Tito i Jermaine zespołu The Jackson Brothers. Początkowo Michael wspomagał muzyków grą na kongach i tamburynie, by w późniejszym czasie wspólnie z Jermainem wykorzystywać swoje umiejętności wokalne. W tym okresie chłopcy dali wiele koncertów w stanie Indiana, zaś po wygraniu lokalnego konkursu młodych talentów w 1966 r. (wykonując piosenkę zespołu The Temptations – „My Girl”, śpiewaną przez Michaela) zaczęli grać profesjonalne koncerty w Chicago oraz na Środkowym Zachodzie (Midwest) Stanów Zjednoczonych. Wiele z tych koncertów odbyło się w cieszących się złą sławą klubach nocnych dla czarnoskórych, w miejscach zwanych „Chitlin' Circuit”, gdzie młodzi chłopcy musieli grać przed występami striptizerek[19].\n" +
                "Kiedy grupa zmieniła nazwę z The Jackson Brothers na The Jackson 5 w 1966 r. młody Michael podzielił obowiązki wokalisty ze swoim bratem Jermainem. W 1968 r. zespół podpisał kontrakt z wytwórnią Motown Records[20]. Wkrótce po podpisaniu umowy zespół zyskał status gwiazdy dzięki hitom z pierwszych czterech singli: „I Want You Back”, „ABC”, „The Love You Save” i „I’ll Be There”, które znalazły się na pierwszych miejscach listy przebojów Billboardu. W tamtym czasie młody Jackson rozpoczął karierę jako artysta solowy, wydając albumy Got to Be There (1972) i Ben (1972). Płyty te, nagrane z The Jackson 5, zostały wydane pod szyldem tego zespołu; znalazły się na nich odnoszące sukcesy single „Got to Be There”, „Ben” i nowa aranżacja piosenki „Rockin’ Robin”.\n" +
                "\n" +
                "\n" +
                "Jackson (pośrodku) w składzie The Jackson 5, rok 1972\n" +
                "Po 1973 roku sprzedaż płyt grupy zaczęła spadać, a sam zespół zaczął narzekać na kontrolę ich twórczości przez wytwórnię Motown. W konsekwencji sporów w 1976 r. grupa podpisała nowy kontrakt z wytwórnią CBS Records[21]. W odpowiedzi Motown Records wytoczył grupie serię procesów z powodu naruszenia warunków kontraktu, w rezultacie których Jacksonowie stracili prawa do używania nazwy i logo The Jackson 5. Z zespołem pożegnał się również Jermaine Jackson, który ze względu na swój związek z córką prezesa Motown, Berry’ego Gordy, wolał związać się z jego wytwórnią[22]. W tej sytuacji zespół zmienił nazwę na The Jacksons, włączając do składu – na miejsce Jermaine’a – najmłodszego brata Randy’ego Jacksona. W tym składzie bracia kontynuowali swą karierę, koncertując po Stanach Zjednoczonych i za granicą. Pomiędzy 1976 a 1984 r. wydali kolejne sześć albumów, od 1983 r. działając jako sekstet ponownie w składzie z Jermainem. Od 1976 do 1984 Michael Jackson był głównym kompozytorem w zespole, tworząc hity takie jak „Shake Your Body (Down to the Ground)”, „This Place Hotel” (pierwotnie: „Heartbreak Hotel\") i „Can You Feel It”.\n" +
                "W 1978 r. Jackson zagrał stracha na wróble w filmie „Czarnoksiężnik z Krainy Oz”, z przyjaciółką Dianą Ross w roli Doroty[23]. Piosenki z musicalu zostały zaaranżowane przez Quincy’ego Jonesa, który nawiązawszy znajomość z Jacksonem podczas produkcji filmu, postanowił wyprodukować jego kolejne albumy, w tym – jak się miało okazać – przełomowy Thriller.\n" +
                "1979-1981: Okres Off the Wall[edytuj | edytuj kod]\n" +
                "Album Off the Wall, wydany w 1979 r. jako 5. solowy album artysty, zawierał takie utwory jak „Don't Stop 'Til You Get Enough” i „Rock with You”[10], które wkrótce opanowały listy przebojów. Płyta znalazła się na trzecim miejscu na liście albumów Billboardu, utrzymując się przez 48 tygodni w pierwszej dwudziestce. Produkcją wydawnictwa zajęli się wspólnie Quincy Jones i Michael Jackson, zaś za muzykę i teksty, obok samego Jacksona, odpowiedzialni byli Rod Temperton, Stevie Wonder i Paul McCartney. Album stał się sygnałem nadejścia nowego Michaela Jacksona, niezależnego od swych braci w dalszej karierze[24], co po czasie potwierdziła również liczba sprzedanych płyt – światowy nakład osiągnął 20 milionów egzemplarzy[25].\n" +
                "W styczniu 1980 r. Jackson zdobył pierwsze nagrody American Music Awards za swoje dokonania solowe w kategorii „Najlepszy album Soul/R&B” (za Off the Wall), „Najlepszy męski wykonawca Soul/R&B” i „Najlepszy singel Soul/R&B” (za „Don’t Stop 'Til You Get Enough\")[10]. Wkrótce zdobył również dwie nagrody Billboard Awards (dla „Najlepszego czarnoskórego artysty” i „Najlepszy album czarnoskórego artysty”)[10], a jego status gwiazdy dodatkowo potwierdziła nagroda Grammy za „Najlepsze męskie wykonanie” piosenki „Don’t Stop 'Til You Get Enough”[10].\n" +
                "Ponad dwadzieścia pięć lat po premierze płyta Off the Wall pozostaje jednym z najważniejszych momentów w muzycznej karierze Jacksona, który rozpoczął jego dominację na rynku muzyki pop. W 2003 r. w rankingu stacji telewizyjnej VH1 Off the Wall zajęła trzydzieste szóste miejsce na liście albumów wszech czasów; na liście 500 Najlepszych albumów wszech czasów magazynu Rolling Stone znalazła się natomiast na 68. miejscu.\n" +
                "1982-1986: Okres Thrillera[edytuj | edytuj kod]\n" +
                "Rok 1982 przyniósł dwa premierowe wydawnictwa z udziałem Jacksona. Pierwsze z nich to audiobook z bajkami wydany razem z soundtrackiem do filmu Stevena Spielberga E.T. Zawierał on nagranie Michaela Jacksona czytającego bajkę oraz nową piosenkę „Someone in the Dark”. Wkrótce płyta E.T. została uhonorowana nagrodą Grammy za „Najlepszy Album Dziecięcy”.\n" +
                "Drugim, tym razem autorskim wydawnictwem artysty, był wydany w grudniu album Thriller. Był to drugi longplay Jacksona wydany w wytwórni Epic Records. Thriller okazał się najlepiej sprzedającym się albumem w historii fonografii – według danych ze stycznia 2009, sprzedano go w 109 mln egzemplarzy[26]. Album ten stał się również pierwszym w historii, z którego siedem singli znalazło się w pierwszej dziesiątce listy Billboardu, w tym „Billie Jean”, „Beat It” oraz piosenka tytułowa – „Thriller”.\n" +
                "Ważnym wydarzeniem okazały się też teledyski do piosenek singlowych, które towarzyszyły płycie. Trwający trzynaście minut teledysk do utworu „Thriller” został bardzo dobrze przyjęty przez krytyków, a masowa emisja i duża popularność klipu doprowadziła do wydania krótkometrażowego filmu Making Michael Jackson’s Thriller na kasetach wideo, który stał się najlepiej sprzedającą się kasetą domowego wideo w historii[27]. Kolejny ważny wideoklip to „Billie Jean”, który był pierwszym teledyskiem afro-amerykańskiego wykonawcy regularnie wyświetlanym w MTV. Z piosenką tą związane jest również opracowanie przez Jacksona specyficznego sposobu poruszania się po scenie, tzw. moonwalk, który stał się znakiem firmowym piosenkarza i który Jackson po raz pierwszy zaprezentował podczas koncertu Motown 25: Yesterday, Today, Forever w 1983 r.[27]. Moonwalk zainicjował nową falę zainteresowania Thrillerem.\n" +
                "Album Thriller utrzymywał się na liście albumów Billboardu 122 tygodnie, z czego 37 na pierwszym miejscu. Thriller okazał się ogromnym sukcesem komercyjnym i artystycznym; dotychczas (do czerwca 2009 r.) w samych Stanach Zjednoczonych uzyskał 28 razy tytuł platynowej płyty[28]. Płyta ta uczyniła Michaela Jacksona ikoną światowej popkultury. Magazyn Time już w 1984 r. szacował dochody uzyskane ze sprzedaży albumu na 4,1 mld dolarów[29]. Thriller pomógł też czarnoskórym muzykom w ponownej szerszej prezentacji ich utworów w głównych stacjach radiowych, z których zniknęli w połowie lat 70.[29] Album w okresie jego największej popularności spotykał się z entuzjastycznym przyjęciem słuchaczy na całym świecie; jak wyraził się jeden z uczniów radzieckiego liceum: „Jego (Michaela Jacksona) muzyka jest niesamowicie ekscytująca. Jego puls to muzyka naszych czasów”[29].\n" +
                "W 1983 Jackson podpisał kontrakt reklamowy z koncernem Pepsi, który doprowadził do poważnego wypadku. Podczas kręcenia filmu reklamowego, na oczach ok. 3 tys. fanów, wybuch iskier ze specjalistycznego urządzenia spowodował zapalenie się włosów piosenkarza. W wyniku wypadku artysta doznał poparzeń drugiego stopnia przez co włosy nie odrosły w miejscu poparzenia.\n" +
                "W lutym 1984 Jackson został nominowany do nagrody Grammy w dwunastu kategoriach i zdobył osiem statuetek[27], tym samym bijąc rekord największej liczby zdobytych nagród w jednym roku[30]. Siedem zdobył Thriller, ósmą przyznano wydawnictwu E.T.. W 1984 zdobył również osiem American Music Awards, w tym „Specjalną Nagrodę za Zasługi”, a także trzy MTV Video Music Awards.\n" +
                "\n" +
                "\n" +
                "Michael Jackson z Ronaldem i Nancy Reagan w 1984 roku\n" +
                "W maju 1984 sklepy w całych Stanach Zjednoczonych rozpoczęły sprzedaż lalek gwiazdora, które stały się swego rodzaju symbolem seksu, jak je opisał magazyn Time: „Niesamowicie seksowne. Całkowicie bezpieczne. Erotyzm na wyciągnięcie ręki”[29]. Dodatkowo rękawica Michaela Jacksona wykonana z kryształu górskiego oraz kostium, w którym wystąpił w teledysku do „Thrillera”, stały się znakami rozpoznawczymi jego stylu, który zaczął być chętnie kopiowany przez amerykańską młodzież.\n" +
                "W 1984 r. Jackson ponownie zaśpiewał ze swoimi braćmi. Najpierw pomógł im w pracy nad albumem Victory, następnie 6 lipca 1984 wyruszył z nimi jako główna gwiazda w trwającą pięć miesięcy trasę „Victory Tour”. W 1985 Jackson został zaproszony do Białego Domu przez ówczesnego prezydenta Ronalda Reagana, który podziękował mu za użyczenie piosenki „Beat It” w kampanii przeciwko pijanym kierowcom w telewizji i radiu[31]. Jackson kontynuował swą działalność charytatywną. W 1985 wspólnie z Lionelem Richie stworzył przebój „We Are the World”. Singel, dochody z którego zostały przeznaczone na cele dobroczynne, zwrócił uwagę opinii publicznej na problem głodu w Afryce Wschodniej i pomógł w zdobyciu funduszy na walkę z nim. Singel był też jednym z pierwszych przykładów działalności Michaela Jacksona jako filantropa. Piosenka zdobyła statuetkę Grammy w kategorii „Piosenka Roku”[27]. „We Are the World” stał się jednym z pięciu najlepiej sprzedających się singli wszech czasów, rozchodząc się w nakładzie ponad 20 mln egzemplarzy.\n" +
                "Z okresem po wydaniu Thrillera związane są również kontrowersje związane z nabyciem przez Jacksona większości udziałów w koncernie ATV Music Publishing, który posiadał prawa do większości piosenek zespołu The Beatles. Posunięcie to zdenerwowało jego bliskiego przyjaciela i muzyka Paula McCartneya, który również przedstawił koncernowi swoją ofertę. Ironią w tej sprawie było to, że to McCartney pierwszy zwrócił uwagę Jacksona, jak duże zyski mogą płynąć z posiadania praw do piosenek Beatlesów, co skłoniło Jacksona do ich zakupu[32]. Oznaczało to definitywny koniec współpracy artystycznej Jacksona i McCartneya. Ta kontrowersyjna transakcja, jak również doniesienia prasy brukowej o tym, że Jackson sypia w komorze tlenowej o podwyższonym ciśnieniu (w celu zatrzymania procesu starzenia) i że artysta kupił kości Josepha Merricka, mocno nadszarpnęły wizerunek Jacksona i spowodowały, że prasa nadała mu znienawidzony przez niego pejoratywny przydomek „Wacko Jacko” („szurnięty Jackson”)[33].\n" +
                "W 1986 Jackson zagrał w trójwymiarowym filmie wyprodukowanym przez George’a Lucasa, w reżyserii Francisa Forda Coppoli, pod tytułem Kapitan EO (ang. Captain EO). Film ten trwał 17 minut i kosztował 17 mln dolarów[34], stając się w tamtym czasie najdroższym filmem krótkometrażowym. W Disneylandzie film ten był wyświetlany od 18 września 1986 do 7 kwietnia 1997. W filmie pojawiły się dwie nowe piosenki Jacksona, były to „Another Part Of Me” (później pojawiła się ona w albumie Bad) oraz „We Are Here To Change The World”, która oficjalnie ukazała się dopiero w Michael Jackson: The Ultimate Collection w 2004 r.\n" +
                "1987-1989: Okres Bad[edytuj | edytuj kod]\n" +
                "\n" +
                "\n" +
                "Michael Jackson podczas występu, 1988\n" +
                "Album Bad ukazał się w okresie sukcesu Thrillera. Przez pewien czas był drugim najlepiej sprzedającym się albumem wszech czasów.\n" +
                "Bad (1987) był trzecim albumem Jacksona wydanym pod szyldem Epic Records i ostatnim nagranym z producentem Quincym Jonesem[27]. Początkowo Jackson chciał wydać album z 30 utworami, lecz Jones ograniczył tę liczbę do 10. Za namową Jonesa, Jackson zaprosił do zaśpiewania razem z nim tytułowego utworu Prince’a, ten jednak odmówił. Jones powiedział, że jako powód odmowy Prince wyjaśnił, że piosenka będzie hitem zarówno z jego pomocą, jak i bez niej[35]. W swojej zawartości Bad łączył ballady i nastrojowe utwory z mrocznymi i posępnymi piosenkami, a ostatni utwór „Leave Me Alone” był odpowiedzią Jacksona na ataki prasy, kierowane w jego stronę[36].\n" +
                "Premiera albumu była bardzo oczekiwana, jako że była to pierwsza płyta Jacksona od pięciu lat[36]. Jeszcze przed jego wydaniem złożono zamówienia na dwa miliony egzemplarzy[36]. W porównaniu z Thrillerem Bad sprzedał się w końcu w znacznie mniejszym nakładzie, mimo to dla Jacksona wciąż był gigantycznym sukcesem kasowym. Z albumu wydano siedem singli[27], z których pięć wspięło się na szczyty list przebojów: „I Just Can’t Stop Loving You”, „Bad”, „The Way You Make Me Feel”, „Man in the Mirror” oraz „Dirty Diana”. Dwadzieścia lat po premierze Bad wciąż jest albumem, z którego największa liczba piosenek dotarła na pierwsze miejsce na liście przebojów Billboardu (w 2011 rekord ten wyrównała Katy Perry z pięcioma singlami z albumu Teenage Dream). Album rozszedł się w ponad 30 mln egzemplarzy, ośmiokrotnie zdobywając tytuł platynowej płyty[37].\n" +
                "We wrześniu 1987 Jackson ruszył w pierwszą solową trasę koncertową, Bad World Tour. Trasa trwała szesnaście miesięcy, podczas których Jackson dał 123 koncerty przed 4,4 mln fanów na całym świecie. Jednym z warunków dla organizatorów koncertów było, aby artysta miał zapewniony do celów przemieszczania się pomiędzy hotelami i miejscami koncertów jednocześnie prywatny autobus, samolot i helikopter[38].\n" +
                "\n" +
                " promującej „pionierskie teledyski, takie jak „Thriller”, „Billie Jean” i „Beat It\"”[141]. Pod wpływem Jacksona MTV skupiła się";

            StringCounter.PrintOccurencesFromDict(toCheck);
            Console.WriteLine("========================================================");
            StringCounter.PrintOccurencesWithList(toCheck);
            Console.ReadKey();
        }
    }
}
