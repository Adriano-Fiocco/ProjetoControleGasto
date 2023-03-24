using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleGastoAppData.Dao;

namespace ControleGastoAppWin
{
    public partial class frmDespesaConsulta : Form
    {
        int _codigoDespesa;
        public frmDespesaConsulta()
        {
            InitializeComponent();

            AtualizarDGV();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            
            frmDespesa frmDespesa = new frmDespesa(_codigoDespesa);
            frmDespesa.ShowDialog();
            AtualizarDGV();
        }

        private int CodigoSelecionado()
        {
            int codigo = 0;
            //verificar se tem alguma linha selecionada
            if (dgvDespesa.SelectedRows.Count > 0)
            {
                //obtem o codigo que esta primeira linha selecionada
                codigo = Convert.ToInt32(dgvDespesa.CurrentRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Selecione um item da lista");
            }
            return codigo;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            _codigoDespesa = CodigoSelecionado();

            if (_codigoDespesa > 0)
            {
                frmDespesa frmDispesa = new frmDespesa(_codigoDespesa);
                frmDispesa.ShowDialog();
            }
            AtualizarDGV();
            _codigoDespesa = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DespesaDao despesaDao = new DespesaDao();
            DataSet dataSetDispesa = despesaDao.ListaDespesa(_codigoDespesa);
            dgvDespesa.DataSource = dataSetDispesa;
            dgvDespesa.DataMember = "despesa";
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _codigoDespesa = CodigoSelecionado();

            var resposta = MessageBox.Show(
                "Deseja excluir esse registro?",
                "Atenção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                DespesaDao despesaDao = new DespesaDao();
                var resultado = despesaDao.ExcluirDespesa(_codigoDespesa);
            }
            AtualizarDGV();
            _codigoDespesa = 0;


        }

        private void frmDispesaConsulta_Load(object sender, EventArgs e)
        {
            _codigoDespesa = 0;
            AtualizarDGV();
        }
        private void AtualizarDGV() 
        {
            DespesaDao despesaDao = new DespesaDao();
            DataSet dataSetDispesa = despesaDao.ListaDespesa(_codigoDespesa);
            dgvDespesa.DataSource = dataSetDispesa;
            dgvDespesa.DataMember = "despesa";
        }
    }
}
