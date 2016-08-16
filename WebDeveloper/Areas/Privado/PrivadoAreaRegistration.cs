using System.Web.Mvc;

namespace WebDeveloper.Areas.Autor
{
    public class PrivadoAreaRegistration : AreaRegistration
    {
        public override string AreaName => "Privado";

        public override void RegisterArea(AreaRegistrationContext context)
        {
            //Autores
            context.MapRoute(
                "Autor_default",
                "Autor/{action}/{id}",
                new { controller = "Authors", action = "Index", id = UrlParameter.Optional }
            );

            //Libros


            //AutoresLibros


        }
    }
}
