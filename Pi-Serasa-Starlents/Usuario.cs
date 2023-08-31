using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi_Serasa_Starlents
{
    internal class Usuario
    {
        public int id;
        public string nome;
        public string email;
        public string senha;
        public string telefone;
        public string descricao;
        public string pictureBox;

        public Usuario(int id, string nome,string email,string senha,string telefone,string descricao , string avatar)
        {
            this.id = id;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.telefone = telefone;
            this.descricao = descricao;
            this.pictureBox = avatar;
            

        }
        public Usuario carregadados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string nome = linha["nome"].ToString();
            string email = linha["email"].ToString();
            string senha = linha["senha"].ToString();
            string telefone = linha["telefone"].ToString();
            string descricao = linha["descricao"].ToString();
            string avatar = (linha["avatar"].ToString());

            Usuario usuarioTotal = new Usuario(id, nome, email, senha, telefone, descricao, avatar);
            return usuarioTotal;

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
        public Usuario buscarnome(string nome)
        {
            string query = $"SELECT * FROM usuarios WHERE nome = '{nome}';";
            DataTable tabela = Conexao.executaQuery(query);
            Usuario usuario = carregadados(tabela.Rows[0]);
            return usuario;
        }
    }
}

