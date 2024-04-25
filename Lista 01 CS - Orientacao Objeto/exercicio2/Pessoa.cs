// ./Pessoa.cs

public class Pessoa
{
    public string cpf{get; set;}

    public string nome{get; set;}

    public List<Livro> Livros = new List<Livro>();



    public void adicionarLivro(Livro l){
        this.Livros.Add(l);
    }

}