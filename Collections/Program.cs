using CsharpShop2;

// ----------- HASHSET ---------------

HashSet<int> evenNumbers = new HashSet<int>();
HashSet<int> oddNumbers = new HashSet<int>();

oddNumbers.Add(1);
oddNumbers.Add(3);
oddNumbers.Add(1); //non verrà calcolato perchè è duplicato
oddNumbers.Add(5);

evenNumbers.Add(2);
evenNumbers.Add(4);
evenNumbers.Add(6);



Console.WriteLine($"Il numero di elementi contenuti in oddNumbers è {oddNumbers.Count}");
// Pur avendo 4 numeri il .count mi riporta 3 perchè un valore è duplicato

if (oddNumbers.Contains(1)) // per vedere se un elemento è contenuto nell'HashSet
{
    Console.WriteLine("Il numero 1 è presente nell' HashSet");
} else
{
    Console.WriteLine("Il numero 1 non è presente");
}

oddNumbers.Remove(1);  // Per rimuovere un elemento

    if (oddNumbers.Contains(1)) // per vedere se un elemento è contenuto nell'HashSet
{
    Console.WriteLine("Il numero 1 è presente nell' HashSet");
}
else
{
    Console.WriteLine("Il numero 1 non è presente");
}

oddNumbers.Clear();
Console.WriteLine($"Il numero di elementi contenuti in oddNumbers è {oddNumbers.Count}");
// Mi svuota l'HashSet


// ----------- LIST ---------------

List<int> listaDiNumeriDispari = new List<int>();
listaDiNumeriDispari.Add(1);
listaDiNumeriDispari.Add(3);
listaDiNumeriDispari.Add(3);
listaDiNumeriDispari.Add(7);
listaDiNumeriDispari.Add(5);
listaDiNumeriDispari.Add(5);

listaDiNumeriDispari.Sort();

// STAMPIANO LA LISTA DI NUMERI 

foreach(int numero in listaDiNumeriDispari)
{
    Console.WriteLine(numero);
}


int indiceElementoSette = listaDiNumeriDispari.IndexOf(7);

Console.WriteLine("A che indice è finito l'elemento 7?");
Console.WriteLine($"L'elemento 7 è all'indice {indiceElementoSette}");


if (listaDiNumeriDispari.Contains(1)) // per vedere se un elemento è contenuto nell'HashSet
{
    Console.WriteLine("Il numero 1 è presente nella lista");
}
else
{
    Console.WriteLine("Il numero 1 non è presente");
}

Console.WriteLine($"L'elemento alla posizione indice 2 (terzo elemento) è: {listaDiNumeriDispari[2]}");


// --- Posso lavorare anche con le mie classi 

List<Prodotto> listaDiProdotti = new List<Prodotto>();

// Creo i miei prodotti
Prodotto prodotto1 = new Prodotto("frigorifero", "mi permette di tenere il cibo fresco", 699, 22);
Prodotto prodotto2 = new Prodotto("fagioli", "borlotti", 2, 14);

// Aggiungo i prodotti
listaDiProdotti.Add(prodotto1);
listaDiProdotti.Add(prodotto2);

// Aggiungo in line un prodotto alla lista
listaDiProdotti.Add(new Prodotto("succo di frutta", "sacchetto contenente della frutta", 4, 6));


bool trovato = false;

foreach(Prodotto prodotto in listaDiProdotti)
{
    if (prodotto.GetNome("fagioli") == "fagioli")
    {
        trovato = true;
    }
}





foreach (Prodotto prodottoNellaLista in listaDiProdotti) // bosogna toglierlo (stampaProdotto()) dal console.writeLine
{
    //Console.WriteLine(prodottoNellaLista.StampaProdotto());
}





// Per vedere se un elemento esiste nella lista
bool FrigoriferoPresente = listaDiProdotti.Exists(x => x.GetNome("frigorifero") == "frigorifero");
bool FrigoriferoPresente2 = listaDiProdotti.Exists(x => x.GetDescrizione("cibo") == "cibo"); // se c'è la parola cibo nella descrizione

// se voglio chiedere all'utente di aggiungre prodotti posso fare un ciclo for per ogni elemento



// ---------- DIZIONARIO DI PERSONA AL NUMERO DI TELEFONO ---------

Dictionary<string, long> rubrica = new Dictionary<string, long>();
rubrica.Add("Mauro", 345678975);
rubrica.Add("Marco", 3455484875);
rubrica.Add("Francesco", 3485745595);


foreach(KeyValuePair<string, long> elementoDellaRubrica in rubrica)
{
    Console.WriteLine($"La chiave è: {elementoDellaRubrica.Key}");
    Console.WriteLine($"I valore dell'elemento è: {elementoDellaRubrica.Value}");
}


Console.WriteLine($"Dimmi il numero di Marco: {rubrica["Marco"]}");
rubrica["Marco"] = 3866846686;
Console.WriteLine($"Dimmi il numero di Marco: {rubrica["Marco"]}");

// Rimouovere un elemento
rubrica.Remove("Marco");

Dictionary<string, Prodotto> dizionarioDiProdottiPreferiti = new Dictionary<string, Prodotto>();
dizionarioDiProdottiPreferiti.Add("Marco", prodotto1);
dizionarioDiProdottiPreferiti.Add("Laura", prodotto2);

foreach (KeyValuePair<string, Prodotto> elementoListaProdottiPreferiti in dizionarioDiProdottiPreferiti)
{
  //  Console.WriteLine($"La chiave è ")
}



// ---------- DATETIME ----------

DateTime dataEOraAttuale = DateTime.Now;
Console.WriteLine(dataEOraAttuale);

Console.Write("Inserisci una data: ");
string dataInserita = Console.ReadLine();
DateTime dataUtente = DateTime.Parse(dataInserita);

if(dataUtente > dataEOraAttuale)
{
    Console.WriteLine("La data che hai inserito sta nel futuro");
} else if (dataUtente == dataEOraAttuale)
{
    Console.WriteLine("La data che hai inserito è oggi");
} else
{
    Console.WriteLine("La data che hai inserito è nel passato");
}

Console.WriteLine(dataUtente);

DateTime dataTraDieciMinuti = dataUtente.AddMinutes(10);
Console.WriteLine($"L'ora fra 10 minuti sarà {dataTraDieciMinuti}");
DateTime dataTraDieciGiorni = dataUtente.AddDays(10); // Mettendo un numero negativo posso sottrarre giorni/ore/mesi/minuti ecc...
Console.WriteLine($"La data fra 10 giorni sarà {dataTraDieciGiorni}");