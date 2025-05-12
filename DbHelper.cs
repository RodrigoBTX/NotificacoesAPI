using Microsoft.Data.SqlClient;


namespace NotificacoesAPI
{
    public static class DbHelper
    {
        private static readonly string connString = @"Server=BTX036\SQLEXP;Database=MaisRitmo33;User Id=sa;Password=\1qazxsw;";

        public static int ObterNovidades()
        {
            using var conn = new SqlConnection(connString);
            using var cmd = new SqlCommand("SELECT COUNT(*) FROM st (nolock) WHERE stns = 0", conn);
            conn.Open();
            return (int)cmd.ExecuteScalar();
        }
    }
}
