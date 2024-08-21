using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace trabajoDeBD
{
    public partial class Transaccion : Form
    {
        public Transaccion()
        {
            InitializeComponent();
        }
        conexion_xd conec = new conexion_xd();

        private void Transaccion_Load(object sender, EventArgs e)
        {
            try
            {
                conec.getConexion();
                MessageBox.Show("Conexión exitosa");
                conec.cargaTabla("SELECT * FROM transaccion", "transaccion", Datatransaccion, conec.conexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            conec = new conexion_xd();

            if (ValidarDatos())
            {
                try
                {
                    string quer = "UPDATE transaccion SET IDCuentas= @idcuenta, TipoTransaccion=@tipotransaccion,Monto=@monto, FechaDeTransaccion=@fechatransaccion, Ubicacion=@ubicacion WHERE IDTransaccion=@idtransaccion";
                    MySqlCommand cm = new MySqlCommand(quer, conec.getConexion());
                    cm.Parameters.AddWithValue("@idtransaccion", texttransaccion.Text);
                    cm.Parameters.AddWithValue("@idcuenta", textidcuentas.Text);
                    cm.Parameters.AddWithValue("@tipotransaccion", texttipotransaccion.Text);
                    cm.Parameters.AddWithValue("@monto", textmonto.Text);
                    cm.Parameters.AddWithValue("@fechatransaccion", textfechatransaccion.Text);
                    cm.Parameters.AddWithValue("@ubicacion", textubicacion.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados exitosamente");
                    conec.cargaTabla("SELECT * FROM transaccion", "transaccion", Datatransaccion, conec.conexion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                }
                finally
                {
                    conec.getConexion().Close();
                }
            }
            vaciar();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            conec = new conexion_xd();

            if (ValidarDatos())
            {
                try
                {

                    string quer = "UPDATE transaccion SET IDCuentas = @idcuenta, TipoTransaccion=@tipotransaccion,Monto=@monto, FechaDeTransaccion=@fechatransaccion, Ubicacion=@ubicacion WHERE IDTransaccion = @idtransaccion ";
                    MySqlCommand cm = new MySqlCommand(quer, conec.getConexion());
                    cm.Parameters.AddWithValue("@idtransaccion", texttransaccion.Text);
                    cm.Parameters.AddWithValue("@idcuenta", textidcuentas.Text);
                    cm.Parameters.AddWithValue("@tipotransaccion", texttipotransaccion.Text);
                    cm.Parameters.AddWithValue("@monto", textmonto.Text);
                    cm.Parameters.AddWithValue("@fechatransaccion", textfechatransaccion.Text);
                    cm.Parameters.AddWithValue("@ubicacion", textubicacion.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Datos actalizacion exitosamente");
                    conec.cargaTabla("SELECT * FROM transaccion", "transaccion", Datatransaccion, conec.conexion);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos: " + ex.Message);
                }
                finally
                {
                    conec.getConexion().Close();
                }
            }
            vaciar();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            conec = new conexion_xd();
            if (!string.IsNullOrEmpty(texttransaccion.Text))
            {
                try
                {
                    string quer = "DELETE FROM transaccion WHERE IDTransaccion=@idtransaccion";
                    MySqlCommand cm = new MySqlCommand(quer, conec.getConexion());
                    cm.Parameters.AddWithValue("@idtransaccion", texttransaccion.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Datos eliminados exitosamente");
                    conec.cargaTabla("SELECT * FROM transaccion", "transaccion", Datatransaccion, conec.conexion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar los datos: " + ex.Message);
                }
                finally
                {
                    conec.getConexion().Close();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminar.");
            }

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            conec = new conexion_xd();

            if (ValidarDatos())
            {
                try
                {
                    string quer = "INSERT INTO transaccion (IDTransaccion,IDCuentas,TipoTransaccion,Monto,FechaDeTransaccion,Ubicacion) VALUES (@idtransaccion,@idcuenta,@tipotransaccion,@monto,@fechatransaccion,@ubicacion)";
                    MySqlCommand cm = new MySqlCommand(quer, conec.getConexion());

                    cm.Parameters.AddWithValue("@idtransaccion", texttransaccion.Text);
                    cm.Parameters.AddWithValue("@idcuenta", textidcuentas.Text);
                    cm.Parameters.AddWithValue("@tipotransaccion", texttipotransaccion.Text);
                    cm.Parameters.AddWithValue("@monto", textmonto.Text);
                    cm.Parameters.AddWithValue("@fechatransaccion", textfechatransaccion.Text);
                    cm.Parameters.AddWithValue("@ubicacion", textubicacion.Text);
                    cm.ExecuteNonQuery();
                    // MessageBox.Show("Datos agregados exitosamente");
                    conec.cargaTabla("SELECT * FROM transaccion", "transaccion", Datatransaccion, conec.conexion);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar los datos: " + ex.Message);
                }
                finally
                {
                    conec.getConexion().Close();
                }
            }
            vaciar();
        }

      
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(textubicacion.Text) || string.IsNullOrEmpty(texttransaccion.Text) ||
                string.IsNullOrEmpty(textfechatransaccion.Text) || string.IsNullOrEmpty(textidcuentas.Text) ||
                string.IsNullOrEmpty(texttipotransaccion.Text) || string.IsNullOrEmpty(textmonto.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }
            return true;
        }

        private void Datatransaccion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            texttransaccion.Text = Datatransaccion.SelectedCells[0].Value.ToString();
            textidcuentas.Text = Datatransaccion.SelectedCells[1].Value.ToString();
            texttipotransaccion.Text = Datatransaccion.SelectedCells[2].Value.ToString();
            textmonto.Text = Datatransaccion.SelectedCells[3].Value.ToString();
            textfechatransaccion.Text = Datatransaccion.SelectedCells[4].Value.ToString();
            textubicacion.Text = Datatransaccion.SelectedCells[5].Value.ToString();
        }
        private void vaciar()
        {
            texttransaccion.Text = "";
            textidcuentas.Text = "";
            texttipotransaccion.Text = "";
            textmonto.Text ="";
            textfechatransaccion.Text = "";
           textubicacion.Text ="";

        }

        private void Buscar_Click_1(object sender, EventArgs e)
        {
            conec = new conexion_xd();
 
            try
            {
                string quer = "SELECT * FROM transaccion WHERE IDTransaccion LIKE @idtransaccion";
                MySqlCommand cm = new MySqlCommand(quer, conec.getConexion());
                cm.Parameters.AddWithValue("@idtransaccion", "%" + texbuscar.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cm);
                DataSet ds = new DataSet();
                da.Fill(ds, "transaccion");
                Datatransaccion.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }
    }
}
