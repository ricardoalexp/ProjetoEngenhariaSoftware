
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
            this.ckListTratamentos.Location = new System.Drawing.Point(14, 75);
            this.ckListTratamentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckListTratamentos.Name = "ckListTratamentos";
            this.ckListTratamentos.Size = new System.Drawing.Size(357, 224);
            this.ckListTratamentos.TabIndex = 16;
            // 
            // btnAdicionarTratamento
            // 
            this.btnAdicionarTratamento.Location = new System.Drawing.Point(269, 340);
            this.btnAdicionarTratamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionarTratamento.Name = "btnAdicionarTratamento";
            this.btnAdicionarTratamento.Size = new System.Drawing.Size(103, 77);
            this.btnAdicionarTratamento.TabIndex = 15;
            this.btnAdicionarTratamento.Text = "Adicionar Tratamentos Selecionados";
            this.btnAdicionarTratamento.UseVisualStyleBackColor = true;
            this.btnAdicionarTratamento.Click += new System.EventHandler(this.btnAdicionarTratamento_Click);
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(14, 340);
            this.voltarAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(86, 31);
            this.voltarAtras.TabIndex = 14;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            this.voltarAtras.Click += new System.EventHandler(this.voltarAtras_Click);
            // 
            // titleMedicamentos
            // 
            this.titleMedicamentos.AutoSize = true;
            this.titleMedicamentos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleMedicamentos.Location = new System.Drawing.Point(14, 8);
            this.titleMedicamentos.Name = "titleMedicamentos";
            this.titleMedicamentos.Size = new System.Drawing.Size(163, 37);
            this.titleMedicamentos.TabIndex = 13;
            this.titleMedicamentos.Text = "Tratamentos";
            // 
            // AdicionarTratamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 435);
            this.Controls.Add(this.ckListTratamentos);
            this.Controls.Add(this.btnAdicionarTratamento);
            this.Controls.Add(this.voltarAtras);
            this.Controls.Add(this.titleMedicamentos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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