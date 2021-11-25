using FluxoCaixaApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FluxoCaixaApplication.DAL
{
    public class MovimentoCaixaDAO
    {
        MySQLPersistence _bd = new MySQLPersistence();
        private static MovimentoCaixaDAO instance;
        private MovimentoCaixaDAO() { }
        public static MovimentoCaixaDAO getInstance()
        {
            if (instance == null)
                instance = new MovimentoCaixaDAO();
            return instance;
        }

        public (int, string) Gravar(MovimentoCaixa movimentoCaixa)
        {
            int linhas = 0;
            string msg = "";

            try
            {
                string sql = "insert into movimento_caixa (id_caixa, id_acerto, valor,tipo)" +
                "values (@id_caixa, @id_acerto, @valor, @tipo)";

                _bd.LimparParametros();
                _bd.AdicionarParametro("@id_caixa", movimentoCaixa.Caixa.Id);
                _bd.AdicionarParametro("@id_acerto", movimentoCaixa.Acerto.Id);
                _bd.AdicionarParametro("@valor", movimentoCaixa.Valor);
                _bd.AdicionarParametro("@tipo", movimentoCaixa.Tipo);

                _bd.AbrirConexao();
                linhas = _bd.ExecutarNonQuery(sql);
                _bd.FecharConexao();
            }
            catch (Exception ex)
            { 
                msg = "Não foi possível salvar. Tente novamente."; 
            }
            return (linhas, msg);
        }
    }
}
