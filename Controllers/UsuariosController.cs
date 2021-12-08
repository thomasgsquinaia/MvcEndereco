using CrudMvcEndereco.Models.Contexto;
using CrudMvcEndereco.Models.Entidade;
using CrudMvcEndereco.Models.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudMvcEndereco.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly ContextoBancoDeDados _contexto;
        
        public UsuariosController(ContextoBancoDeDados contexto)
        {
            _contexto = contexto;//ele faz a criacao do objeto
        }

        public IActionResult Index()
        {
            var lista =  _contexto.Usuario.ToList();
            CarregaTipoUsuario();
            return View(lista);
        }

        // =========================== Create ===========================
        [HttpGet]
        public IActionResult Create()
        {
            //get carrega a pagina em branco (LER )
            var estados = _contexto.Estados.ToList();
            int estadoId = estados.FirstOrDefault().Id;
            var usuario = new EditUserViewModel()
            {
                Estados = estados,
                Cidades = _contexto.Cidades.Where(c => c.EstadoId == estadoId).ToList()
            };
            CarregaTipoUsuario();
            return View(usuario);
        }


        [HttpPost]
        public  IActionResult Create(Usuario usuario)
        {
            //post - salvar as informações no banco (SALVA)
            if(ModelState.IsValid)// se todos os campos foram preenchidos na tela vai salvar o user
            {
                 _contexto.Usuario.Add(usuario);
                 _contexto.SaveChangesAsync(); //executar no banco, abre a query e efetua o comando

                return RedirectToAction("Index");
            }
            CarregaTipoUsuario();//se nao for valido aparece novamente
            return View(usuario);
        }

        // =========================== Edit ===========================
        [HttpGet]
        public IActionResult Edit(int Id)//carrega a edição do user (a tela)
        {
            //get carrega a pagina em branco
            var usuario = _contexto.Usuario.Find(Id);
            CarregaTipoUsuario();
            return View(usuario);
        }

        [HttpPost]
        public IActionResult Edit(Usuario usuario) //quando clicar em SALVAR esse metodo aciona (envia para o banco de dados)
        {
            //post - salvar as informações no banco

            if (ModelState.IsValid)// se todos os campos foram preenchidos na tela vai salvar o user
            {
                _contexto.Usuario.Update(usuario);
                _contexto.SaveChanges(); //executar no banco, abre a query e efetua o comando do UPDATE

                return RedirectToAction("Index");
            } 
            else // se o usuario nao digitou algum campo obrigatorio, retorna para a tela pricipal para ele preencher os campos que estao faltando.
            {
                CarregaTipoUsuario();
                return View(usuario);
            }
           
        }

        //=========================== Delete ===========================
        [HttpGet]
        public IActionResult Delete(int Id)//carrega a tela de delete
        {
            //get carrega a pagina em branco

            var usuario = _contexto.Usuario.Find(Id);
            CarregaTipoUsuario();
            return View(usuario);
        }

        [HttpPost] 
        public IActionResult Delete(Usuario _usuario)//exclui o usuario do banco e retornar a lista de usuarios cadastrados
        {
            var usuario = _contexto.Usuario.Find(_usuario.Id);
            if (usuario!= null)
            {
                _contexto.Usuario.Remove(usuario);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usuario);
            
        }

        // =========================== Details ===========================

        [HttpGet] 
        public IActionResult Details(int Id)
        {
            var usuario = _contexto.Usuario.Find(Id);
            CarregaTipoUsuario();
            return View(usuario);
        }


        // =========================== Método Tipo de user ===========================
        public void CarregaTipoUsuario()
        {
            var ItensTipoUsuario = new List<SelectListItem>
            {
                new SelectListItem{ Value ="1", Text = "Administrador"},
                new SelectListItem{ Value ="2", Text = "Técnico"},
                new SelectListItem{ Value="3", Text = " Usuário Normal"}
            };

            ViewBag.TiposUsuario = ItensTipoUsuario;
        }

        // =========================== Método Estado do user ===========================
        public void CarregaEstadoUsuario()
        {
            var Estados = new List<SelectListItem>
            {

            };
        }


    }
}
