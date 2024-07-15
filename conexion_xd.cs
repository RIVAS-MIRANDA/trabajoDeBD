using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace trabajoDeBD
{
    class conexion_xd
    {
        public MySqlConnection conexion;
        private string server = "localhost";
        private string sdatabase = "moviliariadb";
        private string user = "root";
        private string password = "";
        private string cadenaConexion;

        public conexion_xd()
        {
            cadenaConexion = "Database=" + sdatabase +
                     ";DataSource=" + server +
                    ";User Id=" + user +
             ";Password=" + password;
        }
        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }
            return conexion;
        }
        public void cargaTabla(string sql, string tabla, DataGridView Grid, MySqlConnection Conex)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Conex);

            DataSet ds = new DataSet();
            da.Fill(ds, tabla);
            Grid.DataSource = ds.Tables[0].DefaultView;
        }
    }
}




