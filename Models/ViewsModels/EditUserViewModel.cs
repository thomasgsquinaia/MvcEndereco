using CrudMvcEndereco.Models.Entidade;
using System.Collections.Generic;

namespace CrudMvcEndereco.Models.ViewsModels
{
    public class EditUserViewModel
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public int Tipo { get; set; }

        public ICollection<Estado> Estados { get; set; }

        public ICollection<Cidade> Cidades { get; set; }

    }
}
