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

namespace Proyecto_Final
{
    public partial class Restaurar_contraseña : Form
    {
        public Restaurar_contraseña()
        {
            InitializeComponent();
            nombre();
        }

        private void nombre()
        {
            lbl_nombre.Text = Program.NombreEmpleadoLogueado;
        }

        private void butt_acep_Click(object sender, EventArgs e)
        {
            if (tx_contra.TextLength < 4)
            {
                MessageBox.Show("No se permiten contraseñas menores a 3 caracteres.", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (tx_contra.Text == tx_contra1.Text)
                {
                    string Query = "UPDATE `final_clinica1`.`usuario` SET `Contraseña`='" + tx_contra.Text + "' WHERE `Nombre`='" + Program.NombreEmpleadoLogueado + "';";
                    try
                    {
                        MySqlCommand cmdDataBase = new MySqlCommand(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                        MySqlDataReader myReader;
                        myReader = cmdDataBase.ExecuteReader();
                        MessageBox.Show("Se cambio la contraseña con exito");
                        this.Close();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void butt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
