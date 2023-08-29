using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace Pi-Serasa-Starlents
{
    internal class postagens
    {


      public int id;
      public string id usuario;
	  public string postagem;
      public string registro;



      public postagens()
      {


      }

      public postagens(int id, string id_usuario, string postagem, string registro)
      {
        this.id = id;
        this.id_usuario = id_usuario;
        this.postagerm = postagem;
        this.registro = registro;
      }

      public List<postagens>buscaTodos() 
      {
        string query = "SELECT * FROM postagen;";

        DataTable tabela = Conexao.executaQuery(query);

      }

    }


}

