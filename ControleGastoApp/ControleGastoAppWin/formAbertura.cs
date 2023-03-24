using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleGastoAppWin
{
    public partial class formAbertura : Form
    {
        public formAbertura()
        {
            InitializeComponent();
        }

        private void Contador_Tick(object sender, EventArgs e)
        {
            if (barCarregando.Value < 100)
            {
                barCarregando.Value += 50;
            }
            else
            {
                //desabilita o contador
                Contador.Enabled = false;
                //chama o form principal
                frmControleGasto frmControleGasto = new frmControleGasto();
                frmControleGasto.Show();
                // desativa o form de abertura
                this.Visible = false;
            }
        }
    }
}
