
namespace ControleGastoAppWin
{
    partial class frmReceita
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceita));
            this.lblValorRenda = new System.Windows.Forms.Label();
            this.txbValorRenda = new System.Windows.Forms.TextBox();
            this.lblFonteRenda = new System.Windows.Forms.Label();
            this.txbFonteRenda = new System.Windows.Forms.TextBox();
            this.gbxCadastroR = new System.Windows.Forms.GroupBox();
            this.dateTPReceita = new System.Windows.Forms.DateTimePicker();
            this.lbldataReceita = new System.Windows.Forms.Label();
            this.cbxPessoaR = new System.Windows.Forms.ComboBox();
            this.lblPessoaR = new System.Windows.Forms.Label();
            this.lblReceita = new System.Windows.Forms.Label();
            this.lblCodigoR = new System.Windows.Forms.Label();
            this.txtCodigoR = new System.Windows.Forms.TextBox();
            this.btnSalvarR = new System.Windows.Forms.Button();
            this.btnFecharR = new System.Windows.Forms.Button();
            this.gbxCadastroR.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValorRenda
            // 
            this.lblValorRenda.AutoSize = true;
            this.lblValorRenda.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValorRenda.ForeColor = System.Drawing.Color.White;
            this.lblValorRenda.Location = new System.Drawing.Point(6, 148);
            this.lblValorRenda.Name = "lblValorRenda";
            this.lblValorRenda.Size = new System.Drawing.Size(176, 25);
            this.lblValorRenda.TabIndex = 2;
            this.lblValorRenda.Text = "VALOR DE  RENDA:";
            // 
            // txbValorRenda
            // 
            this.txbValorRenda.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbValorRenda.Location = new System.Drawing.Point(6, 175);
            this.txbValorRenda.Name = "txbValorRenda";
            this.txbValorRenda.Size = new System.Drawing.Size(300, 27);
            this.txbValorRenda.TabIndex = 3;
            // 
            // lblFonteRenda
            // 
            this.lblFonteRenda.AutoSize = true;
            this.lblFonteRenda.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFonteRenda.ForeColor = System.Drawing.Color.White;
            this.lblFonteRenda.Location = new System.Drawing.Point(6, 92);
            this.lblFonteRenda.Name = "lblFonteRenda";
            this.lblFonteRenda.Size = new System.Drawing.Size(170, 25);
            this.lblFonteRenda.TabIndex = 4;
            this.lblFonteRenda.Text = "FONTE DE RENDA:";
            // 
            // txbFonteRenda
            // 
            this.txbFonteRenda.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbFonteRenda.Location = new System.Drawing.Point(6, 119);
            this.txbFonteRenda.Name = "txbFonteRenda";
            this.txbFonteRenda.Size = new System.Drawing.Size(300, 27);
            this.txbFonteRenda.TabIndex = 5;
            // 
            // gbxCadastroR
            // 
            this.gbxCadastroR.BackColor = System.Drawing.Color.Transparent;
            this.gbxCadastroR.Controls.Add(this.dateTPReceita);
            this.gbxCadastroR.Controls.Add(this.lbldataReceita);
            this.gbxCadastroR.Controls.Add(this.cbxPessoaR);
            this.gbxCadastroR.Controls.Add(this.lblPessoaR);
            this.gbxCadastroR.Controls.Add(this.txbFonteRenda);
            this.gbxCadastroR.Controls.Add(this.lblFonteRenda);
            this.gbxCadastroR.Controls.Add(this.lblValorRenda);
            this.gbxCadastroR.Controls.Add(this.txbValorRenda);
            this.gbxCadastroR.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxCadastroR.ForeColor = System.Drawing.SystemColors.Window;
            this.gbxCadastroR.Location = new System.Drawing.Point(26, 82);
            this.gbxCadastroR.Name = "gbxCadastroR";
            this.gbxCadastroR.Size = new System.Drawing.Size(324, 267);
            this.gbxCadastroR.TabIndex = 6;
            this.gbxCadastroR.TabStop = false;
            this.gbxCadastroR.Text = "Cadastro Receita";
            // 
            // dateTPReceita
            // 
            this.dateTPReceita.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPReceita.Location = new System.Drawing.Point(6, 235);
            this.dateTPReceita.Name = "dateTPReceita";
            this.dateTPReceita.Size = new System.Drawing.Size(170, 23);
            this.dateTPReceita.TabIndex = 9;
            this.dateTPReceita.Value = new System.DateTime(2023, 3, 3, 20, 17, 20, 0);
            // 
            // lbldataReceita
            // 
            this.lbldataReceita.AutoSize = true;
            this.lbldataReceita.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldataReceita.ForeColor = System.Drawing.Color.White;
            this.lbldataReceita.Location = new System.Drawing.Point(6, 207);
            this.lbldataReceita.Name = "lbldataReceita";
            this.lbldataReceita.Size = new System.Drawing.Size(173, 25);
            this.lbldataReceita.TabIndex = 8;
            this.lbldataReceita.Text = "DATA DA RECEITA:";
            // 
            // cbxPessoaR
            // 
            this.cbxPessoaR.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxPessoaR.FormattingEnabled = true;
            this.cbxPessoaR.Location = new System.Drawing.Point(6, 62);
            this.cbxPessoaR.Name = "cbxPessoaR";
            this.cbxPessoaR.Size = new System.Drawing.Size(300, 28);
            this.cbxPessoaR.TabIndex = 7;
            // 
            // lblPessoaR
            // 
            this.lblPessoaR.AutoSize = true;
            this.lblPessoaR.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPessoaR.ForeColor = System.Drawing.Color.White;
            this.lblPessoaR.Location = new System.Drawing.Point(6, 35);
            this.lblPessoaR.Name = "lblPessoaR";
            this.lblPessoaR.Size = new System.Drawing.Size(85, 25);
            this.lblPessoaR.TabIndex = 6;
            this.lblPessoaR.Text = "PESSOA:";
            // 
            // lblReceita
            // 
            this.lblReceita.AutoSize = true;
            this.lblReceita.BackColor = System.Drawing.Color.Transparent;
            this.lblReceita.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblReceita.ForeColor = System.Drawing.Color.Cyan;
            this.lblReceita.Location = new System.Drawing.Point(26, 41);
            this.lblReceita.Name = "lblReceita";
            this.lblReceita.Size = new System.Drawing.Size(111, 37);
            this.lblReceita.TabIndex = 7;
            this.lblReceita.Text = "Receita";
            // 
            // lblCodigoR
            // 
            this.lblCodigoR.AutoSize = true;
            this.lblCodigoR.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoR.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigoR.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCodigoR.Location = new System.Drawing.Point(250, 23);
            this.lblCodigoR.Name = "lblCodigoR";
            this.lblCodigoR.Size = new System.Drawing.Size(58, 20);
            this.lblCodigoR.TabIndex = 8;
            this.lblCodigoR.Text = "Codígo";
            // 
            // txtCodigoR
            // 
            this.txtCodigoR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoR.Location = new System.Drawing.Point(250, 51);
            this.txtCodigoR.Name = "txtCodigoR";
            this.txtCodigoR.Size = new System.Drawing.Size(100, 25);
            this.txtCodigoR.TabIndex = 9;
            this.txtCodigoR.Text = "0";
            this.txtCodigoR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSalvarR
            // 
            this.btnSalvarR.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvarR.FlatAppearance.BorderSize = 2;
            this.btnSalvarR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarR.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarR.ForeColor = System.Drawing.Color.White;
            this.btnSalvarR.Location = new System.Drawing.Point(112, 355);
            this.btnSalvarR.Name = "btnSalvarR";
            this.btnSalvarR.Size = new System.Drawing.Size(75, 35);
            this.btnSalvarR.TabIndex = 10;
            this.btnSalvarR.Text = "Salvar";
            this.btnSalvarR.UseVisualStyleBackColor = false;
            this.btnSalvarR.Click += new System.EventHandler(this.btnSalvarR_Click);
            // 
            // btnFecharR
            // 
            this.btnFecharR.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharR.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFecharR.FlatAppearance.BorderSize = 2;
            this.btnFecharR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharR.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFecharR.ForeColor = System.Drawing.Color.White;
            this.btnFecharR.Location = new System.Drawing.Point(215, 355);
            this.btnFecharR.Name = "btnFecharR";
            this.btnFecharR.Size = new System.Drawing.Size(75, 35);
            this.btnFecharR.TabIndex = 11;
            this.btnFecharR.Text = "Fechar";
            this.btnFecharR.UseVisualStyleBackColor = false;
            this.btnFecharR.Click += new System.EventHandler(this.btnFecharR_Click);
            // 
            // frmReceita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 401);
            this.Controls.Add(this.btnFecharR);
            this.Controls.Add(this.btnSalvarR);
            this.Controls.Add(this.txtCodigoR);
            this.Controls.Add(this.lblCodigoR);
            this.Controls.Add(this.lblReceita);
            this.Controls.Add(this.gbxCadastroR);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "frmReceita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receitas";
            this.Load += new System.EventHandler(this.frmReceita_Load);
            this.gbxCadastroR.ResumeLayout(false);
            this.gbxCadastroR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblValorRenda;
        private System.Windows.Forms.TextBox txbValorRenda;
        private System.Windows.Forms.Label lblFonteRenda;
        private System.Windows.Forms.TextBox txbFonteRenda;
        private System.Windows.Forms.GroupBox gbxCadastroR;
        private System.Windows.Forms.Label lblReceita;
        private System.Windows.Forms.Label lblCodigoR;
        private System.Windows.Forms.TextBox txtCodigoR;
        private System.Windows.Forms.Button btnSalvarR;
        private System.Windows.Forms.Button btnFecharR;
        private System.Windows.Forms.ComboBox cbxPessoaR;
        private System.Windows.Forms.Label lblPessoaR;
        private System.Windows.Forms.DateTimePicker dateTPReceita;
        private System.Windows.Forms.Label lbldataReceita;
    }
}