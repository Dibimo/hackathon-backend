using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        [ForeignKey("EnderecoId")]
        public virtual Endereco EnderecoId { get; set; }
        public string Senha { get; set; }

    }
}
