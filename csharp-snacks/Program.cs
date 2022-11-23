//Funzioni
static bool convalida() {
    bool ancora = true;
    bool valid = false;
    do {
        string letter = Console.ReadLine().ToLower();
        if (letter == "s" || letter == "n" || letter == "") {
            valid = true;
            if (letter == "s") {
                ancora = true;
            }
            else {
                ancora = false;
            }
        }
        else {
            Console.Write("Non è una scelta valida. Inserisci \"s\" o \"n\": ");
        }
    } while (!valid);
    return ancora;
}

static void grechetta() {
    Console.WriteLine("\n~ ~ ~\n");
}

// Snack 1
static void snack1() { 
    string[] mesi = { "Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre" };
    foreach (string v in mesi) {
        Console.WriteLine(v);
    }
}

// Snack 2
static void snack2() { 
string[] nomi = { "Paolo", "Laura", "Giovanni", "Mario", "Laura" };
    for (int i = 0; i< nomi.Length; i++) {
        string nomeEstratto = nomi[i];
        if(nomeEstratto == "Laura") {
            nomi[i] = "Marco";
        }
    }


    foreach (string v in nomi) {
        Console.WriteLine(v);
    }
}


// Snack 3
static void snack3() {
    int[] numeri = { 4, 7, 2, 6, 1, 2, 7, 3, 9, 0, 3, 4, 5 };
    for (int j = 0; j < numeri.Length; j++) {
        int v = numeri[j];
        switch (v % 2) {
            case 0:
                Console.WriteLine("Il numero " + v + " è pari.");
                break;
            default:
                Random rng = new Random();
                int numerodispari = v;
                int randomizzatore = rng.Next(1, 3);
                switch (randomizzatore % 2) {
                    case 1:
                        numerodispari++;
                        break;
                    default:
                        numerodispari--;
                        break;
                }
                numeri[j] = numerodispari;
                Console.WriteLine("Il numero " + v + " è dispari. Te lo cambio in pari: " + numerodispari);
                break;
        }
    }

    foreach (int v in numeri) {
        Console.Write(v + " ");
    }
    Console.Write("\n");
}

// Snack 4
static void snack4() {
    bool ancora = false;
    do {
        Console.Write("Inserisci una parola: ");
        string parola1 = Console.ReadLine();
        Console.Write("Inserisci un'altra parola: ");
        string parola2 = Console.ReadLine();
        if (parola1.Length > parola2.Length) {
            Console.WriteLine("La parola più lunga è " + parola1);
        }
        else if (parola1.Length < parola2.Length) {
            Console.WriteLine("La parola più lunga è " + parola2);
        }
        else {
            Console.WriteLine("Le due parole sono lunghe uguali.");
        }
        Console.Write("Ancora? (s/N): ");
        ancora = convalida();
    } while (ancora);
}

// Snack 5
static void snack5() {
    Random errennegi = new Random();
    float nVirgolaRandom = errennegi.NextSingle(); // Single per i float, double per i double
    int nInteroRandom = (int)(nVirgolaRandom * 120);
    Console.WriteLine("Sarà un multiplo di 3? (s/N): ");
    bool risposta = convalida();
    if ((risposta && nInteroRandom % 3 == 0) || (!risposta && nInteroRandom % 3 != 0)) {
        Console.Write("Esatto!");
    }
    else {
        Console.Write("Sbagliato!");
    }
    if (nInteroRandom % 3 == 0) {
        Console.Write($" Il numero random è un multiplo di 3! ({nInteroRandom})");
    }
    else {
        Console.Write($" Il numero random non è un multiplo di 3! ({nInteroRandom})");
    }
}

// Scegliere cosa eseguire
Console.Write("Scegli lo snack da eseguire (1-5) o termina il programma scrivendo qualcos altro: ");
string sceltaSnack = Console.ReadLine();
switch (sceltaSnack) {
    case "1":
        snack1();
        grechetta();
        break;
    case "2":
        snack2();
        grechetta();
        break;
    case "3":
        snack3();
        grechetta();
        break;
    case "4":
        snack4();
        grechetta();
        break;
    case "5":
        snack5();
        grechetta();
        break;
    default:
        Console.WriteLine("バイバイ！");
        break;
}