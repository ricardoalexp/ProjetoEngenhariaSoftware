
namespace ClinicaTerapeutica.Interface
{
    partial class verConsultasP
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.consultasMarcadas = new System.Windows.Forms.Label();
            this.voltarAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 69);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 199);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            // 
            // verConsultasP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 309);
            this.Controls.Add(this.voltarAtras);
            this.Controls.Add(this.consultasMarcadas);
            this.Controls.Add(this.listBox1);
            this.Name = "verConsultasP";
            this.Text = "Consultas Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label consultasMarcadas;
        private System.Windows.Forms.Button voltarAtras;
    }
}