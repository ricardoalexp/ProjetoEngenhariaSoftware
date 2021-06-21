
namespace ClinicaTerapeutica.Interface.Terapeuta
{
    partial class verSessoesT
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
            this.voltarAtras = new System.Windows.Forms.Button();
            this.listSessoes = new System.Windows.Forms.ListBox();
            this.titleSessoes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(12, 233);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(75, 23);
            this.voltarAtras.TabIndex = 13;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            // 
            // listSessoes
            // 
            this.listSessoes.FormattingEnabled = true;
            this.listSessoes.ItemHeight = 15;
            this.listSessoes.Location = new System.Drawing.Point(12, 49);
            this.listSessoes.Name = "listSessoes";
            this.listSessoes.Size = new System.Drawing.Size(304, 169);
            this.listSessoes.TabIndex = 12;
            // 
            // titleSessoes
            // 
            this.titleSessoes.AutoSize = true;
            this.titleSessoes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleSessoes.Location = new System.Drawing.Point(12, 9);
            this.titleSessoes.Name = "titleSessoes";
            this.titleSessoes.Size = new System.Drawing.Size(108, 37);
            this.titleSessoes.TabIndex = 11;
            this.titleSessoes.Text = "Sessões";
            // 
            // verSessoesT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 272);
            this.Controls.Add(this.voltarAtras);
            this.Controls.Add(this.listSessoes);
            this.Controls.Add(this.titleSessoes);
            this.Name = "verSessoesT";
            this.Text = "verSessoes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltarAtras;
        private System.Windows.Forms.ListBox listSessoes;
        private System.Windows.Forms.Label titleSessoes;
    }
}