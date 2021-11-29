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

namespace Empleado
{
    public partial class inventario : Form
    {
        string fecha, id;
        int posicion, id_fin;

        public inventario()
        {
            InitializeComponent();
            cargar_tabla();
            proveedor_combobox();
            gen_fin_id();
            admin();
            limpiar();
            fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

        }

        public void admin()
        {
            if(Proyecto_Final.Program.Admin == false)
            {
                button1.Dispose();
                button3.Dispose();
                btngua.Dispose();
                this.Height = 366;
            }

        }

        public bool repetir()
        {
            bool repetir = false;
            
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM Clínica La Condesa.productos where Nombre='" + tbnombre.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
                MySqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read())
                {
                    repetir = true;
                }
            
            return repetir;
        }


        public void radiobuton1()
        {
            string Query = "SELECT * FROM Clínica La Condesa.productos where Nombre like '" + textBox1.Text + "%';";

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

            string Query = "SELECT * FROM Clínica La Condesa.productos where Marca like '" + textBox1.Text + "%';";
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

            string Query = "SELECT * FROM Clínica La Condesa.productos where idProductos like '" + textBox1.Text + "%';";

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

        public void limpiar()
        {
            tbnombre.Clear();
            tbcantidad.Clear();
            tbmarca.Clear();
            tbPrecio.Clear();
            textBox1.Clear();
            cbprov.ResetText();
            button1.Enabled = false;
            button3.Enabled = false;
            btngua.Enabled = true;
            textBox1.Enabled = true;
            errorProvider1.Clear();

        }

        private void gen_fin_id()
        {
            MySqlConnection conection = new MySqlConnection("server=localhost;database=bmd_practica;Uid=root;pwd=2015030063");

            conection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT idProductos FROM Clínica La Condesa.productos order by idProductos DESC  LIMIT 0, 1 ;", conection);
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                id_fin = Convert.ToInt32(leer["idProductos"]);

                conection.Close();
            }
            else
            {
                conection.Close();

            }
        }

