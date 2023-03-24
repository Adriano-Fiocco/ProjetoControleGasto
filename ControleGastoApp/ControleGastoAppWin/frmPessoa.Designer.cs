
namespace ControleGastoAppWin
{
    partial class frmPessoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPessoa));
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txbCpf = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.gbxCadastroP = new System.Windows.Forms.GroupBox();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.btnSalvarP = new System.Windows.Forms.Button();
            this.btnFecharP = new System.Windows.Forms.Button();
            this.gbxCadastroP.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbNome.Location = new System.Drawing.Point(6, 47);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(300, 27);
            this.txbNome.TabIndex = 1;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCpf.ForeColor = System.Drawing.Color.White;
            this.lblCpf.Location = new System.Drawing.Point(6, 77);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(48, 25);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(6, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(72, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "NOME:";
            // 
            // txbCpf
            // 
            this.txbCpf.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbCpf.Location = new System.Drawing.Point(6, 105);
            this.txbCpf.Name = "txbCpf";
            this.txbCpf.Size = new System.Drawing.Size(300, 27);
            this.txbCpf.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(6, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(79, 25);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-MAIL:";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbEmail.Location = new System.Drawing.Point(6, 163);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(300, 27);
            this.txbEmail.TabIndex = 5;
            // 
            // gbxCadastroP
            // 
            this.gbxCadastroP.BackColor = System.Drawing.Color.Transparent;
            this.gbxCadastroP.Controls.Add(this.lblNome);
            this.gbxCadastroP.Controls.Add(this.txbEmail);
            this.gbxCadastroP.Controls.Add(this.txbNome);
            this.gbxCadastroP.Controls.Add(this.lblEmail);
            this.gbxCadastroP.Controls.Add(this.lblCpf);
            this.gbxCadastroP.Controls.Add(this.txbCpf);
            this.gbxCadastroP.ForeColor = System.Drawing.Color.White;
            this.gbxCadastroP.Location = new System.Drawing.Point(25, 83);
            this.gbxCadastroP.Name = "gbxCadastroP";
            this.gbxCadastroP.Size = new System.Drawing.Size(318, 219);
            this.gbxCadastroP.TabIndex = 6;
            this.gbxCadastroP.TabStop = false;
            this.gbxCadastroP.Text = "Cadastro Pessoa";
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.BackColor = System.Drawing.Color.Transparent;
            this.lblPessoa.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblPessoa.ForeColor = System.Drawing.Color.Cyan;
            this.lblPessoa.Location = new System.Drawing.Point(25, 43);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(104, 37);
            this.lblPessoa.TabIndex = 7;
            this.lblPessoa.Text = "Pessoa";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCodigo.ForeColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(242, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(58, 20);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Codígo";
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCodigoP.Location = new System.Drawing.Point(242, 50);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(100, 25);
            this.txtCodigoP.TabIndex = 9;
            this.txtCodigoP.Text = "0";
            this.txtCodigoP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSalvarP
            // 
            this.btnSalvarP.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalvarP.FlatAppearance.BorderSize = 2;
            this.btnSalvarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarP.ForeColor = System.Drawing.Color.White;
            this.btnSalvarP.Location = new System.Drawing.Point(95, 308);
            this.btnSalvarP.Name = "btnSalvarP";
            this.btnSalvarP.Size = new System.Drawing.Size(75, 35);
            this.btnSalvarP.TabIndex = 10;
            this.btnSalvarP.Text = "Salvar";
            this.btnSalvarP.UseVisualStyleBackColor = false;
            this.btnSalvarP.Click += new System.EventHandler(this.btnSalvarP_Click);
            // 
            // btnFecharP
            // 
            this.btnFecharP.BackColor = System.Drawing.Color.Transparent;
            this.btnFecharP.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFecharP.FlatAppearance.BorderSize = 2;
            this.btnFecharP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFecharP.ForeColor = System.Drawing.Color.White;
            this.btnFecharP.Location = new System.Drawing.Point(206, 308);
            this.btnFecharP.Name = "btnFecharP";
            this.btnFecharP.Size = new System.Drawing.Size(75, 35);
            this.btnFecharP.TabIndex = 11;
            this.btnFecharP.Text = "Fechar";
            this.btnFecharP.UseVisualStyleBackColor = false;
            this.btnFecharP.Click += new System.EventHandler(this.btnFecharP_Click);
            // 
            // frmPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnFecharP);
            this.Controls.Add(this.btnSalvarP);
            this.Controls.Add(this.txtCodigoP);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPessoa);
            this.Controls.Add(this.gbxCadastroP);
            this.MaximizeBox = false;
            this.Name = "frmPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pessoa";
            this.gbxCadastroP.ResumeLayout(false);
            this.gbxCadastroP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbCpf;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.GroupBox gbxCadastroP;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.Button btnSalvarP;
        private System.Windows.Forms.Button btnFecharP;
    }
}