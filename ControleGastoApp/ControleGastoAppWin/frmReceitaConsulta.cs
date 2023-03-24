using ControleGastoAppData.Dao;
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
    public partial class frmReceitaConsulta : Form
    {
        int _codigoReceita;
        public frmReceitaConsulta()
        {
            InitializeComponent();

            AtualizarDGV();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            frmReceita frmReceita = new frmReceita(_codigoReceita);
            frmReceita.ShowDialog();
            AtualizarDGV();
        }

        private int CodigoSelecionado()
        {
            int codigo = 0;
            //verificar se tem alguma linha selecionada
            if (dgvReceita.SelectedRows.Count > 0)
            {
                //obtem o codigo que esta primeira linha selecionada
                codigo = Convert.ToInt32(dgvReceita.CurrentRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Selecione um item da lista");
            }
            return codigo;
        }

        

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            _codigoReceita = CodigoSelecionado();

            if (_codigoReceita > 0)
            {
                frmReceita frmReceita = new frmReceita(_codigoReceita);
                frmReceita.ShowDialog();    

            }
            AtualizarDGV();
            _codigoReceita = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ReceitaDao receitaDao = new ReceitaDao();
            DataSet dataSetReceita = receitaDao.ListaReceita(_codigoReceita);

            dgvReceita.DataSource = dataSetReceita;
            dgvReceita.DataMember = "receita";
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _codigoReceita = CodigoSelecionado();

            var resposta = MessageBox.Show(
                "Deseja excluir esse registro?",
                "Atenção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (resposta == DialogResult.Yes)
            {
                ReceitaDao receitaDao = new ReceitaDao();
                var resultado = receitaDao.ExcluirReceita(_codigoReceita);
                    
            }
            AtualizarDGV();
            _codigoReceita = 0;
        }

        private void frmReceitaConsulta_Load(object sender, EventArgs e)
        {
            AtualizarDGV();
            _codigoReceita = 0;
            
        }

        private void AtualizarDGV()
        {
            ReceitaDao receitaDao = new ReceitaDao();
            DataSet dataSetReceita = receitaDao.ListaReceita(_codigoReceita);
            dgvReceita.DataSource = dataSetReceita;
            dgvReceita.DataMember = "receita";
        }
    }
}
