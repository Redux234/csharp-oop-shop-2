using csharp_oop_shop_2;
using CSharpShop;

Acqua prodotto1 = new Acqua("Acqua", "Questa è acqua",  12.4, 3, 12, 3, "Monte Pallo");
Sacchetto prodotto2 = new Sacchetto("Sacchetto di frutta", "Questo è un sacchetto di frutta", 55, 99, 3, "mela");

List<Prodotto> prodotti = new List<Prodotto>();
prodotto1.StampaProdotto();
prodotto2.StampaProdotto();