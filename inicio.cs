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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }
        conexion_xd conec = new conexion_xd();

        private void inicio_Load(object sender, EventArgs e)
        {

        }
        private void cuentas_Click(object sender, EventArgs e)
        {
            Cuentas cuentas = new Cuentas();
            cuentas.Show();
        }

        private void usuario_Click(object sender, EventArgs e)
        {
          Usuario usuario = new Usuario();
            usuario.Show();
        }

        private void transaccion_Click(object sender, EventArgs e)
        {
            Transaccion transaccion = new Transaccion();
            transaccion.Show();
        }
    }
}
