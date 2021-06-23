
namespace ClinicaTerapeutica.Interface
{
    partial class VerConsultasP
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
            this.consultasMarcadas = new System.Windows.Forms.Label();
            this.voltarAtras = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.desmarcarSelecionadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // consultasMarcadas
            // 
            this.consultasMarcadas.AutoSize = true;
            this.consultasMarcadas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consultasMarcadas.Location = new System.Drawing.Point(67, 9);
            this.consultasMarcadas.Name = "consultasMarcadas";
            this.consultasMarcadas.Size = new System.Drawing.Size(198, 30);
            this.consultasMarcadas.TabIndex = 1;
            this.consultasMarcadas.Text = "Consultas marcadas";
            this.consultasMarcadas.Click += new System.EventHandler(this.label1_Click);
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(12, 274);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(75, 23);
            this.voltarAtras.TabIndex = 2;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            this.voltarAtras.Click += new System.EventHandler(this.voltarAtras_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 42);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(314, 220);
            this.checkedListBox1.TabIndex = 3;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // desmarcarSelecionadas
            // 
            this.desmarcarSelecionadas.Location = new System.Drawing.Point(240, 274);
            this.desmarcarSelecionadas.Name = "desmarcarSelecionadas";
            this.desmarcarSelecionadas.Size = new System.Drawing.Size(86, 67);
            this.desmarcarSelecionadas.TabIndex = 4;
            this.desmarcarSelecionadas.Text = "Desmarcar consultas Selecionadas";
            this.desmarcarSelecionadas.UseVisualStyleBackColor = true;
            this.desmarcarSelecionadas.Click += new System.EventHandler(this.desmarcarSelecionadas_Click);
            // 
            // VerConsultasP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 353);
            this.Controls.Add(this.desmarcarSelecionadas);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.voltarAtras);
            this.Controls.Add(this.consultasMarcadas);
            this.Name = "VerConsultasP";
            this.Text = "Consultas Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label consultasMarcadas;
        private System.Windows.Forms.Button voltarAtras;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button desmarcarSelecionadas;
    }
}