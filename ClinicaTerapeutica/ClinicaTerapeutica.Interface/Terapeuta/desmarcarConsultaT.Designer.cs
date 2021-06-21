
namespace ClinicaTerapeutica.Interface.Terapeuta
{
    partial class desmarcarConsultaT
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
            this.desmarcarSelecionados = new System.Windows.Forms.Button();
            this.voltarAtras = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tituloDesmarcarConsulta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // desmarcarSelecionados
            // 
            this.desmarcarSelecionados.Location = new System.Drawing.Point(154, 223);
            this.desmarcarSelecionados.Name = "desmarcarSelecionados";
            this.desmarcarSelecionados.Size = new System.Drawing.Size(85, 55);
            this.desmarcarSelecionados.TabIndex = 7;
            this.desmarcarSelecionados.Text = "Desmarcar consultas selecionadas";
            this.desmarcarSelecionados.UseVisualStyleBackColor = true;
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(12, 239);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(75, 23);
            this.voltarAtras.TabIndex = 6;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 52);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(227, 148);
            this.checkedListBox1.TabIndex = 5;
            // 
            // tituloDesmarcarConsulta
            // 
            this.tituloDesmarcarConsulta.AutoSize = true;
            this.tituloDesmarcarConsulta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tituloDesmarcarConsulta.Location = new System.Drawing.Point(12, 9);
            this.tituloDesmarcarConsulta.Name = "tituloDesmarcarConsulta";
            this.tituloDesmarcarConsulta.Size = new System.Drawing.Size(199, 30);
            this.tituloDesmarcarConsulta.TabIndex = 4;
            this.tituloDesmarcarConsulta.Text = "Desmarcar Consulta";
            // 
            // desmarcarConsultaT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 293);
            this.Controls.Add(this.desmarcarSelecionados);
            this.Controls.Add(this.voltarAtras);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.tituloDesmarcarConsulta);
            this.Name = "desmarcarConsultaT";
            this.Text = "desmarcarConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button desmarcarSelecionados;
        private System.Windows.Forms.Button voltarAtras;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label tituloDesmarcarConsulta;
    }
}