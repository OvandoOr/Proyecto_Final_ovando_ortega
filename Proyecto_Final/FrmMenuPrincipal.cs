using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Imaging;
using System.IO;


using MySql.Data.MySqlClient;
using MySql.Data;


namespace Capa_de_Presentacion
{

    public partial class FormMenuPrincipal : Form
    {
        int musica=0;

        public FormMenuPrincipal()
        {
            
            InitializeComponent();
            tipo_usuario();
            admin();
            toolStripComboBox1.SelectedIndex = 0;
            toolStripComboBox2.SelectedIndex = 0;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\MarthaAlicia\Desktop\VS 2013\Muestra fin\Examen_Ov\Clínica La Condesa\musica.wav");
            //sp.PlayLooping();

        }

        public void admin()
        {
            if (Proyecto_Final.Program.Admin == false)
            {
                
                pacientesToolStripMenuItem.Enabled = false;
                inventariosToolStripMenuItem.Enabled = false;
                farmaciaToolStripMenuItem.Enabled = false;
            }
        }

        public void tipo_usuario()
        {
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM final_clinica1.trabajador where idTrabajador='"+ Proyecto_Final.Program.PuestoEmpleadoLogueado + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion()); //Realizamos una selecion de la tabla usuarios.
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read()) 
            {
                Proyecto_Final.Program.PuestoEmpleadoLogueado = Convert.ToString(leer["Descripcion"]);
            }

                txt_usuario.Text = Proyecto_Final.Program.PuestoEmpleadoLogueado + "(a)  "+ Proyecto_Final.Program.NombreEmpleadoLogueado;

