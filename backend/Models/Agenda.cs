using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Agenda
    {
        public Guid Id { get; set; }
        [ForeignKey("AbrigoId")]
        public virtual Abrigo AbrigoId { get; set; }

        [ForeignKey("UsuarioId")]
        public virtual Usuario UsuarioId { get; set; }

        [ForeignKey("AnimalEstimacaoId")]
        public virtual AnimalEstimacao AnimalEstimacaoId { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fim { get; set; }

    }
}
