using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class AnimalEstimacao
    {
        public Guid Id { get; set; }
        [ForeignKey("AnimalId")]
        public virtual Animal AnimalId { get; set; }

        [ForeignKey("EspecieId")]
        public virtual Especie EspecieId { get; set; }

        [ForeignKey("AbrigoId")]
        public virtual Abrigo AbrigoId { get; set; }

        [ForeignKey("FotoId")]
        public virtual Foto FotoId { get; set; }
        public string? Apelido { get; set; }
        public DateTime? DataNascimento { get; set; }
        public EnumSexo Sexo { get; set; }

        public enum EnumSexo {

            [Description("Masculino")]
            Masculino,
            [Description("Feminino")]
            Feminino
        }

        public string? Personalidade { get; set; }
        public string? Necessidades { get; set; }
        public bool Castrado { get; set; }
        public bool VacinacaoEmDia { get; set; }
        public string? OutrasInformacoes { get; set; }
        public EnumStatus Status { get; set; }

        public enum EnumStatus
        {

            [Description("Disponível")]
            Disponivel,
            [Description("Reservado")]
            Reservado,
            [Description("Adotado")]
            Adotado,
            [Description("Sobre cuidados médicos")]
            CuidadosMedicos

        }


    }
}
