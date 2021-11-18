﻿using Controle_de_Caixa.Controls;
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
        [HttpPost]
        public IActionResult Gravar([FromBody] System.Text.Json.JsonElement dados)
        {
            bool sucesso = false;
            string msg = "";
           
            CaixaControl cc = CaixaControl.getInstance();
            (sucesso, msg) = cc.Gravar(dados);

            var retorno = new
            {
                sucesso = sucesso,
                msg = msg
            };
            return Json(retorno);
        }



        public IActionResult Index()
        {
            return View();
        }
    }
}
