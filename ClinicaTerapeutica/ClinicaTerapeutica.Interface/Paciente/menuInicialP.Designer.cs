
namespace ClinicaTerapeutica.Interface
{
    partial class menuInicialP
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
            this.verConsultas = new System.Windows.Forms.Button();
            this.verPerscricoes = new System.Windows.Forms.Button();
            this.tituloBemVindo = new System.Windows.Forms.Label();
            this.marcarConsulta = new System.Windows.Forms.Button();
            this.desmarcarConsulta = new System.Windows.Forms.Button();
            this.verTratamentos = new System.Windows.Forms.Button();
            this.verSessoes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // verConsultas
            // 
            this.verConsultas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verConsultas.Location = new System.Drawing.Point(33, 80);
            this.verConsultas.Name = "verConsultas";
            this.verConsultas.Size = new System.Drawing.Size(124, 64);
            this.verConsultas.TabIndex = 0;
            this.verConsultas.Text = "Ver consultas";
            this.verConsultas.UseVisualStyleBackColor = true;
            this.verConsultas.Click += new System.EventHandler(this.button1_Click);
            // 
            // verPerscricoes
            // 
            this.verPerscricoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verPerscricoes.Location = new System.Drawing.Point(195, 80);
            this.verPerscricoes.Name = "verPerscricoes";
            this.verPerscricoes.Size = new System.Drawing.Size(124, 64);
            this.verPerscricoes.TabIndex = 1;
            this.verPerscricoes.Text = "Ver perscrições";
            this.verPerscricoes.UseVisualStyleBackColor = true;
            // 
            // tituloBemVindo
            // 
            this.tituloBemVindo.AutoSize = true;
            this.tituloBemVindo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tituloBemVindo.Location = new System.Drawing.Point(187, 9);
            this.tituloBemVindo.Name = "tituloBemVindo";
            this.tituloBemVindo.Size = new System.Drawing.Size(132, 32);
            this.tituloBemVindo.TabIndex = 2;
            this.tituloBemVindo.Text = "Bem Vindo";
            this.tituloBemVindo.Click += new System.EventHandler(this.label1_Click);
            // 
            // marcarConsulta
            // 
            this.marcarConsulta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marcarConsulta.Location = new System.Drawing.Point(33, 184);
            this.marcarConsulta.Name = "marcarConsulta";
            this.marcarConsulta.Size = new System.Drawing.Size(124, 64);
            this.marcarConsulta.TabIndex = 3;
            this.marcarConsulta.Text = "Marcar consulta";
            this.marcarConsulta.UseVisualStyleBackColor = true;
            this.marcarConsulta.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // desmarcarConsulta
            // 
            this.desmarcarConsulta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desmarcarConsulta.Location = new System.Drawing.Point(195, 184);
            this.desmarcarConsulta.Name = "desmarcarConsulta";
            this.desmarcarConsulta.Size = new System.Drawing.Size(124, 64);
            this.desmarcarConsulta.TabIndex = 4;
            this.desmarcarConsulta.Text = "Desmarcar Consulta";
            this.desmarcarConsulta.UseVisualStyleBackColor = true;
            this.desmarcarConsulta.Click += new System.EventHandler(this.cancelarConsulta_Click);
            // 
            // verTratamentos
            // 
            this.verTratamentos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verTratamentos.Location = new System.Drawing.Point(349, 80);
            this.verTratamentos.Name = "verTratamentos";
            this.verTratamentos.Size = new System.Drawing.Size(124, 64);
            this.verTratamentos.TabIndex = 5;
            this.verTratamentos.Text = "Ver tratamentos";
            this.verTratamentos.UseVisualStyleBackColor = true;
            this.verTratamentos.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // verSessoes
            // 
            this.verSessoes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.verSessoes.Location = new System.Drawing.Point(349, 184);
            this.verSessoes.Name = "verSessoes";
            this.verSessoes.Size = new System.Drawing.Size(124, 64);
            this.verSessoes.TabIndex = 6;
            this.verSessoes.Text = "Ver sessões";
            this.verSessoes.UseVisualStyleBackColor = true;
            this.verSessoes.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // menuInicialPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 276);
            this.Controls.Add(this.verSessoes);
            this.Controls.Add(this.verTratamentos);
            this.Controls.Add(this.desmarcarConsulta);
            this.Controls.Add(this.marcarConsulta);
            this.Controls.Add(this.tituloBemVindo);
            this.Controls.Add(this.verPerscricoes);
            this.Controls.Add(this.verConsultas);
            this.Name = "menuInicialPaciente";
            this.Text = "Menu Inicial (Paciente)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button verConsultas;
        private System.Windows.Forms.Button verPerscricoes;
        private System.Windows.Forms.Label tituloBemVindo;
        private System.Windows.Forms.Button marcarConsulta;
        private System.Windows.Forms.Button desmarcarConsulta;
        private System.Windows.Forms.Button verTratamentos;
        private System.Windows.Forms.Button verSessoes;
    }
}