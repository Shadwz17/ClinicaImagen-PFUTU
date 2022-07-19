namespace ClinicaImagen
{
    partial class FormLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(69, 143);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Iniciar Sesion";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(69, 172);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(110, 23);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registrarme";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(69, 60);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(110, 23);
            this.txtUser.TabIndex = 2;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(69, 104);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.PasswordChar = '*';
            this.txtPasswd.Size = new System.Drawing.Size(110, 23);
            this.txtPasswd.TabIndex = 3;
            // 
            // Correo
            // 
            this.Correo.AutoSize = true;
            this.Correo.Location = new System.Drawing.Point(99, 42);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(43, 15);
            this.Correo.TabIndex = 4;
            this.Correo.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Contraseña";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnLogin);
            this.Name = "FormLogin";
            this.Text = "Clinica Imagen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label Correo;
        private System.Windows.Forms.Label label1;
    }
}
