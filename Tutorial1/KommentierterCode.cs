using System;

namespace TutorialBibliothek
{
    public class KommentierterCode
    {
        public static void Tutorial1()
        {


            //----------------------------------------------Elementare Syntax-------------------------------------------------------------------------------------

            Console.Write("Hallo...");                              //Anweisungen enden immer mit einem Semikolon // Methode erzeugt eine Ausgabe
                                                                    //Konsolen-Cursor am Ende der Zeile 

            Console.                                                //Anweisungen können in verschiedene Zeilen aufgeteilt werden //
                WriteLine                                           //Diese Methode erzeugt eine Ausgabe in der Konsole // Cursor in der nächste Zeile
                /* Kommentar*/("C# macht spaß");                    //Kommentare können in mitten einer Anweisung stehen

            Console.WriteLine("..."); Console.WriteLine("!");       //Mehrere Anweisun
                                                                    //gen können in eine Zeile geschrieben werden

            Console.ReadLine();                                     //Reagiert nur auf 'Enter'

            Console.ReadKey(); ;                                    //Reagiert auf jede Taste //Mehrere Semikolons füren nicht zu einem Fehler



            //----------------------------------------------Datendeklaration-------------------------------------------------------------------------------------

            int value;                                              //Deklaration durch Datentyp + Bezeichner
                                                                    //(Der Bezeichner repräsentiert eine Speicheradresse im Arbeitsspeicher)

            /* Variablenbezeichner
            ->Ein Bezeichner setzt sich aus alphanumerischen Zeichen und dem Unterstrich zusammen.
              Leerzeichen und andere Sonderzeichen wie beispielsweise #, § und $ sind nicht zugelassen.           
            ->Ein Bezeichner muss mit einem Buchstaben oder dem Unterstrich anfangen.
            ->Ein einzelner Unterstrich als Variablenname ist nicht zugelassen.
            ->Der Bezeichner muss eindeutig sein, Er darf nicht gleichlautend mit einem Schlüsselwort, einer Methode
              , einer Klasse oder einem Objektnamen sein.
            */

            value = 1234;                                           //Zuweisung eines gültigen Wertes (Initialisierung)

            double value2 = 1000.11;                                //Deklaration und Initialisierung können in einer Anweisung erfolgen
            Console.WriteLine(value + value2);                      //Werte werden in der Konsole addiert ausgegeben


            long a = 10, b = 1000000000000000000;                   //Mehrere Variablen gleichen Typs deklarieren und direkt initialisieren



            //----------------------------------------------Variable durch Platzhalter-------------------------------------------------------------------------------------

            Console.WriteLine                                       //Konsolenausgabe der Variable durch Platzhalter { }
                ("Wert von'a'= {0}\nWert von 'b'= {1}", a, b);


            Console.WriteLine("Ich kaufe {0,3} Eier", a);           //Breite des einzusetzenden Wertes {N,M}
            Console.WriteLine("Ich kaufe {0,10} Eier", a);          //->N ist ein nullbasierter Zähler ->M gibt die Breite der Ausgabe
            Console.WriteLine("Ich kaufe {0,-10} Eier", a);         /*Die Ausgabe hat eine Gesamtbreite von 10 Zeichen,
                                                                      die Zahl selbst allerdings nur zwei Ziffern. Daher wird vor ggf. nach der Zahl 8
                                                                      Leestellen eingefügt*/

            /*  Vollständige Syntax des Formatausdrucks:
                {N [,M][:Format]}
                Formatangabe    Beschreibung
                C               Zeigt die Zahl im lokalen Währungsformat.
                D               Zeigt die Zahl als dezimalen Integer an.
                E               Zeigt die Zahl im wissenschaftlichen Format
                                (Exponentialschreibweise).
                F               Zeigt die Zahl im Festpunktformat an.
                G               Eine numerische Zahl wird entweder imFestpunkt- 
                                oder im wissenschaftlichen Format angezeigt. 
                                Zur Anzeige kommt das >>kompakteste<< Format.
                N               Zeigt eine numerische Zahl einschließlich Kommaseparatoren.
                P               Zeigt die numerische Zahl als Prozentzahl an. 
                X               Die Anzeige erfolgt in Hexadezimalnotation.*/

            Console.WriteLine("value={0:E}", value);                //Ausgabe: value=1,234000E+003
            Console.WriteLine("value={0:E2}", value);               //Ausgabe: value=1,23E+003

            float value3 = 0.2512F;
            Console.WriteLine("value3={0,10:G}", value3);           //Ausgabe: value3=    0,2512
            Console.WriteLine("value3={0:P4}", value3);             //Ausgabe: value3=25,1200 %

            Console.WriteLine($"a={a},b={b}");                      //Angabe der Variablen innerhalb der geschweiften Klammern
                                                                    //Beachten Sie, dass vor der Zeichenfolge $ gesetzt wird



            //----------------------------------------------Formatierung der Ausgabe-------------------------------------------------------------------------------------

            /*  Escape-Zeichen
                werden verwendet wenn Sonderzeichen innerhalb einer Zeichenfolge
                ausgegeben werden sollen.
                
                Escape-Zeichen      Beschreibung
                \'                  Fügt ein Hochkomma in die Zeichenfolge ein.
                \''                 Fügt Anführungsstriche ein.
                \\                  Fügt einen Backslash in die Zeichenfolge ein.
                \a                  Löst einen Alarmton aus.
                \b                  Führt zum Löschen des vorhergehenden Zeichens.
                \f                  Löst einen Formularvorschub bei Druckern aus.
                \n                  Lost einen Zeilenvorschub aus(entspricht der 
                                    Funktionalität der 'ENTER'-Taste)
                \r                  Führt zu einem Wagenrücklauf.
                \t                  Führt auf dem Bildschirm zu einem Tabulatorsprung. 
                \u                  Fügt ein Unicode-Zeichen in die Zeichenfolge ein.
                \v                  Fügt einen vertikalen Tabulator in eine Zeichenfolge ein.
             */

            Console.WriteLine("Hallo\\nWelt");                         //Ausgabe: Hallo\nWelt // Ein zweiter Backslash erzwingt die Ausgabe
            Console.WriteLine(@"C#\nmacht\nSpaß");                     //Ausgabe: C#\nmacht\nSpaß // Vor die Zeichenfolge @ setzen
                                                                       //um die Interpretation als Escape-Sequenz abzuschalten.



            //---------------------------------------------->>ReadLine<< und >>Read<<-------------------------------------------------------------------------------------

            string input1 = Console.ReadLine();                        //Wartet auf den Eingabestrom und gibt die Zeichenfolge als string wieder
            Console.WriteLine(input1);                                 //Der Zeilenumbruch wird bei ReadLine aus dem Eingabestrom gelöscht

            int input2 = Console.Read();                               //Read liest den ersten eingabewert als Dezimalen ASCII-Wert aus (darum int)
            Console.WriteLine(input2);                                 //Der Zeilenumbruch wird nicht aus dem Eingabestrom gelöscht. Er wird so lange
            Console.ReadLine();                                        //gepuffert bis ein Methode wie ReadLine sie direkt verarbeitet.
            Console.ReadLine();
        }


