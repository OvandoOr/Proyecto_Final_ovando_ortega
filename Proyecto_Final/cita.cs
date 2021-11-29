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

namespace clinica
{
    public partial class cita : Form
    {
        int posicion;
        string id, fecha;
        public cita()
        {
            InitializeComponent();
            cargar_tabla();

        }

        public void limpiar()
        {
            tx_nombrePac.Clear();
            tx_edadPac.Clear();
            tx_doc.Clear();
            tx_consul.Clear();
            num_min.Value = 0;
            num_hora.Value = 7;
            dtp_dia.Value = DateTime.Today;

            Proyecto_Final.Program.IdDoctor = 0;
            Proyecto_Final.Program.IdCliente = 0;
            fecha = "";
            Proyecto_Final.Program.idconsultorio = -1;
            Proyecto_Final.Program.Tipo_De_Cliente = "";
            Proyecto_Final.Program.NombreCliente = "";
            Proyecto_Final.Program.ApellidoCliente="";
            Proyecto_Final.Program.NombreConsultorio="";
            Proyecto_Final.Program.NombreDoctor = "";
            Proyecto_Final.Program.ApellidoDoctor="";


            butt_gua.Enabled = true;
            butt_eli.Enabled = false;
            butt_mod.Enabled = false;
            textBox1.Enabled = true;
            errorProvider1.Clear();



        }

        private void cargar_tabla()
        {

            string hoy = (DateTime.Now).ToString("yyyy-MM-dd");
            string Query = "select *  from final_clinica1.consulta where Fecha >= '"+hoy+"'";

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


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            capturarfecha();
        }
        private void capturarfecha()
        {
            lfecha.Text = DateTime.Now.ToShortDateString();
            lhora.Text = DateTime.Now.ToShortTimeString();
        }

        private void cita_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        public bool repetir()
        {
            bool repetir = false;

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.consulta where Doctor='" + Proyecto_Final.Program.IdDoctor + "'and Fecha='"+fecha +"' ;", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                repetir = true;
                MessageBox.Show("El Doctor ya tiene una cita a esta hora.", "ERROR");
            }

            cmd = new MySqlCommand("SELECT * FROM final_clinica1.consulta where `Numero de consultorio`='" + Proyecto_Final.Program.idconsultorio + "'and Fecha='" + fecha + "' ;", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                repetir = true;
                MessageBox.Show("El consultorio esta ocupado a esta hora.", "ERROR");
            }

            cmd = new MySqlCommand("SELECT * FROM final_clinica1.consulta where `Paciente`='" + Proyecto_Final.Program.IdCliente + "'and Fecha='" + fecha + "' ;", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                repetir = true;
                MessageBox.Show("Este paciente ya tiene una cita a esta hora.", "ERROR");
            }

            return repetir;
        }

        public bool repetir1()
        {
            bool repetir = false;
            int repet = 0;

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.consulta where Doctor='" + Proyecto_Final.Program.IdDoctor + "'and Fecha='" + fecha + "' ;", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                repet++;
            }
            if (repet >= 2)
            {
                repetir = true;
            }

            repet = 0;

            cmd = new MySqlCommand("SELECT * FROM final_clinica1.consulta where `Numero de consultorio`='" + Proyecto_Final.Program.idconsultorio + "'and Fecha='" + fecha + "' ;", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                repet++;
            }
            if (repet >= 2)
            {
                repetir = true;
            }

            repet = 0;

            cmd = new MySqlCommand("SELECT * FROM final_clinica1.consulta where `Paciente`='" + Proyecto_Final.Program.IdCliente + "'and Fecha='" + fecha + "' ;", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                repet++;
            }
            if (repet >= 2)
            {
                repetir = true;
            }

            return repetir;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //INSERT INTO `final_clinica1`.`consulta` (`Doctor`, `Paciente`, `Fecha`, `Numero de consultorio`, `Estado_consulta`) VALUES ('1', '1', '2017/11/06', '0', 'Programada');

