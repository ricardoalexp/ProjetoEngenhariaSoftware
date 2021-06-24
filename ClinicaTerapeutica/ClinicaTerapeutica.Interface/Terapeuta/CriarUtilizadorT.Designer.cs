
namespace ClinicaTerapeutica.Interface.Terapeuta
{
    partial class CriarUtilizadorT
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
            this.checkBoxTerapeuta = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.titleCriarUtilizador = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.labeldatanasc = new System.Windows.Forms.Label();
            this.textBoxDataNasc = new System.Windows.Forms.TextBox();
            this.textBoxTelemovel = new System.Windows.Forms.TextBox();
            this.labeltelefone = new System.Windows.Forms.Label();
            this.voltarAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBoxTerapeuta
            // 
            this.checkBoxTerapeuta.AutoSize = true;
            this.checkBoxTerapeuta.Location = new System.Drawing.Point(209, 49);
            this.checkBoxTerapeuta.Name = "checkBoxTerapeuta";
            this.checkBoxTerapeuta.Size = new System.Drawing.Size(82, 19);
            this.checkBoxTerapeuta.TabIndex = 13;
            this.checkBoxTerapeuta.Text = "Terapeuta?";
            this.checkBoxTerapeuta.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(209, 136);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 23);
            this.textBoxPassword.TabIndex = 12;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(72, 134);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(137, 25);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Palavra-passe: ";
            // 
            // titleCriarUtilizador
            // 
            this.titleCriarUtilizador.AutoSize = true;
            this.titleCriarUtilizador.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleCriarUtilizador.Location = new System.Drawing.Point(85, 9);
            this.titleCriarUtilizador.Name = "titleCriarUtilizador";
            this.titleCriarUtilizador.Size = new System.Drawing.Size(196, 37);
            this.titleCriarUtilizador.TabIndex = 10;
            this.titleCriarUtilizador.Text = "Criar Utilizador";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNome.Location = new System.Drawing.Point(137, 89);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(72, 25);
            this.labelNome.TabIndex = 9;
            this.labelNome.Text = "Nome: ";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(209, 89);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(100, 23);
            this.textBoxUser.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Criar utilizador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(209, 233);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 23);
            this.textBoxEmail.TabIndex = 17;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelemail.Location = new System.Drawing.Point(137, 231);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(75, 25);
            this.labelemail.TabIndex = 16;
            this.labelemail.Text = "E-mail: ";
            // 
            // labeldatanasc
            // 
            this.labeldatanasc.AutoSize = true;
            this.labeldatanasc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldatanasc.Location = new System.Drawing.Point(26, 181);
            this.labeldatanasc.Name = "labeldatanasc";
            this.labeldatanasc.Size = new System.Drawing.Size(183, 25);
            this.labeldatanasc.TabIndex = 15;
            this.labeldatanasc.Text = "Data de nascimento:";
            // 
            // textBoxDataNasc
            // 
            this.textBoxDataNasc.Location = new System.Drawing.Point(209, 183);
            this.textBoxDataNasc.Name = "textBoxDataNasc";
            this.textBoxDataNasc.Size = new System.Drawing.Size(100, 23);
            this.textBoxDataNasc.TabIndex = 14;
            // 
            // textBoxTelemovel
            // 
            this.textBoxTelemovel.Location = new System.Drawing.Point(209, 278);
            this.textBoxTelemovel.Name = "textBoxTelemovel";
            this.textBoxTelemovel.Size = new System.Drawing.Size(100, 23);
            this.textBoxTelemovel.TabIndex = 19;
            // 
            // labeltelefone
            // 
            this.labeltelefone.AutoSize = true;
            this.labeltelefone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeltelefone.Location = new System.Drawing.Point(11, 276);
            this.labeltelefone.Name = "labeltelefone";
            this.labeltelefone.Size = new System.Drawing.Size(198, 25);
            this.labeltelefone.TabIndex = 18;
            this.labeltelefone.Text = "Número de telemóvel:";
            // 
            // voltarAtras
            // 
            this.voltarAtras.Location = new System.Drawing.Point(26, 337);
            this.voltarAtras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voltarAtras.Name = "voltarAtras";
            this.voltarAtras.Size = new System.Drawing.Size(121, 22);
            this.voltarAtras.TabIndex = 20;
            this.voltarAtras.Text = "Voltar atrás";
            this.voltarAtras.UseVisualStyleBackColor = true;
            this.voltarAtras.Click += new System.EventHandler(this.button2_Click);
            // 
            // CriarUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 383);
            this.Controls.Add(this.voltarAtras);
            this.Controls.Add(this.textBoxTelemovel);
            this.Controls.Add(this.labeltelefone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.labeldatanasc);
            this.Controls.Add(this.textBoxDataNasc);
            this.Controls.Add(this.checkBoxTerapeuta);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.titleCriarUtilizador);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.button1);
            this.Name = "CriarUtilizador";
            this.Text = "CriarUtilizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxTerapeuta;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label titleCriarUtilizador;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.Label labeldatanasc;
        private System.Windows.Forms.TextBox textBoxDataNasc;
        private System.Windows.Forms.TextBox textBoxTelemovel;
        private System.Windows.Forms.Label labeltelefone;
        private System.Windows.Forms.Button voltarAtras;
    }
}