        public static void Tutorial2()
        {

            /* --------Elementaren Datentypen----------
                In der ersten Spalte ist der Typbezeichner in der .Net-Klassenbibliothek angeführt. 
                In der zweiten Spalte steht der C#-Alias, der bei der Deklaration einer Variablen angegeben werden kann
                In der dritten Spalte ist angegeben, ob der Typ den Vorgaben der Common Language Specification (CLS) entspricht.
                Für die Typen die nicht der CLS entsprechen bedeutet das, dass es ggf. keine Operatoren für diese Datentypen existieren.
                .NET-Laufzeittyp    C#-Alias    CLS-konform     Wertebereich
                Byte                byte        ja              0...255
                SByte               sbyte       nein            -128 ... 127 
                Int16               short       ja              -2^(15) ... 2^(15) -1
                UInt16              ushort      nein            0 ... 65.535
                Int32               int         ja              -2^(31) ... 2^()31 -1
                UInt32              uint        nein            0 ... 2^(32)-1
                Int64               long        ja              -2^(63) ... 2^(64) -1
                UInt64              ulong       nein            0 ... 2^(64) -1
                Single              float       ja              1,4 x 10^(-45) bis 3,4 x 10^(38)
                Double              double      ja              5,0 x 10^(-324) bis 1,7 x 10^(308)
                Decimal             decimal     ja              +/-79E27 ohne Dezimalpunktangabe;
                                                                +/-7.9E-29, falls 28 Stellen hinter dem Dezimal-
                                                                punkt angegeben werden. Die kleinste Darstellbare
                                                                Zahl beträgt +/-1.0E-29.
                Char                char        ja              Unicode-Zeichen zwischen 0 und 65.535
                String              string      ja              ca. 2^(31) Unicode-zeichen
                Boolean             bool        ja              true oder false
                Object              object      ja              Eine Variable vom Typ Object kann jeden anderen 
                                                                Datentypen enthalten. ist also universell.
                 */


            Int32 value1 = 123456789;                                   //Die Variablen können mit dem .NET-Laufzeittyp und dem C#-Alias deklariert werden.
            int value2 = 123456789;
            Console.WriteLine($"value1={value1},value2={value2}");



            //----------------------------------------------Dezimalzahlen-------------------------------------------------------------------------------------

            /*float value3 = 0.123456789;                                 Literale (Zeichenfolge zur direkten Darstellung der Werte), die eine Dezimalzahl beschreib
                                                                          werden von der .NET-Laufzeitumgebung als 'Double'-Typ angesehen. Literale hingegen die eine 
                                                                          Ganzzahl beschreiben, werden von der Laufzeitumgebung als 'int' (Int32) betrachtet. */

            float value3 = -0.123456789123456789123456789F;             //Der Buchstabe 'F' zwingt hier das Literal in den Typ float.//GENAUIGKEIT etwa 10 Stellen
            double value4 = -0.123456789123456789123456789;             //GENAUIGKEIT etwa 16 Stellen
            decimal value5 = -0.123456789123456789123456789M;           //GENAUIGKEIT etwa 25-16 Stellen.
            Console.WriteLine                                           //Die genauigkeit ist zudem abhängig von der Anzahl der ganzzahligen Ziffern.
                ("value3={0,30}\nvalue4={1,30}\nvalue5={2,30}"
                , value3, value4, value5);


            //--------------------------------------------->>String<< und >>Char<<-------------------------------------------------------------------------------

            char letter = 'A';                                          //Variablen vom Typ 'char' können Zeichen des Unicode-Zeichensatzes aufnehmen (65.536 Zeichen).
                                                                        //Der Typ 'char' wird in einfache Anführungsstriche gesetzt.
            int letterASCII = letter;                                   //Um den ASCII-Wert eines zeichens zu erhalten, weisen Sie es einem Zahlentyp zu(z.B. int).                                               
            Console.WriteLine(letterASCII);

            string str = "C# ist spitze.";                              //'char' beschränkt sich auf ein Zeichen. Um eine Zeichenkette zu deklarieren, wird 'string' verwendet.


            //---------------------------------------------->>Boolean<<------------------------------------------------------------------------------------------

            bool flag = true;                                           //Variablen vom Typ 'bool' können nur zwei Zustände beschreiben,
            Console.WriteLine(flag);                                    //nämlich 'true' oder 'false'.

            //---------------------------------------------->>Objekte<<-----------------------------------------------------------------------------------------

            object universal = 5;                                       //Ein 'Objekt' Datentyp beschreibt einen vier Byte Zeiger der die Speicheradresse des 
            Console.WriteLine(universal);                               //Objektes enthält.
            universal = "Hallo Aachen";                                 //Eine Variable dieses Types kann jeden beliebigen anderen Datentyp beschreiben. 
            Console.WriteLine(universal);

            Console.WriteLine("Int16(min) = {0}", Int16.MinValue);      //Alles Datentypen sind Objekte und hinter den Variablennamen verbergen sich verschiedene Möglichkeiten.
            Console.WriteLine("Int16(max)={0}", Int16.MaxValue);


            //------------------------------------------Elementare Typkonvertierung-----------------------------------------------------------------------------

            //-->implizite Konvertierung            
            int value6 = 12000;                                         //Der Inhalt der Variable mit dem Typ-'int' wird in eine Variable mit dem Typ-'long' geschrieben.
            long value7 = value6;

            //long value8 = 12000;                                      //Der Wertebereich eines 'int' ist kleiner als der eines 'long'-Typs.  
            //int value9 = value8;

            //-->explizite Konvertierung
            float value8 = 3.12F;                                       //'float' und 'decimal' können nicht implizit konvertiert werden.
            decimal value9 = (decimal)value8;

            long value10 = 20;                                          //Der größere Wertebereich von 'long' wird in 'int' nur explizit umgewandelt,
            int value11 = (int)value10;                                 //da der Datenverlust bewust eingegangen wird.

            //Einige Typen konnen mit dem Konvertierungsoperator '()' nicht konvertiert werden.
            //Beispielsweise: 'string', 'bool'... Um dennoch diese Typen zu konvertieren, 

            int value12 = Convert.ToInt32(Console.ReadLine());          /*Methode               Beschreibung
                                                                          ToBoolean(Ausdruck)   Konvertiert den Ausdruck in einen 'bool'-Typ.
                                                                          ToByte(Ausdruck)      Konvertiert den Ausdruck in einen 'byte'-Typ.
                                                                          ToChar(Ausdruck)      Konvertiert den Ausdruck in einen 'char'-Typ.
                                                                          ToDecimal(Ausdruck)   Konvertiert den Ausdruck in einen 'decimal'-Typ.
                                                                          ToDouble(Ausdruck)    Konvertiert den Ausdruck in einen 'double'-Typ.
                                                                          ToInt16(Ausdruck)     Konvertiert den Ausdruck in einen 'short'-Typ. */


            short value13 = Convert.ToInt16(Console.ReadLine());        //Es wird generell kein Datenverlust durch einen Überlauf angezeigt. 
                                                                        //-->Bei der Verwendung von >>Convert<< wird eine Überlauf durch eine Warnung angezeigt. 
            byte value14 = (byte)value13;                               //-->Ein Überlauf kann mit den Operatoren 'checked' und 'unchecked' erkannt werden.
                                                                        //-->Um immer auf einen Überlauf zu prüfen, kann im Projekteigenschaftenfenster
                                                                        //die prüfung eingeschaltet werden.
        }
        public static void Tutorial3()
        {
            //--------------------------------------------Operatoren------------------------------------------------------------------------------------------

            //value=22;     Operant: value,22    Operator: =

            //--------------------------------------------Arithmetische Operatoren----------------------------------------------------------------------------
            /*C# kennt die üblichen Operatoren der vier Grundrechenarten Addition, Subtraktion, Division und Multiplikation. Darüber hinaus werden in der 
                nachfolgenden Tabelle weitere Operatoren beschrieben.
                Operator      Beschreibung
                +             ->Als Addition bildet er die Summe zweier Operanden (x+y).
                            ->Als Vorzeichenoperator beschreibt er eine positive Zahl (+x).
                -             ->Als Subtraktionsoperatoreingesetzt, bildet er die Differenz zweier Operanden (x-y).
                            ->Als unärer Vorzeichenoperator Beschreibt er eine negative Zahl (-x).
                *             Multiplikationsoperator; multipliziert zwei Operanden (x*y).
                /             Divisionsoperator; dividiert zwei Operanden (x/y), behält den nachkommateil der Division.
                %             Restwertoperator; dividiert zwei Operanden und liefert als Ergebnis den Restwert der Operation (x%y)=x - (x / y) * y.
                ++            Erhöht den Inhalt des Operanden um 1. Das Ergebnis der Operation ++x ist der Wert des Operanden nach der Erhöhung.
                            Das Ergebnis der Operation x++ ist der Wert des Operanden vor der Erhöhung.
                --            Verringert den Inhalt des Operanden um 1. Das Ergebnis der Operation --x ist der Wert des Operanden nach der Verringerung. 
                            Das Ergebnis der Operation x-- ist der Wert des Operanden vor der verringerung.
                            >>>Viele mathematische Operatoren wie der Potenzoperator werden mit der Klasse 'Math' bereitgestellt.<<< double value = Math.Pow(2,5);               */

            int x = 5;
            int y;

            y = x++;                                                                           //x hat den Inhalt 6 und y den Inhalt 5
            Console.WriteLine("x = {0}, y = {1}", x, y);
            x = 5;
            y = ++x;                                                                           //x und y haben den Inhalt 6
            Console.WriteLine("x = {0}, y = {1}", x, y);



            //Besonderheiten einer Division

            double value = 3 / 4;                                                              //Die Konsole zeigt den Wert 0. Beide Literale werden dem Typ 'int' zugeordnet.
            Console.WriteLine(value);                                                          //Das endgültige Ergebnis wird zwischengespeichert, dabei wird Typ mit dem Typ des
                                                                                               //des größten der beiden Operanden gleichgesetzt.
            value = 3.0 / 4;
            //value = (double)3/4;
            Console.WriteLine(value);



            //--------------------------------------------Vergleichsoperatoren----------------------------------------------------------------------------
            /*Vergleichsoperatoren vergleichen zwei Ausdrücke miteinander. Der Rückgabewert ist immer ein boolescher Wert, also entweder 'true' oder 'false'.
                Vergleiche können auf Gleichheit bzw. Ungleichheit sowie auf >>größer<< und >>kleiner<< durchgeführt werden.
                Operator      Beschreibung
                a==b          (Vergleichsoperator) prüft, ob Ausdruck a Ausdruck b entspricht, und gibt in diesem Fall 'true' zurück
                a!=b          Ergebnis der Operation ist 'true', wenn a ungleich b ist.
                a>b           Ergebnis der Operation ist 'true', wenn a größer b ist.
                a<b           Ergebnis der Operation ist 'true', wenn a kleiner b ist.
                a<=b          Ergebnis der Operation ist 'true', wenn a kleiner oder gleich b ist.
                a>=b          Ergebnis der Operation ist 'true', wenn a größer oder gleich b ist.                                                 */

            bool compare;
            compare = value <= 100;                                                           //Vergleichsoperatoren haben eine höhere Priorität als der Zuweisungsoperator.



            //--------------------------------------------Logische Operatoren----------------------------------------------------------------------------

            /*
                * Operator      Beschreibung
                !             Unärer Negationsoperator. Der Ausdruck '!a' ist 'true', wenn 'a' einen unwahren Wert beschreibt, und 'false', wenn 'a' wahr ist.
                &             (And-Operator, 1.Variante) Der Ausdruck 'a&b' ist dann 'true', wenn sowohl 'a' als auch 'b true' sind. Dabei werden in jedem Fall beide Ausdrücke ausgewertetr.
                |             (Or-Operator, 1. Variante) Der Ausdruck 'a|b' ist 'true', wenn entweder 'a' oder 'b' wahr ist. Dabei werden in jedem Fall beide Ausdrücke ausgewertet.
                ^             (Xor-Operator) Der Ausdruck 'a^b' ist 'true', wenn die beiden beteiligten Operanden unterschiedliche Wahrheitswerte haben. 
                &&            (And-Operator, 2.Variante) Der Ausdruck 'a&&b' ist 'true', wenn sowohl 'a' als auch 'b true' sind. Zuerst wird 'a' ausgewertet. Sollte 'a false' sein,
                            ist in jedem Fall der Gesamtausdruck unabhängig von 'b' auch falsch. 'b' wird dann nicht mehr ausgewertet.
                ||            (Or-Operator, 2.Variante) Der Ausdruck 'a||b' ist 'true', wenn 'a' oder 'b true' ist. Zuerst wird 'a' ausgewertet. Sollte 'a' bereits 'true' sein,
                            ist in jedem Fall der Gesamtausdruck unabhängig von 'b' auch Wahr. 'b' wird dann nicht mehr ausgewertet. 
                Bedingung1        Bedungung2      And-Operator        Or-Operator     Xor-Operator
                false             false           false               false           false
                true              false           false               true            true
                false             true            false               true            true
                true              true            false               true            false
                */

            if (x < 5 || y > 20)                                                              //||-Operator hat die geringste Priorität. 'x<5' >> 'y>20' >> '||'
                Console.WriteLine("Bedingung ist erfüllt 1");

            x = 8;
            y = 9;

            if ((x != y) || DoSomething())                                                    //'x!=y' entspricht true, aus diesem Grund wird 'DoSomething()' nicht ausgeführt.
                Console.WriteLine("Bedingung ist erfüllt 2");
            Console.ReadLine();



            //--------------------------------------------Zuweisungsoperatoren----------------------------------------------------------------------------
            /*Operator  Beschreibung
                =         x=y     weist x den Wert von y zu.
                +=        x+=Y    weist x den Wert von x+y zu.
                -=        x-=y    weist x den Wert von x-y zu.
                *=        x*=y    weist x den Wert von x*y zu.
                /=        x/=y    weist x den Wert von x/y zu.
                %=        x%=y    weist x den Wert von x%y zu.
                &=        x&=y    weist x den Wert von x&y zu.
                |=        x|=y    weist x den Wert von x|y zu.
                ^=        x^=y    weist x den Wert von x^y zu.
                <<=       x<<=y   weist x den Wert von x<<y zu.              
                >>=       x>>=y   weist x den Wert von x>>y zu.              */


            //--------------------------------------------Stringverkettung----------------------------------------------------------------------------

            string text1 = "Leckere";
            string text2 = "Suppe";
            string text3 = text1 + "" + text2;
            Console.WriteLine(text3);
            value = 4711;
            string text = "Hallo";
            text += value;                                                                  //Bei einer Verkettung von einem 'string' und einem 'int' mit '+' wird der Operand vom Typ 'int' 
            Console.WriteLine(text);                                                        //in ein 'string' umgewandelt.


            //--------------------------------------------Die >>if<<-Anweisung----------------------------------------------------------------------------
            /*Die 'if'-Anweisung bietet sich an, wenn bestimmte Programmteile nur beim Auftreten einer bestimmten Bedingung ausgeführt werden soll
            if(Bedingung)                                                                   //Auf die geschweiften Klammern kann verzichtet werden, wenn es sich um genau eine Anweisung handelt. 
            {
                Anweisung1
            }
            else
            {
                Anweisung2
            }
                */

            string name = Console.ReadLine();

            if (name.Length == 0)                                                           //In C# gibt es keine Standartkonvertierung von einem 'int' in einen 'bool'.
                Console.WriteLine("Haben Sie keinen Namen?");                               //Die Bedingung muss ein 'bool' ergeben ('true' oder 'false').
            else
                Console.WriteLine("Ihr Name ist {0}", name);                                //>>Merke<<
            Console.ReadLine();                                                             //Eine 'else'-Klausel wird immer an das am nächsten stehenden 'if' gebunden. Dies kann nur 
                                                                                            //durch das Festlegen von Anweisungsblöcken umgangen werden.


            //Komplexe >>if<<-Statements

            if (value == 0)                                                                 //Die an 'else' anschließende 'if'-Anweisung erzeugt eine Überschaubarkeit. 
                Console.WriteLine("Die Zahl ist 0");
            else if (value == 1)
                Console.WriteLine("Die Zahl ist 1");
            else if (value == 2)
                Console.WriteLine("Die Zahl ist 2");
            else
                Console.WriteLine("Zahl > 2");



            //--------------------------------------------Herrausforderung----------------------------------------------------------------------------
            /*Als Nächstes fügen Sie Ihrem Projekt komplexeren Rechnercode hinzu.
                Nutzen Sie die Komplexen if-Statements um für jede Auswahl die entsprechende Rechnung auszuführen und in der Konsole auszugeben*/


        }

