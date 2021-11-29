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
    public partial class Mobiliario : Form
    {
        string id;
        int posicion=0,id_fin;
        public Mobiliario()
        {
            InitializeComponent();
            cargar_tabla();
            //admin();
            limpiar();
            gen_fin_id();
            area_combobox();
            this.toolTip1.SetToolTip(tbnombre, "Ingrese el nombre");
            this.toolTip1.SetToolTip(tx_modelo, "Ingrese el Numero de telefono");


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
        
        public void area_combobox()
        {
            string Query = "SELECT * FROM final_clinica1.area_clinica;";

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);

                cb_area.DisplayMember = "Descripcion";
                cb_area.ValueMember = "idArea_Clinica";
                cb_area.DataSource = ds;
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

            MySqlCommand cmd = new MySqlCommand("SELECT idMobiliario FROM final_clinica1.mobiliario order by idMobiliario DESC  LIMIT 0, 1 ;", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id_fin = Convert.ToInt32(leer["idMobiliario"]);

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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.mobiliario where Descripcion='" + tbnombre.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.mobiliario where Descripcion='" + tbnombre.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
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
            string Query = "SELECT * FROM final_clinica1.mobiliario;";

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
            string Query = "SELECT * FROM final_clinica1.mobiliario where Descripcion like'" + textBox1.Text + "%';";

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

            string Query = "SELECT * FROM final_clinica1.mobiliario where `Tipo de equipo` like'" + textBox1.Text + "%';";
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

            string Query = "SELECT * FROM final_clinica1.mobiliario where idMobiliario like'" + textBox1.Text + "%';";

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

            try {
                posicion = dataGridView1.CurrentCell.RowIndex;

                errorProvider1.Clear();
                // esto es para que te diga en que posición esta la columna seleccionada 
                id = Convert.ToString(dataGridView1[0, posicion].Value);
                tbnombre.Text = Convert.ToString(dataGridView1[1, posicion].Value);
                cb_tipoE.Text = (Convert.ToString(dataGridView1[2, posicion].Value));
                tx_uso.Text = Convert.ToString(dataGridView1[3, posicion].Value);
                tx_marca.Text = Convert.ToString(dataGridView1[4, posicion].Value);
                tx_modelo.Text = Convert.ToString(dataGridView1[5, posicion].Value);
                cb_area.SelectedIndex = (Convert.ToInt32(dataGridView1[6, posicion].Value));


                button1.Enabled = true;
                button3.Enabled = true;
                btngua.Enabled = false;
                textBox1.Enabled = false;

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
             if (validacion())
            {
                if (!repetir1())
                {
                    //UPDATE `final_clinica1`.`usuario` SET `Nombre`= 'Robert', `Contraseña`= '1234', `Pregunta_idPregunta`= '0', `Respuesta_pregunta`= 'NA' WHERE `idUsuario`= '2'  and`id_trabajador`= '2';
                    string Query = "UPDATE `final_clinica1`.`mobiliario` SET `Descripcion`='"+tbnombre.Text+ "', `Tipo de equipo`='" + cb_tipoE.Text + "', `uso`='" + tx_uso.Text + "', `Marca`='" + tx_marca.Text + "', `Modelo`='" + tx_modelo.Text + "', `Area_Clinica_idArea_Clinica`='" + cb_area.SelectedIndex + "' WHERE `idMobiliario`='"+id+"';";
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
                    MessageBox.Show("Este moviliario ya fue registrada.", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("ERROR: Favor de ingresar datos correctos", "Clínica La Condesa");
            }
    }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string Query = "DELETE FROM final_clinica1.mobiliario where idMobiliario='" + id +"';";

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
            tbnombre.Clear();
            textBox1.Clear();
            tx_marca.Clear();
            tx_modelo.Clear();
            tx_uso.Clear();
            cb_tipoE.SelectedIndex = 0;
            cb_area.SelectedIndex = 0;


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


        private void btngua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (validacion())
            {
                if (!repetir())
                {
                    id_fin++;
                    string Query = "INSERT INTO `final_clinica1`.`mobiliario` (`Descripcion`, `Tipo de equipo`, `uso`, `Marca`, `Modelo`, `Area_Clinica_idArea_Clinica`) VALUES ('" + tbnombre.Text + "', '" + cb_tipoE.Text + "', '" + tx_uso.Text + "', '" + tx_marca.Text + "', '" + tx_modelo.Text + "', '" + cb_area.SelectedIndex + "'); ";
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
            if (tbnombre.Text == "" || tbnombre.Text.Contains("  "))
            {
                errorProvider1.SetError(tbnombre, "Ingresa un nombre correcto. No se permite doble espaciado");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tbnombre, null);
            }

            if (tx_marca.Text == "" || tx_marca.Text.Contains("  "))
            {
                errorProvider1.SetError(tx_marca, "Ingresa una marca correcta");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tx_marca, null);
            }

            if (tx_modelo.Text == "" || tx_modelo.Text.Contains("  "))
            {
                errorProvider1.SetError(tx_modelo, "Ingresa un modelo correcto. Mayor a 5 caracteres.No doble espacio");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tx_modelo, null);
            }

            if (tx_uso.Text.Contains("  "))
            {
                errorProvider1.SetError(tx_uso, "Ingresa un uso correcto. No doble espacio");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tx_uso, null);
            }


            return validar;
        }

        private void tbnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && tbnombre.TextLength == 0)
            {
                e.Handled = true;
            }
            else
            {
                if ((char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) && tbnombre.TextLength < 25 || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tx_modelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && tx_modelo.TextLength == 0)
            {
                e.Handled = true;
            }
            else
            {
                if ((char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) && tx_modelo.TextLength < 25 || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tx_marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && tx_modelo.TextLength == 0)
            {
                e.Handled = true;
            }
            else
            {
                if ((char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) && tx_modelo.TextLength < 25 || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tx_uso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && tx_modelo.TextLength == 0)
            {
                e.Handled = true;
            }
            else
            {
                if ((char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) && tx_modelo.TextLength < 25 || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


    }
}
          