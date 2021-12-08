using CrudMvcEndereco.Models.Entidade;
using System.Collections.Generic;

namespace CrudMvcEndereco.Models.Repositorio
{
    public interface IUsuarioRepositorio
    {
        IEnumerable<Usuario> BuscarTodos();
        Usuario BuscarPorId(int id);
        IEnumerable<Usuario> BuscarPorNome();
        Usuario Atualiza(Usuario usuario);
        void DeletaUsuario(Usuario usuario);

    }
}
