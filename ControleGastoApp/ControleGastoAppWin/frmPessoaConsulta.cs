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
    public partial class frmPessoaConsulta : Form
    {
        //Atributo
        int _codigoPessoa;

        public frmPessoaConsulta()
        {
            InitializeComponent();
            //Pega o codigo do cliente da tela
            _codigoPessoa = 0;
            AtualizarDGV();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            //Relacao de formulario mestre e detalhe
            frmPessoa frmPessoa = new frmPessoa(_codigoPessoa);
            //Exibe  com jabela filha
            frmPessoa.ShowDialog();
            AtualizarDGV();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            _codigoPessoa = CodigoSelecionado();
            //Verificar se é uma alteracao
            if (_codigoPessoa > 0)
            {
                //vai para o formulario de cadastro
                //Relacao de formulario mestre e detalhe
                frmPessoa frmPessoa = new frmPessoa(_codigoPessoa);
                //exibe com janela filha
                frmPessoa.ShowDialog();
            }
            AtualizarDGV();
            _codigoPessoa = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //1- acesso ao banco de daos e obetendo a lista de clientes
            PessoaDao pessoaDao = new PessoaDao();
            DataSet dataSetPessoa = pessoaDao.ListaPessoa();

            //2- preencher o controle DataGridview com o dataset
            dgvPessoa.DataSource = dataSetPessoa;
            dgvPessoa.DataMember = "pessoa";
        }

        private int CodigoSelecionado()
        {
            int codigo = 0;
            //verificar se tem alguma linha selecionada
            if (dgvPessoa.SelectedRows.Count > 0)
            {
                //obtem o codigo que esta primeira linha selecionada
                codigo = Convert.ToInt32(dgvPessoa.CurrentRow.Cells[0].Value);
            }
            else
            {
                MessageBox.Show("Selecione um item da lista");
            }
            return codigo;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //1- obtem o codigo do cliente selecionado na lista
            _codigoPessoa = CodigoSelecionado();
            ReceitaDao receitaDao = new ReceitaDao();
            DespesaDao despesaDao = new DespesaDao();

            receitaDao.DeletarTudoReceita(_codigoPessoa);
            despesaDao.DeletarTudoDespesa(_codigoPessoa);


            //2- pergunta se deseja mesmo fazer a exclusao
            var resposta = MessageBox.Show(
                "Deseja excluir esse registro?",
                "Atenção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            //3- verificar a resposta no banco de dados
            if (resposta == DialogResult.Yes)
            {
                //4- faz a axclusao no banco de dados
                PessoaDao pessoaDao = new PessoaDao();
                var resultado = pessoaDao.ExcluirPessoa(_codigoPessoa);
            }
            AtualizarDGV();
            _codigoPessoa = 0;
        }

        private void AtualizarDGV()
        {
            PessoaDao pessoaDao = new PessoaDao();
            DataSet dataSetPessoa = pessoaDao.ListaPessoa();
            dgvPessoa.DataSource = dataSetPessoa;
            dgvPessoa.DataMember = "pessoa";
        }

        private void frmPessoaConsulta_Load(object sender, EventArgs e)
        {
            AtualizarDGV();
        }
    }
}
