public abstract class ItemBiblioteca { // Classe ABSTRATA ItemBiblioteca criada.
    public int Id { get; set; }    // Propriedades da classe 
    public string Titulo { get; set; }   // Propriedades da classe 
    protected string DescricaoInterna { get; set; }   // Propriedades da classe 
    public ItemBiblioteca(int id, string titulo){ // Construtor ItemBiblioteca para iniciar ID, TITULO e dar uma descrição interna BASE.
        this.Id = id;
        this.Titulo = titulo;
        DescricaoInterna = "Base";
    }
}