        static bool DoSomething()
        {
            Console.WriteLine("in DoSomething");
            return true;
        }

        public static void Tutorial4()
        {
            /*--------------------------------------------Das >>switch<<-Statement----------------------------------------------------------------------------
              
             
               switch(Ausdruck)                                                             //Es wird geprüft, ob die in den Klammern stehende Anweisung mit        
                {                                                                           //einer der hinter 'case' stehenden Konstanten übereinstimmt.
                 case Konstante1:
                    //Anweisung1                                                            //Bei einer Übereinstimmung werden die Anweisungen des jeweiligen 'case' bis zum 'break' ausgeführt 
                    break;
                 
                 case Konstante2:
                    //Anweisung2
                    break;
            
                 ...
                  default:                                                                  //Wenn keine Übereinstimmung mit den Konstanten festgestellt werden kann, wird die 'default'
                    //Anweisung                                                             //Anweisung ausgeführt.
                    break;
                }*/


            int value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case 1:                                                                     //Auf 'break' kann man verzichten, wenn mehrere 'case'-Anweisungen direkt hintereinander stehen.
                case 2:
                case 3:
                    Console.WriteLine("value = 1, 2 oder 3");
                    break;
                case 4:
                    Console.WriteLine("value = 4");
                    break;
                default:
                    Console.WriteLine("Anderer Wert");
                    break;

            }

