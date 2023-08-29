using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Pi_Serasa_Starlents
{
    internal class Conexao
    {
        const string host = "localhost";
        const string banco = "projetointegrador";
        const string usuario = "root";
        const string senha = "senac";

        const string dadosConexao = $"Server={host};Database={banco};Uid={usuario};Pwd={senha};";
        static MySqlConnection conexao = new MySqlConnection(dadosConexao);





        public static DataTable executaQuery(string query)
        {
            try
            {
                conexao.Open();


                MySqlCommand comando = new MySqlCommand(query, conexao);
                MySqlDataReader dados = comando.ExecuteReader();

                DataTable tabela = new DataTable();
                tabela.Load(dados);

                return tabela;


            }
            catch (Exception erro)
            {


                return null;

            }

            finally
            {
                conexao.Close();
            }

        }


    }
    public List<Conexao> buscaTodos()
    {
        string query = "SELECT * FROM conexao;";

        DataTable tabela = Conexao.executaQuery(query);

        List<Conexao> conexao = new List<Conexao>();
       
        foreach (DataRow linha in tabela.Rows)
        {
           Conexao conexao = CarregaDados(linha);
            conexao.Add(conexao);

        }
        return conexao;

    }
}

