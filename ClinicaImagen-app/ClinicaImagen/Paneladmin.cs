using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using System.Net;
using System.Net.Mail;

namespace ClinicaImagen
{
    public partial class Paneladmin : Form
    {
        string[] datos = new string[2];
        public Paneladmin()
        {
            InitializeComponent();
            dgVerificados.DataSource = usuariosVerificados();
            dgNoVerificados.DataSource = usuariosNoVerificados();
            datosUsuario();
            lblCorreo.Text = $"Correo: \n{datos[0]}";
            lblUsuario.Text = $"Usuario: \n{datos[1]}";
        }

        private void datosUsuario()
        {
            using (MySqlConnection connection = new MySqlConnection(MainBD.connString))
            {
                using (MySqlCommand cmd = new MySqlCommand($"SELECT correo, nombre from usuarios WHERE correo=\"{FormLogin.informacion.correoLogin}\"", connection))
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    for (int i = 0; i < 2; i++)
                    {
                        reader.Read();
                        datos[i] = reader.GetString(i);
                    }
                }
            }
        }

        private DataTable usuariosVerificados()
        {
            DataTable usuarios = new DataTable();
            using (MySqlConnection connection =  new MySqlConnection(MainBD.connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT correo, passwd, nombre from usuarios WHERE verificado=1 AND cargo!=1", connection))
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    usuarios.Load(reader);
                }
            }
            return usuarios;
        }

        private DataTable usuariosNoVerificados()
        {
            DataTable usuarios = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(MainBD.connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT correo, passwd, nombre from usuarios WHERE verificado=0", connection))
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    usuarios.Load(reader);
                }
            }
            return usuarios;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Paneladmin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgVerificados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            var from = "fzalasupport@c1550024.ferozo.com";
            var subject = "Verificación - Clinica Imagen";
            var body = "Has sido verificado en la aplicación de Clinica Imagen";
            var passwordEmail = "i@/1Axd4wT";
            var client = new SmtpClient("c1550024.ferozo.com", 465)
            {
                Credentials = new NetworkCredential(from, passwordEmail),
                EnableSsl = true
            };
            
            
            string correo;
            correo = Interaction.InputBox("Ingrese el correo a verificar: ", "Verificador");
            var to = correo;

            using (MySqlConnection connection = new MySqlConnection(MainBD.connString))
            {
                using (MySqlCommand verificarQuery = new MySqlCommand($"UPDATE usuarios SET verificado=1 WHERE correo=\"{correo}\";", connection))
                {
                    client.Send(from, to, subject, body);
                    connection.Open();
                    MySqlDataReader reader = verificarQuery.ExecuteReader();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgVerificados.DataSource = usuariosVerificados();
            dgNoVerificados.DataSource = usuariosNoVerificados();
        }

        private void btnActualizarContraseña_Click(object sender, EventArgs e)
        {
            string correo;
            correo = Interaction.InputBox("Correo a resetear: ", "Clinica Imagen - Admin");

            using (MySqlConnection connection = new MySqlConnection(MainBD.connString))
            {
                using (MySqlCommand verificarQuery = new MySqlCommand($"UPDATE usuarios SET passwd=\"CICliente\" WHERE correo=\"{correo}\";", connection))
                {
                    connection.Open();
                    MySqlDataReader reader = verificarQuery.ExecuteReader();
                    MessageBox.Show("La contraseña por defecto es CICliente", "Clinica Imagen - Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