            //--------------------------------------------Die >>goto<<-Anweisung----------------------------------------------------------------------------

            goto meineMarke;                                                                //Die 'goto'-Anweisung wird generell verwendet um beliebige Marke im Code anzusteuern.
            Console.WriteLine("Anweisung zwischen 'goto'");
        meineMarke:                                                                     //
            Console.WriteLine("meineMarke");


            //--------------------------------------------Programmschleifen----------------------------------------------------------------------------
            /*Schleifen dienen dazu, Anweisungsfolgen wiederholt auszuführen. 
              Dabei wird zwischen zwei Schleifentypen unterschieden:
                    
                    - bestimmte Schleifen
                    - unbestimmte Schleifen
            Ist beim Schleifeneintritt bekannt, wie oft die Anweisungsfolge durchlaufen werden muss, wird von einer bestimmten Schleife gesprochen. 
            Ergibt sich erst während des Schleifendurchlaufs, wann die zyklische Bearbeitung abgebrochen werden kann oder muss, spricht man von 
            unbestimmten Schleifen. */


            //--------------------------------------------Die>>for<<-Schleife----------------------------------------------------------------------------

            /* Man setzt die 'for'-Schleife meistens dann ein, wenn bekannt ist, wie oft bestimmte Anweisungen ausgeführt werden müssen. Die allgemeine Syntax des 
               'for'-Schleifenkonstrukts sieht dabei wie folgt aus:
            for (Ausdruck1; Ausdruck2; Ausdruck3)                                           //Ausdruck1 ist der Anfangswert, Ausdruck2 ist der Endwert, Ausdruck3 bestimmt aus welchen Betrag der Zahler erhöht wird
            {
            //Anweisung
            }
             
             */