            {
                errorProvider1.Clear();

                if (validacion())
                {
                    if (!repetir())
                    {
                        string Query = "INSERT INTO `final_clinica1`.`consulta` (`Doctor`, `Paciente`, `Fecha`, `Numero de consultorio`) VALUES ('"+Proyecto_Final.Program.IdDoctor+ "', '" + Proyecto_Final.Program.IdCliente + "', '"+fecha+"', '" + Proyecto_Final.Program.idconsultorio + "');";
                        try
                        {
                            MySqlCommand cmdDataBase = new MySqlCommand(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                            MySqlDataReader myReader;
                            myReader = cmdDataBase.ExecuteReader();
                            MessageBox.Show("Se registraron los datos con exito");

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        cargar_tabla();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Esta cita no puede realizarse.", "ERROR");
                    }

                }
                else
                {
                    MessageBox.Show("ERROR: Favor de ingresar datos correctos", "Clínica La Condesa");
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Capa_de_Presentacion.Elegir_doctores U = new Capa_de_Presentacion.Elegir_doctores();
            U.ShowDialog();
        }

        private void llenar_textbox()
        {
            
            try
            {
                DateTime nacimiento = Convert.ToDateTime(Proyecto_Final.Program.Tipo_De_Cliente); //Fecha de nacimiento

                int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                tx_nombrePac.Text = Proyecto_Final.Program.NombreCliente + " " + Proyecto_Final.Program.ApellidoCliente;
                if(edad<100)
                tx_edadPac.Text = Convert.ToString(edad);
                tx_consul.Text = Proyecto_Final.Program.NombreConsultorio;
                tx_doc.Text = Proyecto_Final.Program.NombreDoctor + " " + Proyecto_Final.Program.ApellidoDoctor;
            }
            catch { }
       }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Capa_de_Presentacion.Elegir_consultorio U = new Capa_de_Presentacion.Elegir_consultorio();
            U.ShowDialog();
        }

        private void cita_Activated(object sender, EventArgs e)
        {
            llenar_textbox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Capa_de_Presentacion.Elegir_Cliente U = new Capa_de_Presentacion.Elegir_Cliente();
            U.ShowDialog();
        }

        private void num_min_ValueChanged(object sender, EventArgs e)
        {
            if(num_min.Value!=0 && num_min.Value != 30)
            {
                num_min.Value = 0;
            }
        }

        private void num_hora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void num_min_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string Query = "SELECT * FROM final_clinica1.consulta where Paciente like'" + textBox1.Text + "%';";

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
            try
            {
                posicion = dataGridView1.CurrentCell.RowIndex;
                errorProvider1.Clear();
                // esto es para que te diga en que posición esta la columna seleccionada 
                id = Convert.ToString(dataGridView1[0, posicion].Value);
                Proyecto_Final.Program.IdDoctor = Convert.ToInt32(dataGridView1[1, posicion].Value);
                Proyecto_Final.Program.IdCliente = Convert.ToInt32(dataGridView1[2, posicion].Value);
                fecha = Convert.ToString(dataGridView1[3, posicion].Value);
                Proyecto_Final.Program.idconsultorio = Convert.ToInt32(dataGridView1[4, posicion].Value);

                datos_paciente();
                nombre_consultorio();
                nombre_doctor();
                recup_fecha();
                
                


                butt_mod.Enabled = true;
                butt_eli.Enabled = true;
                butt_gua.Enabled = false;
                textBox1.Enabled = false;
            }
            catch { }
        }


        private void nombre_doctor()
        {
            
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.doctores where idDoctores='"+Proyecto_Final.Program.IdDoctor+"';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                string nombre_doc,apellido_doc;
                nombre_doc = Convert.ToString(leer["Nombre"]);
                apellido_doc = Convert.ToString(leer["A_paterno"]);
                tx_doc.Text = nombre_doc + " " + apellido_doc;

                //conection.Close();
            }

        }

        private void recup_fecha()
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.consulta where idConsulta='" + id + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                string fecha,dia,hora,minutos;
                fecha = Convert.ToString(leer["Fecha"]);
                String[] substrings = fecha.Split(' ');
                dia = substrings[0];
                hora = substrings[1];
                if (substrings[2].Contains('p'))
                {
                    String[] substrings1 = hora.Split(':');
                    hora = substrings1[0];
                    minutos = substrings1[1];

                    dtp_dia.Value = Convert.ToDateTime(dia);
                    num_hora.Value = (Convert.ToInt32(hora))+12;
                    num_min.Value = Convert.ToInt32(minutos);
                }
                else
                {
                    String[] substrings1 = hora.Split(':');
                    hora = substrings1[0];
                    minutos = substrings1[1];

                    dtp_dia.Value = Convert.ToDateTime(dia);
                    num_hora.Value = Convert.ToInt32(hora);
                    num_min.Value = Convert.ToInt32(minutos);
                }

