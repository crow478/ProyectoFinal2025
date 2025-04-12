﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            conexion conexion = new conexion();

            cmbproducto.Items.Add("CARNES");
            cmbproducto.Items.Add("VERDURAS");
            cmbproducto.Items.Add("FRUTAS");
            cmbproducto.Items.Add("GRANOS");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IDproducto = int.Parse(idproducto.Text);
            string NombreAlimento = cmbalimento.SelectedItem.ToString();
            string TipoAlimento = cmbproducto.SelectedItem.ToString();
            int carbohidratosP = int.Parse(carbohidratos.Text);
            int proteinasP = int.Parse(proteinas.Text);
            int grasasP = int.Parse(grasas.Text);
            int energiasP = int.Parse(energias.Text);
            int CaloriasP = int.Parse(calorias.Text);

            string query = @"INSERT INTO producto (idProducto,nombreProducto,caloriaProducto,carbohidratoProducto,proteinaProducto,grasasProducto,energiaProducto,tipoproducto)
                                         VALUES (@idProducto,@nombreProducto,@caloriaProducto,@carbohidratoProducto,@proteinaProducto,@grasasProducto,@energiaProducto,@tipoproducto)";

            using (SqlConnection conn = new SqlConnection(connectionString)) 
            using (SqlCommand cmd = new SqlCommand(query, conn))

            {
                // Usar las variables ya convertidas
                cmd.Parameters.AddWithValue("@idProducto", IDproducto);
                cmd.Parameters.AddWithValue("@nombreProducto", NombreAlimento);
                cmd.Parameters.AddWithValue("@carbohidratoProducto", carbohidratosP);
                cmd.Parameters.AddWithValue("@proteinaProducto", proteinasP);
                cmd.Parameters.AddWithValue("@grasasProducto", grasasP);
                cmd.Parameters.AddWithValue("@energiaProducto", energiasP);
                cmd.Parameters.AddWithValue("@caloriaProducto", CaloriasP);
                cmd.Parameters.AddWithValue("@tipoproducto", TipoAlimento);




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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbalimento.SelectedItem.ToString();

            if (seleccion == "RES")
            {
                carbohidratos.Text = "0";
                proteinas.Text = "26";
                grasas.Text = "17";
                energias.Text = "250";
                calorias.Text = "250";
            }

            else if (seleccion == "POLLO")
            {
                carbohidratos.Text = "0";
                proteinas.Text = "31";
                grasas.Text = "3.6";
                energias.Text = "165";
                calorias.Text = "165";

            }
            else if (seleccion == "CERDO")
            {
                carbohidratos.Text = "0";
                proteinas.Text = "27";
                grasas.Text = "14";
                energias.Text = "242";
                calorias.Text = "242";

            }
            else if (seleccion == "HUEVO")
            {
                carbohidratos.Text = "0.6";
                proteinas.Text = "6";
                grasas.Text = "5";
                energias.Text = "68";
                calorias.Text = "68";

            }
            else if (seleccion == "PESCADO")
            {
                carbohidratos.Text = "0";
                proteinas.Text = "22";
                grasas.Text = "2.5";
                energias.Text = "105";
                calorias.Text = "105";

            }
            else if (seleccion == "ZANAHORIA")
            {
                carbohidratos.Text = "9.6";
                proteinas.Text = "0.9";
                grasas.Text = "0.2";
                energias.Text = "41";
                calorias.Text = "41";

            }
            else if (seleccion == "BROCOLI")
            {
                carbohidratos.Text = "6.6";
                proteinas.Text = "2.8";
                grasas.Text = "0.4";
                energias.Text = "34";
                calorias.Text = "34";

            }
            else if (seleccion == "ESPINACA")
            {
                carbohidratos.Text = "3.6";
                proteinas.Text = "2.9";
                grasas.Text = "0.4";
                energias.Text = "23";
                calorias.Text = "23";

            }
            else if (seleccion == "LECHUGA")
            {
                carbohidratos.Text = "2.9";
                proteinas.Text = "1.4";
                grasas.Text = "0.2";
                energias.Text = "15";
                calorias.Text = "15";

            }
            else if (seleccion == "PEPINO")
            {
                carbohidratos.Text = "3.6";
                proteinas.Text = "0.7";
                grasas.Text = "0.1";
                energias.Text = "16";
                calorias.Text = "16";

            }
            else if (seleccion == "MANZANA")
            {
                carbohidratos.Text = "13.8";
                proteinas.Text = "0.3";
                grasas.Text = "0.2";
                energias.Text = "52";
                calorias.Text = "52";

            }
            else if (seleccion == "MANGO")
            {
                carbohidratos.Text = "15";
                proteinas.Text = "0.8";
                grasas.Text = "0.4";
                energias.Text = "60";
                calorias.Text = "60";

            }
            else if (seleccion == "MANDARINA")
            {
                carbohidratos.Text = "13.3";
                proteinas.Text = "0.8";
                grasas.Text = "0.3";
                energias.Text = "53";
                calorias.Text = "53";

            }
            else if (seleccion == "FRESAS")
            {
                carbohidratos.Text = "7.7";
                proteinas.Text = "0.7";
                grasas.Text = "0.3";
                energias.Text = "32";
                calorias.Text = "32";

            }
            else if (seleccion == "BANANO")
            {
                carbohidratos.Text = "22.8";
                proteinas.Text = "1.1";
                grasas.Text = "0.3";
                energias.Text = "89";
                calorias.Text = "89";

            }
            else if (seleccion == "ARROZ")
            {
                carbohidratos.Text = "28.2";
                proteinas.Text = "2.7";
                grasas.Text = "0.3";
                energias.Text = "130";
                calorias.Text = "130";

            }
            else if (seleccion == "AVENA")
            {
                carbohidratos.Text = "66.3";
                proteinas.Text = "16,9";
                grasas.Text = "6.9";
                energias.Text = "389";
                calorias.Text = "389";

            }
            else if (seleccion == "FRIJOL")
            {
                carbohidratos.Text = "22.8";
                proteinas.Text = "8.9";
                grasas.Text = "0.5";
                energias.Text = "127";
                calorias.Text = "127";

            }





        }

        private void cmbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbalimento.Items.Clear();

            if (cmbproducto.SelectedItem != null)
            {
                string tipoalimento = cmbproducto.SelectedItem.ToString();

                // Agregamos los municipios correspondientes según el departamento seleccionado
                if (tipoalimento == "CARNES")
                {
                    cmbalimento.Items.Add("RES");
                    cmbalimento.Items.Add("POLLO");
                    cmbalimento.Items.Add("CERDO");
                    cmbalimento.Items.Add("HUEVO");
                    cmbalimento.Items.Add("PESCADO");


                }
                else if (tipoalimento == "VERDURAS")
                    {
                    cmbalimento.Items.Add("ZANAHORIA");
                    cmbalimento.Items.Add("BROCOLI");
                    cmbalimento.Items.Add("ESPINACA");
                    cmbalimento.Items.Add("LECHUGA");
                    cmbalimento.Items.Add("PEPINO");

                }
                else if (tipoalimento == "FRUTAS")
                {
                    cmbalimento.Items.Add("MANZANA");
                    cmbalimento.Items.Add("MANGO");
                    cmbalimento.Items.Add("MANDARINA");
                    cmbalimento.Items.Add("FRESAS");
                    cmbalimento.Items.Add("BANANO");

                }
                else if (tipoalimento == "GRANOS")
                {
                    cmbalimento.Items.Add("ARROZ");
                    cmbalimento.Items.Add("AVENA");
                    cmbalimento.Items.Add("FRIJOL");

                }
         

            

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void carbohidratos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