            for (int counter = 0; counter <= 20; counter++)                                  //Wird der Zähler 'counter' im Schleifenkopf deklariert, kann nur innerhan der Schleife darauf zugegriffen werden.
                Console.WriteLine(counter);
            //Console.WriteLine(counter);                                                   //Ein Aufruf ausserhalb der Schleife für zu einem Fehler




            //--------Initialisierung von Arrays in einer >>for<<-Schleife

            int[] liste;
            Console.WriteLine("Geben Sie den höchsten Array-Index ein: ");
            liste = new int[Convert.ToInt32(Console.ReadLine()) + 1];

            for (int i = 0; i < liste.Length; i++)
            {
                liste[i] = i * i;
                Console.WriteLine(liste[i]);
            }



            //--------Verschachtelte Schleifen
            /*'for'-Schleifen können beliebig verschachtelt werden. Im nächsten Beispiel wird gezeigt, wie 
             * eine verschachtelte Schleife dazu benutzt werden kann, um einen Baum beliebiger Größe zu erzeugen.
             * 
             1:     M
             2:    MMM
             3:   MMMMM
             4:  MMMMMMM
             5: MMMMMMMMM
             6:MMMMMMMMMMM
            */

            Console.WriteLine("Geben Sie die Anzahl der Stufen ein: ");
            int zeile = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= zeile; i++)
            {
                for (int j = 1; j <= zeile - i; j++)
                    Console.Write(" ");

                for (int j = 1; j <= i * 2 - 1; j++)
                    Console.Write("M");
                Console.WriteLine();
            }

