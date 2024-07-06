using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void Cuentas_Load(object sender, EventArgs e)
        {
            conec.getConexion();
            MessageBox.Show("conexion exitosa");

            conec.cargaTabla("SELECT * FROM trasaccion", "transaccion", dataGridView1, conec.conexion);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
