using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJER1_G2_POO
{
    public partial class frmventana : Form
    {
        public frmventana()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string texto = txtnombre.Text;
            string mensaje = string.Format("Bienvenido al segundo formulario " + texto);
            Form2 frmrecibe = new Form2(mensaje);
            frmrecibe.Visible = true;
            this.Visible = false;
            //MessageBox.Show("Bienvenido a POO " + texto + " este es tu primer formulario");
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
