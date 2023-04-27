
using C__Shop_3;


Shop negozietto = new Shop("Trony", "roma", "via monte carmelo", 18);

Acqua acqua = new Acqua("panna ", "acqua incredibile ", 1.25f, 1.5f, 1.3f, "everest");
FruitBag fruitBag = new FruitBag("sacco di arance", "un sacchetto di arance", 3.30f, "spagna", 5);


negozietto.AggiungereProdotto(acqua);
negozietto.AggiungereProdotto(fruitBag);

Console.WriteLine("Prodotti in negozio");
Console.WriteLine(negozietto.ListaProdotti());


Console.WriteLine("Info del negozio");
Console.WriteLine(negozietto.getStringNegozio());

// #############################################################
//               Acqua


int i = 0;
Console.WriteLine("Descrizione");
Console.WriteLine(acqua.Description);
Console.WriteLine("Capacità");
Console.WriteLine(acqua.Liters);
Console.WriteLine("La svuoto");
acqua.Empty();
Console.Write("Riempio di ");
i = int.Parse(Console.ReadLine());
acqua.Fill(i);
acqua.getStringProdotto();



// #############################################################
//               Sacchetto frutta

Console.WriteLine("info del prodotto.");
Console.WriteLine(fruitBag.getStringProdotto());

Console.Write("Me ne mangio : " + "\n");

i = int.Parse(Console.ReadLine());

Console.WriteLine("Ora ne avrò : \n");

fruitBag.Eat(i);

Console.WriteLine(fruitBag.getStringProdotto());


