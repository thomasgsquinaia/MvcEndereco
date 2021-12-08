using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMvcEndereco.Models.Entidade
{
    [Table("Usuario")]
    public class Usuario
    {
        
        [Key]
        [Display(Description = "Codigo")]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Description = "Nome")]
        public string Nome { get; set; }

        [Display(Description = "Idade")]
        public int Idade { get; set; }

        [Display(Description = "Tipo de usuário")]
        public int Tipo { get; set; }

        [ForeignKey("Cidade")]
        public int CidadeId { get; set; }

        public Cidade Cidade { get; set; }
    }
}
