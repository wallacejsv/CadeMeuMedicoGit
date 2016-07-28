using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadeMeuMedico.Controllers
{
    public class MensagensController : Controller
    {
        // GET: Mensagens
        public ActionResult BomDia()
        {
            return Content("Bom dia..hoje voce acordou cedo!");
        }

         public ActionResult BoaTarde()
        {
            return Content("Boa Tarde... Nao durma na mesa do trabalho!!");
        }
    }
}