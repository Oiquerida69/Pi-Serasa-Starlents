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
        
        //const string host = "localhost";
        //const string banco = "mario_01";
        //const string usuario = "root";
        //const string senha = "";
        const string host = "10.60.45.48";
        const string banco = "novobanco ";
        const string usuario = "senac";
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

}

