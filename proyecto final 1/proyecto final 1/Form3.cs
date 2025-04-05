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
    public partial class Form3 : Form
    {
        private string connectionString = "Data Source=LAPTOP-R1VO187T\\SQLEXPRESS;Initial Catalog=Proyecto;Integrated Security=True";

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IDproducto = int.Parse(idproducto.Text);
            string Nombre = nombreproducto.Text;
            int caloriasP = int.Parse(calorias.Text);
            int carbohidratosP = int.Parse(carbohidratos.Text);
            int proteinasP = int.Parse(proteinas.Text);
            int grasasP = int.Parse(grasas.Text);
            int energiasP = int.Parse(energias.Text);
            int PorcentajeP = int.Parse(porcentajeproducto.Text);

            string query = @"INSERT INTO producto (idProducto,nombreProducto,caloriaProducto,carbohidratoProducto,proteinaProducto,grasasProducto,energiaProducto,porcentajeProducto)
                                         VALUES (@idProducto,@nombreProducto,@caloriaProducto,@carbohidratoProducto,@proteinaProducto,@grasasProducto,@energiaProducto,@porcentajeProducto)";

            using (SqlConnection conn = new SqlConnection(connectionString)) 
            using (SqlCommand cmd = new SqlCommand(query, conn))

            {
                // Usar las variables ya convertidas
                cmd.Parameters.AddWithValue("@idProducto", IDproducto);
                cmd.Parameters.AddWithValue("@nombreProducto", Nombre);
                cmd.Parameters.AddWithValue("@caloriaProducto", caloriasP);
                cmd.Parameters.AddWithValue("@carbohidratoProducto", carbohidratosP);
                cmd.Parameters.AddWithValue("@proteinaProducto", proteinasP);
                cmd.Parameters.AddWithValue("@grasasProducto", grasasP);
                cmd.Parameters.AddWithValue("@energiaProducto", energiasP);
                cmd.Parameters.AddWithValue("@porcentajeProducto", PorcentajeP);



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
            Form4 formulario4 = new Form4();

            // Mostrar el segundo formulario
            formulario4.Show();
            this.Hide();
        }
    }
}
