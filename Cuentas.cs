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
using System.Windows.Forms;

namespace trabajoDeBD
{
    public partial class Cuentas : Form
    {
        public Cuentas()
        {
            InitializeComponent();
        }
        conexion_xd conec = new conexion_xd();
        private void Cuentas_Load(object sender, EventArgs e)
        {


            try
            {
                conec.getConexion();
                MessageBox.Show("Conexión exitosa");
                conec.cargaTabla("SELECT * FROM cuentas", "cuentas", dataGridView, conec.conexion);
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
                    string query = "UPDATE cuentas SET IDUsuario = @usuario,TipoCuenta = @tcuenta, Saldo = @saldo, FechaDeCreacion = @creacion WHERE  IDCuenta = @cuenta";
                    MySqlCommand cmd = new MySqlCommand(query, conec.getConexion());
                    cmd.Parameters.AddWithValue("@usuario", idusuario.Text);
                    cmd.Parameters.AddWithValue("@cuenta", idcuenta.Text);
                    cmd.Parameters.AddWithValue("@tcuenta", tipocuenta.Text);
                    cmd.Parameters.AddWithValue("@saldo", saldo.Text);
                    cmd.Parameters.AddWithValue("@creacion", fechacrecion.Text);
                    conec.cargaTabla("SELECT * FROM cuentas", "cuentas", dataGridView, conec.conexion);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados exitosamente");
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }
                finally
                {
                    conec.getConexion().Close();
                }
            }

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            conec = new conexion_xd();

            if (ValidarDatos())
            {
                try
                {
                    string query = "UPDATE cuentas SET IDUsuario = @usuario,TipoCuenta = @tcuenta, Saldo = @saldo, FechaDeCreacion = @creacion WHERE  IDCuenta = @cuenta";
                    MySqlCommand cmd = new MySqlCommand(query, conec.getConexion());
                    cmd.Parameters.AddWithValue("@usuario", idusuario.Text);
                    cmd.Parameters.AddWithValue("@cuenta", idcuenta.Text);
                    cmd.Parameters.AddWithValue("@tcuenta", tipocuenta.Text);
                    cmd.Parameters.AddWithValue("@saldo", saldo.Text);
                    cmd.Parameters.AddWithValue("@creacion", fechacrecion.Text);
                    cmd.ExecuteNonQuery();
                    conec.cargaTabla("SELECT * FROM cuentas", "cuentas", dataGridView, conec.conexion);
                    MessageBox.Show("Datos actalizados exitosamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " + ex.Message);
                }
                finally
                {
                    conec.getConexion().Close();
                }
            }

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            conec = new conexion_xd();

            if (!string.IsNullOrEmpty(idcuenta.Text))
            {
                try
                {
                    string query = "DELETE FROM cuentas WHERE IDCuenta = @cuenta";
                    MySqlCommand cmd = new MySqlCommand(query, conec.getConexion());
                    cmd.Parameters.AddWithValue("@cuenta", idcuenta.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos eliminados exitosamente");
                    conec.cargaTabla("SELECT * FROM cuentas", "cuentas", dataGridView, conec.conexion);
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
                    string query = "INSERT INTO cuentas (IDUsuario ,IDCuenta ,TipoCuenta ,Saldo , FechaDeCreacion) VALUES  (@usuario, @cuenta, @tcuenta ,@saldo, @creacion)";
                    MySqlCommand cmd = new MySqlCommand(query, conec.getConexion());
                    cmd.Parameters.AddWithValue("@usuario", idusuario.Text);
                    cmd.Parameters.AddWithValue("@cuenta", idcuenta.Text);
                    cmd.Parameters.AddWithValue("@tcuenta", tipocuenta.Text);
                    cmd.Parameters.AddWithValue("@saldo", saldo.Text);
                    cmd.Parameters.AddWithValue("@creacion", fechacrecion.Text);
                    cmd.ExecuteNonQuery();
                    conec.cargaTabla("SELECT * FROM cuentas", "cuentas", dataGridView, conec.conexion);
                     MessageBox.Show("Datos agregados exitosamente");
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
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            conec = new conexion_xd();

            try
            {
                string query = "SELECT * FROM cuentas WHERE IDCuenta LIKE @cuenta";
                MySqlCommand cmd = new MySqlCommand(query, conec.getConexion());
                cmd.Parameters.AddWithValue("@cuenta", "%" + txbuscar.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "cuentas");
                dataGridView.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }


        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(idusuario.Text) || string.IsNullOrEmpty(saldo.Text) ||
                string.IsNullOrEmpty(idcuenta.Text) || string.IsNullOrEmpty(fechacrecion.Text) ||
                string.IsNullOrEmpty(tipocuenta.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }
            return true;
        }

        private void dataGridView_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idusuario.Text = dataGridView.SelectedCells[0].Value.ToString();
            idcuenta.Text = dataGridView.SelectedCells[1].Value.ToString();
            tipocuenta.Text = dataGridView.SelectedCells[2].Value.ToString();
            saldo.Text = dataGridView.SelectedCells[3].Value.ToString();
            fechacrecion.Text = dataGridView.SelectedCells[4].Value.ToString();

        }
    }
}
