public class Livro : ItemBiblioteca{  // Classe Livro herdando propriedades da classe abstrata ItemBiblioteca
    public string Autor { get; set; }   // Propriedade da classe
    public Livro (int id, string titulo, string autor, string descricaointerna) : base (id, titulo){  // Construtor Livro para iniciar ID, titulo, Autor e herdar ID e titulo da classe base
        this.Autor = autor;                                                                           // e Inicializar a DescriçãoInterna
        DescricaoInterna = descricaointerna;
    }
    public void ExibirDescricaoInterna(){ // Método para exibir a descrição interna do livro desejado.
        Console.WriteLine($"A descrição do livro desejado é {DescricaoInterna}!"); 
    }
}