using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMvcEndereco.Models.Entidade
{
    [Table("Cidade")]
    public class Cidade
    {
        public Cidade()
        {
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }

        [ForeignKey("Estado")]
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }

        public ICollection<Cidade> Cidades { get; set; }
    }
}