            if (Proyecto_Final.Program.PuestoEmpleadoLogueado == "Administrador")
            {
                Proyecto_Final.Program.Admin = true;

                pic_areas.Show();
                pic_citas.Show();
                pic_consulta.Show();
                pic_doctores.Show();
                pic_empleados.Show();
                pic_farmacia.Show();
                pic_historial.Show();
                pic_inven.Show();
                pic_pac.Show();
                pic_pagos.Show();
                pic_proveedores.Show();
                pic_usuarios.Show();

                lb_areas.Show();
                lb_citas.Show();
                lb_consulta.Show();
                lb_doctor.Show();
                lb_empleados.Show();
                lb_farmacia.Show();
                lb_historial.Show();
                lb_inventario.Show();
                lb_pac.Show();
                lb_pago.Show();
                lb_proveedores.Show();
                lb_usuarios.Show();

                areasToolStripMenuItem.Enabled=true;
                citasToolStripMenuItem.Enabled = true;
                consultaToolStripMenuItem.Enabled = true;
                doctoresToolStripMenuItem.Enabled = true;
                empleadosToolStripMenuItem.Enabled = true;
                farmaciaToolStripMenuItem.Enabled = true;
                historialToolStripMenuItem1.Enabled = true;
                inventariosToolStripMenuItem.Enabled = true;
                pacientesToolStripMenuItem.Enabled = true;
                ventasToolStripMenuItem1.Enabled = true;
                proveedoresToolStripMenuItem1.Enabled = true;
                usuariosToolStripMenuItem1.Enabled = true;
                historialVentasToolStripMenuItem.Enabled = true;
            }
            if (Proyecto_Final.Program.PuestoEmpleadoLogueado == "Doctor")
            {
                Proyecto_Final.Program.Admin = false;

                pic_areas.Hide();
                pic_citas.Hide();
                pic_consulta.Show();
                pic_doctores.Hide();
                pic_empleados.Hide();
                pic_farmacia.Hide();
                pic_historial.Show();
                pic_inven.Hide();
                pic_pac.Hide();
                pic_pagos.Hide();
                pic_proveedores.Hide();
                pic_usuarios.Hide();

                lb_areas.Hide();
                lb_citas.Hide();
                lb_consulta.Show();
                lb_doctor.Hide();
                lb_empleados.Hide();
                lb_farmacia.Hide();
                lb_historial.Show();
                lb_inventario.Hide();
                lb_pac.Hide();
                lb_pago.Hide();
                lb_proveedores.Hide();
                lb_usuarios.Hide();

                areasToolStripMenuItem.Enabled = false;
                citasToolStripMenuItem.Enabled = false;
                consultaToolStripMenuItem.Enabled = true;
                doctoresToolStripMenuItem.Enabled = false;
                empleadosToolStripMenuItem.Enabled = false;
                farmaciaToolStripMenuItem.Enabled = false;
                historialToolStripMenuItem1.Enabled = true;
                inventariosToolStripMenuItem.Enabled = false;
                pacientesToolStripMenuItem.Enabled = false;
                ventasToolStripMenuItem1.Enabled = false;
                proveedoresToolStripMenuItem1.Enabled = false;
                usuariosToolStripMenuItem1.Enabled = false;
                historialVentasToolStripMenuItem.Enabled = false;

                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM final_clinica1.doctores where Usuario_idUsuario='" + Proyecto_Final.Program.IdEmpleadoLogueado + "';", Proyecto_Final.BaseDeDatos.ObtenerConexion()); //Realizamos una selecion de la tabla usuarios.
                MySqlDataReader leer1 = cmd1.ExecuteReader();
                if (leer1.Read())
                {
                    Proyecto_Final.Program.IdDoctor = Convert.ToInt32(leer1["idDoctores"]);
                    Proyecto_Final.Program.NombreDoctor = Convert.ToString(leer1["Nombre"]);
                    Proyecto_Final.Program.ApellidoDoctor = Convert.ToString(leer1["A_paterno"]);
                    Proyecto_Final.Program.Especialidad_doctor = Convert.ToString(leer1["id_especialidad"]);


                }

            }
            if (Proyecto_Final.Program.PuestoEmpleadoLogueado == "Farmaceutico")
            {
                Proyecto_Final.Program.Admin = false;

                pic_areas.Hide();
                pic_citas.Hide();
                pic_consulta.Hide();
                pic_doctores.Hide();
                pic_empleados.Hide();
                pic_farmacia.Show();
                pic_historial.Show();
                pic_inven.Hide();
                pic_pac.Hide();
                pic_pagos.Show();
                pic_proveedores.Show();
                pic_usuarios.Hide();

                lb_areas.Hide();
                lb_citas.Hide();
                lb_consulta.Hide();
                lb_doctor.Hide();
                lb_empleados.Hide();
                lb_farmacia.Show();
                lb_historial.Show();
                lb_inventario.Hide();
                lb_pac.Hide();
                lb_pago.Show();
                lb_proveedores.Show();
                lb_usuarios.Hide();

                areasToolStripMenuItem.Enabled = false;
                citasToolStripMenuItem.Enabled = false;
                consultaToolStripMenuItem.Enabled = false;
                doctoresToolStripMenuItem.Enabled = false;
                empleadosToolStripMenuItem.Enabled = false;
                farmaciaToolStripMenuItem.Enabled = true;
                historialToolStripMenuItem1.Enabled = true;
                inventariosToolStripMenuItem.Enabled = false;
                pacientesToolStripMenuItem.Enabled = false;
                ventasToolStripMenuItem1.Enabled = true;
                proveedoresToolStripMenuItem1.Enabled = true;
                usuariosToolStripMenuItem1.Enabled = false;
                historialVentasToolStripMenuItem.Enabled = true;

            }
            if (Proyecto_Final.Program.PuestoEmpleadoLogueado == "Secretario")
            {
                Proyecto_Final.Program.Admin = false;

                pic_areas.Hide();
                pic_citas.Show();
                pic_consulta.Hide();
                pic_doctores.Hide();
                pic_empleados.Hide();
                pic_farmacia.Hide();
                pic_historial.Hide();
                pic_inven.Hide();
                pic_pac.Show();
                pic_pagos.Hide();
                pic_proveedores.Hide();
                pic_usuarios.Hide();

                lb_areas.Hide();
                lb_citas.Show();
                lb_consulta.Hide();
                lb_doctor.Hide();
                lb_empleados.Hide();
                lb_farmacia.Hide();
                lb_historial.Hide();
                lb_inventario.Hide();
                lb_pac.Show();
                lb_pago.Hide();
                lb_proveedores.Hide();
                lb_usuarios.Hide();

                areasToolStripMenuItem.Enabled = false;
                citasToolStripMenuItem.Enabled = true;
                consultaToolStripMenuItem.Enabled = false;
                doctoresToolStripMenuItem.Enabled = false;
                empleadosToolStripMenuItem.Enabled = false;
                farmaciaToolStripMenuItem.Enabled = false;
                historialToolStripMenuItem1.Enabled = false;
                inventariosToolStripMenuItem.Enabled = false;
                pacientesToolStripMenuItem.Enabled = true;
                ventasToolStripMenuItem1.Enabled = false;
                proveedoresToolStripMenuItem1.Enabled = false;
                usuariosToolStripMenuItem1.Enabled = false;
                historialVentasToolStripMenuItem.Enabled = false;

            }
            if (Proyecto_Final.Program.PuestoEmpleadoLogueado == "Jefe mantenimiento")
            {
                Proyecto_Final.Program.Admin = false;

                pic_areas.Show();
                pic_citas.Hide();
                pic_consulta.Hide();
                pic_doctores.Hide();
                pic_empleados.Hide();
                pic_farmacia.Hide();
                pic_historial.Hide();
                pic_inven.Show();
                pic_pac.Hide();
                pic_pagos.Hide();
                pic_proveedores.Hide();
                pic_usuarios.Hide();

                lb_areas.Show();
                lb_citas.Hide();
                lb_consulta.Hide();
                lb_doctor.Hide();
                lb_empleados.Hide();
                lb_farmacia.Hide();
                lb_historial.Hide();
                lb_inventario.Show();
                lb_pac.Hide();
                lb_pago.Hide();
                lb_proveedores.Hide();
                lb_usuarios.Hide();

                areasToolStripMenuItem.Enabled = true;
                citasToolStripMenuItem.Enabled = false;
                consultaToolStripMenuItem.Enabled = false;
                doctoresToolStripMenuItem.Enabled = false;
                empleadosToolStripMenuItem.Enabled = false;
                farmaciaToolStripMenuItem.Enabled = false;
                historialToolStripMenuItem1.Enabled = false;
                inventariosToolStripMenuItem.Enabled = true;
                pacientesToolStripMenuItem.Enabled = false;
                ventasToolStripMenuItem1.Enabled = false;
                proveedoresToolStripMenuItem1.Enabled = false;
                usuariosToolStripMenuItem1.Enabled = false;
                historialVentasToolStripMenuItem.Enabled = false;

            }
            if (Proyecto_Final.Program.PuestoEmpleadoLogueado == "Enfermero(a)")
            {
                Proyecto_Final.Program.Admin = false;

                pic_areas.Hide();
                pic_citas.Hide();
                pic_consulta.Hide();
                pic_doctores.Hide();
                pic_empleados.Hide();
                pic_farmacia.Hide();
                pic_historial.Show();
                pic_inven.Hide();
                pic_pac.Hide();
                pic_pagos.Hide();
                pic_proveedores.Hide();
                pic_usuarios.Hide();

                lb_areas.Hide();
                lb_citas.Hide();
                lb_consulta.Hide();
                lb_doctor.Hide();
                lb_empleados.Hide();
                lb_farmacia.Hide();
                lb_historial.Show();
                lb_inventario.Hide();
                lb_pac.Hide();
                lb_pago.Hide();
                lb_proveedores.Hide();
                lb_usuarios.Hide();

                areasToolStripMenuItem.Enabled = false;
                citasToolStripMenuItem.Enabled = false;
                consultaToolStripMenuItem.Enabled = false;
                doctoresToolStripMenuItem.Enabled = false;
                empleadosToolStripMenuItem.Enabled = false;
                farmaciaToolStripMenuItem.Enabled = false;
                historialToolStripMenuItem1.Enabled = true;
                inventariosToolStripMenuItem.Enabled = false;
                pacientesToolStripMenuItem.Enabled = false;
                ventasToolStripMenuItem1.Enabled = false;
                proveedoresToolStripMenuItem1.Enabled = false;
                usuariosToolStripMenuItem1.Enabled = false;
                historialVentasToolStripMenuItem.Enabled = false;

                txt_usuario.Text = Proyecto_Final.Program.PuestoEmpleadoLogueado;

            }
        }

