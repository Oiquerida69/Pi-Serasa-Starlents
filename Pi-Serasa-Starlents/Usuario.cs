using MySql.Data.MySqlClient;
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
        Conexao conexao;
        
        public string nome;
        public string email;
        public string senha;
        public string telefone;
        public string descricao;
        public string avatar;

        public Usuario(string nome,string email,string senha,string telefone,string descricao , string avatar)
        {
            
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.telefone = telefone;
            this.descricao = descricao;
            this.avatar = avatar;
            

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

            Usuario usuarioTotal = new Usuario(nome, email, senha, telefone, descricao, avatar);
            return usuarioTotal;

        }
        public Usuario()
        {

        }
        public void CadastrarUsuario(Usuario u)
        {
            string query = $"INSERT INTO usuarios (nome,senha,email,telefone,descricao,avatar) VALUES ('{u.nome}','{u.senha}','{u.email}','{u.telefone}','{u.descricao}','{u.avatar}');";
            Conexao.executaQuery(query);
        }
        public List<Usuario> ListarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string query = $"SELECT * FROM usuarios;";
            DataTable tabela = Conexao.executaQuery(query);
            foreach( DataRow linha in tabela.Rows)
            {
                Usuario usuario = carregadados(linha);
                usuarios.Add(usuario);
            } 
            return usuarios;
            
        }
        public List<Usuario> ListarAvatar()
        {
            List<Usuario> usuarios = new List<Usuario>();
            string query = $"SELECT * FROM avatar;";
            DataTable tabela = Conexao.executaQuery(query);
            foreach (DataRow linha in tabela.Rows)
            {
                Usuario usuario = carregadados(linha);
                usuarios.Add(usuario);
            }
            return usuarios;
        }
        public void ListarContatos()
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
        public Usuario login (string email , string senha)
        {
            string query = $" SELECT * FROM usuarios WHERE email = '{email}' AND senha = '{senha}';";
            DataTable resutlados = Conexao.executaQuery(query);
            if (resutlados.Rows.Count == null)
                return null;

            Usuario u = carregadados(resutlados.Rows[0]);
            return u;
        }

        public List<Usuario> buscaPerfil(int id_usuario, string interesse ,string interesse2 ,string interesse3)
        {
            List<Usuario> us = new List<Usuario>();
            //string query = $"SELECT * FROM usuarios WHERE interesse1 IN ('{interesse}','{interesse2}','{interesse3}') OR interesse2 IN ('{interesse}','{interesse2}','{interesse3}') OR interesse3 IN ('{interesse}','{interesse2}','{interesse3}');";
            string query = $"SELECT * FROM usuarios WHERE interesse1 IN ('{interesse}','{interesse2}','{interesse3}') OR interesse2 IN ('{interesse}','{interesse2}','{interesse3}') OR interesse3 IN ('{interesse}','{interesse2}','{interesse3}');";
            DataTable table = Conexao.executaQuery(query);
            if(table.Rows.Count == 0)
            {
                return null;
            }

            string ids = "";
            foreach( DataRow l in table.Rows)
            {
                ids += l["id"] + ",";
            }
            ids = ids.Substring(0, ids.Length-1);
            MessageBox.Show(ids);

            query = $"SELECT usuarios.* FROM usuarios, mix WHERE mix.id_usuario_1 = {id_usuario} AND mix.id_usuario_2 NOT IN ({ids});";
            table = Conexao.executaQuery(query);


            foreach (DataRow linha in table.Rows)
            {
                Usuario u = carregadados(linha);
                us.Add(u);
            }
            return us;
            
        }
        
        //public void Curtida(int id_usuario_1, int id_usuario_2, bool curtiu)
        //{
        //    string query = $"INSERT INTO mix (id_usuario_1, id_usuario_2, curtiu) VALUES ({=id_usuario_1}, {id_usuario_2}, {curtiu});";
        //    Conexao.executaQuery(query);
        //}

    }
}

