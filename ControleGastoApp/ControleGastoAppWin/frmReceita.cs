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
using ControleGastoAppData.Dto;

namespace ControleGastoAppWin
{
    public partial class frmReceita : Form
    {
        int _codigoReceita;
        Receita _receita;
        ReceitaDao _receitaDao;

        public frmReceita(int codigo)
        {
            InitializeComponent();
            ListarPessoa();

            _codigoReceita = codigo;
            txtCodigoR.Text = _codigoReceita.ToString();

            if (_codigoReceita == 0)
            {
                this.Text = "Receita - Inclusão";

            }
            else
            {
                this.Text = "Receita - Alteração";

                _receita = new Receita();
                _receitaDao = new ReceitaDao();

                _receita = _receitaDao.ObtemReceita(_codigoReceita);

                if (_receita == null)
                {
                    MessageBox.Show("Receita não cadastrada");
                }



               
                txbFonteRenda.Text = _receita.TipoRenda;
                txbValorRenda.Text = _receita.ValorRenda.ToString();
                dateTPReceita.Value = _receita.DataReceita;
            }

            

        }


        public void ListarPessoa()
        {
            PessoaDao pessoaDao = new PessoaDao();
            DataTable dataTablePessoa = new DataTable();
            dataTablePessoa = pessoaDao.ListaPessoa().Tables["pessoa"];
            cbxPessoaR.DataSource = dataTablePessoa;
            cbxPessoaR.DisplayMember = "nome";
            cbxPessoaR.ValueMember = "codPessoa";
        }

        

        
        private Int32 PegarCodigoCBX()
        {

            return Convert.ToInt32(cbxPessoaR.SelectedValue);
        }

        private void btnSalvarR_Click(object sender, EventArgs e)
        {
            _receita = new Receita();
            _receita.CodReceita = _codigoReceita;
            _receita.CodPessoa = PegarCodigoCBX();
            _receita.TipoRenda = txbFonteRenda.Text;
            _receita.ValorRenda = Convert.ToDouble(txbValorRenda.Text);
            _receita.DataReceita = dateTPReceita.Value.Date;

            _receitaDao = new ReceitaDao();

            bool resultado = false;

            if (_codigoReceita == 0)
            {
                resultado = _receitaDao.IncluirReceita(_receita);
            }
            else
            {
                resultado = _receitaDao.AlterarReceita(_receita);
                
            }

            if (resultado)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");

                if (_codigoReceita > 0)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel realizar o cadastro. Ocorreu um erro. Tente novamente!");
            }

            txbValorRenda.Text = string.Empty;
            txbFonteRenda.Text = string.Empty;
            dateTPReceita.Text = string.Empty;

            _codigoReceita= 0;
        }

        private void btnFecharR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceita_Load(object sender, EventArgs e)
        {

        }
    }
}
