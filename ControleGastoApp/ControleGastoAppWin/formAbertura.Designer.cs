﻿namespace ControleGastoAppWin
{
    partial class formAbertura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAbertura));
            this.barCarregando = new System.Windows.Forms.ProgressBar();
            this.Contador = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // barCarregando
            // 
            this.barCarregando.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.barCarregando.Location = new System.Drawing.Point(256, 434);
            this.barCarregando.Name = "barCarregando";
            this.barCarregando.Size = new System.Drawing.Size(293, 23);
            this.barCarregando.TabIndex = 0;
            // 
            // Contador
            // 
            this.Contador.Enabled = true;
            this.Contador.Tick += new System.EventHandler(this.Contador_Tick);
            // 
            // formAbertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.barCarregando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAbertura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formAbertura";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar barCarregando;
        private System.Windows.Forms.Timer Contador;
    }
}