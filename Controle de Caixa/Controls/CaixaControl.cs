using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_de_Caixa.Controls
{
    public class CaixaControl
    {
        private static CaixaControl _instance;
        private CaixaControl() { }
        public static CaixaControl getInstance()
        {
            if (_instance == null)
                _instance = new CaixaControl();
            return _instance;
        }


        public (bool, string) Gravar(System.Text.Json.JsonElement dados)

        {
            bool sucesso = false;
            string msg = "";
            string operacao = "registrado";
            
            return (sucesso, msg);
        }
    }
}
