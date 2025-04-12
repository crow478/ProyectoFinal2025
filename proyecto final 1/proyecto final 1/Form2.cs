using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_1
{
    public partial class Form2 : Form
    {
        private string connectionString = "Data Source=LAPTOP-R1VO187T\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conexion c = new conexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string RegistroPaciente = txtRegistroPaciente.Text;

            int IdUsuario;
            if (!int.TryParse(txtIdUsuario.Text, out IdUsuario))
            {
                MessageBox.Show("ID de usuario inválido.");
                return;
            }

            DateTime FechaRegistro;
            if (!DateTime.TryParse(txtFechaRegistro.Text, out FechaRegistro))
            {
                MessageBox.Show("Fecha inválida.");
                return;
            }

            int Altura;
            if (!int.TryParse(txtAltura.Text, out Altura))
            {
                MessageBox.Show("Altura inválida.");
                return;
            }

            int Peso;
            if (!int.TryParse(txtPeso.Text, out Peso))
            {
                MessageBox.Show("Peso inválido.");
                return;
            }

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO registro_paciente (idRegistroPaciente, idUsuario, fecha_registro, peso, altura) " +
                               "VALUES (@idRegistroPaciente, @idUsuario, @fecha_registro, @peso, @altura)";

                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@idRegistroPaciente", RegistroPaciente);
                comando.Parameters.AddWithValue("@idUsuario", IdUsuario);
                comando.Parameters.AddWithValue("@fecha_registro", FechaRegistro);
                comando.Parameters.AddWithValue("@peso", Peso); 
                comando.Parameters.AddWithValue("@altura", Altura); 

                try
                {
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            Form3 formulario3 = new Form3();

            // Mostrar el segundo formulario
            formulario3.Show();
            this.Hide();
        }

        private void txtFechaRegistro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

