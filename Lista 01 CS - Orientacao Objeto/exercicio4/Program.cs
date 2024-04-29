

Vendedor vendedor = new Vendedor();
vendedor.nome = "joão";

Cliente cliente = new Cliente();
cliente.nome = "Gabi";

Produto produto = new Produto();
produto.nome = "Sanduiche";

Pedido pedido1 = new Pedido(cliente);
pedido1.adicionarProduto(produto);

Produto produto2 = new Produto();
produto2.nome = "Coca Cola";
pedido1.adicionarProduto(produto2);


pedido1.data = "29-04-2024";
pedido1.vendedor = vendedor;


////////////////////////////////////////////
Console.WriteLine("\n");
////////////////////////////////////////////


Console.WriteLine("Data: " + pedido1.data);
Console.WriteLine("Cliente: " + pedido1.cliente.nome);
Console.WriteLine("Garçom: " + pedido1.vendedor.nome);

foreach (var pro in pedido1.produtos)
{
    Console.WriteLine(pro.nome);
}
