using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;


namespace clinica
{
    public partial class historial : Form
    {
        int posicion = 0;
        public historial()
        {
            InitializeComponent();
            cargar_tabla();

            Proyecto_Final.Program.IdDoctor = 0;
            Proyecto_Final.Program.IdCliente = 0;
            Proyecto_Final.Program.idconsultorio = -1;
            Proyecto_Final.Program.Tipo_De_Cliente = "";
            Proyecto_Final.Program.NombreCliente = "";
            Proyecto_Final.Program.ApellidoCliente = "";
            Proyecto_Final.Program.NombreConsultorio = "";
            Proyecto_Final.Program.NombreDoctor = "";
            Proyecto_Final.Program.ApellidoDoctor = "";
            Proyecto_Final.Program.antecedentesH = "";
            Proyecto_Final.Program.antecedentesP = "";

        }

        private void cargar_tabla()
        {
            string Query = "SELECT * FROM final_clinica1.historial_clinico where idPaciente like'" + Proyecto_Final.Program.IdCliente + "'LIMIT 0, 1;";

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);
                dataGridView4.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             Query = "SELECT idPaciente,estatura,peso,Doctor,observaciones,Sintomas,Diagnostico,Consultorio,Fecha,Hora FROM final_clinica1.historial_clinico where idPaciente like'" + Proyecto_Final.Program.IdCliente + "';";

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

                string id_paciente = Convert.ToString(dataGridView1[0, 0].Value);
                string Query = "SELECT * FROM final_clinica1.paciente where idPaciente='"+id_paciente+"';";

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                    DataTable ds = new DataTable();
                    sda.Fill(ds);
                    datagridviewdatos.DataSource = ds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            

                string id_doctor = Convert.ToString(dataGridView1[3, 0].Value);
                string Query1 = "SELECT idDoctores,Nombre,A_paterno,A_materno,Usuario_idUsuario,sexo,id_especialidad FROM final_clinica1.doctores where idDoctores='" + id_doctor + "';";

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(Query1, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                    DataTable ds = new DataTable();
                    sda.Fill(ds);
                    dataGridView2.DataSource = ds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                string id_consultorios = Convert.ToString(dataGridView1[3, 0].Value);
                string Query2 = "SELECT * FROM final_clinica1.consultorios where idConsultorios='" + id_consultorios + "';";

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(Query2, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                    DataTable ds = new DataTable();
                    sda.Fill(ds);
                    dataGridView3.DataSource = ds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                        

        }




        private void btngua_Click(object sender, EventArgs e)//limpiar segunda tabla
        {

            datagridviewdatos.DataSource = null;
            Proyecto_Final.Program.IdDoctor = 0;
            Proyecto_Final.Program.IdCliente = 0;
            Proyecto_Final.Program.idconsultorio = -1;
            Proyecto_Final.Program.Tipo_De_Cliente = "";
            Proyecto_Final.Program.NombreCliente = "";
            Proyecto_Final.Program.ApellidoCliente = "";
            Proyecto_Final.Program.NombreConsultorio = "";
            Proyecto_Final.Program.NombreDoctor = "";
            Proyecto_Final.Program.ApellidoDoctor = "";
            Proyecto_Final.Program.antecedentesH = "";
            Proyecto_Final.Program.antecedentesP = "";

            tx_nombre_pac.Text = "";
            tx_edad.Text = "";
            //tx_antecentesH.Text = "";
            //tx_antecentesP.Text = "";
            cargar_tabla();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            

        }

        private void historial_Activated(object sender, EventArgs e)
        {
            try
            {
                DateTime nacimiento = Convert.ToDateTime(Proyecto_Final.Program.Tipo_De_Cliente); //Fecha de nacimiento

                int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                tx_nombre_pac.Text = Proyecto_Final.Program.NombreCliente + " " + Proyecto_Final.Program.ApellidoCliente;
                if (edad < 100)
                    tx_edad.Text = Convert.ToString(edad);
                //tx_antecentesH.Text = Proyecto_Final.Program.antecedentesH;
                //tx_antecentesP.Text = Proyecto_Final.Program.antecedentesP;
            }
            catch { }
            cargar_tabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Process.Start(Proyecto_Final.Program.NombreCliente + ".png");
                Process.Start("C:\\Users\\MarthaAlicia\\Desktop\\Proyecto_Final\\señales\\"+Proyecto_Final.Program.NombreCliente+".png");
            }
            catch { }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Capa_de_Presentacion.Elegir_Cliente U = new Capa_de_Presentacion.Elegir_Cliente();
            U.ShowDialog();

            try
            {
                string id_paciente = Convert.ToString(dataGridView1[0, 0].Value);
                string Query = "SELECT * FROM final_clinica1.paciente where idPaciente='" + id_paciente + "';";

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                    DataTable ds = new DataTable();
                    sda.Fill(ds);
                    datagridviewdatos.DataSource = ds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                string id_doctor = Convert.ToString(dataGridView1[3, 0].Value);
                string Query1 = "SELECT idDoctores,Nombre,A_paterno,A_materno,Usuario_idUsuario,sexo,id_especialidad FROM final_clinica1.doctores where idDoctores='" + id_doctor + "';";

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(Query1, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                    DataTable ds = new DataTable();
                    sda.Fill(ds);
                    dataGridView2.DataSource = ds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                string id_consultorios = Convert.ToString(dataGridView1[7, 0].Value);
                string Query2 = "SELECT * FROM final_clinica1.consultorios where idConsultorios='" + id_consultorios + "';";

                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter(Query2, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                    DataTable ds = new DataTable();
                    sda.Fill(ds);
                    dataGridView3.DataSource = ds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch { }

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
