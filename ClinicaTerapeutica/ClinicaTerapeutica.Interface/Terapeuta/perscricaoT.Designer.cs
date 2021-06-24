
namespace ClinicaTerapeutica.Interface.Terapeuta
{
    partial class PerscricaoT
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
            this.titlePrescricao = new System.Windows.Forms.Label();
            this.voltarAtras = new System.Windows.Forms.Button();
            this.btnAdicionarMedicamento = new System.Windows.Forms.Button();
            this.btnAdicionarExercício = new System.Windows.Forms.Button();
            this.btnAdicionarTratamento = new System.Windows.Forms.Button();
            this.listBoxprescricao = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // titlePrescricao
            // 
            this.titlePrescricao.AutoSize = true;
            this.titlePrescricao.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titlePrescricao.Location = new System.Drawing.Point(12, 9);
            this.titlePrescricao.Name = "titlePrescricao";
            this.titlePrescricao.Size = new System.Drawing.Size(136, 37);
            this.titlePrescricao.TabIndex = 10;
            this.titlePrescricao.Text = "Prescrição";
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(12, 310);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(96, 42);
            this.voltarAtras.TabIndex = 8;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            this.voltarAtras.Click += new System.EventHandler(this.voltarAtras_Click);
            // 
            // btnAdicionarMedicamento
            // 
            this.btnAdicionarMedicamento.Location = new System.Drawing.Point(251, 310);
            this.btnAdicionarMedicamento.Name = "btnAdicionarMedicamento";
            this.btnAdicionarMedicamento.Size = new System.Drawing.Size(96, 42);
            this.btnAdicionarMedicamento.TabIndex = 11;
            this.btnAdicionarMedicamento.Text = "Adicionar Medicamento";
            this.btnAdicionarMedicamento.UseVisualStyleBackColor = true;
            this.btnAdicionarMedicamento.Click += new System.EventHandler(this.btnAdicionarMedicamento_Click);
            // 
            // btnAdicionarExercício
            // 
            this.btnAdicionarExercício.Location = new System.Drawing.Point(126, 310);
            this.btnAdicionarExercício.Name = "btnAdicionarExercício";
            this.btnAdicionarExercício.Size = new System.Drawing.Size(96, 42);
            this.btnAdicionarExercício.TabIndex = 12;
            this.btnAdicionarExercício.Text = "Adicionar Exercício";
            this.btnAdicionarExercício.UseVisualStyleBackColor = true;
            this.btnAdicionarExercício.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdicionarTratamento
            // 
            this.btnAdicionarTratamento.Location = new System.Drawing.Point(365, 310);
            this.btnAdicionarTratamento.Name = "btnAdicionarTratamento";
            this.btnAdicionarTratamento.Size = new System.Drawing.Size(96, 42);
            this.btnAdicionarTratamento.TabIndex = 13;
            this.btnAdicionarTratamento.Text = "Adicionar Tratamento";
            this.btnAdicionarTratamento.UseVisualStyleBackColor = true;
            this.btnAdicionarTratamento.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBoxprescricao
            // 
            this.listBoxprescricao.FormattingEnabled = true;
            this.listBoxprescricao.ItemHeight = 15;
            this.listBoxprescricao.Location = new System.Drawing.Point(12, 49);
            this.listBoxprescricao.Name = "listBoxprescricao";
            this.listBoxprescricao.Size = new System.Drawing.Size(449, 244);
            this.listBoxprescricao.TabIndex = 14;
            this.listBoxprescricao.SelectedIndexChanged += new System.EventHandler(this.listBoxprescricao_SelectedIndexChanged);
            // 
            // PerscricaoT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 368);
            this.Controls.Add(this.listBoxprescricao);
            this.Controls.Add(this.btnAdicionarTratamento);
            this.Controls.Add(this.btnAdicionarExercício);
            this.Controls.Add(this.btnAdicionarMedicamento);
            this.Controls.Add(this.titlePrescricao);
            this.Controls.Add(this.voltarAtras);
            this.Name = "PerscricaoT";
            this.Text = "perscricao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlePrescricao;
        private System.Windows.Forms.Button voltarAtras;
        private System.Windows.Forms.Button btnAdicionarMedicamento;
        private System.Windows.Forms.Button btnAdicionarExercício;
        private System.Windows.Forms.Button btnAdicionarTratamento;
        private System.Windows.Forms.ListBox listBoxprescricao;
    }
}