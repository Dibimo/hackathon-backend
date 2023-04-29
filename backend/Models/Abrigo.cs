﻿using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class Abrigo
    {
        public Guid Id { get; set; }
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Cnpj { get; set; }
        [ForeignKey("EnderecoId")]
        public virtual Endereco EnderecoId { get; set; }
        public string? Informacoes { get; set; }
        public string? Responsavel { get; set; }

    }
}
