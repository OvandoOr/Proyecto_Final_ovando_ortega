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
using System.Text.RegularExpressions;


namespace Empleado
{
    public partial class Usuarios : Form
    {
        string id;
        int posicion=0,id_fin;
        public Usuarios()
        {
            InitializeComponent();
            cargar_tabla();
            admin();
            limpiar();
            gen_fin_id();
            pregunta_combobox();
            puesto_combobox();         
            this.toolTip1.SetToolTip(txcontra, "Ingrese la contraseña del usuario");

        }

        public void admin()
        {
            if (Proyecto_Final.Program.Admin == false)
            {
                button1.Dispose();
                button3.Dispose();
                btngua.Dispose();

            }

        }


        public void puesto_combobox()
        {
            string Query = "SELECT * FROM final_clinica1.trabajador;";

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);

                comboBox1.DisplayMember = "Descripcion";
                comboBox1.ValueMember = "idTrabajador";
                comboBox1.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void pregunta_combobox()
        {
            string Query = "SELECT * FROM final_clinica1.pregunta;";

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);

                cb_pregunta.DisplayMember = "Pregunta";
                cb_pregunta.ValueMember = "idPregunta";
                cb_pregunta.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void gen_fin_id()
        {
            //MySqlConnection conection = new MySqlConnection("server=localhost;database=bmd_practica;Uid=root;pwd=2015030063");

            //conection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT idUsuario FROM final_clinica1.usuario order by idUsuario DESC  LIMIT 0, 1 ;", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id_fin = Convert.ToInt32(leer["idUsuario"]);

                //conection.Close();
            }
            else
            {
                //conection.Close();

            }
        }

        public bool repetir()
        {
            bool repetir = false;

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.usuario where Nombre='" + txnombreu.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                repetir = true;
            }

            return repetir;
        }

        public bool repetir1()
        {
            bool repetir = false;
            int repet = 0;

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.usuario where Nombre='" + txnombreu.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
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



        private void cargar_tabla()
        {
            string Query = "SELECT * FROM final_clinica1.usuario;";

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

        public void radiobuton1()
        {
            string Query = "SELECT * FROM final_clinica1.usuario where Nombre like'" + textBox1.Text + "%';";

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

        public void radiobuton2()
        {

            string Query = "SELECT * FROM final_clinica1.usuario where id_trabajador like'" + textBox1.Text + "%';";
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
        public void radiobuton3()
        {

            string Query = "SELECT * FROM final_clinica1.usuario where idUsuario like'" + textBox1.Text + "%';";

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
                id = Convert.ToString(dataGridView1[0, posicion].Value);

                txnombreu.Text = Convert.ToString(dataGridView1[1, posicion].Value);
                txcontra.Text = Convert.ToString(dataGridView1[2, posicion].Value);
                cb_pregunta.SelectedIndex = (Convert.ToInt32(dataGridView1[3, posicion].Value) - 1);
                tx_resp.Text = Convert.ToString(dataGridView1[4, posicion].Value);
                comboBox1.SelectedIndex = (Convert.ToInt32(dataGridView1[5, posicion].Value) - 1);

                button1.Enabled = true;
                button3.Enabled = true;
                btngua.Enabled = false;
                textBox1.Enabled = false;
            }
            catch { }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
             if (validacion())
            {
                if (!repetir1())
                {
                    //UPDATE `final_clinica1`.`usuario` SET `Nombre`= 'Robert', `Contraseña`= '1234', `Pregunta_idPregunta`= '0', `Respuesta_pregunta`= 'NA' WHERE `idUsuario`= '2'  and`id_trabajador`= '2';

                    string Query = "UPDATE `final_clinica1`.`usuario` SET `Nombre`= '"+txnombreu.Text+"', `Contraseña`= '"+txcontra.Text+"', `Pregunta_idPregunta`= '"+cb_pregunta.SelectedIndex+"', `Respuesta_pregunta`= '"+tx_resp.Text+ "', `id_trabajador`= '" + (comboBox1.SelectedIndex + 1) + "' WHERE `idUsuario`= '" + id+"' ;";
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
                    MessageBox.Show("El producto ya existe.", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("ERROR: Favor de ingresar datos correctos", "Clínica La Condesa");
            }
            cargar_tabla();
            limpiar();
    }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string Query = "DELETE FROM final_clinica1.usuario where idUsuario='" + id +"';";

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

            cargar_tabla();

            limpiar();
        }

        public void limpiar()
        {
            
            textBox1.Clear();
            txnombreu.Clear();
            txcontra.Clear();
            tx_resp.Clear();

            
            cb_pregunta.SelectedIndex=0;
            comboBox1.SelectedIndex=0;

            button1.Enabled = false;
            button3.Enabled = false;
            btngua.Enabled = true;
            textBox1.Enabled = true;
            errorProvider1.Clear();



        }
        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        public void registrar_usuario()
        {

            string Query = "INSERT INTO `final_clinica1`.`usuario` (`Nombre`, `Contraseña`, `Pregunta_idPregunta`, `Respuesta_pregunta`, `id_trabajador`) VALUES ('"+txnombreu.Text+"', '"+txcontra.Text+"', '"+cb_pregunta.SelectedIndex+"', '"+tx_resp+"', '2');";
            try
            {
                MySqlCommand cmdDataBase = new MySqlCommand(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                MySqlDataReader myReader;
                myReader = cmdDataBase.ExecuteReader();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btngua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (validacion())
            {
                if (!repetir())
                {
                    registrar_usuario();
                    
                    cargar_tabla();
                    gen_fin_id();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Este usuario ya existe.", "ERROR");
                }
                   
                }
            else
            {
                MessageBox.Show("ERROR: Favor de ingresar datos correctos", "Clínica La Condesa");
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                radiobuton1();
            }

            if (radioButton2.Checked == true)
            {
                radiobuton2();
            }

            if (radioButton3.Checked == true)
            {
                radiobuton3();
            }

        }

        public bool validacion()
        {
            bool validar = true;
            

            if (txnombreu.Text == "" || txnombreu.TextLength < 4)
            {
                errorProvider1.SetError(txnombreu, "Ingresa un nombre de usuario correcto. Mayor de 3 carácteres");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(txnombreu, null);
            }

            if (txcontra.Text == "" || txcontra.TextLength < 4)
            {
                errorProvider1.SetError(txcontra, "Ingresa una contraseña correcta. Mayor de 3 carácteres");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(txcontra, null);
            }

            
            if (tx_resp.Text == "" || tx_resp.TextLength < 4)
            {
                errorProvider1.SetError(tx_resp, "Ingresa una respuesta correcta. Mayor de 4 carácteres");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tx_resp, null);
            }

            return validar;
        }

        

        private void txnombreu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) && txnombreu.TextLength < 15 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txcontra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) && txcontra.TextLength < 15 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



       

        private void tx_resp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) && tx_resp.TextLength < 30 || char.IsControl(e.KeyChar))
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

          