            //--------Vorzeitiges Beenden einer Schleife mit >>break<<
            /*Es kann sich zur Laufzeit als erforderlich erweisen, nicht auf das Erfüllen der Abbruchbedingung zu warten, 
             * sondern den Schleifendurchlauf vorzeitig zu beenden. C# stellt ein Schlüsselwort zur Verfügung, das uns daszu 
             * in die Lage versetzt:'break'
             */
            for (int i = 0; i <= 10; i++)
            {
                if (i == 3)
                    break;                                                                  //'break' beendet sie Schleife und setzt den Programmablauf hinter dem 
                Console.WriteLine("Zähler = {0}", i);                                       //Anweisungsblock der 'for'-Schleife fort.
            }

            //--------Abbruch der Anweisung im Schleifenblock mit  >>continue<<
            /*Sehr ähnlich wie 'break' verhält sich auch die Anweisung 'continue'. Die Bearbeitung des Codes in der Schleife wird zwar
             * abgebrochen, aber die Steuerung wieder an den Schleifenkopf übergeben. Mit anderen Worten: Alle Anweisungen, die zwischen 
             * 'continue' und dem Ende des Anweisungsblocks stehen, werden übersprungen.
             */

            for (int i = 0; i <= 10; i++)
            {
                if (i == 3)
                    continue;
                Console.WriteLine("Zähler={0}", i);
            }

