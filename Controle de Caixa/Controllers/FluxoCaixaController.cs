using FluxoCaixaApplication.Controls;
using FluxoCaixaApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_de_Caixa.Controllers
{
    public class FluxoCaixaController : Controller
    {
        [HttpPost]
        public IActionResult Gravar([FromBody] System.Text.Json.JsonElement dados)
        {
            bool sucesso = false;
            string msg = "";
           
            FluxoCaixaControl fc = FluxoCaixaControl.getInstance();

            Caixa caixa = new Caixa()
            {
                SaldoInicial = 100,
                SaldoFinal = 100,
                Status = true
            };

            char tipo = Convert.ToChar(dados.GetProperty("tipo").ToString());
            decimal valor = Convert.ToDecimal(dados.GetProperty("valor").ToString());
            string motivo = dados.GetProperty("motivo").ToString();

            (sucesso, msg) = fc.Gravar(caixa,tipo,valor,motivo);

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
