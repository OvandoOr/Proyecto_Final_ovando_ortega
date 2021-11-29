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
    public partial class Elegir_Cliente : Form
    {
        public Elegir_Cliente()
        {
            InitializeComponent();
            cargar_tabla();
        }
        int posicion = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Proyecto_Final.Program.IdCliente = Convert.ToInt32(dataGridView1[0 ,posicion].Value);
            Proyecto_Final.Program.NombreCliente = Convert.ToString(dataGridView1[1, posicion].Value);
            Proyecto_Final.Program.ApellidoCliente = Convert.ToString(dataGridView1[2, posicion].Value);
            Proyecto_Final.Program.Tipo_De_Cliente = Convert.ToString(dataGridView1[7, posicion].Value);
            Proyecto_Final.Program.antecedentesH = Convert.ToString(dataGridView1[14, posicion].Value);
            Proyecto_Final.Program.antecedentesP = Convert.ToString(dataGridView1[15, posicion].Value);

            this.Close();
        }

        private void cargar_tabla()
        {
            string Query = "SELECT * FROM final_clinica1.paciente;";

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

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string Query = "SELECT * FROM final_clinica1.paciente where Nombre like'" + textBox1.Text + "%';";

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentCell.RowIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado.Paciente V = new Empleado.Paciente();
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
