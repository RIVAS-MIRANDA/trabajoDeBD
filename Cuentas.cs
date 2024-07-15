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
    public partial class Cuentas : Form
    {
        public Cuentas()
        {
            InitializeComponent();
        }
        //Conexion_xd conec = new Conexion_xd();
        private void Cuentas_Load(object sender, EventArgs e)
        {

            //conec.getConexion();
           // MessageBox.Show("conexion exitosa");

           // conec.cargaTabla("SELECT * FROM cuentas", "cuentas", dataGridView1, conec.conexion);
        }
    }
}
