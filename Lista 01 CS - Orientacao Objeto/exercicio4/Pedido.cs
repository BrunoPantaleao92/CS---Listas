// ./Pedido.cs

public class Pedido{

    public Cliente cliente{get; set;}
    public Vendedor vendedor{get; set;}
    public string data {get; set;}
    public List<Produto> produtos;

    public Pedido(Cliente cliente){
        this.cliente = cliente;
        this.produtos = new List<Produto>();

    }

    public void adicionarProduto(Produto produto){
        produtos.Add(produto);

    }


}