using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MensajeriaCliente.Controllers
{
    public class MensajeriaController : Controller
    {
        // GET: Mensajeria
        public ActionResult Index()
        {
            return View();
        }
    }
}