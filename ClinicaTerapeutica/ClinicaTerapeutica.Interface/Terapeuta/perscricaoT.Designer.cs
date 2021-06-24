
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // titlePrescricao
            // 
            this.titlePrescricao.AutoSize = true;
            this.titlePrescricao.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titlePrescricao.Location = new System.Drawing.Point(14, 12);
            this.titlePrescricao.Name = "titlePrescricao";
            this.titlePrescricao.Size = new System.Drawing.Size(172, 46);
            this.titlePrescricao.TabIndex = 10;
            this.titlePrescricao.Text = "Prescrição";
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(14, 413);
            this.voltarAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(110, 56);
            this.voltarAtras.TabIndex = 8;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            this.voltarAtras.Click += new System.EventHandler(this.voltarAtras_Click);
            // 
            // btnAdicionarMedicamento
            // 
            this.btnAdicionarMedicamento.Location = new System.Drawing.Point(287, 413);
            this.btnAdicionarMedicamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionarMedicamento.Name = "btnAdicionarMedicamento";
            this.btnAdicionarMedicamento.Size = new System.Drawing.Size(110, 56);
            this.btnAdicionarMedicamento.TabIndex = 11;
            this.btnAdicionarMedicamento.Text = "Adicionar Medicamento";
            this.btnAdicionarMedicamento.UseVisualStyleBackColor = true;
            this.btnAdicionarMedicamento.Click += new System.EventHandler(this.btnAdicionarMedicamento_Click);
            // 
            // btnAdicionarExercício
            // 
            this.btnAdicionarExercício.Location = new System.Drawing.Point(144, 413);
            this.btnAdicionarExercício.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionarExercício.Name = "btnAdicionarExercício";
            this.btnAdicionarExercício.Size = new System.Drawing.Size(110, 56);
            this.btnAdicionarExercício.TabIndex = 12;
            this.btnAdicionarExercício.Text = "Adicionar Exercício";
            this.btnAdicionarExercício.UseVisualStyleBackColor = true;
            this.btnAdicionarExercício.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdicionarTratamento
            // 
            this.btnAdicionarTratamento.Location = new System.Drawing.Point(417, 413);
            this.btnAdicionarTratamento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionarTratamento.Name = "btnAdicionarTratamento";
            this.btnAdicionarTratamento.Size = new System.Drawing.Size(110, 56);
            this.btnAdicionarTratamento.TabIndex = 13;
            this.btnAdicionarTratamento.Text = "Adicionar Tratamento";
            this.btnAdicionarTratamento.UseVisualStyleBackColor = true;
            this.btnAdicionarTratamento.Click += new System.EventHandler(this.button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 84);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(513, 301);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            // 
            // PerscricaoT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 491);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnAdicionarTratamento);
            this.Controls.Add(this.btnAdicionarExercício);
            this.Controls.Add(this.btnAdicionarMedicamento);
            this.Controls.Add(this.titlePrescricao);
            this.Controls.Add(this.voltarAtras);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}