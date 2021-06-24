
namespace ClinicaTerapeutica.Interface.Terapeuta
{
    partial class AdicionarExercicioT
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
            this.titleExercícos = new System.Windows.Forms.Label();
            this.voltarAtras = new System.Windows.Forms.Button();
            this.btnAdicionarExercicio = new System.Windows.Forms.Button();
            this.ckListExercicios = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // titleExercícos
            // 
            this.titleExercícos.AutoSize = true;
            this.titleExercícos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleExercícos.Location = new System.Drawing.Point(14, 12);
            this.titleExercícos.Name = "titleExercícos";
            this.titleExercícos.Size = new System.Drawing.Size(124, 37);
            this.titleExercícos.TabIndex = 5;
            this.titleExercícos.Text = "Exercícos";
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(14, 344);
            this.voltarAtras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(86, 31);
            this.voltarAtras.TabIndex = 6;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            this.voltarAtras.Click += new System.EventHandler(this.voltarAtras_Click);
            // 
            // btnAdicionarExercicio
            // 
            this.btnAdicionarExercicio.Location = new System.Drawing.Point(270, 344);
            this.btnAdicionarExercicio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionarExercicio.Name = "btnAdicionarExercicio";
            this.btnAdicionarExercicio.Size = new System.Drawing.Size(102, 77);
            this.btnAdicionarExercicio.TabIndex = 7;
            this.btnAdicionarExercicio.Text = "Adicionar Exercícios Selecionados";
            this.btnAdicionarExercicio.UseVisualStyleBackColor = true;
            this.btnAdicionarExercicio.Click += new System.EventHandler(this.btnAdicionarExercicio_Click);
            // 
            // ckListExercicios
            // 
            this.ckListExercicios.FormattingEnabled = true;
            this.ckListExercicios.Location = new System.Drawing.Point(14, 79);
            this.ckListExercicios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckListExercicios.Name = "ckListExercicios";
            this.ckListExercicios.Size = new System.Drawing.Size(357, 224);
            this.ckListExercicios.TabIndex = 8;
            // 
            // AdicionarExercicioT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 452);
            this.Controls.Add(this.ckListExercicios);
            this.Controls.Add(this.btnAdicionarExercicio);
            this.Controls.Add(this.voltarAtras);
            this.Controls.Add(this.titleExercícos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdicionarExercicioT";
            this.Text = "AdicionarExercicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleExercícos;
        private System.Windows.Forms.Button voltarAtras;
        private System.Windows.Forms.Button btnAdicionarExercicio;
        private System.Windows.Forms.CheckedListBox ckListExercicios;
    }
}