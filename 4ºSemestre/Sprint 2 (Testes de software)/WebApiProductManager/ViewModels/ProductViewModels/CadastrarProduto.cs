using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiProductManager.ViewModels.ProductViewModels
{
    public class CadastrarProduto
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}
