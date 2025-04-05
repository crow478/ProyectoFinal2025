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
    public partial class Form6 : Form
    {
        private string connectionString = "Data Source=LAPTOP-R1VO187T\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";

        public Form6()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ActividadF = int.Parse(txtactividadF.Text);
            int RegistroPaciente = int.Parse(txtregistro.Text);
            int Usuario = int.Parse(txtusuario.Text);
            string TipoActividad =    txttipo.Text;
            int TiempoSemanal = int.Parse(txttiempo.Text);

            string query = @"INSERT INTO actividad_fisica
                (idActividadFisica, idRegistroPaciente, idUsuario, tipoActividad, tiempoSemanal)
                VALUES (@idActividadFisica, @idRegistroPaciente, @idUsuario, @tipoActividad, @tiempoSemanal)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))

            {
                // Usar las variables ya convertidas
                cmd.Parameters.AddWithValue("@idActividadFisica", ActividadF);
                cmd.Parameters.AddWithValue("@idRegistroPaciente", RegistroPaciente);
                cmd.Parameters.AddWithValue("@idUsuario", Usuario);
                cmd.Parameters.AddWithValue("@tipoActividad", TipoActividad);
                cmd.Parameters.AddWithValue("@tiempoSemanal", TiempoSemanal);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 formulario7 = new Form7();

            // Mostrar el segundo formulario
            formulario7.Show();
            this.Hide();
        }
    }
}
