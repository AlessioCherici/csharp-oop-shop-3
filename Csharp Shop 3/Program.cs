using Csharp_shop_2;


List<Prodotto> list = new List<Prodotto>();

Acqua BottigliaAcqua = new Acqua("Bottiglia d'Acqua", "Una fin troppo comune bottiglia d'acqua naturale da 1.5L.", 1.5, 7, "Sorgente reale di Frosinone", 15, 22);

BottigliaAcqua.stampaTutto();

SacchettoDiFrutta SacchettoDiFrutta = new SacchettoDiFrutta("Bustina di noci", "Una busta di frutta secca contenente noci", "Noci", 300, 0.30d, 22);

SacchettoDiFrutta.stampaTutto();

Elettrodomestico Lavatrice = new Elettrodomestico("Lavatrice Belkin MkII", "Lavatrice Belkin in grado di lavare veramente tutto tutto",
    "Lavatrice multifunzione", 900, "A++", 1750, 22);

Lavatrice.stampaTutto();

// Svuoto la bottiglia
BottigliaAcqua.svuotaBottiglia();

//Aggiungo un litro d'acqua alla bottiglia
BottigliaAcqua.refillBottigliaUtente(1);

//Bevo 0.3L dalla bottiglia *slurp*
BottigliaAcqua.beviAcqua();

//Stampo il risultato delle operazioni precedenti, ora la bottiglia dovrebbe avere dentro 0.7 L
Console.WriteLine("La bottiglia ora contiene " + BottigliaAcqua.GetLitri() + " L");