using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi_Serasa_Starlents
{
    internal class Interesses
    {
        int id;
        int id_usuario;
        string interesse;



        public Interesses( int id , int id_usuario, string interesse)
        {
            this.id = id;
            this.id_usuario = id_usuario;
            this.interesse = interesse;
        }

        public Interesses()
        {

        }
        public List<Interesses> buscaTodos()
        {
            string query = "SELECT * FROM interesses;";

            DataTable resultados = Conexao.executaQuery(query);
            if (resultados == null)
                return null;
            List<Interesses> interesses = new List<Interesses>();
            foreach (DataRow row in resultados.Rows)
            {
                Interesses interesses1 = carregadados(row);
                interesses.Add(interesses1);




            }
            return interesses;
        }

            public Interesses carregadados(DataRow linha)
            {
                int id = int.Parse(linha["id"].ToString());
                int id_usuario = int.Parse(linha["id_usuario"].ToString());
                string interesse = linha["interesse"].ToString();

                Interesses interesses1 = new Interesses(id, id_usuario, interesse);
                return interesses1;

            }

        
    }
    
}
