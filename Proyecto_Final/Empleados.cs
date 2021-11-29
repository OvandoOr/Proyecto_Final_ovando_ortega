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
    public partial class Empleado : Form
    {
        string id;
        int posicion=0,id_fin;
        public Empleado()
        {
            InitializeComponent();
            cargar_tabla();
            //admin();
            limpiar();
            gen_fin_id();
            sexo_combobox();
            sangre_combobox();
            puesto_combobox();
            area_combobox();
            estado_civil_combobox();
            fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
            this.toolTip1.SetToolTip(tbnombre, "Ingrese el nombre");
            this.toolTip1.SetToolTip(tba_Paterno, "Ingrese el Apellido Paterno");
            this.toolTip1.SetToolTip(tba_Materno, "Ingrese el Apellido Materno");
            this.toolTip1.SetToolTip(tbTelefono, "Ingrese el Numero de telefono");
            this.toolTip1.SetToolTip(tbCorreo, "Ingrese el Correo electronico");
            this.toolTip1.SetToolTip(tbCURP, "Ingrese el CURP");
            this.toolTip1.SetToolTip(cbSexo, "Seleccione el sexo");

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


        public void sexo_combobox()
        {
            string Query = "SELECT * FROM final_clinica1.sexo;";

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);

                cbSexo.DisplayMember = "descripcion";
                cbSexo.ValueMember = "idSexo";
                cbSexo.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                cb_puesto.DisplayMember = "Descripcion";
                cb_puesto.ValueMember = "idTrabajador";
                cb_puesto.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public void sangre_combobox()
        {
            string Query = "SELECT * FROM final_clinica1.tipo_sangre;";

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);

                cb_sangre.DisplayMember = "Descripcion";
                cb_sangre.ValueMember = "idTipo_Sangre";
                cb_sangre.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void estado_civil_combobox()
        {
            string Query = "SELECT * FROM final_clinica1.estado_civil;";

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);

                cb_estadoC.DisplayMember = "Descripcion";
                cb_estadoC.ValueMember = "idEstado_Civil";
                cb_estadoC.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                cb_areaC.DisplayMember = "Descripcion";
                cb_areaC.ValueMember = "idArea_Clinica";
                cb_areaC.DataSource = ds;
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

            MySqlCommand cmd = new MySqlCommand("SELECT idEmpleado FROM final_clinica1.empleado order by idEmpleado DESC  LIMIT 0, 1 ;", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id_fin = Convert.ToInt32(leer["idEmpleado"]);

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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.empleado where Nombre='" + tbnombre.Text + "'and A_paterno='" + tba_Paterno.Text + "'and A_materno='" + tba_Materno.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
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

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.empleado where Nombre='" + tbnombre.Text + "'and A_paterno='" + tba_Paterno.Text + "'and A_materno='" + tba_Materno.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
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
            string Query = "SELECT * FROM final_clinica1.empleado;";

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
            string Query = "SELECT * FROM final_clinica1.empleado where Nombre like'" + textBox1.Text + "%';";

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

            string Query = "SELECT * FROM final_clinica1.empleado where A_paterno like'" + textBox1.Text + "%';";
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

            string Query = "SELECT * FROM final_clinica1.empleado where A_materno like'" + textBox1.Text + "%';";

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
                tba_Paterno.Text = Convert.ToString(dataGridView1[2, posicion].Value);
                tba_Materno.Text = Convert.ToString(dataGridView1[3, posicion].Value);
                tbTelefono.Text = Convert.ToString(dataGridView1[4, posicion].Value);
                tx_telemer.Text = Convert.ToString(dataGridView1[5, posicion].Value);
                tbCorreo.Text = Convert.ToString(dataGridView1[6, posicion].Value);
                dtpFecha.Text = Convert.ToString(dataGridView1[7, posicion].Value);
                tx_direccion.Text = Convert.ToString(dataGridView1[8, posicion].Value);
                tbCURP.Text = Convert.ToString(dataGridView1[9, posicion].Value);

                cb_sangre.SelectedIndex = (Convert.ToInt32(dataGridView1[10, posicion].Value)) - 1;
                cb_estadoC.SelectedIndex = (Convert.ToInt32(dataGridView1[11, posicion].Value)) - 1;
                cb_puesto.SelectedIndex = (Convert.ToInt32(dataGridView1[12, posicion].Value)) - 1;
                cb_areaC.SelectedIndex = (Convert.ToInt32(dataGridView1[13, posicion].Value));
                cbSexo.SelectedIndex = (Convert.ToInt32(dataGridView1[14, posicion].Value)) - 1;


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

                    string Query = "UPDATE `final_clinica1`.`empleado` SET `Nombre`='"+tbnombre.Text+ "', `A_paterno`='" + tba_Paterno.Text + "', `A_materno`='" + tba_Materno.Text + "', `Telefono`='" + tbTelefono.Text + "', `Telefono_Emergencia`='" + tx_telemer.Text + "', `Correo`='" + tbCorreo.Text + "', `Fecha_Nac`='" + fecha + "', `Direccion`='" + tx_direccion.Text + "', `CURP`='" + tbCURP.Text + "', `Tipo_Sangre_idTipo_Sangre`='" + (cb_sangre.SelectedIndex + 1) + "', `Estado_Civil_idEstado_Civil`='" + (cb_estadoC.SelectedIndex + 1) + "', `Trabajador_idTrabajador`='" + (cb_puesto.SelectedIndex + 1) + "', `Area_Clinica_idArea_Clinica`='" + (cb_areaC.SelectedIndex + 1) + "', `sexo`='" + (cb_sangre.SelectedIndex + 1) + "' WHERE `idEmpleado`='" + id + "';";
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
            
            string Query = "DELETE FROM final_clinica1.empleado where idEmpleado='" + id +"';";

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
            tba_Paterno.Clear();
            tba_Materno.Clear();
            tbCorreo.Clear();
            tbCURP.Clear();
            tbTelefono.Clear();
            textBox1.Clear();

            tx_direccion.Clear();
            tx_telemer.Clear();

            cbSexo.SelectedIndex=0;
            cb_estadoC.SelectedIndex = 0;
            cb_sangre.SelectedIndex = 0;


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
                    string Query = "INSERT INTO `final_clinica1`.`empleado` (`Nombre`, `A_paterno`, `A_materno`, `Telefono`, `Telefono_Emergencia`, `Correo`, `Fecha_Nac`, `Direccion`, `CURP`, `Tipo_Sangre_idTipo_Sangre`, `Estado_Civil_idEstado_Civil`, `Trabajador_idTrabajador`, `Area_Clinica_idArea_Clinica`, `sexo`) VALUES ('" + tbnombre.Text+"', '"+tba_Paterno.Text+"', '"+tba_Materno.Text+"', '"+tbTelefono.Text+ "','" + tx_telemer.Text + "', '" + tbCorreo.Text+"', '"+fecha+"', '"+tx_direccion.Text+"', '"+tbCURP.Text+"', '"+(cb_sangre.SelectedIndex+1)+"', '"+(cb_estadoC.SelectedIndex+1)+ "', '" + (cb_puesto.SelectedIndex + 1) + "', '" + (cb_areaC.SelectedIndex + 1) + "', '" + (cbSexo.SelectedIndex+1)+"');";
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

            if (tba_Paterno.Text == "" || tba_Paterno.Text.Contains("  "))
            {
                errorProvider1.SetError(tba_Paterno, "Ingresa un apellido paterno correcto");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tba_Paterno, null);
            }

            if (tba_Materno.Text == "")
            {
                errorProvider1.SetError(tba_Materno, "Ingresa un apellido materno correcto");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tba_Materno, null);
            }

            if (tbTelefono.Text == "" || tbTelefono.TextLength<7 || tbTelefono.TextLength > 12)
            {
                errorProvider1.SetError(tbTelefono, "Ingresa un telefono correcto. De 7 a 12 diditos");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tbTelefono, null);
            }

            if (tbCURP.Text == "" || tbCURP.TextLength != 18)
            {
                errorProvider1.SetError(tbCURP, "Ingresa un CURP correcto(18 carácteres)");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tbCURP, null);
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


            if (tx_direccion.Text == "" || tx_direccion.TextLength < 6)
            {
                errorProvider1.SetError(tx_direccion, "Ingresa una dirección correcta. Mayor de 15 carácteres");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tx_direccion, null);
            }

            if (tx_telemer.Text == "" || tx_telemer.TextLength < 4)
            {
                errorProvider1.SetError(tx_telemer, "Ingresa una cedula correcta. Mayor de 4 carácteres");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tx_telemer, null);
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
            if (char.IsLetter(e.KeyChar) && tba_Paterno.TextLength < 15 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tba_Materno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && tba_Materno.TextLength < 15 || char.IsControl(e.KeyChar))
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
            if (char.IsDigit(e.KeyChar) && tbTelefono.TextLength < 14 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbCURP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsUpper(e.KeyChar) || char.IsDigit(e.KeyChar)) && tbCURP.TextLength < 19 || char.IsControl(e.KeyChar))
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
            if ((char.IsSymbol(e.KeyChar)|| char.IsLetterOrDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar)) && tbCorreo.TextLength < 30 || char.IsControl(e.KeyChar))
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



        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) && tx_direccion.TextLength < 200 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tx_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && tx_direccion.TextLength < 200 || char.IsControl(e.KeyChar))
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
            if (dtpFecha.Value<DateTime.Now.AddYears(-17))

            fecha = dtpFecha.Value.ToString("yyyy-MM-dd");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cb_puesto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tx_telemer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbSexo_Click(object sender, EventArgs e)
        {

        }

        private void txtCURP_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {

        }

        private void txtA_Materno_Click(object sender, EventArgs e)
        {

        }

        private void txtA_Paterno_Click(object sender, EventArgs e)
        {

        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbCURP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void tba_Materno_TextChanged(object sender, EventArgs e)
        {

        }

        private void tba_Paterno_TextChanged(object sender, EventArgs e)
        {

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
          