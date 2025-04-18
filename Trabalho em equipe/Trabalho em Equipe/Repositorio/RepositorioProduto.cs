using MySql.Data.MySqlClient;
using Trabalho_em_Equipe.BancoDados;
using Trabalho_em_Equipe.Dominio;

namespace Trabalho_em_Equipe.Repositorio
{
    internal class RepositorioProduto
    {
        public void AdicionarProduto(Produto novoProduto)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"INSERT INTO produto(nome) VALUES(@nome, @dataEntrada);";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@produto", novoProduto.Nome);
                    cmd.Parameters.AddWithValue("@produto", novoProduto.dataEntrada);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletarProduto(Produto produto)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"DELETE FROM PRODUTO WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", produto.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void ComprarProduto(Estoque produtoComprado)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"UPDATE produto SET nome = @nome WHERE Id = @Id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nome", produtoComprado.Produto);
                    cmd.Parameters.AddWithValue("@id", produtoComprado.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void VenderProduto(Estoque produto)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"DELETE FROM PRODUTO WHERE id = @id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", produto.Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Estoque BuscarProduto(Produto produto)
        {
            List <Estoque> estoque = new();

            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"SELECT produto.nome, estoque.id, dataEntrada.produto FROM estoque INNER JOIN produto ON estoque.id_produto = produto.id WHERE id_produto = @produto;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            return new Estoque()
                            {
                                Id = reader.GetInt32(produto.Id),
                                Produto = (Estoque)reader.GetString(Produto.Produto)
                            };
                        }
                    }
                }
            }
        }
    }
}