                //conection.Close();
            }
            else
            {
                //conection.Close();

            }
        }

        private void terminar_citas()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.paciente where idPaciente='" + Proyecto_Final.Program.IdCliente + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                string nombre_pac, apellido_pac, fecha_nac;
                int edad;
                DateTime nacimiento;

                nombre_pac = Convert.ToString(leer["Nombre"]);
                apellido_pac = Convert.ToString(leer["A_paterno"]);
                fecha_nac = Convert.ToString(leer["Fecha_Nac"]);

                nacimiento = Convert.ToDateTime(fecha_nac);
                edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;

                tx_nombrePac.Text = nombre_pac + " " + apellido_pac;
                tx_edadPac.Text = Convert.ToString(edad);

                //conection.Close();
            }
            else
            {
                //conection.Close();

            }
        }

        private void datos_paciente()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.paciente where idPaciente='" + Proyecto_Final.Program.IdCliente + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                string nombre_pac, apellido_pac, fecha_nac;
                int edad;
                DateTime nacimiento; 

                nombre_pac = Convert.ToString(leer["Nombre"]);
                apellido_pac = Convert.ToString(leer["A_paterno"]);
                fecha_nac=Convert.ToString(leer["Fecha_Nac"]);

                nacimiento = Convert.ToDateTime(fecha_nac);
                edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;

                tx_nombrePac.Text = nombre_pac + " " + apellido_pac;
                tx_edadPac.Text = Convert.ToString(edad);

                //conection.Close();
            }
            else
            {
                //conection.Close();

            }
        }

        private void nombre_consultorio()
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.consultorios where idConsultorios='" + Proyecto_Final.Program.idconsultorio + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                string nombre_con;
                nombre_con = Convert.ToString(leer["Descripcion"]);
                
                tx_consul.Text = nombre_con;

                //conection.Close();
            }
            else
            {
                //conection.Close();

            }
        }

        private void butt_lim_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void butt_mod_Click(object sender, EventArgs e)
        {
            //UPDATE `final_clinica1`.`consulta` SET `Doctor`='0', `Paciente`='0', `Fecha`='0', `Numero de consultorio`='1', `Estado_consulta`='0' WHERE `idConsulta`='3' and`Numero de consultorio`='0' and`Doctor`='1' and`Paciente`='1';
            errorProvider1.Clear();
            if (validacion())
            {
                if (!repetir1())
                {
                    string Query = "UPDATE `final_clinica1`.`consulta` SET `Doctor`='"+Proyecto_Final.Program.IdDoctor+ "', `Paciente`='" + Proyecto_Final.Program.IdCliente + "', `Fecha`='" + fecha + "', `Numero de consultorio`='" + Proyecto_Final.Program.idconsultorio + "'  WHERE `idConsulta`='"+id+"';";
                    try
                    {
                        MySqlCommand cmdDataBase = new MySqlCommand(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                        MySqlDataReader myReader;
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Se registraron los datos con exito");

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Esta cita no puede realizarse.", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("ERROR: Favor de ingresar datos correctos", "Clínica La Condesa");
            }
            cargar_tabla();
            limpiar();
        }

        private void cita_FormClosing(object sender, FormClosingEventArgs e)
        {
            limpiar();
        }

        public bool validacion()
        {
            bool validar = true;
            if (tx_nombrePac.Text == "")
            {
                errorProvider1.SetError(tx_nombrePac, "Ingresa un nombre correcto. No se permite doble espaciado");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tx_nombrePac, null);
            }

            if (tx_consul.Text == "" || tx_consul.Text.Contains("  "))
            {
                errorProvider1.SetError(tx_consul, "Ingresa un apellido paterno correcto");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tx_consul, null);
            }

            if (tx_doc.Text == "")
            {
                errorProvider1.SetError(tx_doc, "Ingresa una formula correcta. Mayor a 5 caracteres");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tx_doc, null);
            }

            
            fecha = dtp_dia.Value.ToString("yyyy-MM-dd");
            fecha = fecha + " " + Convert.ToString(num_hora.Value) + ":" + Convert.ToString(num_min.Value) + ":00";

            if (Convert.ToDateTime(fecha) < DateTime.Now.AddHours(6))
            {
                MessageBox.Show("Error en la fecha y hora de la cita. Las citas se realizan con un minumo de 6 horas de anticipacion.");
                validar = false;
            }
          
            return validar;
        }

        
    }
}
