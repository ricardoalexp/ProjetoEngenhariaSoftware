
namespace ClinicaTerapeutica.Interface.Paciente
{
    partial class MarcarConsultaP
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
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.horaLabel = new System.Windows.Forms.Label();
            this.titleInicioSessao = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.btn_marcar = new System.Windows.Forms.Button();
            this.terapeutaLabel = new System.Windows.Forms.Label();
            this.listTerapeutas = new System.Windows.Forms.ListBox();
            this.voltarAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(109, 99);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(100, 23);
            this.textBoxPassword.TabIndex = 12;
            // 
            // horaLabel
            // 
            this.horaLabel.AutoSize = true;
            this.horaLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horaLabel.Location = new System.Drawing.Point(48, 97);
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(62, 25);
            this.horaLabel.TabIndex = 11;
            this.horaLabel.Text = "Hora: ";
            // 
            // titleInicioSessao
            // 
            this.titleInicioSessao.AutoSize = true;
            this.titleInicioSessao.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleInicioSessao.Location = new System.Drawing.Point(62, 9);
            this.titleInicioSessao.Name = "titleInicioSessao";
            this.titleInicioSessao.Size = new System.Drawing.Size(210, 37);
            this.titleInicioSessao.TabIndex = 10;
            this.titleInicioSessao.Text = "Marcar Consulta";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataLabel.Location = new System.Drawing.Point(48, 63);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(55, 25);
            this.dataLabel.TabIndex = 9;
            this.dataLabel.Text = "Data:";
            this.dataLabel.Click += new System.EventHandler(this.labelUserId_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(109, 63);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 23);
            this.textBoxUser.TabIndex = 8;
            // 
            // btn_marcar
            // 
            this.btn_marcar.Location = new System.Drawing.Point(109, 247);
            this.btn_marcar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_marcar.Name = "btn_marcar";
            this.btn_marcar.Size = new System.Drawing.Size(127, 22);
            this.btn_marcar.TabIndex = 7;
            this.btn_marcar.Text = "Marcar Consulta";
            this.btn_marcar.UseVisualStyleBackColor = true;
            this.btn_marcar.Click += new System.EventHandler(this.btn_marcar_Click);
            // 
            // terapeutaLabel
            // 
            this.terapeutaLabel.AutoSize = true;
            this.terapeutaLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.terapeutaLabel.Location = new System.Drawing.Point(6, 133);
            this.terapeutaLabel.Name = "terapeutaLabel";
            this.terapeutaLabel.Size = new System.Drawing.Size(104, 25);
            this.terapeutaLabel.TabIndex = 13;
            this.terapeutaLabel.Text = "Terapeuta: ";
            this.terapeutaLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // listTerapeutas
            // 
            this.listTerapeutas.FormattingEnabled = true;
            this.listTerapeutas.ItemHeight = 15;
            this.listTerapeutas.Location = new System.Drawing.Point(109, 133);
            this.listTerapeutas.Name = "listTerapeutas";
            this.listTerapeutas.Size = new System.Drawing.Size(189, 94);
            this.listTerapeutas.TabIndex = 15;
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(17, 247);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(75, 23);
            this.voltarAtras.TabIndex = 16;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            this.voltarAtras.Click += new System.EventHandler(this.voltarAtras_Click);
            // 
            // MarcarConsultaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 283);
            this.Controls.Add(this.voltarAtras);
            this.Controls.Add(this.listTerapeutas);
            this.Controls.Add(this.terapeutaLabel);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.horaLabel);
            this.Controls.Add(this.titleInicioSessao);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.btn_marcar);
            this.Name = "MarcarConsultaP";
            this.Text = "MarcarConsultaP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label horaLabel;
        private System.Windows.Forms.Label titleInicioSessao;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button btn_marcar;
        private System.Windows.Forms.Label terapeutaLabel;
        private System.Windows.Forms.ListBox listTerapeutas;
        private System.Windows.Forms.Button voltarAtras;
    }
}