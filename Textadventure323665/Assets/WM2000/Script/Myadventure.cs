    using System.Collections.Generic;
    using System.Collections;
    using UnityEngine;

    public class Myadventure : MonoBehaviour {

        private enum States {
            start,
            intro,
            delen,
            deelnee,
            deelja,
            woonkamer,
            Gesprek,
            schuur,
            zolder,
            Dood,
            Slaapkamer,
            keuken,
            Droom,
            boven
        }
        private States currentState = States.start;

        // Start is called before the first frame update
        void Start () {
            Terminal.ClearScreen ();
            print ("hello world");
            Terminal.WriteLine ("Druk een knop in om te typen");
            ShowMainMenu ();
        }
        void ShowMainMenu () {
            Terminal.WriteLine ("Welkom bij HorrorNite");
            Terminal.WriteLine ("Dit is gebaseerd op een waargebeurd verhaal");
            Terminal.WriteLine ("Type start om te beginnen");
        }

        // Update is called once per frame
        void Update () {

        }

        void OnUserInput (string input) {
            switch (currentState) {
                case States.start:
                    if (input == "start") {
                        StartIntro ();
                    } else if (input == "1337") {
                        Terminal.WriteLine ("Jij bent leet!");
                    } else {
                        Terminal.WriteLine ("Je moet start typen om te beginnen joh!");
                    }
                    break;
                case States.intro:
                    if (input == "verder") {
                        gegevensdelen ();
                    }
                    break;

                case States.delen:
                    if (input == "ja") {
                        deelja ();
                    } else if (input == "nee") {
                        deelnee ();
                    }
                    break;

                case States.deelnee:
                    if (input == "REN") {
                        woonkamer ();
                    }
                    break;

                case States.deelja:
                    if (input == "verder") {
                        Gesprek ();
                    }
                    break;

                case States.Gesprek:
                    if (input == "tuin") {
                        schuur ();
                    } else if (input == "zolder") {
                        zolder ();
                    }
                    break;

                case States.schuur:
                    if (input == "liggen") {
                        Dood ();
                    } else if (input == "REN") {
                        Slaapkamer ();
                    }
                    break;

                case States.Dood:
                    if (input == "start") {
                        Start ();
                    }
                    break;

                case States.Slaapkamer:
                    if (input == "Verder") {
                        Droom ();
                    }
                    break;

                case States.woonkamer:
                    if (input == "keuken") {
                        keuken ();
                    } else if (input == "Boven") {
                        boven ();
                    }
                    break;


            }

        }
        void StartIntro () {
            Terminal.ClearScreen ();
            Terminal.WriteLine ("Het is vrijdagavond, en je ouders hebben een datenight");
            Terminal.WriteLine ("Gelukkig is ook je zusje logeren bij haar vriendje");
            Terminal.WriteLine ("Hierdoor kan je ongestoord de hele nacht gamen");
            Terminal.WriteLine ("Typ verder om door te gaan!");
            currentState = States.intro;

        }

        void gegevensdelen () {
            Terminal.ClearScreen ();
            Terminal.WriteLine ("Je krijgt de vraag van een andere speler om je discord nickname te delen");
            Terminal.WriteLine ("Wil je dit doen?");
            Terminal.WriteLine ("Typ ja om te delen of nee om niet te delen");
            currentState = States.delen;
        }
        // HIER BEGINT ALLES VANAF JA
        void deelja () {
            Terminal.ClearScreen ();
            Terminal.WriteLine ("Je deelt je gegevens en krijgt een call binnen.");
            Terminal.WriteLine ("Je neemt op en hoort een diepe stem");
            Terminal.WriteLine ("die zegt: I can see you");
            Terminal.WriteLine ("Typ verder om verder te gaan!");
            currentState = States.deelja;
        }

        void Gesprek () {
            Terminal.ClearScreen ();
            Terminal.WriteLine ("Je vraagt wat de man bedoeld");
            Terminal.WriteLine ("Hij zegt: De voordeur open laten is niet zo handig");
            Terminal.WriteLine ("je draait je om en rent je gamekamer uit!");
            Terminal.WriteLine ("Je rent de woonkamer in.");
            Terminal.WriteLine ("Typ zolder om naar zolder te gaan of typ tuin om naar de tuin te gaan");
            currentState = States.Gesprek;
        }

        void schuur () {
            Terminal.ClearScreen ();
            Terminal.WriteLine ("Je rent de tuin in");
            Terminal.WriteLine ("en zoekt een verstopplek in het schuurtje.");
            Terminal.WriteLine ("Je gaat onder een Kano boot liggen die in de schuur ligt.");
            Terminal.WriteLine ("De schuurdeur wordt open gegooid en je hoort voetstappen steeds dichter bij je.");
            Terminal.WriteLine ("Typ 'REN' om uit de schuur te rennen typ 'liggen' om te blijven liggen!");
            currentState = States.schuur;
        }

        

        void zolder () {
            Terminal.ClearScreen ();
            Terminal.WriteLine ("Je rent de trap op en verstopt je op de zolder!");
            Terminal.WriteLine ("Je gaat achter een oude bank liggen.");
            Terminal.WriteLine ("Je valt in slaap en wordt tot de volgende ochtend niet wakker.");
            Terminal.WriteLine ("Je loopt zachtjes naar beneden en ziet je ouders aan tafel zitten.");
            Terminal.WriteLine ("Er lijkt niks aan de hand en de vriendschap op discord is ook verwijderd!");
            //Je wint
            Terminal.WriteLine ("Je hebt het overleefd!!");
            currentState = States.zolder;
        }
        //Dood
        void Dood () {
            Terminal.ClearScreen ();
            Terminal.WriteLine ("Je blijft liggen, Maar de man tilt de kanoboot op.");
            Terminal.WriteLine ("Hij pakt je bij de kraag  tilt je op en gooit je weer op de grond");
            Terminal.WriteLine ("Met zijn mes snijdt hij langzaam je keel open!");
            Terminal.WriteLine ("JE BENT DOOD!");
            Terminal.WriteLine ("GAME-OVER! Typ 'start'om opnieuw te beginnen");
            currentState = States.Dood;
        }
        
        void Slaapkamer () {
            Terminal.ClearScreen ();
            Terminal.WriteLine ("je gooit de kanoboot van je af.");
            Terminal.WriteLine ("De kanoboot valt op de voet van de man en je rent snel de schuur uit");
            Terminal.WriteLine ("Je rent door de woonkamer naar de trap en rent de trap op");
            Terminal.WriteLine ("Je rent je kamer in en doet je deur op slot.");
            Terminal.WriteLine ("Typ 'Verder' om door te gaan");
            currentState = States.Slaapkamer;
        }
        void Droom () {
            Terminal.ClearScreen ();
            Terminal.WriteLine ("Je gaat op bed zitten wacht af wat er gaat gebeuren.");
            Terminal.WriteLine ("Je wordt moe en langzaam vallen je ogen dicht");
            Terminal.WriteLine ("De volgende ochtend wordt je wakker.");
            Terminal.WriteLine ("Je ligt netjes in bed en alles beneden staat ook netjes.");
            Terminal.WriteLine ("Het blijkt een droom te zijn want ook het vriendschapsverzoek is er niet!");
            Terminal.WriteLine ("Je hebt het overleefd!");
            currentState = States.Droom;
        }

        // HIER BEGINT ALLES VANAF NEE
        void deelnee () {
            Terminal.ClearScreen ();
            Terminal.WriteLine ("Je wijst het verzoek af.");
            Terminal.WriteLine ("Je loopt richting de keuken om een glas melk te halen");
            Terminal.WriteLine ("Ineens krijg je een berichtje op discord");
            Terminal.WriteLine ("in het berichtje staat: Hoop dat alles op slot en dicht zit");
            Terminal.WriteLine ("Je schrikt je rot en rent naar de woonkamer");
            Terminal.WriteLine ("typ REN om naar de woonkamer te gaan!");
            currentState = States.deelnee;
        }

        void woonkamer () {
            Terminal.ClearScreen ();
            Terminal.WriteLine ("Je checkt je ramen en ziet dat ze dicht zitten.");
            Terminal.WriteLine ("Alles zit op slot denk je todat je bij de voordeur komt.");
            Terminal.WriteLine ("De voordeur staat op een kiertje");
            Terminal.WriteLine ("Je rent naar de deur en gooit hem dicht");
            Terminal.WriteLine ("Je hoor dingen vallen in de keuken");
            Terminal.WriteLine ("Typ Keuken om naar de keuken te gaan of Typ Boven om naar boven te gaan");
            currentState = States.woonkamer;
        }
            //Dood
          void keuken () {
            Terminal.ClearScreen ();
            Terminal.WriteLine ("Je rent de keuken in en pakt een mes");
            Terminal.WriteLine ("Je gaat achter de bank zitten.");
            Terminal.WriteLine ("Je ziet de man naar binnen lopen en wacht op het goeie moment en springt achter de bank vandaan.");
            Terminal.WriteLine ("Je rent op hem af en probeert hem te steken.");
            Terminal.WriteLine ("Maar hij draait zich precies optijd om en steekt jou neer.");
            Terminal.WriteLine ("Je bent dood!");
            currentState = States.keuken;
        }
        void boven () {
            Terminal.ClearScreen ();
            Terminal.WriteLine ("Je rent naar boven.");
            Terminal.WriteLine ("Je pakt de trap naar zolder en verstopt je daar");
            Terminal.WriteLine ("Je ziet een oud mes liggen wat van je opa was.");
            Terminal.WriteLine ("De man komt op zolder en je bent doodstil.");
            Terminal.WriteLine ("Hij draait met ze rug naar je toe en je steekt hem in de rug");
            Terminal.WriteLine ("Je hebt het overleefd");
            currentState = States.boven;
        }



    }