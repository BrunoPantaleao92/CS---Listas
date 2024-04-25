
Pessoa pessoa = new Pessoa();
pessoa.nome = "Bruno";
pessoa.cpf = "088.048.999-30";

Livro livro = new Livro();
livro.autor = "Machado de Assis";
livro.titulo = "Memórias postumas";
pessoa.adicionarLivro(livro);

livro = new Livro();
livro.autor = "Douglas Adams";
livro.titulo = "O guia do mochileiro das galaxias";
pessoa.adicionarLivro(livro);





Console.WriteLine(pessoa.nome);

Console.WriteLine("################");

foreach (var l in pessoa.Livros){
    Console.WriteLine(l.titulo + " - " + l.autor);
    Console.WriteLine("################");


}