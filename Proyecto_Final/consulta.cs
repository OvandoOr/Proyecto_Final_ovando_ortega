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
    public partial class consulta : Form
    {
        int codigo = 0, codigo1 = 0, posicion, posicion1, id_fin;
        string fechaf,fechas, tiempo;
        public consulta()
        {
            InitializeComponent();

            
            consumibles_combobox();
            farmacia_combobox();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            capturarfechayhora();
        }
        private void capturarfechayhora()
        {
            fecha.Text = DateTime.Now.ToShortDateString();
            hora.Text = DateTime.Now.ToShortTimeString();
        }

        private void consulta_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        public void farmacia_combobox()
        {
            string Query = "SELECT * FROM final_clinica1.farmacia where `Medicamento o recurso medico` = 1; ";

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);

                cb_medica.DisplayMember = "Nombre";
                cb_medica.ValueMember = "idFarmacia";
                cb_medica.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void consumibles_combobox()
        {
            string Query = "SELECT * FROM final_clinica1.farmacia where `Medicamento o recurso medico` = 0;";

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);

                cb_consumibles.DisplayMember = "Nombre";
                cb_consumibles.ValueMember = "idFarmacia";
                cb_consumibles.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void llenar_textbox()
        {

            try
            {
                tx_doc.Text = Proyecto_Final.Program.NombreDoctor + " " + Proyecto_Final.Program.ApellidoDoctor;
                nombre_especialidad();
                if (tx_especialidad.Text == "Cardiologia")
                {
                    butt_señal.Show();
                }
                else
                {
                    butt_señal.Hide();
                }

                DateTime nacimiento = Convert.ToDateTime(Proyecto_Final.Program.Tipo_De_Cliente); //Fecha de nacimiento

                int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                tx_pac.Text = Proyecto_Final.Program.NombreCliente + " " + Proyecto_Final.Program.ApellidoCliente;
                if (edad < 100)
                    tx_edad.Text = Convert.ToString(edad);
                tx_consultorio.Text = Proyecto_Final.Program.NombreConsultorio;
                
            }
            catch { }
            

        }

        private void nombre_especialidad()
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.especialidad where idEspecialidad=" + Proyecto_Final.Program.Especialidad_doctor + ";", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {

                tx_especialidad.Text = Convert.ToString(leer["Descripcion"]);

            }

        }

        private void butt_doc_Click(object sender, EventArgs e)
        {
            Capa_de_Presentacion.Elegir_doctores U = new Capa_de_Presentacion.Elegir_doctores();
            U.ShowDialog();
        }

        private void butt_pac_Click(object sender, EventArgs e)
        {
            Capa_de_Presentacion.Elegir_Cliente U = new Capa_de_Presentacion.Elegir_Cliente();
            U.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Capa_de_Presentacion.Elegir_consultorio U = new Capa_de_Presentacion.Elegir_consultorio();
            U.ShowDialog();
        }

        private void tx_alergias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsWhiteSpace(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && tx_alergias.TextLength < 100 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tx_observaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsWhiteSpace(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && tx_observaciones.TextLength < 300 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tx_sintomas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsWhiteSpace(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && tx_sintomas.TextLength < 300 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsWhiteSpace(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && tx_sintomas.TextLength < 150 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public bool repetir()
        {
            bool repetir = false;

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.consulta where Doctor='" + Proyecto_Final.Program.IdDoctor + "'and Fecha='" + fecha + "' ;", Proyecto_Final.BaseDeDatos.ObtenerConexion());
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

        public bool validacion()
        {
            bool validar = true;
            if (tx_doc.Text == "")
            {
                validar = false;
            }

            if (tx_pac.Text == "")
            {
                validar = false;
            }

            if (tx_observaciones.Text == "")
            {
                validar = false;
            }

            if (tx_padecimiento.Text == "")
            {
                validar = false;
            }

            if (tx_sintomas.Text == "")
            {
                validar = false;
            }

            return validar;
        }

        private void butt_terminar_Click(object sender, EventArgs e)
        {
            if (validacion())
            {
                if (!repetir())
                {//INSERT INTO `final_clinica1`.`historial_clinico` (`idPaciente`, `estatura`, `peso`, `Doctor`, `Consultas_Medicas`, `observaciones`, `Sintomas`, `Diagnostico`, `Consultorio`, `Fecha`, `Hora`) VALUES ('2', '3', '3', '3', '3', '3', '3', '3', '3', '3', '3');
                    fechadehoy();
                    string Query = "INSERT INTO `final_clinica1`.`historial_clinico` (`idPaciente`, `estatura`, `peso`, `Doctor`, `observaciones`, `Sintomas`, `Diagnostico`, `Consultorio`, `Fecha`, `Hora`) VALUES ('" + Proyecto_Final.Program.IdCliente + "', '" + num_estatura.Value + "', '" + num_peso.Value + "', '" + Proyecto_Final.Program.IdDoctor + "', '" + tx_observaciones.Text + "', '" + tx_sintomas.Text + "', '" + tx_padecimiento.Text + "', '" + Proyecto_Final.Program.idconsultorio + "', '" + fechas + "', '" + tiempo + "');";
                    try
                    {
                        MySqlCommand cmdDataBase = new MySqlCommand(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                        MySqlDataReader myReader;
                        myReader = cmdDataBase.ExecuteReader();
                        this.Close();

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
                MessageBox.Show("ERROR: Favor de llenar todos los datos del paciente. Puede poner NINGUNO en caso de no necesitar llenar el espacio", "Clínica La Condesa");
            }

            for (int i = 0; i < codigo; i++)
            {
                if (Medicamentos[i] != "-1")
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.farmacia where `Nombre`= '" + nom_consumibles[i] + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
                    MySqlDataReader leer = cmd.ExecuteReader();
                    if (leer.Read())
                    {
                        idMedicamentos[i] = Convert.ToString(leer["idFarmacia"]);

                        //conection.Close();
                    }

                    string Query1 = "INSERT INTO `final_clinica1`.`receta` (`Numero de receta`, `Medicamento`, `Cantidad`, `Toma del medicamento`, `Paciente`, `Doctor`, `Fecha`) VALUES ('" + id_fin + "', '" + idMedicamentos[i] + "', '" + cant_med[i] + "', '" + espec_med[i] + "', '" + Proyecto_Final.Program.IdCliente + "', '" + Proyecto_Final.Program.IdDoctor + "', '" + fechaf + "');";
                    try
                    {
                        MySqlCommand cmdDataBase = new MySqlCommand(Query1, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                        MySqlDataReader myReader;
                        myReader = cmdDataBase.ExecuteReader();
                        this.Close();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

            for (int i = 0; i < codigo1; i++)
            {
                if (nom_consumibles[i] != "-1")
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.farmacia where `Nombre`= '" + nom_consumibles[i] + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
                    MySqlDataReader leer = cmd.ExecuteReader();
                    if (leer.Read())
                    {
                        id_consumibles[i] = Convert.ToString(leer["idFarmacia"]);

                        //conection.Close();
                    }

                    string Query1 = "INSERT INTO `final_clinica1`.`ventas` (`numero_recibo`, `Tipo_de_pago`, `Cantidad`, `Total`, `Cliente_idCliente`, `Empleado_idEmpleado`, `Productos_idProductos`, `Fecha_Compra`) VALUES ('0', 'Utilizado en consulta', '" + cant_consu[i] + "', '0', '" + Proyecto_Final.Program.IdCliente + "', '" + Proyecto_Final.Program.IdDoctor + "', '" + id_consumibles[i] + "', '" + fechaf + "');";
                    try
                    {
                        MySqlCommand cmdDataBase = new MySqlCommand(Query1, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                        MySqlDataReader myReader;
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Se registraron los datos con exito");
                        this.Close();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
            
        

        private void fechadehoy()
        {
            fechas = DateTime.Now.ToString("yyyy-MM-dd");
            tiempo = DateTime.Now.ToString("HH:mm:ss");
            fechaf = fechas + " " + tiempo;

        }
        private void gen_idrecibo()
        {
            //MySqlConnection conection = new MySqlConnection("server=localhost;database=bmd_practica;Uid=root;pwd=2015030063");

            //conection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT `Numero de receta` FROM final_clinica1.receta order by `Numero de receta` DESC  LIMIT 0, 1 ;", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id_fin = Convert.ToInt32(leer["Numero de receta"]);

                //conection.Close();
            }
            

        }


        String[] idMedicamentos = new string[20];
        String[] Medicamentos = new string[20];
        String[] cant_med = new string[20];
        String[] espec_med = new string[20];

        
        private void butt_agregar_med_Click(object sender, EventArgs e)
        {
            Medicamentos[codigo] = cb_medica.Text;
            cant_med[codigo] = Convert.ToString(num_medica.Value);
            espec_med[codigo] = tx_tomarmed.Text;

            datagrid_med.Rows.Add(cb_medica.Text, Convert.ToString(num_medica.Value), tx_tomarmed.Text);
            limpiar_medicamento();

            //MessageBox.Show("Datos ingresados correctamente");
            codigo++;
        }

        private void limpiar_medicamento()
        {
            try
            {
                 cb_medica.SelectedIndex = 0;
                    num_medica.Value = 1;
                    tx_tomarmed.Clear();
            }
            catch { }
              
        }

        private void butt_eliminar_med_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(datagrid_med[0, posicion].Value) != "")
            {
                datagrid_med.Rows.RemoveAt(posicion);
                limpiar_consumible();
            }
        }

        String[] id_consumibles = new string[20];
        String[] nom_consumibles = new string[20];
        String[] cant_consu = new string[20];

        private void butt_agregar_consu_Click(object sender, EventArgs e)
        {
            if (num_consumibles.Value <= numproductos())
            {
                nom_consumibles[codigo1] = cb_consumibles.Text;
                cant_consu[codigo1] = Convert.ToString(num_consumibles.Value);

                datagrid_consu.Rows.Add(cb_consumibles.Text, Convert.ToString(num_consumibles.Value));
                limpiar_medicamento();

                //MessageBox.Show("Datos ingresados correctamente");
                codigo1++;
            }
            else
            {
                MessageBox.Show("No hay suficiente stock de este producto.", "ERROR");
            }
        }
        private int numproductos()
        {
            int num_total = 0;

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.farmacia where `Nombre`= '"+cb_consumibles.Text+"';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                num_total = Convert.ToInt32(leer["Stock"]);
            }
            
            return num_total;
        }

        private void limpiar_consumible()
        {
            try
            {
                cb_consumibles.SelectedIndex = 0;
                num_consumibles.Value = 1;
            }
            catch { }
        }

        private void datagrid_med_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = datagrid_med.CurrentCell.RowIndex;

            cb_medica.Text = Convert.ToString(datagrid_med[0, posicion].Value);
            num_medica.Text = Convert.ToString(datagrid_med[1, posicion].Value);
            tx_tomarmed.Text = Convert.ToString(datagrid_med[2, posicion].Value);
        }

        private void consulta_Activated(object sender, EventArgs e)
        {
            llenar_textbox();
        }

        private void butt_señal_Click(object sender, EventArgs e)
        {
            
            Seriallab.MainForm U = new Seriallab.MainForm();
            U.ShowDialog();
        }

        private void consulta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Proyecto_Final.Program.IdCliente = 0;
            fechaf = "";
            Proyecto_Final.Program.idconsultorio = -1;
            Proyecto_Final.Program.Tipo_De_Cliente = "";
            Proyecto_Final.Program.NombreCliente = "";
            Proyecto_Final.Program.ApellidoCliente = "";
            Proyecto_Final.Program.NombreConsultorio = "";

        }

        private void datagrid_consu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion1 = datagrid_consu.CurrentCell.RowIndex;

            cb_consumibles.Text = Convert.ToString(datagrid_consu[0, posicion1].Value);
            num_consumibles.Text = Convert.ToString(datagrid_consu[1, posicion1].Value);
        }

        private void butt_modcons_Click(object sender, EventArgs e)
        {
            datagrid_consu[0, posicion].Value = cb_consumibles.Text;
            datagrid_consu[1, posicion].Value = num_consumibles.Value;

            limpiar_consumible();
        }

        private void butt_modmed_Click(object sender, EventArgs e)
        {
            datagrid_med[0, posicion].Value = cb_medica.Text;
            datagrid_med[1, posicion].Value = num_medica.Value;
            datagrid_med[2, posicion].Value = tx_tomarmed.Text;

            limpiar_medicamento();
        }

        private void butt_elimin_consu_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(datagrid_consu[0, posicion].Value) != "")
            {
                datagrid_consu.Rows.RemoveAt(posicion);
                limpiar_consumible();
            }
        }

        private void tx_padecimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsWhiteSpace(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && tx_sintomas.TextLength < 300 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void butt_limp_Click(object sender, EventArgs e)
        {
            tx_pac.Clear();
            tx_edad.Clear();
            tx_observaciones.Clear();
            tx_alergias.Clear();
            tx_padecimiento.Clear();
            tx_sintomas.Clear();
        }
    }
}
