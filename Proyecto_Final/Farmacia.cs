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
    public partial class Farmacia : Form
    {
        string id,fecha1,caducado;
        int posicion=0,id_fin;
        public Farmacia()
        {
            InitializeComponent();
            cargar_tabla();
            //admin();
            limpiar();
            gen_fin_id();
            aviso_caducar();
            proveedor_combobox();
            tipo_producto_combobox();
            fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            this.toolTip1.SetToolTip(tbnombre, "Ingrese el nombre");
            this.toolTip1.SetToolTip(tx_generico, "Ingrese el Apellido Paterno");
            this.toolTip1.SetToolTip(tx_formula, "Ingrese el Numero de telefono");


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

        private void aviso_caducar()
        {

            string hoy = (DateTime.Now).ToString("yyyy-MM-dd");

            try
            {
                MySqlCommand cmd = new MySqlCommand("select *  from final_clinica1.farmacia where `Fecha de caducidad` <= '" + hoy + "'", Proyecto_Final.BaseDeDatos.ObtenerConexion());
                MySqlDataReader leer = cmd.ExecuteReader();
                while (leer.Read())
                {
                    caducado = Convert.ToString(leer["Nombre"]);
                    MessageBox.Show("El producto "+caducado+" ya caduco o esta por caducarse. Favor de retirarlo de farmacia.");

                    //conection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void proveedor_combobox()
        {
            string Query = "SELECT * FROM final_clinica1.`proveedor`;";

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);

                cb_proveedores.DisplayMember = "Nombre";
                cb_proveedores.ValueMember = "idProveedor";
                cb_proveedores.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void tipo_producto_combobox()
        {
            string Query = "SELECT * FROM final_clinica1.`tipo de producto`;";

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);

                cb_tipoPro.DisplayMember = "Descripcion";
                cb_tipoPro.ValueMember = "idTipo de producto";
                cb_tipoPro.DataSource = ds;
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

            MySqlCommand cmd = new MySqlCommand("SELECT idFarmacia FROM final_clinica1.farmacia order by idFarmacia DESC  LIMIT 0, 1 ;", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id_fin = Convert.ToInt32(leer["idFarmacia"]);

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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.farmacia where Nombre='" + tbnombre.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.farmacia where Nombre='" + tbnombre.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
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
            string Query = "SELECT * FROM final_clinica1.farmacia;";

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
            string Query = "SELECT * FROM final_clinica1.farmacia where Nombre like'" + textBox1.Text + "%';";

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

            string Query = "SELECT * FROM final_clinica1.farmacia where `Medicamento o recurso medico` like'" + textBox1.Text + "%';";
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

            string Query = "SELECT * FROM final_clinica1.farmacia where idFarmacia like'" + textBox1.Text + "%';";

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
                cb_tipoPro.SelectedIndex = (Convert.ToInt32(dataGridView1[2, posicion].Value));
                tx_generico.Text = Convert.ToString(dataGridView1[3, posicion].Value);
                txt_precio.Text = Convert.ToString(dataGridView1[9, posicion].Value);
                cb_proveedores.SelectedIndex = (Convert.ToInt32(dataGridView1[4, posicion].Value)) - 1;
                dtpFecha.Text = Convert.ToString(dataGridView1[5, posicion].Value);
                dateTimePicker1.Text = Convert.ToString(dataGridView1[6, posicion].Value);
                if (Convert.ToString(dataGridView1[6, posicion].Value) == "")
                    checkBox1.Checked = true;
                else checkBox1.Checked = false;
                tx_formula.Text = Convert.ToString(dataGridView1[7, posicion].Value);
                num_stock.Value = Convert.ToDecimal(dataGridView1[8, posicion].Value);

                button1.Enabled = true;
                button3.Enabled = true;
                btngua.Enabled = false;
                textBox1.Enabled = false;
            }
            catch { }
        }
        string fecha;

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
             if (validacion())
            {
                if (!repetir1())
                {
                    //UPDATE `final_clinica1`.`usuario` SET `Nombre`= 'Robert', `Contraseña`= '1234', `Pregunta_idPregunta`= '0', `Respuesta_pregunta`= 'NA' WHERE `idUsuario`= '2'  and`id_trabajador`= '2';
                    string Query = "UPDATE `final_clinica1`.`farmacia` SET `Nombre`='"+tbnombre.Text+ "', `Medicamento o recurso medico`='" + cb_tipoPro.SelectedIndex + "', `precio`='" + txt_precio.Text + "', `Nombre generico`='" + tx_generico.Text + "', `proveerdor_idproveerdor`='" + (cb_proveedores.SelectedIndex+1) + "', `Fecha ingreso`='" + fecha + "', `Fecha de caducidad`= '" + fecha1 + "', `Formula`='" + tx_formula.Text + "', `Stock`='" + num_stock.Value+ "' WHERE `idFarmacia`='" + id + "';";
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
            
            string Query = "DELETE FROM final_clinica1.farmacia where idFarmacia='" + id +"';";

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
            tx_generico.Clear();
            tx_formula.Clear();
            textBox1.Clear();
            checkBox1.Checked = false;
            cb_proveedores.SelectedIndex = 0;
            cb_tipoPro.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
            txt_precio.Clear();
            num_stock.Value = 0;

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
                    //INSERT INTO `final_clinica1`.`farmacia` (`Nombre`, `Medicamento o recurso medico`, `Nombre generico`, `proveerdor_idproveerdor`, `Fecha ingreso`, `Fecha de caducidad`, `Formula`, `Stock`) VALUES ('Ibuprofen', '1', 'Simiprufeno', '1', '2017-11-02', '2018-11-02', 'Ibuprofeno55mg', '10');
                    string Query = "INSERT INTO `final_clinica1`.`farmacia` (`Nombre`, `Medicamento o recurso medico`, `Nombre generico`, ´precio´, `proveerdor_idproveerdor`, `Fecha ingreso`, `Fecha de caducidad`, `Formula`, `Stock`) VALUES ('" + tbnombre.Text + "', '" + cb_tipoPro.SelectedIndex + "', '" + tx_generico.Text + "', '" + txt_precio.Text + "','" + (cb_proveedores.SelectedIndex+1) + "', '" + fecha + "', " + fecha1 + ", '" + tx_formula.Text + "', '" + num_stock.Value + "');";
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

            if (tx_generico.Text == "" || tx_generico.Text.Contains("  "))
            {
                errorProvider1.SetError(tx_generico, "Ingresa un apellido paterno correcto");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tx_generico, null);
            }

            if (tx_formula.Text == "" || tx_formula.TextLength<5)
            {
                errorProvider1.SetError(tx_formula, "Ingresa una formula correcta. Mayor a 5 caracteres");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tx_formula, null);
            }

            if (txt_precio.Text == "" || (txt_precio.Text.Contains("..")))
            {
                errorProvider1.SetError(tx_formula, "Ingresa un precio correcto.");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tx_formula, null);
            }


            if (checkBox1.Checked)
            {
                fecha1 = "NULL";
            }
            else
            {
                if (dtpFecha.Value < dateTimePicker1.Value)
                {

                    fecha1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                }
                else
                {
                    MessageBox.Show("La fecha de caducidad no puede ser mayor que la de ingreso");
                    validar = false;
                }

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

        private void tba_Paterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && tx_generico.TextLength < 15 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && tx_formula.TextLength < 14 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                dateTimePicker1.Enabled = false;
            }
            else
            {
                dateTimePicker1.Enabled = true;
            }
        }

        private bool est_fecha()
        {
            bool validar = true;
            if (checkBox1.Checked)
            {
                fecha1= "NULL";
            }
            else
            {
                if (dtpFecha.Value < dateTimePicker1.Value)
                {

                    fecha1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                }
                else
                {
                    MessageBox.Show("La fecha de caducidad no puede ser mayor que la de ingreso");
                    validar = false;
                }

            }
            return validar;
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsPunctuation(e.KeyChar) && txt_precio.TextLength == 0)
            {
                e.Handled = true;
            }
            else
            {
                if ((char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && txt_precio.TextLength < 9 || char.IsControl(e.KeyChar))
                {
                    if (txt_precio.Text.Contains('.') && (char.IsPunctuation(e.KeyChar)))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_precio_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                double num = Convert.ToDouble(txt_precio.Text);
                num = Math.Round(num, 2);
                txt_precio.Text = Convert.ToString(num);
            }
            catch { }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fecha1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


    }
}
          