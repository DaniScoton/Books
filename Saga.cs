class Saga
{
    private List<Livro> livros = new List<Livro>();

    public Saga(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int TotalDePaginas => livros.Sum(livro => livro.Paginas);

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    public void ExibirLivrosDaSaga()
    {
        Console.WriteLine($"Lista de livros da saga {Nome}:\n");
        foreach (var livro in livros)
        {
            Console.WriteLine($"Livro: {livro.Nome}");
        }
        Console.WriteLine($"\nEsta saga possui: {TotalDePaginas} páginas\n");
    }
}
