
namespace ClinicaTerapeutica.Interface.Paciente
{
    partial class MarcarConsultaT
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
            this.textBoxHora = new System.Windows.Forms.TextBox();
            this.horaLabel = new System.Windows.Forms.Label();
            this.titleInicioSessao = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.btn_marcar = new System.Windows.Forms.Button();
            this.pacienteLabel = new System.Windows.Forms.Label();
            this.voltarAtras = new System.Windows.Forms.Button();
            this.textBoxIdPaciente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxHora
            // 
            this.textBoxHora.Location = new System.Drawing.Point(124, 99);
            this.textBoxHora.Name = "textBoxHora";
            this.textBoxHora.Size = new System.Drawing.Size(100, 23);
            this.textBoxHora.TabIndex = 12;
            // 
            // horaLabel
            // 
            this.horaLabel.AutoSize = true;
            this.horaLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horaLabel.Location = new System.Drawing.Point(63, 97);
            this.horaLabel.Name = "horaLabel";
            this.horaLabel.Size = new System.Drawing.Size(62, 25);
            this.horaLabel.TabIndex = 11;
            this.horaLabel.Text = "Hora: ";
            // 
            // titleInicioSessao
            // 
            this.titleInicioSessao.AutoSize = true;
            this.titleInicioSessao.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleInicioSessao.Location = new System.Drawing.Point(77, 9);
            this.titleInicioSessao.Name = "titleInicioSessao";
            this.titleInicioSessao.Size = new System.Drawing.Size(210, 37);
            this.titleInicioSessao.TabIndex = 10;
            this.titleInicioSessao.Text = "Marcar Consulta";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataLabel.Location = new System.Drawing.Point(63, 63);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(55, 25);
            this.dataLabel.TabIndex = 9;
            this.dataLabel.Text = "Data:";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(124, 63);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(100, 23);
            this.textBoxData.TabIndex = 8;
            // 
            // btn_marcar
            // 
            this.btn_marcar.Location = new System.Drawing.Point(124, 184);
            this.btn_marcar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_marcar.Name = "btn_marcar";
            this.btn_marcar.Size = new System.Drawing.Size(127, 22);
            this.btn_marcar.TabIndex = 7;
            this.btn_marcar.Text = "Marcar Consulta";
            this.btn_marcar.UseVisualStyleBackColor = true;
            this.btn_marcar.Click += new System.EventHandler(this.btn_marcar_Click);
            // 
            // pacienteLabel
            // 
            this.pacienteLabel.AutoSize = true;
            this.pacienteLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pacienteLabel.Location = new System.Drawing.Point(12, 133);
            this.pacienteLabel.Name = "pacienteLabel";
            this.pacienteLabel.Size = new System.Drawing.Size(113, 25);
            this.pacienteLabel.TabIndex = 13;
            this.pacienteLabel.Text = "Id Paciente: ";
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(32, 183);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(75, 23);
            this.voltarAtras.TabIndex = 16;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            this.voltarAtras.Click += new System.EventHandler(this.voltarAtras_Click);
            // 
            // textBoxIdPaciente
            // 
            this.textBoxIdPaciente.Location = new System.Drawing.Point(124, 135);
            this.textBoxIdPaciente.Name = "textBoxIdPaciente";
            this.textBoxIdPaciente.Size = new System.Drawing.Size(100, 23);
            this.textBoxIdPaciente.TabIndex = 17;
            // 
            // MarcarConsultaT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 226);
            this.Controls.Add(this.textBoxIdPaciente);
            this.Controls.Add(this.voltarAtras);
            this.Controls.Add(this.pacienteLabel);
            this.Controls.Add(this.textBoxHora);
            this.Controls.Add(this.horaLabel);
            this.Controls.Add(this.titleInicioSessao);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.btn_marcar);
            this.Name = "MarcarConsultaT";
            this.Text = "MarcarConsultaP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxHora;
        private System.Windows.Forms.Label horaLabel;
        private System.Windows.Forms.Label titleInicioSessao;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Button btn_marcar;
        private System.Windows.Forms.Label pacienteLabel;
        private System.Windows.Forms.Button voltarAtras;
        private System.Windows.Forms.TextBox textBoxIdPaciente;
    }
}