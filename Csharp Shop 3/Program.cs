using Csharp_shop_3;
using Csharp_Shop_3.CustomException;

List<Prodotto> list = new List<Prodotto>();

Acqua BottigliaAcqua = new Acqua("Bottiglia d'Acqua", "Una fin troppo comune bottiglia d'acqua naturale da 1.5L.", 1.5, 7, "Sorgente reale di Frosinone", 15, 22);
list.Add(BottigliaAcqua);
BottigliaAcqua.stampaTutto();

SacchettoDiFrutta SacchettoDiFrutta = new SacchettoDiFrutta("Bustina di noci", "Una busta di frutta secca contenente noci", "Noci", 300, 0.30d, 22);
list.Add(SacchettoDiFrutta);
SacchettoDiFrutta.stampaTutto();

Elettrodomestico Lavatrice = new Elettrodomestico("Lavatrice Belkin MkII", "Lavatrice Belkin in grado di lavare veramente tutto tutto",
    "Lavatrice multifunzione", 900, "A++", 1750, 22);
Lavatrice.stampaTutto();
list.Add(Lavatrice);

// Primo try catch per testare l' overflow della bottiglia
try
    {
    BottigliaAcqua.beviAcqua(0.7);

    BottigliaAcqua.aggiungiAcqua(0.8);

    BottigliaAcqua.stampaTutto();
    }
catch(TroppaAcquaException e)
    {
    Console.WriteLine(e.message);
    }

// Secondo try catch dove testo lo svuotamento della bottiglia
    Console.WriteLine("\n");
try
    {
    BottigliaAcqua.beviAcqua(1.7);
    }
catch(BevutaAcquaException e)
    { 
    Console.WriteLine(e.message); 
    }

// Metodo conversione litri a galloni
   
Console.WriteLine("\n");
BottigliaAcqua.converti(1.2);




Console.WriteLine(list.Count());