            //-------Endlosschleife
            //Fehlt ein Ausdruck, gilt er stehts als >>erfüllt<<
            //for (; ; )
            //    Console.WriteLine("...");                                                  //Mit der Tastenkombination Strg+Pause lässt sich die Laufzeitumgebung unterbrechen.

            //--------------------------------------------Die>>foreach<<-Schleife----------------------------------------------------------------------------
            //C# kennt noch ein weiteres Konstrukt, das ein Array vom ersten bis zum letzten Element durchläuft. Die 'foreach'-Schleife.

            int[] elements = { 2, 4, 6, 8 };
            foreach (int item in elements)                                                  //Eine Laufvariable nimmt temporär Elemente ein dessen Bezeichner('item') frei wählbar ist.
            {
                Console.WriteLine(item);
                //item = 33;                                                                //Die Laufvariable ist schreibgeschützt, kann also nicht verändert werden.(>>>Ausnahme sind Arrays von Objekten<<<)
            }






            //--------------------------------------------Die>>while<<-Schleife----------------------------------------------------------------------------
            /* In eine Schleife wird dann eingetreten, wenn bestimmte Bedingungen erfüllt sind. Bei der 'while'-Schleife wird diese Bedingung hinter dem 
             * Schlüsselwort 'while' in runden Klammern angegeben. 
             * ---------Kopfgesteuerte Schleife------------------*/

