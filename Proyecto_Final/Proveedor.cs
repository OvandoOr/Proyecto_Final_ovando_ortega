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
    public partial class Proveedores : Form
    {
        string id;
        int posicion = 0, id_fin;
        public Proveedores()
        {
            InitializeComponent();
            cargar_tabla();
            admin();
            limpiar();
            gen_fin_id();
            this.toolTip1.SetToolTip(tbnombre, "Ingrese el nombre");
            this.toolTip1.SetToolTip(tba_giro, "Ingrese el Apellido Paterno");
            this.toolTip1.SetToolTip(tba_Rsocial, "Ingrese el Apellido Materno");
            this.toolTip1.SetToolTip(tbRFC, "Ingrese la edad");
            this.toolTip1.SetToolTip(tbTelefono, "Ingrese el Numero de telefono");
            this.toolTip1.SetToolTip(tbCorreo, "Ingrese el Correo electronico");
            this.toolTip1.SetToolTip(tbdicc, "Ingrese el CURP");

        }

        public void admin()
        {
            if (Proyecto_Final.Program.Admin == false)
            {
                button1.Enabled = false;
                button3.Enabled = false;
                btngua.Enabled = false;

            }

        }

        private void gen_fin_id()
        {
            MySqlConnection conection = new MySqlConnection("server=localhost;database=bmd_practica;Uid=root;pwd=2015030063");

            conection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT idProveedor FROM kioxxo.proveedor order by idProveedor DESC  LIMIT 0, 1 ;", conection);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id_fin = Convert.ToInt32(leer["idProveedor"]);

                conection.Close();
            }
            else
            {
                conection.Close();

            }
        }

        public bool repetir()
        {
            bool repetir = false;

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Clínica La Condesa.proveedor where nombre='" + tbnombre.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.proveedor where nombre='" + tbnombre.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
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
            string Query = "SELECT * FROM final_clinica1.proveedor;";

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
            string Query = "SELECT * FROM final_clinica1.proveedor where nombre like'" + textBox1.Text + "%';";

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

            string Query = "SELECT * FROM final_clinica1.proveedor where giro like'" + textBox1.Text + "%';";
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

            string Query = "SELECT * FROM final_clinica1.proveedor where idProveedor like'" + textBox1.Text + "%';";

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
            errorProvider1.Clear();
            // esto es para que te diga en que posición esta la columna seleccionada 
            id = Convert.ToString(dataGridView1[0, posicion].Value);
            tbnombre.Text = Convert.ToString(dataGridView1[1, posicion].Value);
            tba_giro.Text = Convert.ToString(dataGridView1[2, posicion].Value);
            tba_Rsocial.Text= Convert.ToString(dataGridView1[3, posicion].Value);
            tbRFC.Text= Convert.ToString(dataGridView1[4, posicion].Value);
            tbTelefono.Text= Convert.ToString(dataGridView1[5, posicion].Value);
            tbCorreo.Text= Convert.ToString(dataGridView1[6, posicion].Value);
            tbdicc.Text = Convert.ToString(dataGridView1[7, posicion].Value);

            button1.Enabled = true;
            button3.Enabled = true;
            btngua.Enabled = false;
            textBox1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (validacion())
            {
                if (!repetir1())
                {
                    //idProveedor, nombre, giro, Razon_Social, RFC, Telefono, correo, direccion
                    string Query = " UPDATE `final_clinica1`.`proveedor` SET `nombre`='" + tbnombre.Text + "', `giro`='" + tba_giro.Text + "', `Razon_Social`='" + tba_Rsocial.Text + "', `RFC`='" + tbRFC.Text + "', `Telefono`='" + tbTelefono.Text + "', `correo`='" + tbCorreo.Text + "', `direccion`='" + tbdicc.Text + "' WHERE `idProveedor`='" + id + "';";
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
                    MessageBox.Show("El producto ya existe.", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("ERROR: Favor de ingresar datos correctos", "Clínica La Condesa");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            string Query = "DELETE FROM final_clinica1.proveedor where idProveedor='" + id +"';";
            if (MessageBox.Show("¿Está seguro de eliminar a este proveedor? (Esto puede causar conflicto en los productos de este proveedor, asegurese de cambiar a los proveedores de sus productos)", "Clínica La Condesa", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {

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

        }

        public void limpiar()
        {
            tbnombre.Clear();
            tba_giro.Clear();
            tba_Rsocial.Clear();
            tbRFC.Clear();
            tbCorreo.Clear();
            tbdicc.Clear();
            tbTelefono.Clear();
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
                    //nombre, giro, Razon_Social, RFC, Telefono, correo, direccion
                    string Query = "INSERT INTO `final_clinica1`.`proveedor` (`idProveedor`, `nombre`, `giro`, `Razon_Social`, `RFC`, `Telefono`, `correo`, `direccion`) VALUES ('" + id_fin + "', '" + tbnombre.Text + "', '" + tba_giro.Text + "', '" + tba_Rsocial.Text + "', '" + tba_Rsocial + "', '" + tbTelefono.Text + "', '" + tbCorreo.Text + "', '" + tbdicc.Text+"'); ";
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
                    limpiar();
                    gen_fin_id();
                    cargar_tabla();

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

        private void tbnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && tbnombre.TextLength == 0)
            {
                e.Handled = true;
            }
            else
            {
                if ((char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) && tbnombre.TextLength < 25 || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tba_giro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && tba_giro.TextLength < 15 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tba_Rsocial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsWhiteSpace(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && tbCorreo.TextLength < 30 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsUpper(e.KeyChar) ||char.IsDigit(e.KeyChar)) && tbRFC.TextLength < 14 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsSymbol(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && tbCorreo.TextLength < 30 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
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

            if (tba_giro.Text == "" || tba_giro.Text.Contains("  "))
            {
                errorProvider1.SetError(tba_giro, "Ingresa un giro correcto");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tba_giro, null);
            }

            if (tba_Rsocial.Text == "" || tba_Rsocial.Text.Contains("  "))
            {
                errorProvider1.SetError(tba_Rsocial, "Ingresa una Razon Social correcta");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tba_Rsocial, null);
            }

            if (tbRFC.Text == "" || tbRFC.TextLength<12)
            {
                errorProvider1.SetError(tbRFC, "Ingresa un RFC correcto(Entre 12 y 13 caracteres");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tbRFC, null);
            }


            if (tbTelefono.Text == "" || tbTelefono.TextLength < 7 || tbTelefono.TextLength > 12)
            {
                errorProvider1.SetError(tbTelefono, "Ingresa un telefono correcto. De 7 a 12 diditos");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tbTelefono, null);
            }

            if (tbCorreo.Text == "" || !ComprobarFormatoEmail(tbCorreo.Text))
            {
                errorProvider1.SetError(tbCorreo, "Ingresa un correo electronico valido");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tbCorreo, null);
            }

            if (tbdicc.Text == "" || tbdicc.TextLength < 10)
            {
                errorProvider1.SetError(tbdicc, "Ingresa una direccion correcta(Más 10 caracteres");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tbdicc, null);
            }

            return validar;
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && tbTelefono.TextLength < 14 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbdicc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsWhiteSpace(e.KeyChar) || char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && tbCorreo.TextLength < 150 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static bool ComprobarFormatoEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
          