        private void cargar_tabla()
        {
            string Query = "SELECT * FROM Clínica La Condesa.productos;";

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



        int proveedor;

        public void proveedor_combobox()
        {
            string Query = "SELECT * FROM Clínica La Condesa.proveedor;";

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);

                cbprov.DisplayMember = "nombre";
                cbprov.ValueMember = "idProveedor";
                cbprov.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        public void btngua_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (validacion())
            {
                if (!repetir())
                {
                    id_fin++;
                    string Query = "insert into Clínica La Condesa.productos(idProductos,Nombre,Marca,Cantidad,Precio,Proveedor_idProveedor,Fecha_ingreso) values('" + id_fin + "','" + tbnombre.Text + "','" + tbmarca.Text + "','" + tbcantidad.Text + "','" + tbPrecio.Text + "'," + (proveedor + 1) + ",'" + fecha + "');";
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
                cargar_tabla();
                gen_fin_id();
                limpiar();
            }
            else
            {
                MessageBox.Show("ERROR: Favor de ingresar datos correctos", "Clínica La Condesa");
            }
         }

        

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
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
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string Query = "DELETE FROM Clínica La Condesa.productos where idProductos='" + id + "';";

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
            limpiar();
            cargar_tabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public bool repetir1()
        {
            bool repetir = false;
            int repet = 0;

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM Clínica La Condesa.productos where Nombre='" + tbnombre.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion());
            MySqlDataReader leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                repet++;
            }
            if (repet>=2)
            {
                repetir = true;
            }

            return repetir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbnombre.Text != "Telcel")
            {
                errorProvider1.Clear();

                if (validacion())
                {
                    if (!repetir1())
                    {

                        string Query = " UPDATE `Clínica La Condesa`.`productos` SET `Nombre`='" + tbnombre.Text + "', `Marca`='" + tbmarca.Text + "', `Cantidad`='" + tbcantidad.Text + "', `Precio`='" + tbPrecio.Text + "', `Proveedor_idProveedor`=" + (proveedor + 1) + ", `Fecha_ingreso`='" + fecha + "' WHERE `idProductos`='" + id + "';";
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
            else
            {
                MessageBox.Show("ERROR: No puedes modificar los valores del saldo. Contacta a un accesor Telcel", "Clínica La Condesa");
            }
        }

        private void cbprov_SelectedIndexChanged(object sender, EventArgs e)
        {
            proveedor = cbprov.SelectedIndex;
        }

        private void dtpFecha_ValueChanged_1(object sender, EventArgs e)
        {
            fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

        }

        private void tbnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && tbnombre.TextLength == 0)
            {
                e.Handled = true;
            }
            else
            {
                if ((char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) && tbnombre.TextLength < 20 || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tbmarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) && tbmarca.TextLength == 0)
            {
                e.Handled = true;
            }
            else
            {
                if ((char.IsLetterOrDigit(e.KeyChar) || char.IsWhiteSpace(e.KeyChar)) && tbmarca.TextLength < 20 || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void tbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && tbPrecio.TextLength < 7 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) && tbcantidad.TextLength < 5 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cbprov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) && textBox1.TextLength < 20 || char.IsControl(e.KeyChar))
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
            if (char.IsLetterOrDigit(e.KeyChar) && textBox1.TextLength < 20 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void but_res_Click(object sender, EventArgs e)
        {
            if (tbcantidad.Text != "")
            {
                int cant = Convert.ToInt32(tbcantidad.Text);
                if (cant > 0)
                {
                    cant--;

                }
                tbcantidad.Text = Convert.ToString(cant);
            }
            else
            {
                tbcantidad.Text = "0";
            }
        }

        private void but_sum_Click(object sender, EventArgs e)
        {
            if (tbcantidad.Text!="")
            {
                int cant = Convert.ToInt32(tbcantidad.Text);
                if (cant < 999)
                {
                    cant++;

                }
                tbcantidad.Text = Convert.ToString(cant);
            }
            else
            {
                tbcantidad.Text = "0";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            posicion = dataGridView1.CurrentCell.RowIndex;
            errorProvider1.Clear();
            // esto es para que te diga en que posición esta la columna seleccionada
            id = Convert.ToString(dataGridView1[0, posicion].Value); 
            tbnombre.Text = Convert.ToString(dataGridView1[1, posicion].Value);
            tbmarca.Text = Convert.ToString(dataGridView1[2, posicion].Value);
            tbcantidad.Text = Convert.ToString(dataGridView1[3, posicion].Value);
            tbPrecio.Text = Convert.ToString(dataGridView1[4, posicion].Value);
            cbprov.SelectedIndex = (Convert.ToInt32(dataGridView1[5, posicion].Value) - 1);

            button1.Enabled = true;
            button3.Enabled = true;
            btngua.Enabled = false;
            textBox1.Enabled = false;
        }

        public bool validacion()
        {
            bool validar = true;
            if(tbnombre.Text=="" || tbnombre.Text.Contains("  "))
            {
                errorProvider1.SetError(tbnombre, "Ingresa un nombre correcto del producto. No se permite doble espaciado");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tbnombre,null);
            }

            if (tbmarca.Text == "" || tbmarca.Text.Contains("  "))
            {
                errorProvider1.SetError(tbmarca, "Ingresa un nombre correcto para la marca. No se permite doble espaciado");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tbmarca, null);
            }

            if (tbPrecio.Text == "")
            {
                errorProvider1.SetError(tbPrecio, "Ingresa un precio correcto");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tbPrecio, null);
            }

            if (tbcantidad.Text == "")
            {
                errorProvider1.SetError(tbcantidad, "Ingresa una cantidad de productos correcta");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(tbcantidad, null);
            }
            

            if (cbprov.Text == "")
            {
                errorProvider1.SetError(cbprov, "Ingresa un nombre de proveedor existente");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(cbprov, null);
            }

            if (dtpFecha.Value > DateTime.Now)
            {
                errorProvider1.SetError(dtpFecha, "Ingresa una fecha correcta");
                validar = false;
            }
            else
            {
                errorProvider1.SetError(dtpFecha, null);
            }

            return validar;
        }

    }
}
