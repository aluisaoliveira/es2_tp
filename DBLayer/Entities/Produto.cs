using System.ComponentModel.DataAnnotations;

namespace ESOF.WebApp.DBLayer.Entities;

public class Produto
{
    public Guid ProdutoId { get; set; }
    
    [Required]
    public string Nome { get; set; }
    
    [Required]
    public string Descricao { get; set; }
    
    [Required]
    public double Preco { get; set; }
    
    [Required]
    public int QuantidadeStock { get; set; }
    
    public ICollection<Categoria> Categorias { get; set; }
}