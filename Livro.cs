class Livro
{
    public Livro(Escritor escritor, string nome)
    {
        Escritor = escritor;
        Nome = nome;
    }

    public string Nome { get; }
    public Escritor Escritor { get; }
    public int Paginas { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida => $"O livro {Nome} pertence ao autor {Escritor.Nome}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Escritor: {Escritor.Nome}");
        Console.WriteLine($"Páginas: {Paginas}");
        Console.WriteLine(Disponivel ? "Disponível no plano.\n" : "Adquira o plano Livros+.\n");
    }
}
