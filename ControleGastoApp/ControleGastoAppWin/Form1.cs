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
    public partial class frmControleGasto : Form
    {
        public frmControleGasto()
        {
            InitializeComponent();

        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPessoaConsulta frmPessoaConsulta = new frmPessoaConsulta();
            //frmPessoaConsulta.MdiParent = this;
            //frmPessoaConsulta.StartPosition = FormStartPosition.CenterScreen;
            frmPessoaConsulta.Show();
        }

        private void receitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReceitaConsulta frmReceitaConsulta = new frmReceitaConsulta();
            //frmReceitaConsulta.MdiParent = this;
            //frmReceitaConsulta.StartPosition = FormStartPosition.CenterScreen;
            frmReceitaConsulta.Show();
        }

        private void dispesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDespesaConsulta frmDespesaConsulta = new frmDespesaConsulta();
            //frmDespesaConsulta.MdiParent = this;
            //frmDespesaConsulta.StartPosition = FormStartPosition.CenterScreen;
            frmDespesaConsulta.Show();
        }

        private void menuAnalise_Click(object sender, EventArgs e)
        {
            frmAnalise frmAnalise = new frmAnalise();
            frmAnalise.Show();
        }
    }
}
