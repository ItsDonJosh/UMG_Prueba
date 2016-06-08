using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormProy
{
    public partial class frmProyecto : Form
    {
        public frmProyecto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnBorrar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblTexto.Text = txtTexto.Text;
            btnBorrar.Enabled = true;
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTexto_Click(object sender, EventArgs e)
        {
          
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lblTexto.Text = "";
            txtTexto.Text = "";
            btnBorrar.Enabled = false;
        }
    }
}
