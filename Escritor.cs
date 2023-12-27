class Escritor
{
    private List<Saga> sagas = new List<Saga>();

    public Escritor(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }

    public void AdicionarSaga(Saga saga)
    {
        sagas.Add(saga);
    }

    public void ExibirBiografia()
    {
        Console.WriteLine($"Biografia do autor {Nome}:");
        foreach (Saga saga in sagas)
        {
            Console.WriteLine($"Saga: {saga.Nome} ({saga.TotalDePaginas} páginas)");
        }
    }
}
