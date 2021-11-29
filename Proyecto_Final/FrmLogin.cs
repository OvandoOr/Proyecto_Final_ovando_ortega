using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using MySql.Data.MySqlClient;
using MySql.Data;

namespace Capa_de_Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            obtener_idventa();
           
        }

        //MySqlConnection conection = new MySqlConnection("server=localhost;database=bmd_practica;Uid=root;pwd=2015030063");


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está Seguro que Desea Salir.?", "Clínica La Condesa", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) {
                Application.Exit();
            }
               
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            if (txtUser.Text.Trim() != "")
            {
                if (txtPassword.Text.Trim() != "")
                {

                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.usuario WHERE Nombre='" + txtUser.Text + "'AND Contraseña='" + txtPassword.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion()); //Realizamos una selecion de la tabla usuarios.
                    MySqlDataReader leer = cmd.ExecuteReader();
                    if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                    {

                        

                        Proyecto_Final.Program.PuestoEmpleadoLogueado = Convert.ToString(leer["id_trabajador"]);
                        Proyecto_Final.Program.IdEmpleadoLogueado = Convert.ToInt32(leer["idUsuario"]);
                        Proyecto_Final.Program.NombreEmpleadoLogueado = txtUser.Text;
                        MessageBox.Show("Bienvenido "+ Proyecto_Final.Program.NombreEmpleadoLogueado, "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        

                        
                        
                        Proyecto_Final.Tipo_de_sesion MP = new Proyecto_Final.Tipo_de_sesion();
                        
                        
                        MP.Show();
                        this.Hide();
                    }


                    else
                    {
                        MessageBox.Show("Usuario o contraseña Incorrecta", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Por Favor Ingrese su Contraseña.", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
            }

            else
            {
                MessageBox.Show("Por Favor Ingrese Nombre de Usuario.", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
            } 
                }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            


            System.Threading.Thread.Sleep(5000);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            

        }

        private void obtener_idventa()
        {
            string Query = "SELECT idVentas FROM kioxxo.ventas order by idVentas DESC  LIMIT 0, 1 ;";
            try
            {
                MySqlCommand mycomand = new MySqlCommand(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                MySqlDataReader myreader = mycomand.ExecuteReader();
                myreader.Read();

                if (myreader.Read())
                {
                    Proyecto_Final.Program.IdVenta = Convert.ToInt32(myreader["idVentas"]);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar)&& txtUser.TextLength < 20 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar)&& txtPassword.TextLength < 20 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void butt_olvContra_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.usuario WHERE Nombre='" + txtUser.Text + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion()); //Realizamos una selecion de la tabla usuarios.
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
            {
                Proyecto_Final.Program.NombreEmpleadoLogueado = txtUser.Text;
                Proyecto_Final.FrmOlvContra Ol = new Proyecto_Final.FrmOlvContra();
                Ol.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por Favor Ingrese Nombre de Usuario Existente.", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
 }
    
