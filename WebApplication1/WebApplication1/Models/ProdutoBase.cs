using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ProdutoBaseVm
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe o nome do produto.")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage ="Informe o valor")]
        public float Price { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Informe a quantidade")]
        public int qtd { get; set; }
    }
}