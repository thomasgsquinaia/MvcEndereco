using System;
using System.Collections.Generic;

namespace CrudMvcEndereco.Models.Entidade
{
    public class Pais
    {
        public Pais()
        {
            Estados = new List<Estado>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataCadastro { get; set; }

        public virtual ICollection<Estado> Estados { get; set; }
    }
}
