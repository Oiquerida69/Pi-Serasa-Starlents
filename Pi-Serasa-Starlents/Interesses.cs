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
        public int id;
        public string interesse;
        


        public Interesses( int id , string interesse)
        {
            this.id = id;
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
                string interesse = linha["interesse"].ToString();
                

                Interesses interesses1 = new Interesses(id, interesse);
                return interesses1;

            }
        public Interesses carregaAprender(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string aprender = linha["aprender"].ToString();

            Interesses interesses1 = new Interesses(id, aprender);
            return interesses1;

        }
        public List<Interesses> listaraprendizado()
        {

            string query = "SELECT id,aprender FROM interesses;";

            DataTable resultados = Conexao.executaQuery(query);
            if (resultados == null)
                return null;
            List<Interesses> interesses = new List<Interesses>();
            foreach (DataRow row in resultados.Rows)
            {
                Interesses interesses1 = carregaAprender(row);
                interesses.Add(interesses1);




            }
            return interesses;







        }
        
    }
    
}
