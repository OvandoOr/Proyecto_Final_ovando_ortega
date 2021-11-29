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
    public partial class FrmOlvContra : Form
    {
        int idpregunta=1;
        public FrmOlvContra()
        {
            InitializeComponent();
            pregunta_combobox();
        }

        public void pregunta_combobox()
        {
            string Query = "SELECT * FROM final_clinica1.pregunta;";

            try
            {

                MySqlDataAdapter sda = new MySqlDataAdapter(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                DataTable ds = new DataTable();
                sda.Fill(ds);

                comboBox1.DisplayMember = "Pregunta";
                comboBox1.ValueMember = "idPregunta";
                comboBox1.DataSource = ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void butt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butt_ingre_Click(object sender, EventArgs e)
        {
            if (tx_respuesta.Text.Trim() != "")
            {

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.usuario WHERE Nombre='" + Program.NombreEmpleadoLogueado + "'AND Respuesta_pregunta='" + tx_respuesta.Text + "'AND Pregunta_idPregunta='" + idpregunta +"';", Proyecto_Final.BaseDeDatos.ObtenerConexion()); //Realizamos una selecion de la tabla usuarios.
                MySqlDataReader leer = cmd.ExecuteReader();
                if (leer.Read()) //Si el usuario es correcto nos abrira la otra ventana.
                {
                    

                    Restaurar_contraseña MP = new Restaurar_contraseña();


                    MP.ShowDialog();
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
                tx_respuesta.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            idpregunta = comboBox1.SelectedIndex;
        }
    }
 }

