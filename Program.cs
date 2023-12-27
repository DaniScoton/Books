Escritor rowling = new Escritor("J. K. Rowling");
Saga sagaRowling = new Saga("Harry Potter");

Livro livro1 = new Livro(rowling, "Harry Potter e a pedra filosofal")
{
    Paginas = 208,
    Disponivel = true,
};

Livro livro2 = new Livro(rowling, "Harry Potter e a camara secreta")
{
    Paginas = 224,
    Disponivel = false,
};

sagaRowling.AdicionarLivro(livro1);
sagaRowling.AdicionarLivro(livro2);
rowling.AdicionarSaga(sagaRowling);

livro1.ExibirFichaTecnica();
livro2.ExibirFichaTecnica();
sagaRowling.ExibirLivrosDaSaga();
rowling.ExibirBiografia();
