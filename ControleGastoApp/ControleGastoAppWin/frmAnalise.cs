using ControleGastoAppData.Dao;
using ControleGastoAppData.Dto;
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
    public partial class frmAnalise : Form
    {
        Receita _receita;
        ReceitaDao _receitaDao;

        Despesa _despesa;
        DespesaDao _despesaDao;
        
        public frmAnalise()
        {
            InitializeComponent();
            ListarPessoa();
        }

        public void ListarPessoa()
        {
            PessoaDao pessoaDao = new PessoaDao();
            DataTable dataTablePessoa = new DataTable();
            dataTablePessoa = pessoaDao.ListaPessoa().Tables["pessoa"];
            cbxNome.DataSource = dataTablePessoa;
            cbxNome.DisplayMember = "nome";
            cbxNome.ValueMember = "codPessoa";
        }
       

        private Int32 PegarCodigoCBX() 
        {
            return Convert.ToInt32(cbxNome.SelectedValue);
        }

        private void PreencherReceita() 
        {
            _receita = new Receita();
            _receitaDao = new ReceitaDao();
            
            dgvReceita.DataSource =  _receitaDao.ObtemReceitaDaPessoa(PegarCodigoCBX());
            dgvReceita.DataMember = "receita";
        }

        private void PreencherDespesa()
        {
            _despesa = new Despesa();
            _despesaDao = new DespesaDao();

            dgvDespesa.DataSource = _despesaDao.ObtemDespesaDaPessoa(PegarCodigoCBX());
            dgvDespesa.DataMember = "despesa";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PreencherReceita();
            PreencherDespesa();

            double total = SomatorioReceita() - SomatorioDespesa();

            if (total >= 0)
            {
                lblTotalSaldo.Text = total.ToString("C");
                lblTotalSaldo.ForeColor = Color.Khaki;
                
            }
            else
            {
                lblTotalSaldo.Text = total.ToString("C");
                lblTotalSaldo.ForeColor = Color.Red;
            }
           
        }

        public double SomatorioReceita()
        {
            double totalR = 0;
            foreach (DataGridViewRow row in dgvReceita.Rows)
            {
                totalR += Convert.ToDouble(row.Cells["Valor da Renda"].Value);
            }

            lblTotalReceita.Text = Convert.ToDouble(totalR).ToString("C");
            return totalR;
        }

        public double SomatorioDespesa()
        {
            double totalD = 0;
            foreach (DataGridViewRow row in dgvDespesa.Rows)
            {
                totalD += Convert.ToDouble(row.Cells["Valor da Despesa"].Value);
            }

            lblTotalDespesa.Text = Convert.ToDouble(totalD).ToString("C");
            return totalD;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
