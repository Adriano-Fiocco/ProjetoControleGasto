
namespace ControleGastoAppWin
{
    partial class frmDespesa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDespesa));
            this.lblValorDispesa = new System.Windows.Forms.Label();
            this.lblTipoCategoria = new System.Windows.Forms.Label();
            this.txbValorDespesa = new System.Windows.Forms.TextBox();
            this.txbTipoCategoria = new System.Windows.Forms.TextBox();
            this.gbxCadastroD = new System.Windows.Forms.GroupBox();
            this.dateTPDespesa = new System.Windows.Forms.DateTimePicker();
            this.lbldataDespesa = new System.Windows.Forms.Label();
            this.txbTipoDespesa = new System.Windows.Forms.TextBox();
            this.lblTipoDespesa = new System.Windows.Forms.Label();
            this.cbxPessoaD = new System.Windows.Forms.ComboBox();
            this.lblPessoaD = new System.Windows.Forms.Label();
            this.lblDispesa = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoD = new System.Windows.Forms.TextBox();
            this.btnSalvarD = new System.Windows.Forms.Button();
            this.btnFecharD = new System.Windows.Forms.Button();
            this.gbxCadastroD.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValorDispesa
            // 
            this.lblValorDispesa.AutoSize = true;
            this.lblValorDispesa.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorDispesa.ForeColor = System.Drawing.Color.White;
            this.lblValorDispesa.Location = new System.Drawing.Point(6, 138);
            this.lblValorDispesa.Name = "lblValorDispesa";
            this.lblValorDispesa.Size = new System.Drawing.Size(189, 25);
            this.lblValorDispesa.TabIndex = 2;
            this.lblValorDispesa.Text = "VALOR DA DESPESA:";
            // 
            // lblTipoCategoria
            // 
            this.lblTipoCategoria.AutoSize = true;
            this.lblTipoCategoria.Font = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTipoCategoria.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTipoCategoria.Location = new System.Drawing.Point(6, 358);
            this.lblTipoCategoria.Name = "lblTipoCategoria";
            this.lblTipoCategoria.Size = new System.Drawing.Size(194, 25);
            this.lblTipoCategoria.TabIndex = 3;
            this.lblTipoCategoria.Text = "TIPO DE CATEGORIA:";
            // 
            // txbValorDespesa
            // 
            this.txbValorDespesa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbValorDespesa.Location = new System.Drawing.Point(6, 166);
            this.txbValorDespesa.Name = "txbValorDespesa";
            this.txbValorDespesa.Size = new System.Drawing.Size(300, 27);
            this.txbValorDespesa.TabIndex = 6;
            // 
            // txbTipoCategoria
            // 
            this.txbTipoCategoria.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbTipoCategoria.Location = new System.Drawing.Point(290, 349);
            this.txbTipoCategoria.Name = "txbTipoCategoria";
            this.txbTipoCategoria.Size = new System.Drawing.Size(409, 27);
            this.txbTipoCategoria.TabIndex = 7;
            // 
            // gbxCadastroD
            // 
            this.gbxCadastroD.BackColor = System.Drawing.Color.Transparent;
            this.gbxCadastroD.Controls.Add(this.dateTPDespesa);
            this.gbxCadastroD.Controls.Add(this.lbldataDespesa);
            this.gbxCadastroD.Controls.Add(this.txbTipoDespesa);
            this.gbxCadastroD.Controls.Add(this.lblTipoDespesa);
            this.gbxCadastroD.Controls.Add(this.cbxPessoaD);
            this.gbxCadastroD.Controls.Add(this.txbValorDespesa);
            this.gbxCadastroD.Controls.Add(this.lblPessoaD);
            this.gbxCadastroD.Controls.Add(this.txbTipoCategoria);
            this.gbxCadastroD.Controls.Add(this.lblValorDispesa);
            this.gbxCadastroD.Controls.Add(this.lblTipoCategoria);
            this.gbxCadastroD.ForeColor = System.Drawing.Color.White;
            this.gbxCadastroD.Location = new System.Drawing.Point(31, 89);
            this.gbxCadastroD.Name = "gbxCadastroD";
            this.gbxCadastroD.Size = new System.Drawing.Size(324, 260);
            this.gbxCadastroD.TabIndex = 8;
            this.gbxCadastroD.TabStop = false;
            this.gbxCadastroD.Text = "Cadastro Despesa";
            // 
            // dateTPDespesa
            // 
            this.dateTPDespesa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPDespesa.Location = new System.Drawing.Point(6, 224);
            this.dateTPDespesa.Name = "dateTPDespesa";
            this.dateTPDespesa.Size = new System.Drawing.Size(170, 23);
            this.dateTPDespesa.TabIndex = 13;
            // 
            // lbldataDespesa
            // 
            this.lbldataDespesa.AutoSize = true;
            this.lbldataDespesa.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldataDespesa.ForeColor = System.Drawing.Color.White;
            this.lbldataDespesa.Location = new System.Drawing.Point(6, 196);
            this.lbldataDespesa.Name = "lbldataDespesa";
            this.lbldataDespesa.Size = new System.Drawing.Size(178, 25);
            this.lbldataDespesa.TabIndex = 12;
            this.lbldataDespesa.Text = "DATA DA DESPESA:";
            // 
            // txbTipoDespesa
            // 
            this.txbTipoDespesa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbTipoDespesa.Location = new System.Drawing.Point(6, 108);
            this.txbTipoDespesa.Name = "txbTipoDespesa";
            this.txbTipoDespesa.Size = new System.Drawing.Size(300, 27);
            this.txbTipoDespesa.TabIndex = 11;
            // 
            // lblTipoDespesa
            // 
            this.lblTipoDespesa.AutoSize = true;
            this.lblTipoDespesa.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTipoDespesa.ForeColor = System.Drawing.Color.White;
            this.lblTipoDespesa.Location = new System.Drawing.Point(6, 78);
            this.lblTipoDespesa.Name = "lblTipoDespesa";
            this.lblTipoDespesa.Size = new System.Drawing.Size(169, 25);
            this.lblTipoDespesa.TabIndex = 10;
            this.lblTipoDespesa.Text = "TIPO DE DESPESA:";
            // 
            // cbxPessoaD
            // 
            this.cbxPessoaD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxPessoaD.FormattingEnabled = true;
            this.cbxPessoaD.Location = new System.Drawing.Point(6, 47);
            this.cbxPessoaD.Name = "cbxPessoaD";
            this.cbxPessoaD.Size = new System.Drawing.Size(300, 28);
            this.cbxPessoaD.TabIndex = 9;
            // 
            // lblPessoaD
            // 
            this.lblPessoaD.AutoSize = true;
            this.lblPessoaD.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPessoaD.ForeColor = System.Drawing.Color.White;
            this.lblPessoaD.Location = new System.Drawing.Point(6, 19);
            this.lblPessoaD.Name = "lblPessoaD";
            this.lblPessoaD.Size = new System.Drawing.Size(85, 25);
            this.lblPessoaD.TabIndex = 8;
            this.lblPessoaD.Text = "PESSOA:";
            // 
            // lblDispesa
            // 
            this.lblDispesa.AutoSize = true;
            this.lblDispesa.BackColor = System.Drawing.Color.Transparent;
            this.lblDispesa.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblDispesa.ForeColor = System.Drawing.Color.Cyan;
            this.lblDispesa.Location = new System.Drawing.Point(29, 49);
            this.lblDispesa.Name = "lblDispesa";
            this.lblDispesa.Size = new System.Drawing.Size(123, 37);
            this.lblDispesa.TabIndex = 9;
            this.lblDispesa.Text = "Despesa";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(255, 39);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 20);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Codígo";
            // 
            // txtCodigoD
            // 
            this.txtCodigoD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoD.Location = new System.Drawing.Point(255, 62);
            this.txtCodigoD.Name = "txtCodigoD";
            this.txtCodigoD.Size = new System.Drawing.Size(100, 25);
            this.txtCodigoD.TabIndex = 11;
            this.txtCodigoD.Text = "0";
            this.txtCodigoD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSalvarD
            // 
            this.btnSalvarD.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvarD.FlatAppearance.BorderSize = 2;
            this.btnSalvarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarD.ForeColor = System.Drawing.Color.White;
            this.btnSalvarD.Location = new System.Drawing.Point(114, 355);
            this.btnSalvarD.Name = "btnSalvarD";
            this.btnSalvarD.Size = new System.Drawing.Size(75, 34);
            this.btnSalvarD.TabIndex = 12;
            this.btnSalvarD.Text = "Salvar";
            this.btnSalvarD.UseVisualStyleBackColor = false;
            this.btnSalvarD.Click += new System.EventHandler(this.btnSalvarD_Click);
            // 
            // btnFecharD
            // 
            this.btnFecharD.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFecharD.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFecharD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFecharD.ForeColor = System.Drawing.Color.White;
            this.btnFecharD.Location = new System.Drawing.Point(208, 355);
            this.btnFecharD.Name = "btnFecharD";
            this.btnFecharD.Size = new System.Drawing.Size(75, 34);
            this.btnFecharD.TabIndex = 13;
            this.btnFecharD.Text = "Fechar";
            this.btnFecharD.UseVisualStyleBackColor = false;
            this.btnFecharD.Click += new System.EventHandler(this.btnFecharD_Click);
            // 
            // frmDespesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnFecharD;
            this.ClientSize = new System.Drawing.Size(384, 401);
            this.Controls.Add(this.btnFecharD);
            this.Controls.Add(this.btnSalvarD);
            this.Controls.Add(this.txtCodigoD);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblDispesa);
            this.Controls.Add(this.gbxCadastroD);
            this.MaximizeBox = false;
            this.Name = "frmDespesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dispesa";
            this.gbxCadastroD.ResumeLayout(false);
            this.gbxCadastroD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblValorDispesa;
        private System.Windows.Forms.Label lblTipoCategoria;
        private System.Windows.Forms.TextBox txbValorDespesa;
        private System.Windows.Forms.TextBox txbTipoCategoria;
        private System.Windows.Forms.GroupBox gbxCadastroD;
        private System.Windows.Forms.Label lblDispesa;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigoD;
        private System.Windows.Forms.Button btnSalvarD;
        private System.Windows.Forms.Button btnFecharD;
        private System.Windows.Forms.ComboBox cbxPessoaD;
        private System.Windows.Forms.Label lblPessoaD;
        private System.Windows.Forms.TextBox txbTipoDespesa;
        private System.Windows.Forms.Label lblTipoDespesa;
        private System.Windows.Forms.Label lbldataDespesa;
        private System.Windows.Forms.DateTimePicker dateTPDespesa;
    }
}