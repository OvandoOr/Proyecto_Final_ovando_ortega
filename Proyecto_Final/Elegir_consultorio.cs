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
    public partial class Elegir_consultorio : Form
    {
        public Elegir_consultorio()
        {
            InitializeComponent();
            cargar_tabla();
        }
        int posicion = 0;
        


        private void cargar_tabla()
        {
            string Query = "SELECT * FROM final_clinica1.consultorios;";
            
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



        private void button1_Click(object sender, EventArgs e)
        {
            // esto es para que te diga en que posición esta la columna seleccionada 
            Proyecto_Final.Program.idconsultorio = Convert.ToInt32(dataGridView1[0, posicion].Value);
            Proyecto_Final.Program.NombreConsultorio = Convert.ToString(dataGridView1[1, posicion].Value);

            this.Close();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string Query = "SELECT * FROM final_clinica1.consultorios where Descripcion like '" + textBox1.Text + "%';";

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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
