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

    public partial class Form4 : Form
    {
        private string connectionString = "Data Source=LAPTOP-R1VO187T\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdMedida = int.Parse(idmedida.Text);
            string NombreUnidadMedida = nombremedida.Text;

            String query = @"INSERT INTO unidadMedida (idUnidadMedida,nombreUnidadMedida) 
                                    VALUES (@idUnidadMedida,@nombreUnidadMedida)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))

            {
                // Usar las variables ya convertidas
                cmd.Parameters.AddWithValue("@idUnidadMedida", IdMedida);
                cmd.Parameters.AddWithValue("@nombreUnidadMedida", NombreUnidadMedida);

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
            Form5 formulario5 = new Form5();

            // Mostrar el segundo formulario
            formulario5.Show();
            this.Hide();
        }
    }
}
