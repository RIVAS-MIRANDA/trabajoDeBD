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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        conexion_xd conec = new conexion_xd();

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conec.getConexion();
                MessageBox.Show("Conexión exitosa");
                conec.cargaTabla("SELECT * FROM usuario", "usuario", dataGridView1, conec.conexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            conec = new conexion_xd();

            if (ValidarDatos())
            {
                try
                {
                    string query = "INSERT INTO usuario (Nombre, ID, FechaDeNacimiento, Telefono, Direccion, EsClienteDesde) VALUES (@nombre, @id, @fecha_de_nacimiento, @telefono, @direccion, @fecha_de_inscripcion)";
                    MySqlCommand cmd = new MySqlCommand(query, conec.getConexion());
                    
                    cmd.Parameters.AddWithValue("@nombre", textnombre.Text);
                    cmd.Parameters.AddWithValue("@id", textid.Text);
                    cmd.Parameters.AddWithValue("@fecha_de_nacimiento", textfechadenacimiento.Text);
                    cmd.Parameters.AddWithValue("@telefono", texttelefono.Text);
                    cmd.Parameters.AddWithValue("@direccion", textdireccion.Text);
                    cmd.Parameters.AddWithValue("@fecha_de_inscripcion", textfechadeinscripcion.Text);
                    cmd.ExecuteNonQuery();
                   // MessageBox.Show("Datos agregados exitosamente");
                    conec.cargaTabla("SELECT * FROM usuario", "usuario", dataGridView1, conec.conexion);
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

        private void Guardar_Click(object sender, EventArgs e)
        {
            conec = new conexion_xd();

            if (ValidarDatos())
            {
                try
                {
                    string query = "UPDATE usuario SET Nombre = @nombre, FechaDeNacimiento = @fecha_de_nacimiento, Telefono = @telefono, Direccion = @direccion, EsClienteDesde = @fecha_de_inscripcion WHERE ID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conec.getConexion());
                    cmd.Parameters.AddWithValue("@nombre", textnombre.Text);
                    cmd.Parameters.AddWithValue("@id", textid.Text);
                    cmd.Parameters.AddWithValue("@fecha_de_nacimiento", textfechadenacimiento.Text);
                    cmd.Parameters.AddWithValue("@telefono", texttelefono.Text);
                    cmd.Parameters.AddWithValue("@direccion", textdireccion.Text);
                    cmd.Parameters.AddWithValue("@fecha_de_inscripcion", textfechadeinscripcion.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados exitosamente");
                    conec.cargaTabla("SELECT * FROM usuario", "usuario", dataGridView1, conec.conexion);
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

                    string query = "UPDATE usuario SET Nombre = @nombre, FechaDeNacimiento = @fecha_de_nacimiento, Telefono = @telefono, Direccion = @direccion, EsClienteDesde = @fecha_de_inscripcion WHERE ID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conec.getConexion());
                    cmd.Parameters.AddWithValue("@nombre", textnombre.Text);
                    cmd.Parameters.AddWithValue("@id", textid.Text);
                    cmd.Parameters.AddWithValue("@fecha_de_nacimiento", textfechadenacimiento.Text);
                    cmd.Parameters.AddWithValue("@telefono", texttelefono.Text);
                    cmd.Parameters.AddWithValue("@direccion", textdireccion.Text);
                    cmd.Parameters.AddWithValue("@fecha_de_inscripcion", textfechadeinscripcion.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos actalizados exitosamente");
                    conec.cargaTabla("SELECT * FROM usuario", "usuario", dataGridView1, conec.conexion);
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
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            conec = new conexion_xd();

            if (!string.IsNullOrEmpty(textid.Text))
            {
                try
                {
                    string query = "DELETE FROM usuario WHERE ID = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conec.getConexion());
                    cmd.Parameters.AddWithValue("@id", textid.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos eliminados exitosamente");
                    conec.cargaTabla("SELECT * FROM usuario", "usuario", dataGridView1, conec.conexion);
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

        private void buscar_Click(object sender, EventArgs e)
        {

            conec = new conexion_xd();

            try
            {
                string query = "SELECT * FROM usuario WHERE Nombre LIKE @Nombre";
                MySqlCommand cmd = new MySqlCommand(query, conec.getConexion());
                cmd.Parameters.AddWithValue("@Nombre", "%" + textnombre.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "usuario");
                dataGridView1.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textnombre.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textid.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textfechadenacimiento.Text = dataGridView1.SelectedCells[2].Value.ToString();
            texttelefono.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textdireccion.Text = dataGridView1.SelectedCells[4].Value.ToString();
            textfechadeinscripcion.Text = dataGridView1.SelectedCells[5].Value.ToString();
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(textnombre.Text) || string.IsNullOrEmpty(textid.Text) ||
                string.IsNullOrEmpty(textfechadenacimiento.Text) || string.IsNullOrEmpty(texttelefono.Text) ||
                string.IsNullOrEmpty(textdireccion.Text) || string.IsNullOrEmpty(textfechadeinscripcion.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return false;
            }
            return true;
        }
    }
}
