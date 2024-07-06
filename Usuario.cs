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
            
            conec.getConexion();
            MessageBox.Show("conexion exitosa");

            conec.cargaTabla("SELECT * FROM usuario", "usuario", dataGridView1, conec.conexion);

           
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
           
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {

         /*string Consulta = "Select * from usuario";
            SqlDataAdapter adapter = new SqlDataAdapter(Consulta.conec);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
           conec.getConex */
        }

        private void Agregar_Click(object sender, EventArgs e)
        {

        }

        private void buscar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox2.Text = dataGridView1.SelectedCells[0].Value.ToString();
            textBox3.Text = dataGridView1.SelectedCells[1].Value.ToString();
            textBox4.Text = dataGridView1.SelectedCells[2].Value.ToString();
            textBox5.Text = dataGridView1.SelectedCells[3].Value.ToString();
            textBox6.Text = dataGridView1.SelectedCells[4].Value.ToString();
            textBox7.Text = dataGridView1.SelectedCells[5].Value.ToString();
        }
    }
}