            Console.WriteLine("Geben sie eine Zahl zwischen\n0 und einschließlich 10 ein: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int Counter = 1;
            while (Counter <= number)                                                         //Die Bedingung in den Klammern muss ein booleschen Wert ergeben.
            {                                                                               //Ist die Bedingung bereits bei der ersten  Überprüfung 'false' wird die Anweisung gar nicht erst ausgeführt.

                if (Counter == 3)                                                           //Genau wie bei der 'for'-Schleife beendet 'continue' die aktuelle Iteration.
                {
                    Counter++;                                                              //Hier muss der 'Counter' um 1 erhöht werden, da der Wert sonst bei 9 bleibt und die Schleife nicht beendet werden kann.
                    continue;
                }

                if (Counter == 9)                                                           //Die Schleife wird mit dieser Bedingung beendet.
                    break;
                Console.WriteLine($"{Counter}. Schleifendurchlauf");
                Counter++;
            }



            //--------------------------------------------Die>>do<<-Schleife----------------------------------------------------------------------------
            /* Die 'do'-Schleife unterscheidet sich dahingehend von der 'while'-Schleife, dass die Schleifenbeingung am Ende der Schleife ausgewertet wird.
             * Die Folge ist, dass die Anweisung innerhalb des Anweisungsblocks zumindest einmal durchlaufen werden.
             *---------Fußgesteierte Schleife------------------*/

            Console.WriteLine("W - Programm fortsetzen");
            Console.WriteLine("E - Programm beenden");
            Console.WriteLine("----------------------");

            do
            {
                Console.WriteLine("Ihre Wahl: ");
                string eingabe = Console.ReadLine();

                if (eingabe == "W")
                    break;                                                                  //Die schleife wird beendet
                else if (eingabe == "E")
                    return;                                                                 //Das Programm wird beendet
                else
                {
                    Console.Write("Falsche Eingabe - ");
                    Console.Write("Neue Eingabe erforderlich\n");
                    Console.WriteLine("_______________________\n");
                }

            } while (true);                                                                 //Durch die Austrittbedingung 'while(true)' ist die Schleife als Endlosschleife konstruiert.
            Console.WriteLine("Programm läuft weiter...");

        }
    }
}