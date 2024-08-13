using CursoPOO;

//CarrinhoItem bola = new CarrinhoItem();
//Item bola = Item.CriarBola();

Cesta cesta = new Cesta();

Item bola = new Item("Bola de Futebol", 90M);
cesta.Itens.Add(bola);

Item camiseta = new Item("Camiseta Oficial SP", 350M);
cesta.Itens.Add(camiseta);

foreach (var item in cesta.Itens) 
{
    Console.WriteLine($"{item.Nome}: {item.TotalFormatado}");
}

Console.ReadLine();