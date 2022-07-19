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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var conx = new MainBD();
            MySqlConnection connection = new MySqlConnection(conx.connString);
            string nombre = txtNombre.Text;
            string correo = txtCorreo.Text;
            string passwd = txtPwd.Text;

            connection.Open();
            var checkInfo = new MySqlCommand($"SELECT correo FROM usuarios WHERE correo =\"{correo}\"", connection);
            var reader = checkInfo.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                reader.Close();
                MessageBox.Show("El correo ya existe", "Error de consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                reader.Close();
                var registerQuery = new MySqlCommand($"INSERT INTO usuarios (nombre, correo, passwd) VALUES (\"{nombre}\", \"{correo}\", \"{passwd}\")", connection);
                registerQuery.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado correctamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormLogin Login = new FormLogin();
                Login.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
