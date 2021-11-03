﻿using Controle_de_Caixa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_de_Caixa.DAL
{
    public class CaixaDAO
    {
        MySQLPersistence _bd = new MySQLPersistence();
        private static CaixaDAO instance;
        private CaixaDAO() { }
        public static CaixaDAO getInstance()
        {
            if (instance == null)
                instance = new CaixaDAO();
            return instance;
        }

        public (int, string) Gravar(Caixa caixa)
        {
            int linhas = 0;
            string msg = "";

            try
            {
                string sql = "insert into caixa (saldo_inicial, saldo_final, status)" +
                "values (@saldo_inicial, @saldo_final, @status)";

                _bd.LimparParametros();
                _bd.AdicionarParametro("@saldo_inicial",caixa.SaldoInicial);
                _bd.AdicionarParametro("@saldo_final",caixa.SaldoFinal);
                _bd.AdicionarParametro("@status",caixa.Status);

                _bd.AbrirConexao();
                linhas = _bd.ExecutarNonQuery(sql);
                _bd.FecharConexao();
            }
            catch (Exception ex)
            {msg = "Não foi possível salvar. Tente novamente.";}
            return (linhas, msg);
        }
    }
}