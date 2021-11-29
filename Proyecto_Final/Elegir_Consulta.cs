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
    public partial class Elegir_consulta : Form
    {
        public Elegir_consulta()
        {
            InitializeComponent();
            cargar_tabla();
        }
        int posicion = 0;



        private void cargar_tabla1()
        {

            string hoy = (DateTime.Now).ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm:ss");
            string fecha = hoy + " " + hora;
            string pasado_mañana = (DateTime.Now.AddDays(2)).ToString("yyyy-MM-dd");
            string Query = "select *  from final_clinica1.consulta where Fecha >= '" + fecha + "' and Fecha < '"+pasado_mañana+"'";

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

        private void cargar_tabla()
        {

            string hoy = (DateTime.Now).ToString("yyyy-MM-dd");
            string hora = DateTime.Now.ToString("hh:mm:ss");
            string fecha = hoy + " " + hora;
            string pasado_mañana = (DateTime.Now.AddDays(2)).ToString("yyyy-MM-dd");
            string Query = "select *  from final_clinica1.consulta where Fecha >= '" + fecha + "' and Fecha < '" + pasado_mañana + "' and Doctor = '" + Proyecto_Final.Program.IdDoctor+"'";

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
            posicion = dataGridView1.CurrentCell.RowIndex;
            // esto es para que te diga en que posición esta la columna seleccionada 
            //id = Convert.ToString(dataGridView1[0, posicion].Value);
            Proyecto_Final.Program.IdDoctor = Convert.ToInt32(dataGridView1[1, posicion].Value);
            Proyecto_Final.Program.IdCliente = Convert.ToInt32(dataGridView1[2, posicion].Value);
            //fecha = Convert.ToString(dataGridView1[3, posicion].Value);
            Proyecto_Final.Program.idconsultorio = Convert.ToInt32(dataGridView1[4, posicion].Value);

            datos_paciente();
            nombre_consultorio();
            nombre_doctor();

            clinica.consulta U = new clinica.consulta();
            U.ShowDialog();
            this.Close();
        }


        private void datos_paciente()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.paciente where idPaciente='" + Proyecto_Final.Program.IdCliente + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                Proyecto_Final.Program.NombreCliente = Convert.ToString(leer["Nombre"]);
                Proyecto_Final.Program.ApellidoCliente = Convert.ToString(leer["A_paterno"]);
                Proyecto_Final.Program.Tipo_De_Cliente = Convert.ToString(leer["Fecha_Nac"]);
            }
        }

        private void nombre_consultorio()
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.consultorios where idConsultorios='" + Proyecto_Final.Program.idconsultorio + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                Proyecto_Final.Program.NombreConsultorio = Convert.ToString(leer["Descripcion"]);
            }
        }

        private void nombre_doctor()
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.doctores where idDoctores='" + Proyecto_Final.Program.IdDoctor + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                Proyecto_Final.Program.NombreDoctor = Convert.ToString(leer["Nombre"]);
                Proyecto_Final.Program.ApellidoDoctor = Convert.ToString(leer["A_paterno"]);
                Proyecto_Final.Program.Especialidad_doctor = Convert.ToString(leer["id_especialidad"]);

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                cargar_tabla();
            }
            else
            {
                cargar_tabla1();
            }
        }

        private void Elegir_consulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            clinica.consulta U = new clinica.consulta();
            U.ShowDialog();
        }
    }
}
