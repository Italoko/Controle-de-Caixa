using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace Controle_de_Caixa.DAL
{
    public class MySQLPersistence
    {
        string _strCon = ""; 
        MySqlConnection _conexao; 
        MySqlCommand _comando;
        public int UltimoId { get; set; }
        public MySQLPersistence() 
        {
            _strCon = "Data Source = den1.mysql4.gear.host; Database = aulalp4; User Id = aulalp4; Password = Al59dz6?6v7_; ; SSL Mode = None";
            _conexao = new MySqlConnection(_strCon);
            _comando = _conexao.CreateCommand(); 
        }

        public void AbrirConexao()
        {
            if (_conexao.State != System.Data.ConnectionState.Open)  
                _conexao.Open(); 
        }

        public void FecharConexao()
        {
            _conexao.Close();
        }


        public void AdicionarParametro(string nome, object valor)
        {
            _comando.Parameters.AddWithValue(nome, valor);
        }

        public void LimparParametros()
        {
            _comando.Parameters.Clear();  
        }
                                                  
        public int ExecutarNonQuery(string instrucao, Dictionary<string, object> parametros = null)
        {
            _comando.CommandText = instrucao;
            if (parametros != null)
                foreach (var item in parametros)
                 _comando.Parameters.AddWithValue(item.Key, item.Value);

            int lines = _comando.ExecuteNonQuery();
            if (lines > 0)
                UltimoId = Convert.ToInt32(_comando.LastInsertedId);
            return lines ;
        }
    }
}
