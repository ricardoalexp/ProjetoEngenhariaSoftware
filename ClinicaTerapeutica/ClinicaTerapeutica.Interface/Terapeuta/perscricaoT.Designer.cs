
namespace ClinicaTerapeutica.Interface.Terapeuta
{
    partial class perscricaoT
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
            this.titlePerscricao = new System.Windows.Forms.Label();
            this.TextBoxPerscricao = new System.Windows.Forms.RichTextBox();
            this.voltarAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlePerscricao
            // 
            this.titlePerscricao.AutoSize = true;
            this.titlePerscricao.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titlePerscricao.Location = new System.Drawing.Point(12, 9);
            this.titlePerscricao.Name = "titlePerscricao";
            this.titlePerscricao.Size = new System.Drawing.Size(135, 37);
            this.titlePerscricao.TabIndex = 10;
            this.titlePerscricao.Text = "Perscrição";
            // 
            // TextBoxPerscricao
            // 
            this.TextBoxPerscricao.Location = new System.Drawing.Point(12, 57);
            this.TextBoxPerscricao.Name = "TextBoxPerscricao";
            this.TextBoxPerscricao.Size = new System.Drawing.Size(254, 226);
            this.TextBoxPerscricao.TabIndex = 9;
            this.TextBoxPerscricao.Text = "";
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(98, 289);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(75, 23);
            this.voltarAtras.TabIndex = 8;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            // 
            // perscricaoT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 335);
            this.Controls.Add(this.titlePerscricao);
            this.Controls.Add(this.TextBoxPerscricao);
            this.Controls.Add(this.voltarAtras);
            this.Name = "perscricaoT";
            this.Text = "perscricao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlePerscricao;
        private System.Windows.Forms.RichTextBox TextBoxPerscricao;
        private System.Windows.Forms.Button voltarAtras;
    }
}