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
    internal class Notificacoes
    {
        public int id;
        public string id_usuario;
        public string conteudo;



        public Notificacoes(int id, string id_usuario, string conteudo)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.conteudo = conteudo;


        }

        public List<Notificacoes> buscaTodos()
        {
            string query = "SELECT * FROM notificacoes;";

            DataTable tabela = Conexao.executaQuery(query);


            List<Notificacoes> notificacoes = new List<Notificacoes>();

            foreach (DataRow linha in tabela.Rows)
            {

            }
            return notificacoes;
        }

        public Notificacoes BuscaPorNome(string id_usuario)
        {
            string query = $"SELECT * FROM notificacoes WHERE id_usuario  {id_usuario};";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);
            Notificacoes notificacoes = CarregaDados(tabela.Rows[0]);


            return notificacoes;


        }
        public Notificacoes BuscaPorConteudo(string conteudo)
        {
            string query = $"SELECT * FROM notificacoes WHERE conteudo {conteudo};";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);
            Notificacoes notificacoes = CarregaDados(tabela.Rows[0]);


            return notificacoes;


        }
        public Notificacoes CarregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string id_usuario = linha["id_usuario"].ToString();
            string conteudo = linha["conteudo"].ToString(); 


          Notificacoes notificacoes = new Notificacoes(id,id_usuario, conteudo);
            

            return notificacoes;
        }
    }

}

