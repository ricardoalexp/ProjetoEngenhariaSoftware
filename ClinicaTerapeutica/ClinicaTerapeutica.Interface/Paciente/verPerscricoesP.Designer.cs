﻿
namespace ClinicaTerapeutica.Interface
{
    partial class verPerscricoesP
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
            this.listPerscricoes = new System.Windows.Forms.ListBox();
            this.titlePerscricoes = new System.Windows.Forms.Label();
            this.voltarAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listPerscricoes
            // 
            this.listPerscricoes.FormattingEnabled = true;
            this.listPerscricoes.ItemHeight = 15;
            this.listPerscricoes.Location = new System.Drawing.Point(12, 49);
            this.listPerscricoes.Name = "listPerscricoes";
            this.listPerscricoes.Size = new System.Drawing.Size(304, 169);
            this.listPerscricoes.TabIndex = 0;
            // 
            // titlePerscricoes
            // 
            this.titlePerscricoes.AutoSize = true;
            this.titlePerscricoes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titlePerscricoes.Location = new System.Drawing.Point(12, 9);
            this.titlePerscricoes.Name = "titlePerscricoes";
            this.titlePerscricoes.Size = new System.Drawing.Size(146, 37);
            this.titlePerscricoes.TabIndex = 4;
            this.titlePerscricoes.Text = "Perscrições";
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(12, 224);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(75, 23);
            this.voltarAtras.TabIndex = 5;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            // 
            // verPerscricoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 261);
            this.Controls.Add(this.voltarAtras);
            this.Controls.Add(this.titlePerscricoes);
            this.Controls.Add(this.listPerscricoes);
            this.Name = "verPerscricoes";
            this.Text = "verPerscricoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listPerscricoes;
        private System.Windows.Forms.Label titlePerscricoes;
        private System.Windows.Forms.Button voltarAtras;
    }
}