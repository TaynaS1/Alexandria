using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
namespace Alexandria
{
    public class StatusLeitura
    {
        public int Id;
        public string Nome = "";
        public bool PermiteNota; //ja foi lido?
    }
    public static class BancoLivros
    {
        // banco,onde e como
        private static string conexao = "Server=localhost;Port=3306;Database=Alexandria;Uid=root;Pwd=SUASENHA";
        public static string Conexao => conexao;
        public static void Inserir(Livros livro)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql =
                    "INSERT INTO livros (titulo, autor, genero_id, status_id, nota, resenha) " + 
                    "VALUES (@titulo, @autor, " +
                    "(SELECT id FROM generos WHERE nome = @genero LIMIT 1), " +
                    "(SELECT id FROM status_leitura WHERE nome = @status LIMIT 1), " +
                    "@nota, @resenha)";//livro novo
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
        public static List<Livros> Listar()//livros cadrastrado
        {
            List<Livros> lista = new List<Livros>();
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();

                string sql =
                    "SELECT l.id, l.titulo, l.autor, g.nome, s.nome, l.nota, l.resenha " +
                    "FROM livros l " +
                    "LEFT JOIN generos g ON g.id = l.genero_id " +
                    "JOIN status_leitura s ON s.id = l.status_id " +
                    "ORDER BY l.id";
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
                        livro.nota = r.IsDBNull(5) ? 0 : Convert.ToDouble(r.GetValue(5));
                        livro.resenha = r.IsDBNull(6) ? "" : r.GetString(6);
                        lista.Add(livro);
                    }
                }
            }
            return lista;
        }
        public static int Excluir(int id)//apagar
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
        public static void Atualizar(Livros l)//editar
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql =
                    "UPDATE livros SET titulo = @titulo, autor = @autor, " +
                    "genero_id = (SELECT id FROM generos WHERE nome = @genero LIMIT 1), " +
                    "status_id = (SELECT id FROM status_leitura WHERE nome = @status LIMIT 1), " +
                    "nota = @nota, resenha = @resenha " +
                    "WHERE id = @id";
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
        public static List<string> ListarGeneros()// generos mysql
        {
            List<string> lista = new List<string>();
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "SELECT nome FROM generos ORDER BY nome";
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
        public static void AdicionarGenero(string nome)//genero usuario
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
        public static List<StatusLeitura> ListarStatus()//status listado
        {
            List<StatusLeitura> lista = new List<StatusLeitura>();
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                conn.Open();
                string sql = "SELECT id, nome, permite_nota FROM status_leitura ORDER BY ordem, nome";
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        lista.Add(new StatusLeitura
                        {
                            Id = r.GetInt32(0), Nome = r.GetString(1),PermiteNota = r.GetInt32(2) != 0
                        });
                    }
                }
            }

            return lista;
        }
    }
}
