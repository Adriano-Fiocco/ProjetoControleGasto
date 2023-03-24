
namespace ControleGastoAppWin
{
    partial class frmControleGasto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleGasto));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAnalise = new System.Windows.Forms.ToolStripMenuItem();
            this.hISTÓRICOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTRARToolStripMenuItem,
            this.menuAnalise,
            this.hISTÓRICOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTRARToolStripMenuItem
            // 
            this.cADASTRARToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.cADASTRARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaToolStripMenuItem,
            this.receitaToolStripMenuItem,
            this.dispesasToolStripMenuItem});
            this.cADASTRARToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.cADASTRARToolStripMenuItem.ForeColor = System.Drawing.Color.Khaki;
            this.cADASTRARToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.cADASTRARToolStripMenuItem.Name = "cADASTRARToolStripMenuItem";
            this.cADASTRARToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.cADASTRARToolStripMenuItem.Text = "CADASTROS:";
            // 
            // pessoaToolStripMenuItem
            // 
            this.pessoaToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.pessoaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.pessoaToolStripMenuItem.ForeColor = System.Drawing.Color.Khaki;
            this.pessoaToolStripMenuItem.Name = "pessoaToolStripMenuItem";
            this.pessoaToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.pessoaToolStripMenuItem.Text = "Pessoas";
            this.pessoaToolStripMenuItem.Click += new System.EventHandler(this.pessoaToolStripMenuItem_Click);
            // 
            // receitaToolStripMenuItem
            // 
            this.receitaToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.receitaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.receitaToolStripMenuItem.ForeColor = System.Drawing.Color.Khaki;
            this.receitaToolStripMenuItem.Name = "receitaToolStripMenuItem";
            this.receitaToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.receitaToolStripMenuItem.Text = "Receitas";
            this.receitaToolStripMenuItem.Click += new System.EventHandler(this.receitaToolStripMenuItem_Click);
            // 
            // dispesasToolStripMenuItem
            // 
            this.dispesasToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.dispesasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.dispesasToolStripMenuItem.ForeColor = System.Drawing.Color.Khaki;
            this.dispesasToolStripMenuItem.Name = "dispesasToolStripMenuItem";
            this.dispesasToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.dispesasToolStripMenuItem.Text = "Despesas";
            this.dispesasToolStripMenuItem.Click += new System.EventHandler(this.dispesasToolStripMenuItem_Click);
            // 
            // menuAnalise
            // 
            this.menuAnalise.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.menuAnalise.ForeColor = System.Drawing.Color.Khaki;
            this.menuAnalise.Name = "menuAnalise";
            this.menuAnalise.Size = new System.Drawing.Size(87, 25);
            this.menuAnalise.Text = "ANÁLISE";
            this.menuAnalise.Click += new System.EventHandler(this.menuAnalise_Click);
            // 
            // hISTÓRICOToolStripMenuItem
            // 
            this.hISTÓRICOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.hISTÓRICOToolStripMenuItem.ForeColor = System.Drawing.Color.Khaki;
            this.hISTÓRICOToolStripMenuItem.Name = "hISTÓRICOToolStripMenuItem";
            this.hISTÓRICOToolStripMenuItem.Size = new System.Drawing.Size(119, 25);
            this.hISTÓRICOToolStripMenuItem.Text = "HISTÓRICOS:";
            // 
            // frmControleGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmControleGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Gasto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAnalise;
        private System.Windows.Forms.ToolStripMenuItem hISTÓRICOToolStripMenuItem;
    }
}

