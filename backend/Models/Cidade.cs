using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Cidade
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        [ForeignKey("EstadoId")]
        public virtual Estado EstadoId { get; set; }
    }
}
