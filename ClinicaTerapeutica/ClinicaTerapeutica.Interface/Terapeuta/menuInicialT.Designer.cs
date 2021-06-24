
namespace ClinicaTerapeutica.Interface.Terapeuta
{
    partial class MenuInicialT
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
            this.verTratamentos = new System.Windows.Forms.Button();
            this.marcarConsulta = new System.Windows.Forms.Button();
            this.tituloBemVindo = new System.Windows.Forms.Label();
            this.verPerscricoes = new System.Windows.Forms.Button();
            this.verConsultas = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.criarUtilizador = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.verTratamentos.Click += new System.EventHandler(this.verTratamentos_Click);
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
            this.marcarConsulta.Click += new System.EventHandler(this.marcarConsulta_Click);
            // 
            // tituloBemVindo
            // 
            this.tituloBemVindo.AutoSize = true;
            this.tituloBemVindo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tituloBemVindo.Location = new System.Drawing.Point(120, 9);
            this.tituloBemVindo.Name = "tituloBemVindo";
            this.tituloBemVindo.Size = new System.Drawing.Size(238, 32);
            this.tituloBemVindo.TabIndex = 9;
            this.tituloBemVindo.Text = "Bem vindo terapeuta";
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
            this.verPerscricoes.Click += new System.EventHandler(this.verPerscricoes_Click);
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
            this.verConsultas.Click += new System.EventHandler(this.verConsultas_Click);
            // 
            // logOut
            // 
            this.logOut.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logOut.Location = new System.Drawing.Point(331, 186);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(124, 64);
            this.logOut.TabIndex = 14;
            this.logOut.Text = "LogOut";
            this.logOut.UseVisualStyleBackColor = true;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // criarUtilizador
            // 
            this.criarUtilizador.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.criarUtilizador.Location = new System.Drawing.Point(177, 186);
            this.criarUtilizador.Name = "criarUtilizador";
            this.criarUtilizador.Size = new System.Drawing.Size(124, 64);
            this.criarUtilizador.TabIndex = 15;
            this.criarUtilizador.Text = "Criar utilizador";
            this.criarUtilizador.UseVisualStyleBackColor = true;
            this.criarUtilizador.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuInicialT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 277);
            this.Controls.Add(this.criarUtilizador);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.verTratamentos);
            this.Controls.Add(this.marcarConsulta);
            this.Controls.Add(this.tituloBemVindo);
            this.Controls.Add(this.verPerscricoes);
            this.Controls.Add(this.verConsultas);
            this.Name = "MenuInicialT";
            this.Text = "menuInicialTerapeuta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button verTratamentos;
        private System.Windows.Forms.Button marcarConsulta;
        private System.Windows.Forms.Label tituloBemVindo;
        private System.Windows.Forms.Button verPerscricoes;
        private System.Windows.Forms.Button verConsultas;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button criarUtilizador;
    }
}