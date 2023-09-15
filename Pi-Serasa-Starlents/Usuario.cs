using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace Pi_Serasa_Starlents
{
    
    internal class Usuario
    {
        Conexao conexao;

        public int id;
        public string interesse01;
        public string interesse02;
        public string interesse03;
        public string nome;
        public string email;
        public string senha;
        public string telefone;
        public string descricao;
        public string avatar;
        public string mensagemUsuario;
        public string aprender;
        public string aprender2;
        public bool denunciado;

        public Usuario(int id,string interesse01,string interesse02,string interesse03,string nome,string email,string senha,string telefone,string descricao , string avatar, string mensagemU,string aprender,string aprender2 , bool denunciado)
        {
            this.id = id;
            this.interesse01 = interesse01;
            this.interesse02 = interesse02;
            this.interesse03 = interesse03;
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.telefone = telefone;
            this.descricao = descricao;
            this.avatar = avatar;
            this.mensagemUsuario = mensagemU;
            this.aprender = aprender;
            this.aprender2 = aprender2;
            this.denunciado = denunciado;
        }
        public Usuario carregadados(DataRow linha)
        {
            int id = int.Parse(linha["id"].ToString());
            string interesse = linha["interesse1"].ToString();
            string interesse2 = linha["interesse2"].ToString();
            string interesse3 = linha["interesse3"].ToString();
            string nome = linha["nome"].ToString();
            string email = linha["email"].ToString();
            string senha = linha["senha"].ToString();
            string telefone = linha["telefone"].ToString();
            string descricao = linha["descricao"].ToString();
            string avatar = (linha["avatar"].ToString());
            string mensagemU = linha["mensagem"].ToString();
            string aprender = linha["aprender"].ToString();
            string aprender2 = linha["aprender2"].ToString();
            bool denunciado = bool.Parse(linha["Denunciado"].ToString());
            Usuario usuarioTotal = new Usuario(id,interesse,interesse2,interesse3, nome, email, senha, telefone, descricao, avatar, mensagemU,aprender,aprender2,denunciado);
            return usuarioTotal;

        }
        public Usuario()
        {

        }
        public void CadastrarUsuario(Usuario u)
        {
            string query = $"INSERT INTO usuarios (nome,senha,email,telefone,descricao,avatar,mensagem,interesse1,interesse2,interesse3) VALUES ('{u.nome}','{u.senha}','{u.email}','{u.telefone}','{u.descricao}','{u.avatar}','{u.mensagemUsuario}','{u.interesse01}','{u.interesse02}','{u.interesse03}');";
            Conexao.executaQuery(query);
        }
        public List<Usuario> ListarUsuarios(int usuario_id)
        {
            List<Usuario> usuarios = new List<Usuario>();
            string query = $"SELECT * FROM usuarios;";
             string uqery = $"SELECT usuarios.* FROM mix, usuarios WHERE mix.id_usuario_1 = {usuario_id} AND usuarios.id = {usuario_id}";
            DataTable tabela = Conexao.executaQuery(query);
            foreach( DataRow linha in tabela.Rows)
            {
                Usuario usuario = carregadados(linha);
                usuarios.Add(usuario);
            } 
            return usuarios;
            
        }

        public List<Usuario>buscaTodosPorIdUsuario(int id_usuario)
        {
            List<Usuario> usuarios = new List<Usuario>();
            string query = $"SELECT * FROM usuarios WHERE id_usuario = {id_usuario};";
            DataTable tabela = Conexao.executaQuery(query);
            foreach (DataRow linha in tabela.Rows)
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
            if (resutlados.Rows.Count == 0)
                return null;

            Usuario u = carregadados(resutlados.Rows[0]);

            query = $" SELECT * FROM mix WHERE id_usuario_1 = {u.id} AND id_usuario_2 = {u.id};";
            resutlados = Conexao.executaQuery(query);
            if( resutlados.Rows.Count == 0)
            {
                query = $"INSERT INTO mix (id_usuario_1, id_usuario_2, curtiu) VALUES ({u.id}, {u.id}, 1);";
                Conexao.executaQuery(query);
            }

            return u;
        }

        public List<Usuario> buscaPerfil(int id_usuario, string interesse ,string interesse2 ,string interesse3)
        {
            List<Usuario> us = new List<Usuario>();
            
            string query = $"SELECT * FROM usuarios WHERE id <> {id_usuario} AND ( interesse1 IN ('{interesse}','{interesse2}','{interesse3}') OR interesse2 IN ('{interesse}','{interesse2}','{interesse3}') OR interesse3 IN ('{interesse}','{interesse2}','{interesse3}'));";
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
            //SELECT usuarios.*FROM usuarios, mix WHERE mix.id_usuario_1 = 18 AND mix.id_usuario_2 NOT IN(16, 18);
            query = $"SELECT usuarios.* FROM usuarios, mix WHERE mix.id_usuario_1 = {id_usuario} AND mix.id_usuario_2 NOT IN ({ids});";
            table = Conexao.executaQuery(query);


            foreach (DataRow linha in table.Rows)
            {
                Usuario u = carregadados(linha);
                us.Add(u);
            }
            return us;
            
        }

        public void Curtida(int id_usuario_1, int id_usuario_2, bool curtiu)
        {
            string query = $"INSERT INTO mix (id_usuario_1, id_usuario_2, curtiu) VALUES ({id_usuario_1}, {id_usuario_2}, {curtiu});";
            Conexao.executaQuery(query);
        }
        public void denuncia(Usuario u)
        {
            string query = $"UPTADE usuarios SET Denunciado = 1 Where= {u.id};";
            Conexao.executaQuery(query);
        }
    }
}

