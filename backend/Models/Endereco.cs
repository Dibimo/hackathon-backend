using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Endereco
    {
        public Guid Id { get; set; }
        [ForeignKey("CidadeId")]
        public virtual Cidade CidadeId { get; set; }
        public string? Cep { get; set; }
        public string? Nome { get; set; }
        public string? Bairro { get; set; }
        public string? NumeroEndereco { get; set; }
        public string? Complemento { get; set; }
        public string? Referencia { get; set; }
    }
}
