using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGaragem
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 cadastroCliente = new Form1();
            cadastroCliente.MdiParent = this;
            cadastroCliente.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaCliente consultaCliente = new ConsultaCliente();
            consultaCliente.MdiParent = this;
            consultaCliente.Show();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void motorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCarro cadastroCarro = new CadastroCarro();
            cadastroCarro.MdiParent = this;
            cadastroCarro.Show();
        }
    }
}