        private void FrmMenuPrincipal_Activated(object sender, EventArgs e)
        {
            
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Interval = 500;
            timer1.Start();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Empleado.Mobiliario P = new Empleado.Mobiliario();
            P.ShowDialog();
        }

        private void butt_doc_Click(object sender, EventArgs e)
        {
            Empleado.Paciente C = new Empleado.Paciente();
            C.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            clinica.cita C = new clinica.cita();
            C.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Empleado.Áreas V = new Empleado.Áreas();
            V.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Empleado.Usuarios U = new Empleado.Usuarios();
            U.ShowDialog();
        }

        private void butt_pacientes_Click(object sender, EventArgs e)
        {
            Empleado.Paciente U = new Empleado.Paciente();
            U.ShowDialog();
        }

        private void butt_farmacia_Click(object sender, EventArgs e)
        {
            Empleado.Farmacia U = new Empleado.Farmacia();
            U.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
               CapturarFechaSistema(); 
            
        }

        private void CapturarFechaSistema() {
            txt_fecha.Text = DateTime.Now.ToShortDateString();
            txt_hora.Text = DateTime.Now.ToShortTimeString();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleado.Empleado E = new Empleado.Empleado();
            E.ShowDialog();
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clinica.consulta E = new clinica.consulta();
            E.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            HistorialVentas E = new HistorialVentas();
            E.ShowDialog();
        }

