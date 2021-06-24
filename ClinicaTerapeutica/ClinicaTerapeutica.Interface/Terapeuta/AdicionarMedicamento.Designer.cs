
namespace ClinicaTerapeutica.Interface.Terapeuta
{
    partial class AdicionarMedicamento
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
            this.ckListMedicamentos = new System.Windows.Forms.CheckedListBox();
            this.btnAdicionarMedicamento = new System.Windows.Forms.Button();
            this.voltarAtras = new System.Windows.Forms.Button();
            this.titleMedicamentos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckListMedicamentos
            // 
            this.ckListMedicamentos.FormattingEnabled = true;
            this.ckListMedicamentos.Location = new System.Drawing.Point(14, 81);
            this.ckListMedicamentos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckListMedicamentos.Name = "ckListMedicamentos";
            this.ckListMedicamentos.Size = new System.Drawing.Size(357, 224);
            this.ckListMedicamentos.TabIndex = 12;
            this.ckListMedicamentos.SelectedIndexChanged += new System.EventHandler(this.ckListMedicamentos_SelectedIndexChanged);
            // 
            // btnAdicionarMedicamento
            // 
            this.btnAdicionarMedicamento.Location = new System.Drawing.Point(264, 347);
            this.btnAdicionarMedicamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionarMedicamento.Name = "btnAdicionarMedicamento";
            this.btnAdicionarMedicamento.Size = new System.Drawing.Size(107, 79);
            this.btnAdicionarMedicamento.TabIndex = 11;
            this.btnAdicionarMedicamento.Text = "Adicionar Medicamentos Selecionados";
            this.btnAdicionarMedicamento.UseVisualStyleBackColor = true;
            this.btnAdicionarMedicamento.Click += new System.EventHandler(this.btnAdicionarMedicamento_Click);
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(14, 347);
            this.voltarAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(86, 31);
            this.voltarAtras.TabIndex = 10;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            this.voltarAtras.Click += new System.EventHandler(this.voltarAtras_Click);
            // 
            // titleMedicamentos
            // 
            this.titleMedicamentos.AutoSize = true;
            this.titleMedicamentos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleMedicamentos.Location = new System.Drawing.Point(14, 15);
            this.titleMedicamentos.Name = "titleMedicamentos";
            this.titleMedicamentos.Size = new System.Drawing.Size(192, 37);
            this.titleMedicamentos.TabIndex = 9;
            this.titleMedicamentos.Text = "Medicamentos";
            // 
            // AdicionarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 445);
            this.Controls.Add(this.ckListMedicamentos);
            this.Controls.Add(this.btnAdicionarMedicamento);
            this.Controls.Add(this.voltarAtras);
            this.Controls.Add(this.titleMedicamentos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdicionarMedicamento";
            this.Text = "AdicionarMedicamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ckListMedicamentos;
        private System.Windows.Forms.Button btnAdicionarMedicamento;
        private System.Windows.Forms.Button voltarAtras;
        private System.Windows.Forms.Label titleMedicamentos;
    }
}