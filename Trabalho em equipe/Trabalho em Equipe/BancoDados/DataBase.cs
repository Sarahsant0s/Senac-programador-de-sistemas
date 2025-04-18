using MySql.Data.MySqlClient;

namespace Trabalho_em_Equipe.BancoDados
{
    internal class DataBase
    {
        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=senac_sarah;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
