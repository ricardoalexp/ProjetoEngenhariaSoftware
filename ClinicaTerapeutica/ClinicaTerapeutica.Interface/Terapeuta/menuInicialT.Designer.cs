
namespace ClinicaTerapeutica.Interface.Terapeuta
{
    partial class menuInicialT
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
            this.verSessoes = new System.Windows.Forms.Button();
            this.verTratamentos = new System.Windows.Forms.Button();
            this.desmarcarConsulta = new System.Windows.Forms.Button();
            this.marcarConsulta = new System.Windows.Forms.Button();
            this.tituloBemVindo = new System.Windows.Forms.Label();
            this.verPerscricoes = new System.Windows.Forms.Button();
            this.verConsultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // verSessoes
            // 
            this.verSessoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verSessoes.Location = new System.Drawing.Point(331, 186);
            this.verSessoes.Name = "verSessoes";
            this.verSessoes.Size = new System.Drawing.Size(124, 64);
            this.verSessoes.TabIndex = 13;
            this.verSessoes.Text = "Ver sessões";
            this.verSessoes.UseVisualStyleBackColor = true;
            // 
            // verTratamentos
            // 
            this.verTratamentos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verTratamentos.Location = new System.Drawing.Point(331, 82);
            this.verTratamentos.Name = "verTratamentos";
            this.verTratamentos.Size = new System.Drawing.Size(124, 64);
            this.verTratamentos.TabIndex = 12;
            this.verTratamentos.Text = "Ver tratamentos";
            this.verTratamentos.UseVisualStyleBackColor = true;
            // 
            // desmarcarConsulta
            // 
            this.desmarcarConsulta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desmarcarConsulta.Location = new System.Drawing.Point(177, 186);
            this.desmarcarConsulta.Name = "desmarcarConsulta";
            this.desmarcarConsulta.Size = new System.Drawing.Size(124, 64);
            this.desmarcarConsulta.TabIndex = 11;
            this.desmarcarConsulta.Text = "Desmarcar Consulta";
            this.desmarcarConsulta.UseVisualStyleBackColor = true;
            // 
            // marcarConsulta
            // 
            this.marcarConsulta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marcarConsulta.Location = new System.Drawing.Point(15, 186);
            this.marcarConsulta.Name = "marcarConsulta";
            this.marcarConsulta.Size = new System.Drawing.Size(124, 64);
            this.marcarConsulta.TabIndex = 10;
            this.marcarConsulta.Text = "Marcar consulta";
            this.marcarConsulta.UseVisualStyleBackColor = true;
            // 
            // tituloBemVindo
            // 
            this.tituloBemVindo.AutoSize = true;
            this.tituloBemVindo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tituloBemVindo.Location = new System.Drawing.Point(169, 11);
            this.tituloBemVindo.Name = "tituloBemVindo";
            this.tituloBemVindo.Size = new System.Drawing.Size(132, 32);
            this.tituloBemVindo.TabIndex = 9;
            this.tituloBemVindo.Text = "Bem Vindo";
            // 
            // verPerscricoes
            // 
            this.verPerscricoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verPerscricoes.Location = new System.Drawing.Point(177, 82);
            this.verPerscricoes.Name = "verPerscricoes";
            this.verPerscricoes.Size = new System.Drawing.Size(124, 64);
            this.verPerscricoes.TabIndex = 8;
            this.verPerscricoes.Text = "Ver perscrições";
            this.verPerscricoes.UseVisualStyleBackColor = true;
            // 
            // verConsultas
            // 
            this.verConsultas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verConsultas.Location = new System.Drawing.Point(15, 82);
            this.verConsultas.Name = "verConsultas";
            this.verConsultas.Size = new System.Drawing.Size(124, 64);
            this.verConsultas.TabIndex = 7;
            this.verConsultas.Text = "Ver consultas";
            this.verConsultas.UseVisualStyleBackColor = true;
            // 
            // menuInicialT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 272);
            this.Controls.Add(this.verSessoes);
            this.Controls.Add(this.verTratamentos);
            this.Controls.Add(this.desmarcarConsulta);
            this.Controls.Add(this.marcarConsulta);
            this.Controls.Add(this.tituloBemVindo);
            this.Controls.Add(this.verPerscricoes);
            this.Controls.Add(this.verConsultas);
            this.Name = "menuInicialT";
            this.Text = "menuInicialTerapeuta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verSessoes;
        private System.Windows.Forms.Button verTratamentos;
        private System.Windows.Forms.Button desmarcarConsulta;
        private System.Windows.Forms.Button marcarConsulta;
        private System.Windows.Forms.Label tituloBemVindo;
        private System.Windows.Forms.Button verPerscricoes;
        private System.Windows.Forms.Button verConsultas;
    }
}