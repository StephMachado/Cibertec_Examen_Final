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

namespace WebDeveloper.Areas.Privado.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        private BooksRepository _repositorio;
        public BooksController(BooksRepository repositoio)
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
        public ActionResult Adicionar(Books book)
        {
            if (!ModelState.IsValid) return PartialView("_Adicionar", book);
            _repositorio.Agregar(book);
            return RedirectToAction("Index");
        }

        //Editar
        public ActionResult Editar(int id)
        {
            var book = _repositorio.ObtenerLibro(id);
            if (book == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Editar", book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(Books book)
        {
            if (!ModelState.IsValid) return PartialView("_Editar", book);
            _repositorio.Actualizar(book);
            return RedirectToAction("Index");
        }

        //Eliminar
        [OutputCache(Duration = 0)]
        public ActionResult Eliminar(int id)
        {
            var book = _repositorio.ObtenerLibro(id);
            if (book == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Eliminar", book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Eliminar(Books book)
        {
            if (!ModelState.IsValid) return PartialView("_Eliminar", book);
            _repositorio.Eliminar(book);
            return RedirectToAction("Index");
        }
    }
}