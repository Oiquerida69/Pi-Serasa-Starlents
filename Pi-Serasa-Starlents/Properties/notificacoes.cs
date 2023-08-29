using System;



namespace Pi_Serasa_Starlents
{
    internal class notificacoes
    {
        public int id;
        public string id_usuario;
        public string conteudo;
      


        public notificacoes(int id, string id_usuario, string conteudo)
        { 
            this.id = id;
            this.id_usuario = id_usuario;
            this.conteudo = conteudo;
           
        }
    }
}

