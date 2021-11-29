using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static int Evento;

        //Datos del doctor
        public static int IdDoctor;
        public static String NombreDoctor;
        public static String ApellidoDoctor;
        public static String Especialidad_doctor;


        //datos consultorio
        public static int idconsultorio;
        public static String NombreConsultorio;


        //Datos del Cliente
        public static int IdCliente;
        public static int Cantidad_compras;
        public static String NombreCliente;
        public static int adeudocliente;
        public static String Tipo_De_Cliente;
        public static String ApellidoCliente;
        public static String antecedentesH;
        public static String antecedentesP;

        //Datos del Producto
        public static Int32 i;
        public static Int32[] IdProducto = new int[10];
        public static Int32[] totalxproducto = new int[10];
        public static Int32[] cantidadstock = new int[10];
        public static Int32 IdProductoUnico;
        public static Int32 IdProveedor;
        public static Int32 IdVenta;
        public static String Descripcion;
        public static String Marca;
        public static Int32 Stock;
        public static Int32[] cantidad = new int[10];
        public static Decimal PrecioVenta;
        public static Decimal SumaSubTotal;
        public static Int32 Idtelcel;
        public static Int32 preciosaldo;
        public static String product_ant = "nada";


        //Datos del Empleado
        public static int IdCargo;
        public static int IdEmpleado;

        //Variables de Sesion
        public static int IdEmpleadoLogueado;
        public static bool Admin = false;
        public static String NombreEmpleadoLogueado;
        public static String PuestoEmpleadoLogueado;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Capa_de_Presentacion.FrmLogin());

           // Application.Run(new Tipo_de_sesion());
        }
    }
}
