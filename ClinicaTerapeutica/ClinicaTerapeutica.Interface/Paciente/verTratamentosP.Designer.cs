
namespace ClinicaTerapeutica.Interface.Paciente
{
    partial class VerTratamentosP
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
            this.titleTratamentos = new System.Windows.Forms.Label();
            this.listTratamentos = new System.Windows.Forms.ListBox();
            this.voltarAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTratamentos
            // 
            this.titleTratamentos.AutoSize = true;
            this.titleTratamentos.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleTratamentos.Location = new System.Drawing.Point(12, 9);
            this.titleTratamentos.Name = "titleTratamentos";
            this.titleTratamentos.Size = new System.Drawing.Size(163, 37);
            this.titleTratamentos.TabIndex = 5;
            this.titleTratamentos.Text = "Tratamentos";
            // 
            // listTratamentos
            // 
            this.listTratamentos.FormattingEnabled = true;
            this.listTratamentos.ItemHeight = 15;
            this.listTratamentos.Location = new System.Drawing.Point(12, 49);
            this.listTratamentos.Name = "listTratamentos";
            this.listTratamentos.Size = new System.Drawing.Size(304, 169);
            this.listTratamentos.TabIndex = 6;
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(12, 233);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(75, 23);
            this.voltarAtras.TabIndex = 7;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            this.voltarAtras.Click += new System.EventHandler(this.voltarAtras_Click);
            // 
            // verTratamentosP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 271);
            this.Controls.Add(this.voltarAtras);
            this.Controls.Add(this.listTratamentos);
            this.Controls.Add(this.titleTratamentos);
            this.Name = "verTratamentosP";
            this.Text = "verTratamentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleTratamentos;
        private System.Windows.Forms.ListBox listTratamentos;
        private System.Windows.Forms.Button voltarAtras;
    }
}