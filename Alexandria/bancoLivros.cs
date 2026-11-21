using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;


namespace Alexandria
{
    public static class BancoLivros
    {
        private static string conexao = "Server=127.0.0.1;Port=3306;Database=alexandria;Uid=root;Pwd=SUA_SENHA;";
        public static string Conexao => conexao;
        public static void Inserir(Livros livro)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "INSERT INTO livros (titulo, autor, genero, status, nota, resenha) " +  "VALUES (@titulo, @autor, @genero, @status, @nota, @resenha)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@titulo", livro.titulo);
                    cmd.Parameters.AddWithValue("@autor", livro.autor);
                    cmd.Parameters.AddWithValue("@genero", livro.genero);
                    cmd.Parameters.AddWithValue("@status", livro.status);
                    cmd.Parameters.AddWithValue("@nota", livro.nota);
                    cmd.Parameters.AddWithValue("@resenha", livro.resenha);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<Livros> Listar()
        {
            List<Livros> lista = new List<Livros>();
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string sql = "SELECT id, titulo, autor, genero, status, nota, resenha FROM livros ORDER BY id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        Livros livro = new Livros();
                        livro.id = r.GetInt32(0);
                        livro.titulo = r.IsDBNull(1) ? "" : r.GetString(1);
                        livro.autor = r.IsDBNull(2) ? "" : r.GetString(2);
                        livro.genero = r.IsDBNull(3) ? "" : r.GetString(3);
                        livro.status = r.IsDBNull(4) ? "" : r.GetString(4);
                        livro.nota = r.IsDBNull(5) ? 0 : r.GetDouble(5);
                        livro.resenha = r.IsDBNull(6) ? "" : r.GetString(6);
                        lista.Add(livro);
                    }
                }
            }

            return lista;
        }

        public static int Excluir(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "DELETE FROM livros WHERE id = @id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    return cmd.ExecuteNonQuery(); 
                }
            }
        }

        public static void Atualizar(Livros l)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "UPDATE livros SET titulo=@titulo, autor=@autor, genero=@genero, " + "status=@status, nota=@nota, resenha=@resenha WHERE id=@id";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@titulo", l.titulo);
                    cmd.Parameters.AddWithValue("@autor", l.autor);
                    cmd.Parameters.AddWithValue("@genero", l.genero);
                    cmd.Parameters.AddWithValue("@status", l.status);
                    cmd.Parameters.AddWithValue("@nota", l.nota);
                    cmd.Parameters.AddWithValue("@resenha", l.resenha);
                    cmd.Parameters.AddWithValue("@id", l.id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<string> ListarGeneros()
        {
            List<string> lista = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "SELECT nome FROM generos " + "UNION " + "SELECT DISTINCT genero FROM livros WHERE genero IS NOT NULL AND genero <> '' " +   "ORDER BY 1";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        lista.Add(r.GetString(0));
                    }
                }
            }

            return lista;
        }

        public static void AdicionarGenero(string nome)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "INSERT IGNORE INTO generos (nome) VALUES (@nome)";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", nome);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
