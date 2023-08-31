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
    internal class Postagens
    {
        public int id;
        public string id_usuario;
        public string postagem;
        public string registro;


       


        public Postagens(int id, string id_usuario, string postagem, string registro)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.postagem = postagem;
            this.registro = registro;

        }

        public List<Postagens> buscaTodos()
        {
            string query = "SELECT * FROM postagens;";

            DataTable tabela = Conexao.executaQuery(query);


            List<Postagens> postagens = new List<Postagens>();

            foreach (DataRow linha in tabela.Rows)
            {
               
            }
            return postagens;

           

        }

        public Postagens BuscaPorNome(string id_usuario)
        {
            string query = $"SELECT * FROM postagens WHERE id_usuario  {id_usuario};";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);
            Postagens postagens = CarregaDados(tabela.Rows[0]);


            return postagens;


        }
        public Postagens BuscaPorPostagem(string postagem)
        {
            string query = $"SELECT * FROM postagens WHERE postagem {postagem};";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);
            Postagens postagens = CarregaDados(tabela.Rows[0]);


            return postagens;


        }

        public Postagens BuscaPorRegistro(string registro)
        {
            string query = $"SELECT * FROM postagens WHERE registro {registro};";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);
            Postagens postagens = CarregaDados(tabela.Rows[0]);


            return postagens;

        }
        public Postagens CarregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string id_usuario = linha["id_usuario"].ToString(); 
            string postagem = linha["postagem"].ToString(); 
            string registro = linha["registro"].ToString(); 


            Postagens postagens = new Postagens(id, id_usuario, postagem, registro);

            return postagens;
        }

    }

}


