using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebBooks.Model;
using WebBooks.DataAccess;

namespace WebDeveloper.Areas.Autor.Controllers
{
    [Authorize]
    public class AuthorsController : Controller
    {
        private AuthorsRepository _repositorio;
        public AuthorsController(AuthorsRepository repositoio)
        {
            _repositorio = repositoio;
        }

        //Listar
        public ActionResult Index()
        {
            return View(_repositorio.ObtenerLista());
        }

        //Crear
        public PartialViewResult Adicionar()
        {
            return PartialView("_Adicionar");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Adicionar(Authors author)
        {
            if (!ModelState.IsValid) return PartialView("_Adicionar", author);
            _repositorio.Agregar(author);
            return RedirectToAction("Index");
        }

        //Editar
        public ActionResult Editar(int id)
        {
            var author = _repositorio.ObtenerAutor(id);
            if (author == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Editar", author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Authors author)
        {
            if (!ModelState.IsValid) return PartialView("_Editar", author);
            _repositorio.Actualizar(author);
            //return RedirectToRoute("Autor_default");
            return RedirectToAction("Index");
        }

        //Eliminar
        [OutputCache(Duration = 0)]
        public ActionResult Eliminar(int id)
        {
            var author = _repositorio.ObtenerAutor(id);
            if (author == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Eliminar", author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Eliminar(Authors author)
        {
            if (!ModelState.IsValid) return PartialView("_Eliminar", author);
            _repositorio.Eliminar(author);
            //return RedirectToRoute("Autor_default");
            return RedirectToAction("Index");
        }
    }
}
