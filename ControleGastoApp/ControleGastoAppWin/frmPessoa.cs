using ControleGastoAppData.Dto;
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
    public partial class frmPessoa : Form
    {
        int _codigoPessoa;
        Pessoa _pessoa;
        PessoaDao _pessoaDao;

        public frmPessoa(int codigo)
        {
            InitializeComponent();

            //preenche o codigo
            _codigoPessoa = codigo;
            txtCodigoP.Text = _codigoPessoa.ToString();

            //verificar se inclusao ou alteracao
            if (_codigoPessoa == 0)
            {
                //this é o proprio formulario = frmPessoa
                this.Text = "Pessoa - Inclusão";
            }
            else
            {
                //1- identifica a operacao de cadastro
                this.Text = "Pessoa - Alteração";

                //2- na alteração preenche o cadastro com os dados do cliente
                _pessoa = new Pessoa();
                _pessoaDao= new PessoaDao();
                _pessoa = _pessoaDao.ObtemPessoa(_codigoPessoa);

                //3- verificar se a pessoa esta cadastrada
                if (_pessoa == null)
                {
                    MessageBox.Show("Pessoa não cadastrada");
                    return;
                }

                //4- preencher o fomrulario com os dados do cliente
                txbNome.Text = _pessoa.Nome;
                txbCpf.Text = _pessoa.Cpf;
                txbEmail.Text = _pessoa.Email;
                

            }

        }

        private void btnSalvarP_Click(object sender, EventArgs e)
        {
            //1 obtem os dados do cadastro
            //atribuir com os dados preenchidos na tela
            
            _pessoa = new Pessoa();
            _pessoa.CodigoPessoa = _codigoPessoa;
            _pessoa.Nome = txbNome.Text;
            _pessoa.Cpf = txbCpf.Text;
            _pessoa.Email = txbEmail.Text;

            //2- salvar os dados do cadastro no banco de dados
            //atributo de escopo para acesso ao banco de dados
            _pessoaDao= new PessoaDao();
            bool resultado = false;
            //verificar se é inclusao ou alteracao
            if (_codigoPessoa == 0)
            {
                //inclusao
                resultado = _pessoaDao.IncluirPessoa(_pessoa);

            }
            else 
            {
                //alteracao
                resultado = _pessoaDao.AlterarPessoa(_pessoa);
               
            }

            //3- avisa sobre o resultado da operacao
            if (resultado)
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
                //verificar se é alteracao
                if (_codigoPessoa > 0)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Não foi possivel realizar o cadastro, ocorreu um erro. Tente novamente.");
            }

            //4- limpa a tela
            txbNome.Text = string.Empty;
            txbEmail.Text = string.Empty;
            txbCpf.Text = string.Empty;

            _codigoPessoa = 0;
        }

        private void btnFecharP_Click(object sender, EventArgs e)
        {
            
            //1- fechar o formulario
            this.Close();
        }

        

        
    }
}
