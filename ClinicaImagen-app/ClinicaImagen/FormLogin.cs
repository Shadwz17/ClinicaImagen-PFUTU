using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaImagen
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(MainBD.connString);
            connection.Open();
            var correo_form = txtUser.Text;
            var passwd_form = txtPasswd.Text;
            var loginQuery = new MySqlCommand($"SELECT nombre, verificado, cargo FROM usuarios WHERE correo =\"{correo_form}\" AND passwd=\"{passwd_form}\"", connection);
            var reader = loginQuery.ExecuteReader();
            reader.Read();

            if (reader.HasRows && Boolean.Parse(reader["cargo"].ToString()) == true)
            {
                Paneladmin paneladmin = new Paneladmin();
                this.Hide();
                paneladmin.Show();
            }
            else if (reader.HasRows && Boolean.Parse(reader["verificado"].ToString()) == true)
            {
                MessageBox.Show($"Bienvenido {reader["nombre"].ToString()}");
            }
            
            else
            {
                MessageBox.Show("Su usuario/contraseña son invalidos o no se encuentra verificado en este momento", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister Registro = new FormRegister();
            Registro.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
