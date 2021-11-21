using Controle_de_Caixa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_de_Caixa.DAL
{
    public class AcertoCaixaDAO
    {
        MySQLPersistence _bd = new MySQLPersistence();
        private static AcertoCaixaDAO instance;
        private AcertoCaixaDAO() { }
        public static AcertoCaixaDAO getInstance()
        {
            if (instance == null)
                instance = new AcertoCaixaDAO();
            return instance;
        }

        public (int, string) Gravar(AcertoCaixa acertoCaixa)
        {
            int linhas = 0;
            string msg = "";

            try
            {
                string sql = "insert into acerto_caixa (data, tipo, valor,motivo)" +
                "values (@data, @tipo, @valor, @motivo)";

                _bd.LimparParametros();
                _bd.AdicionarParametro("@data",acertoCaixa.Data);
                _bd.AdicionarParametro("@tipo", acertoCaixa.Tipo);
                _bd.AdicionarParametro("@valor", acertoCaixa.Valor);
                _bd.AdicionarParametro("@motivo", acertoCaixa.Motivo);

                _bd.AbrirConexao();
                linhas  = _bd.ExecutarNonQuery(sql);
                if (linhas > 0)
                    acertoCaixa.Id = _bd.UltimoId;
                _bd.FecharConexao();
            }
            catch (Exception ex)
            { msg = "Não foi possível salvar. Tente novamente."; }
            return (linhas, msg);
        }
    }
}
