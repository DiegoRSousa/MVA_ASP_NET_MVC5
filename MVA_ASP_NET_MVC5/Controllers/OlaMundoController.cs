using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVA_ASP_NET_MVC5.Controllers
{
    public class OlaMundoController : Controller
    {
        // GET: OlaMundo
        public string Index()
        {
            return "Olá MVC 5";
        }

        public string TesteController()
        {
            return "Texto <b>em negrito</b>, retorno do controller";
        }

        // GET: OlaMundo/GetJson
        public JsonResult GetJson()
        {
            var produto = new 
            {
                ID = 12,
                Nome = "Bicicleta",
                Qtde = 10
            };
            return Json(produto, JsonRequestBehavior.AllowGet);
        }

        // GET: OlaMundo/GetDados?nome=Diego&idade=24
        public string GetDados(string nome, int idade = 20)
        {
            return HttpUtility.HtmlEncode(
                string.Format("Bem Vindo {0} com idade {1}", nome, idade));
        }
    }
}