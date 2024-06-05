using System.ComponentModel.DataAnnotations;

namespace ESOF.WebApp.DBLayer.Entities;

public class Categoria
{
    public Guid CategoriaId { get; set; }
    
    [Required]
    public string Nome { get; set; }
}