using Controle_de_Caixa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_de_Caixa.Controllers
{
    public class CaixaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
