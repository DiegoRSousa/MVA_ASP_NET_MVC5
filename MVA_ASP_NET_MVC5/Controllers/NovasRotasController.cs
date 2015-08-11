using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVA_ASP_NET_MVC5.Controllers
{
    [RoutePrefix("geral")]
    public class NovasRotasController : Controller
    {
        [Route("index/{nascimento:datetime}")]
        public string Index(DateTime nascimento)
        {
            return string.Format("Data de nascimento {0:dd/MM/yyyy}", nascimento);
        }

        [Route("info/{nome}/{idade}")]
        public string GetDados(string nome, int idade)
        {
            return HttpUtility.HtmlEncode(
                string.Format("Bem vindo {0} com idade {1}", nome, idade));
        }
        [Route("preco/{preco:double:min(20)}")]
        public string GetPreco(int preco)
        {
            return "preco = " + preco;
        }
        [Route("getcliente/{id:int:min(-100):max(100)}")]
        public string GetCliente(int id)
        {
            return "Código do cliente " + id;
        }
    }
}
