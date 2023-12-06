Livro L1 = new Livro(1, "As Aventuras de Pi", "Paulo Brito", "Aventura e Exploração"); // Livro criado com suas propriedades

Livro L2 = new Livro(2, "As Vantagens de Ser Invisivel", "Paola Carossela", "Love & Fiction: As Vantagens de Ser Invisivel"); // Livro criado com suas propriedades

Livro L3 = new Livro(3, "O Menino Maluquinho", "Antogdo", "Arruaça e Aventura"); // Livro criado com suas propriedades

Biblioteca B1 = new Biblioteca(); // Biblioteca criada
B1.AdicionarItem(L1); // Item adicionado a biblioteca
B1.AdicionarItem(L2); // Item adicionado a biblioteca
B1.AdicionarItem(L3); // Item adicionado a biblioteca

ItemBiblioteca? LivroEncontradoPorTitulo = B1.BuscarItemLivro("O Menino Maluquinho"); // Pesquisar Livro por Titulo
if(LivroEncontradoPorTitulo != null){
    Livro livroEncontrado = (Livro)LivroEncontradoPorTitulo;
    livroEncontrado.ExibirDescricaoInterna(); // Mostra a descrição do livro encontrado pelo Titulo
}

ItemBiblioteca? LivroEncontradoPorId = B1.BuscarItemLivro(1); // Pesquisar Livro por ID
if(LivroEncontradoPorId != null){
    Livro livroEncontrado = (Livro)LivroEncontradoPorId;
    livroEncontrado.ExibirDescricaoInterna(); // Mostra a descrição do livro encontrado pelo Titulo
}

B1.RemoverItem(L1); // Item removido da biblioteca
B1.RemoverItem(L2); // Item removido da biblioteca
B1.RemoverItem(L3); // Item removido da biblioteca