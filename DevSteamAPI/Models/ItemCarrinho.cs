using System.ComponentModel.DataAnnotations;

namespace DevSteamAPI.Models
{
    public class ItemCarrinho
    {
        public Guid ItemCarrinhoId { get; set; }
        public Guid CarrinhoId { get; set; }
        public Guid JogoId { get; set; }

        [Required(ErrorMessage = "O Campo é Obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = "A Quantidade deve ser maior que 0")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "O Campo é Obrigatório")]
        [Range(0.01, 9999.99, ErrorMessage = "O Valor deve ser maior que 0 e menor que R$ 9.999,00")]
        public decimal Valor { get; set; }
        public decimal Total { get; set; }

    }
}
