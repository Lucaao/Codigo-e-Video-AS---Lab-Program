public class Biblioteca { // Classe Biblioteca criada
    private List<ItemBiblioteca> Colecao1; // Lista com a coleção 1
    public Biblioteca(){ // Construtor Biblioteca para iniciar a Coleção 1 como uma nova Lista da item biblioteca
        Colecao1 = new List<ItemBiblioteca>();
    }
    public void AdicionarItem(ItemBiblioteca item){ // Método para adicionar livro na coleção
        Colecao1.Add(item);
        Console.WriteLine($"O livro {item.Titulo} foi adicionado na biblioteca!");
    }
    public void RemoverItem(ItemBiblioteca item){ // Método para remover item da coleção
        Colecao1.Remove(item);
        Console.WriteLine($"O livro {item.Titulo} foi removido da biblioteca!");
    }
    public ItemBiblioteca? BuscarItemLivro(string titulo){ // Método para pesquisar livro utilizando o Titulo
        return Colecao1.Find(item => item.Titulo == titulo);
    }
    public ItemBiblioteca? BuscarItemLivro(int id){ // Sobrecarga de Método para pesquisar livro utilizando o ID
        return Colecao1.Find(item => item.Id == id);
    }
}