        private void butt_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado.Paciente P = new Empleado.Paciente();
            P.ShowDialog();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado.Paciente E = new Empleado.Paciente();
            E.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado.Paciente C = new Empleado.Paciente();
            C.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistroVentas V = new FrmRegistroVentas();
            V.ShowDialog();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialVentas E = new HistorialVentas();
            E.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado.inventario U = new Empleado.inventario();
            U.ShowDialog();
        }

                //this.BackColor = System.Drawing.Color.White;
                //button1.BackColor= System.Drawing.Color.Turquoise;
                //button1.ForeColor = System.Drawing.Color.White;


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Empleado.Mobiliario U = new Empleado.Mobiliario();
            U.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            Empleado.Paciente U = new Empleado.Paciente();
            U.ShowDialog();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            clinica.cita U = new clinica.cita();
            U.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Elegir_consulta U = new Elegir_consulta();
            U.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Empleado.Doctor U = new Empleado.Doctor();
            U.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Empleado.Farmacia U = new Empleado.Farmacia();
            U.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Empleado.Áreas U = new Empleado.Áreas();
            U.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FrmRegistroVentas U = new FrmRegistroVentas();
            U.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Empleado.Proveedores U = new Empleado.Proveedores();
            U.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            clinica.historial U = new clinica.historial();
            U.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Empleado.Empleado U = new Empleado.Empleado();
            U.ShowDialog();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Empleado.Usuarios U = new Empleado.Usuarios();
            U.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmLogin U = new FrmLogin();
            U.Show();
            this.Hide();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado.Paciente U = new Empleado.Paciente();
            U.ShowDialog();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clinica.cita U = new clinica.cita();
            U.ShowDialog();
        }

        private void inventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado.Mobiliario U = new Empleado.Mobiliario();
            U.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clinica.consulta U = new clinica.consulta();
            U.ShowDialog();
        }

        private void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado.Doctor U = new Empleado.Doctor();
            U.ShowDialog();
        }

        private void farmaciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado.Farmacia U = new Empleado.Farmacia();
            U.ShowDialog();
        }

        private void areasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado.Áreas U = new Empleado.Áreas();
            U.ShowDialog();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Capa_de_Presentacion.FrmRegistroVentas U = new Capa_de_Presentacion.FrmRegistroVentas();
            U.ShowDialog();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Empleado.Proveedores U = new Empleado.Proveedores();
            U.ShowDialog();
        }

        private void historialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            clinica.historial U = new clinica.historial();
            U.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado.Empleado U = new Empleado.Empleado();
            U.ShowDialog();
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Empleado.Usuarios U = new Empleado.Usuarios();
            U.ShowDialog();
        }

        private void historialVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialVentas U = new HistorialVentas();
            U.ShowDialog();
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            musica = toolStripComboBox2.SelectedIndex;
            if (musica == 0)
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\MarthaAlicia\Desktop\VS 2013\Muestra fin\Examen_Ov\Clínica La Condesa\musica.wav");
                //sp.PlayLooping();
            }

            if (musica == 1)
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\MarthaAlicia\Desktop\VS 2013\Muestra fin\Examen_Ov\Clínica La Condesa\musica2.wav");
                //sp.PlayLooping();
            }

            if (musica == 2)
            {
                System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\MarthaAlicia\Desktop\VS 2013\Muestra fin\Examen_Ov\Clínica La Condesa\musica.wav");
                //sp.Stop();
            }
        }
    }
}
