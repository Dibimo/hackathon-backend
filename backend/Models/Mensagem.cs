using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Mensagem
    {
        public Guid Id { get; set; }
        public string? Descricao { get; set; }

        [ForeignKey("AbrigoId")]
        public virtual Abrigo AbrigoId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario UsuarioId{ get; set; }
        public DateTime? DataEnvio { get; set; }

    }
}
