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

namespace ClinicaImagen
{
    public partial class Paneladmin : Form
    {
        public Paneladmin()
        {
            InitializeComponent();
            dgVerificados.DataSource = usuariosVerificados();
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
    }
}
