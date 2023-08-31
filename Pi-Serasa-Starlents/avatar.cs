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
    internal class Avatar
    {
        public int id;
        public string id_usuario;
        public string rosto;
        public string olho;
        public string pele;
        public string cabelo;


        public Avatar(int id, string id_usuario, string rosto, string olho, string pele, string cabelo) 
        { 
            this.id = id;
            this.id_usuario = id_usuario;
            this.rosto = rosto;
            this.olho = olho;
            this.pele = pele;
            this.cabelo = cabelo;
            
        }
        public List<Avatar> buscaTodos()
        {
            string query = "SELECT * FROM avatar;";

            DataTable tabela = Conexao.executaQuery(query);


            List<Avatar> avatar = new List<Avatar>();

            foreach (DataRow linha in tabela.Rows)
            {

            }
            return avatar;



        }
        public Avatar BuscaPorNome(string id_usuario)
        {
            string query = $"SELECT * FROM avatar WHERE id_usuario  {id_usuario};";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);
            Avatar avatar = CarregaDados(tabela.Rows[0]);


            return avatar;


        }
        public Avatar BuscaPorRosto(string rosto)
        {
            string query = $"SELECT * FROM avatar WHERE rosto {rosto};";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);
            Avatar avatar = CarregaDados(tabela.Rows[0]);


            return avatar;


        }
        public Avatar BuscaPorOlho(string olho)
        {
            string query = $"SELECT * FROM avatar WHERE olho {olho};";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);
            Avatar avatar = CarregaDados(tabela.Rows[0]);


            return avatar;


        }
        public Avatar BuscaPorPele(string pele)
        {
            string query = $"SELECT * FROM avatar WHERE pele {pele};";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);
            Avatar avatar = CarregaDados(tabela.Rows[0]);


            return avatar;


        }
        public Avatar BuscaPorCabelo(string cabelo)
        {
            string query = $"SELECT * FROM avatar WHERE cabelo {cabelo};";
            Conexao.executaQuery(query);
            DataTable tabela = Conexao.executaQuery(query);
            Avatar avatar = CarregaDados(tabela.Rows[0]);


            return avatar;


        }
        public Avatar CarregaDados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string id_usuario = linha["id_usuario"].ToString();
            string rosto = linha["rosto"].ToString(); 
            string olho = linha["olho"].ToString(); 
            string pele = linha["peleo"].ToString(); 
            string cabelo = linha["cabelo"].ToString(); 

          Avatar avatar = new Avatar(id, id_usuario, rosto, olho, pele, cabelo);
            
            return avatar;

        }
    }
}













