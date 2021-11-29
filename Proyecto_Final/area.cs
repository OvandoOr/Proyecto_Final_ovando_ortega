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
    public partial class Áreas : Form
    {
        string id;
        int posicion=0,id_fin;
        public Áreas()
        {
            InitializeComponent();
            cargar_tabla();
            //admin();
            limpiar();
            gen_fin_id();
            this.toolTip1.SetToolTip(tbnombre, "Ingrese el nombre del área");


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


        
        private void gen_fin_id()
        {
            //MySqlConnection conection = new MySqlConnection("server=localhost;database=bmd_practica;Uid=root;pwd=2015030063");

            //conection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT idArea_Clinica FROM final_clinica1.area_clinica order by idArea_Clinica DESC  LIMIT 0, 1 ;", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id_fin = Convert.ToInt32(leer["idArea_Clinica"]);

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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.area_clinica where Nombre='" + tbnombre.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.area_clinica where Nombre='" + tbnombre.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
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
            string Query = "SELECT * FROM final_clinica1.area_clinica;";

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
            string Query = "SELECT * FROM final_clinica1.area_clinica where Descripcion like'" + textBox1.Text + "%';";

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
                tbnombre.Text = Convert.ToString(dataGridView1[1, posicion].Value);


                button1.Enabled = true;
                button3.Enabled = true;
                btngua.Enabled = false;
                textBox1.Enabled = false;
            }
            catch
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
             if (validacion())
            {
                if (!repetir1())
                {

                    string Query = "UPDATE `final_clinica1`.`area_clinica` SET `Descripcion`='"+tbnombre.Text+"' WHERE `idArea_Clinica`='2'; ";
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
                    MessageBox.Show("Esta persona ya fue registrada.", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("ERROR: Favor de ingresar datos correctos", "Clínica La Condesa");
            }
    }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string Query = "DELETE FROM final_clinica1.area_clinica where idEmpleado='" + id +"';";

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
                    //INSERT INTO `final_clinica1`.`doctores` (`Nombre`, `A_paterno`, `A_materno`, `Telefono`, `Correo`, `Fecha_Nac`, `Direccion`, `CURP`, `Cedula`, `Escuela_Estudios`, `Tipo_Sangre_idTipo_Sangre`, `Estado_Civil_idEstado_Civil`, `Usuario_idUsuario`, `sexo`, `id_especialidad`) VALUES ('aaaa', 'aaaa', 'aaaa', '123123123', 'asdsad@hotmail.com', '1996-11-11', 'Por aca', '1231232131', '123213123', 'UNAM', '2', '1', '2', '1', '1');
                    string Query = "INSERT INTO `final_clinica1`.`area_clinica` (`Descripcion`) VALUES ('"+tbnombre.Text+"'); ";
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
                    MessageBox.Show("Esta área ya existe.", "ERROR");
                }
                   
                }
            else
            {
                MessageBox.Show("ERROR: Favor de ingresar datos correctos", "Clínica La Condesa");
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
                radiobuton1();
            

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

       
    }
}
          