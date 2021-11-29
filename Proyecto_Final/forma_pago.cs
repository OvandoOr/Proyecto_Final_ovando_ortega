using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Capa_de_Presentacion
{
    public partial class Forma_pago : Form
    {
        string fecha,tiempo,fechaF;
        int recibo_id;
        public Forma_pago()
        {
            InitializeComponent();
            fechadehoy();
            
            generar_id_venta();
            generar_id_recibo();
            noregistado();
            button1.Enabled = false;
            button3.Enabled = false;

        }

        MySqlConnection conection = new MySqlConnection("server=localhost;database=bmd_practica;Uid=root;pwd=2015030063");
        private void noregistado()
        {
            comboBox1.SelectedIndex = 0;
            if(Proyecto_Final.Program.NombreCliente=="No registrado")
            {
                comboBox1.Enabled=false;
            }
        }


        private void generar_id_venta()
        {

            conection.Open(); 

            MySqlCommand cmd = new MySqlCommand("SELECT idVentas FROM final_clinica1.ventas order by idVentas DESC  LIMIT 0, 1 ;", conection); //Realizamos una selecion de la tabla usuarios.
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read()) 
            {
                Proyecto_Final.Program.IdVenta = Convert.ToInt32(leer["idVentas"])+1;
                conection.Close();
            }
            else
            {
                conection.Close();

            }
        }

        private void generar_id_recibo()
        {

            conection.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT numero_recibo FROM final_clinica1.ventas order by numero_recibo DESC  LIMIT 0, 1 ;", conection); //Realizamos una selecion de la tabla usuarios.
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                recibo_id = Convert.ToInt32(leer["numero_recibo"]) + 1;
                conection.Close();
            }
            else
            {
                conection.Close();

            }
        }


        private void fechadehoy()
        {
            fecha = DateTime.Now.ToString("yyyy-MM-dd");
            tiempo = DateTime.Now.ToString("HH:mm:ss");
            fecha = fecha +" "+tiempo;

            

           fechaF = fecha.TrimEnd('p','a', ' ', 'm','.' );

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Proyecto_Final.Program.i; i++)                                                                               
            {
                if (Proyecto_Final.Program.IdProducto[i] != -1)
                {
                                                                                                                                                                                                            //Tipo_de_pago, Cantidad, Total, Cliente_idCliente, Empleado_idEmpleado, Productos_idProductos, Fecha_Compra
                    string Query = "insert into final_clinica1.ventas(idVentas,numero_recibo,Tipo_de_pago, Cantidad, Total, Cliente_idCliente, Empleado_idEmpleado, Productos_idProductos, Fecha_Compra) values('" + Proyecto_Final.Program.IdVenta + "','" + recibo_id + "','" + comboBox1.Text + "','" + Proyecto_Final.Program.cantidad[i] + "','" + Proyecto_Final.Program.totalxproducto[i] + "','" + Proyecto_Final.Program.IdCliente + "','" + Proyecto_Final.Program.IdEmpleadoLogueado + "'," + Proyecto_Final.Program.IdProducto[i] + ",'" + fechaF + "');";
                    try
                    {
                        MySqlCommand cmdDataBase = new MySqlCommand(Query, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                        MySqlDataReader myReader;
                        myReader = cmdDataBase.ExecuteReader();
                        Proyecto_Final.Program.IdVenta++;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    int cantidadres = Proyecto_Final.Program.cantidadstock[i] - Proyecto_Final.Program.cantidad[i];
                    string Query1 = "UPDATE `final_clinica1`.`farmacia` SET `Stock`= '" + cantidadres+ "' WHERE `idFarmacia`= '" + Proyecto_Final.Program.IdProducto[i] + "';";
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(Query1, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                        MySqlDataReader Reader;
                        Reader = cmd.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
             }
            if(comboBox1.SelectedIndex==2)
            {
                Proyecto_Final.Program.adeudocliente = Proyecto_Final.Program.adeudocliente + Convert.ToInt32(Proyecto_Final.Program.SumaSubTotal);
            }
            Proyecto_Final.Program.Cantidad_compras++;

            string Query2 = "UPDATE `kioxxo`.`cliente` SET `Cantidad_compras`= '"+ Proyecto_Final.Program.Cantidad_compras+ "', `Adeudo`= '"+ Proyecto_Final.Program.adeudocliente+"' WHERE `idCliente`= '" + Proyecto_Final.Program.IdCliente + "';";
            try
            {
                MySqlCommand cmd1 = new MySqlCommand(Query2, Proyecto_Final.BaseDeDatos.ObtenerConexion());
                MySqlDataReader Reader1;
                Reader1 = cmd1.ExecuteReader();
                MessageBox.Show("Se registraron los datos con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            generar_pdf();

            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            generar_pdf();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button3.Enabled = true;
        }

        private void generar_pdf()
        {

            //"insert into kioxxo.ventas(, Cantidad, Total, Cliente_idCliente, Empleado_idEmpleado, Productos_idProductos, Fecha_Compra) 
            //values "','" + Program.cantidad[i] + "','" + Program.totalxproducto[i] + "','" + Program.IdCliente + "','" + Program.IdEmpleadoLogueado + "'," + Program.IdProducto[i] + ",'" + fechaF + "');";
            int x = 25;
            int total = 0;
            PdfDocument recibo = new PdfDocument();
            recibo.Info.Title = "Recibo de compra numero "+ recibo_id ;
            PdfPage pdfpage1 = recibo.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfpage1);
            XFont letra = new XFont("Verdana", 20, XFontStyle.Bold);
            XFont letra1 = new XFont("Verdana", 14, XFontStyle.Regular);
            graph.DrawString("Recibo de compra numero " + Proyecto_Final.Program.IdVenta, letra, XBrushes.Black, new XRect(0, 0, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormats.TopCenter);
            graph.DrawString("Tipo de pago:" + comboBox1.Text, letra1, XBrushes.Black, new XRect(0, x, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormats.TopCenter);
            x = x + x;
            graph.DrawString("Clínica La Condesa", letra1, XBrushes.Black, new XRect(0, x, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormats.TopCenter);
            x=x+50;
            for (int i = 0; i < Proyecto_Final.Program.i; i++)
            {
                if (Proyecto_Final.Program.IdProducto[i] != -1)
                {

                    graph.DrawString("Producto ID:   " + nombre_producto(Proyecto_Final.Program.IdProducto[i]) + "      cantidad:   " + Proyecto_Final.Program.cantidad[i] + "------------------$" + Proyecto_Final.Program.totalxproducto[i], letra1, XBrushes.Black, new XRect(0, x, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormats.TopCenter);
                    x = x + 25;
                    total = total + Proyecto_Final.Program.totalxproducto[i];
                }
            }
            x = x + 25;
            graph.DrawString("Total:   $" + total, letra1, XBrushes.Black, new XRect(30, x, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormats.TopCenter);
            x = x + 50;
            graph.DrawString("Cliente ID: " + Proyecto_Final.Program.NombreCliente +"  "+ Proyecto_Final.Program.ApellidoCliente, letra1, XBrushes.Black, new XRect(0, x, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormats.TopCenter);
            x = x + 25;
            graph.DrawString("IDEmpleado: " + Proyecto_Final.Program.IdEmpleadoLogueado +"         Empleado: "+ Proyecto_Final.Program.NombreEmpleadoLogueado, letra1, XBrushes.Black, new XRect(0, x, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormats.TopCenter);
            x = x + 50;
            graph.DrawString("Fecha: " + fechaF, letra1, XBrushes.Black, new XRect(0, x, pdfpage1.Width.Point, pdfpage1.Height.Point), XStringFormats.TopCenter);

            recibo.Save("Recibo" + Proyecto_Final.Program.IdVenta);
            Process.Start("Recibo" + Proyecto_Final.Program.IdVenta);
        }

        public string nombre_producto(int i)
        {
            conection.Open();
            string producto="";
            MySqlCommand cmd = new MySqlCommand("SELECT nombre FROM kioxxo.productos where idProductos='"+i+"';", conection); //Realizamos una selecion de la tabla usuarios.
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())
            {
                producto = Convert.ToString(leer["nombre"]);
                conection.Close();
            }
            else
            {
                conection.Close();

            }
            return producto;
        }
   
    }
}
