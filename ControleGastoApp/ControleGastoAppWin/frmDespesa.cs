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
    public partial class frmDespesa : Form
    {
        int _codigoDespesa;
        
        Despesa _despesa;
        DespesaDao _despesaDao;
        
        

        public frmDespesa(int codigo)
        {
            InitializeComponent();
            ListarPessoa();
            
            
            _codigoDespesa = codigo;
            txtCodigoD.Text = _codigoDespesa.ToString();

            if (_codigoDespesa == 0)
            {
                this.Text = "Despesa - Incluir";
            }
            else
            {
                this.Text = "Despesa - Alteração";

                _despesa = new Despesa();
                _despesaDao = new DespesaDao();

                _despesa = _despesaDao.ObtemDespesa(_codigoDespesa);

                if (_despesa == null)
                {
                    MessageBox.Show("Despesa não cadastrada");
                    return;
                }

                
                txbTipoDespesa.Text = _despesa.TipoDespesa;
                txbValorDespesa.Text = _despesa.ValorDespesa.ToString();
                dateTPDespesa.Value = _despesa.DataDespesa;
            }
        }

        public void ListarPessoa()
        {
            PessoaDao pessoaDao = new PessoaDao();
            DataTable dataTablePessoa = new DataTable();
            dataTablePessoa = pessoaDao.ListaPessoa().Tables["pessoa"];
            cbxPessoaD.DataSource = dataTablePessoa;
            cbxPessoaD.DisplayMember = "nome";
            cbxPessoaD.ValueMember = "codPessoa";
            
             
            
        }
        private Int32 PegarCodigoCBX()
        {

            return Convert.ToInt32(cbxPessoaD.SelectedValue);
        }

        private void btnSalvarD_Click(object sender, EventArgs e)
        {
            

            _despesa = new Despesa();
            _despesa.CodPessoa = PegarCodigoCBX();
            _despesa.CodDespesa = _codigoDespesa;
            _despesa.ValorDespesa = Convert.ToDouble(txbValorDespesa.Text);
            _despesa.TipoDespesa = txbTipoDespesa.Text;
            _despesa.DataDespesa = dateTPDespesa.Value.Date;
            

            _despesaDao = new DespesaDao();
            bool resultado = false;

            if (_codigoDespesa == 0)
            {
                resultado = _despesaDao.IncluirDespesa(_despesa);

            }
            else
            {
                resultado = _despesaDao.AlterarDespesa(_despesa);
            }

            if (resultado)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
                if (_codigoDespesa > 0)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel realizar o cadasdtro. Ocorreu um erro. Tente novamente");

            }

            txbValorDespesa.Text = string.Empty;
            txbTipoDespesa.Text = string.Empty;
            dateTPDespesa.Text = string.Empty;

            _codigoDespesa= 0;
        }

        private void btnFecharD_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        
    }
}
