﻿
namespace ClinicaTerapeutica.Interface
{
    partial class inicioSessao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUserId = new System.Windows.Forms.Label();
            this.titleInicioSessao = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.terapeuta = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(210, 136);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(114, 27);
            this.textBoxUser.TabIndex = 1;
            this.textBoxUser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUserId.Location = new System.Drawing.Point(16, 136);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(188, 32);
            this.labelUserId.TabIndex = 2;
            this.labelUserId.Text = "Id de Utilizador: ";
            this.labelUserId.Click += new System.EventHandler(this.label1_Click);
            // 
            // titleInicioSessao
            // 
            this.titleInicioSessao.AutoSize = true;
            this.titleInicioSessao.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleInicioSessao.Location = new System.Drawing.Point(73, 24);
            this.titleInicioSessao.Name = "titleInicioSessao";
            this.titleInicioSessao.Size = new System.Drawing.Size(253, 46);
            this.titleInicioSessao.TabIndex = 3;
            this.titleInicioSessao.Text = "Início de sessão";
            this.titleInicioSessao.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(35, 179);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(169, 32);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Palavra-passe: ";
            this.labelPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(210, 184);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(114, 27);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // terapeuta
            // 
            this.terapeuta.AutoSize = true;
            this.terapeuta.Location = new System.Drawing.Point(125, 85);
            this.terapeuta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.terapeuta.Name = "terapeuta";
            this.terapeuta.Size = new System.Drawing.Size(149, 24);
            this.terapeuta.TabIndex = 6;
            this.terapeuta.Text = "Sou um terapeuta";
            this.terapeuta.UseVisualStyleBackColor = true;
            this.terapeuta.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // inicioSessao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 288);
            this.Controls.Add(this.terapeuta);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.titleInicioSessao);
            this.Controls.Add(this.labelUserId);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.button1);
            this.Name = "inicioSessao";
            this.Text = "Sistema Clinica Terapeutica blabla123";
            this.Load += new System.EventHandler(this.inicioSessao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label titleInicioSessao;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.CheckBox terapeuta;
    }
}

