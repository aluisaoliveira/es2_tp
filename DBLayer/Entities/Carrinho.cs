using System.ComponentModel.DataAnnotations;

namespace ESOF.WebApp.DBLayer.Entities;

public class Carrinho
{
    public Guid CarrinhoId { get; set; }
    
    [Required]
    public string Nome { get; set; }
    
    [Required]
    public DateTime Data { get; set; }
    
    [Required]
    public double Total { get; set; }
    
    [Required]
    public double PrecoUnitario { get; set; }

    public ICollection<User> Users { get; set; }
    public ICollection<Produto> Produtos { get; set; }
    
}