using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi_Serasa_Starlents
{
    internal class Usuario
    {
        public string nome;
        public string email;
        public string senha;
        public string telefone;
        public string descricao;
        public PictureBox pictureBox;

        public Usuario(string nome,string email,string senha,string telefone,string descricao , PictureBox avatar)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.telefone = telefone;
            this.descricao = descricao;
            this.pictureBox = avatar;
            

        }
        public Usuario()
        {

        }
        public void CadastrarUsuario(Usuario usuario)
        {
            string query = $"INSERT INTO usuarios (nome,senha,email,telefone,descricao) VALUES ('{usuario.nome},{usuario.senha},{usuario.email},{usuario.telefone},{usuario.descricao}';";
            Conexao.executaQuery(query);
        }
        public void ListarUmUsuario(Usuario usuario)
        {
            string query = $"SELECT nome,descricao,avatar FROM usuarios;";
            Conexao.executaQuery(query);
        }
        public void ListarContatos(Usuario usuario)
        {
            string query = $"SELECT nome,avatar FROM usuarios;";
            Conexao.executaQuery(query);
        }

    }

}
