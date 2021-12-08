using CrudMvcEndereco.Models.Entidade;
using System.Collections.Generic;
using CrudMvcEndereco.Models.Contexto;

namespace CrudMvcEndereco.Models.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ContextoBancoDeDados contexto;

        public UsuarioRepositorio(ContextoBancoDeDados contexto)
        {
            this.contexto = contexto ?? throw new System.ArgumentNullException(nameof(contexto));
        }

        public Usuario Atualiza(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }

        public Usuario BuscarPorId(int id)
        {
            return contexto.Usuario.Find(id);
        }

        public IEnumerable<Usuario> BuscarPorNome()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Usuario> BuscarTodos()
        {
            throw new System.NotImplementedException();
        }

        public void DeletaUsuario(Usuario usuario)
        {
            throw new System.NotImplementedException();
        }
    }
}
