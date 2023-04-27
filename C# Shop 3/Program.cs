
using C__Shop_3;


Shop negozietto = new Shop("Trony", "roma", "via monte carmelo", 18);

Acqua acqua;

   acqua  = new Acqua("panna ", "acqua incredibile ", 1.25f, 1.5f, 11f, "everest");
   negozietto.AggiungereProdotto(acqua);




FruitBag fruitBag = new FruitBag("sacco di arance", "un sacchetto di arance", 3.30f, "spagna", 5);



negozietto.AggiungereProdotto(fruitBag);

Console.WriteLine("Prodotti in negozio");
Console.WriteLine(negozietto.ListaProdotti());


Console.WriteLine("Info del negozio");
Console.WriteLine(negozietto.getStringNegozio());

// #############################################################

//                           Acqua

Console.WriteLine("Qui le info dell'acqua presente in negozio : \n" +acqua.getStringProdotto());
double litriacqua = 0f;
Console.WriteLine("Descrizione");
Console.WriteLine(acqua.Description + "\n");
Console.WriteLine("Capacità");
Console.WriteLine(acqua.Liters + "\n");
Console.WriteLine("La svuoto");
acqua.Empty();
Console.WriteLine("\nI litri ora sono : " + acqua.Liters + "\n");

Console.Write("Riempio di :");
litriacqua = double.Parse(Console.ReadLine());
try
{
    acqua.Fill(litriacqua);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Inserisci un'altra quantità");
    litriacqua = double.Parse(Console.ReadLine());
    try
    {
        acqua.Fill(litriacqua);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
//acqua.getStringProdotto();
Console.WriteLine($"ora avrò : " +acqua.Liters + " litri");



// #############################################################
//               Sacchetto frutta

Console.WriteLine("info del Sacchetto di frutta.");
Console.WriteLine(fruitBag.getStringProdotto());

Console.Write("Me ne mangio : " + "\n");
int j;
j = int.Parse(Console.ReadLine());

Console.WriteLine("Ora ne avrò : \n");

fruitBag.Eat(j);

Console.WriteLine(fruitBag.Capacity);


