﻿
namespace ClinicaTerapeutica.Interface.Terapeuta
{
    partial class AdicionarTratamentos
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
            this.ckListTratamentos = new System.Windows.Forms.CheckedListBox();
            this.btnAdicionarTratamento = new System.Windows.Forms.Button();
            this.voltarAtras = new System.Windows.Forms.Button();
            this.titleMedicamentos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckListTratamentos
            // 
            this.ckListTratamentos.FormattingEnabled = true;
            this.ckListTratamentos.Location = new System.Drawing.Point(12, 56);
            this.ckListTratamentos.Name = "ckListTratamentos";
            this.ckListTratamentos.Size = new System.Drawing.Size(313, 184);
            this.ckListTratamentos.TabIndex = 16;
            this.ckListTratamentos.SelectedIndexChanged += new System.EventHandler(this.ckListTratamentos_SelectedIndexChanged);
            // 
            // btnAdicionarTratamento
            // 
            this.btnAdicionarTratamento.Location = new System.Drawing.Point(235, 255);
            this.btnAdicionarTratamento.Name = "btnAdicionarTratamento";
            this.btnAdicionarTratamento.Size = new System.Drawing.Size(90, 58);
            this.btnAdicionarTratamento.TabIndex = 15;
            this.btnAdicionarTratamento.Text = "Adicionar Tratamentos Selecionados";
            this.btnAdicionarTratamento.UseVisualStyleBackColor = true;
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(12, 255);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(75, 23);
            this.voltarAtras.TabIndex = 14;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            this.voltarAtras.Click += new System.EventHandler(this.voltarAtras_Click);
            // 
            // titleMedicamentos
            // 
            this.titleMedicamentos.AutoSize = true;
            this.titleMedicamentos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleMedicamentos.Location = new System.Drawing.Point(12, 6);
            this.titleMedicamentos.Name = "titleMedicamentos";
            this.titleMedicamentos.Size = new System.Drawing.Size(127, 30);
            this.titleMedicamentos.TabIndex = 13;
            this.titleMedicamentos.Text = "Tratamentos";
            // 
            // AdicionarTratamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 326);
            this.Controls.Add(this.ckListTratamentos);
            this.Controls.Add(this.btnAdicionarTratamento);
            this.Controls.Add(this.voltarAtras);
            this.Controls.Add(this.titleMedicamentos);
            this.Name = "AdicionarTratamentos";
            this.Text = "AdicionarTratamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ckListTratamentos;
        private System.Windows.Forms.Button btnAdicionarTratamento;
        private System.Windows.Forms.Button voltarAtras;
        private System.Windows.Forms.Label titleMedicamentos;
    }
}