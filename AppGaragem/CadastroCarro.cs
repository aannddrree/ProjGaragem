using Dados;
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
    public partial class CadastroCarro : Form
    {
        public CadastroCarro()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroCarro_Load(object sender, EventArgs e)
        {
            //IMPLEMENTAR CARREGAR COMBOBOX
            cboMotor.DataSource = new MotorDB().ListarMotor();
            cboMotor.DisplayMember = "Descricao";
            cboMotor.ValueMember = "Id";
        }
    }
}
