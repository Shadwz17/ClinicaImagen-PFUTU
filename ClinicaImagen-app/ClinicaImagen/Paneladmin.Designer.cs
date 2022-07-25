namespace ClinicaImagen
{
    partial class Paneladmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paneladmin));
            this.dgVerificados = new System.Windows.Forms.DataGridView();
            this.dgNoVerificados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnResetearPwd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVerificados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNoVerificados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVerificados
            // 
            this.dgVerificados.AllowUserToAddRows = false;
            this.dgVerificados.AllowUserToDeleteRows = false;
            this.dgVerificados.AllowUserToResizeColumns = false;
            this.dgVerificados.AllowUserToResizeRows = false;
            this.dgVerificados.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgVerificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVerificados.Location = new System.Drawing.Point(-1, 32);
            this.dgVerificados.MultiSelect = false;
            this.dgVerificados.Name = "dgVerificados";
            this.dgVerificados.ReadOnly = true;
            this.dgVerificados.RowTemplate.Height = 25;
            this.dgVerificados.Size = new System.Drawing.Size(397, 421);
            this.dgVerificados.TabIndex = 0;
            this.dgVerificados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVerificados_CellContentClick);
            // 
            // dgNoVerificados
            // 
            this.dgNoVerificados.AllowUserToAddRows = false;
            this.dgNoVerificados.AllowUserToDeleteRows = false;
            this.dgNoVerificados.AllowUserToResizeColumns = false;
            this.dgNoVerificados.AllowUserToResizeRows = false;
            this.dgNoVerificados.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dgNoVerificados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNoVerificados.Location = new System.Drawing.Point(398, 32);
            this.dgNoVerificados.MultiSelect = false;
            this.dgNoVerificados.Name = "dgNoVerificados";
            this.dgNoVerificados.ReadOnly = true;
            this.dgNoVerificados.RowTemplate.Height = 25;
            this.dgNoVerificados.Size = new System.Drawing.Size(402, 421);
            this.dgNoVerificados.TabIndex = 1;
            this.dgNoVerificados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(-1, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Verificados:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(398, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pendientes:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnVerificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVerificar.Location = new System.Drawing.Point(503, 459);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(172, 47);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.BurlyWood;
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnActualizar.Location = new System.Drawing.Point(115, 459);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(172, 47);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(836, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Información de usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(815, 75);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(815, 110);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(46, 15);
            this.lblCorreo.TabIndex = 8;
            this.lblCorreo.Text = "Correo:";
            // 
            // btnResetearPwd
            // 
            this.btnResetearPwd.BackColor = System.Drawing.Color.LightCoral;
            this.btnResetearPwd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnResetearPwd.Location = new System.Drawing.Point(808, 173);
            this.btnResetearPwd.Name = "btnResetearPwd";
            this.btnResetearPwd.Size = new System.Drawing.Size(172, 47);
            this.btnResetearPwd.TabIndex = 9;
            this.btnResetearPwd.Text = "Resetear contraseña";
            this.btnResetearPwd.UseVisualStyleBackColor = false;
            this.btnResetearPwd.Click += new System.EventHandler(this.btnActualizarContraseña_Click);
            // 
            // Paneladmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(992, 508);
            this.Controls.Add(this.btnResetearPwd);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgNoVerificados);
            this.Controls.Add(this.dgVerificados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Paneladmin";
            this.Text = "Clinica Imagen - Admin";
            this.Load += new System.EventHandler(this.Paneladmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVerificados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNoVerificados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVerificados;
        private System.Windows.Forms.DataGridView dgNoVerificados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Button btnResetearPwd;
    }
}