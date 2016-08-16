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
        public PartialViewResult Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Authors author)
        {
            if (!ModelState.IsValid) return PartialView("_Create", author);
            _repositorio.Agregar(author);
            return RedirectToAction("Index");
        }

        //Editar
        public ActionResult Edit(int id)
        {
            var author = _repositorio.ObtenerAutor(id);
            if (author == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Edit", author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Authors author)
        {
            if (!ModelState.IsValid) return PartialView("_Edit", author);
            _repositorio.Actualizar(author);
            return RedirectToRoute("Autor_default");
        }

        //Eliminar
        [OutputCache(Duration = 0)]
        public ActionResult Delete(int id)
        {
            var author = _repositorio.ObtenerAutor(id);
            if (author == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Delete", author);
        }
    }
}
