using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;



namespace Capa_de_Presentacion
{
    public partial class Elegir_Producto : Form
    {
        public Elegir_Producto()
        {
            InitializeComponent();
            cargar_tabla();
        }
        int posicion = 0;
        


        private void cargar_tabla()
        {
            string Query = "SELECT idFarmacia,Nombre,`Nombre generico`,Precio,Stock FROM final_clinica1.farmacia;";
            
            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);
                dataGridView1.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // esto es para que te diga en que posición esta la columna seleccionada 
            Proyecto_Final.Program.IdProductoUnico = Convert.ToInt32(dataGridView1[0, posicion].Value);
            Proyecto_Final.Program.Descripcion = Convert.ToString(dataGridView1[1, posicion].Value);
            Proyecto_Final.Program.Marca = Convert.ToString(dataGridView1[2, posicion].Value);
            Proyecto_Final.Program.PrecioVenta = Convert.ToInt32(dataGridView1[3, posicion].Value);
            Proyecto_Final.Program.Stock = Convert.ToInt32(dataGridView1[4, posicion].Value);
            this.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string Query = "SELECT SELECT idFarmacia,Nombre,`Nombre generico`,Precio,Stock FROM final_clinica1.farmacia where Nombre like '" + textBox1.Text + "%';";

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(Query,Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);
                dataGridView1.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentCell.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado.inventario V = new Empleado.inventario();
            V.ShowDialog();
        }
    }
}
