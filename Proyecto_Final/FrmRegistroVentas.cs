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


namespace Capa_de_Presentacion
{
    public partial class FrmRegistroVentas : Form
    {
       
       int celula = 3,celula_ant;
        int cant_ant = 0;

        private List<clsVenta> lst = new List<clsVenta>();


        public FrmRegistroVentas()
        {
            InitializeComponent();
            btnRegistrarVenta.Enabled = false;
            txtDocIdentidad.ResetText();
            txtDatos.ResetText();
            Limpiar();
            Proyecto_Final.Program.i = 0;
            Proyecto_Final.Program.Tipo_De_Cliente="";
            Proyecto_Final.Program.ApellidoCliente = ""; 
            Proyecto_Final.Program.NombreCliente = "";
            Proyecto_Final.Program.IdProductoUnico = 0;
            Proyecto_Final.Program.Descripcion = "";
            Proyecto_Final.Program.Marca = "";
            Proyecto_Final.Program.Stock = 0;
            Proyecto_Final.Program.PrecioVenta =0;
        }

      

      

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }



        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Elegir_Cliente C = new Elegir_Cliente();
            C.ShowDialog();
        }

        private void llenar_textbox()
        {
            txtDocIdentidad.Text = Proyecto_Final.Program.Tipo_De_Cliente;
            txtDatos.Text = Proyecto_Final.Program.ApellidoCliente + ", " + Proyecto_Final.Program.NombreCliente;
            txtidprod.Text = Proyecto_Final.Program.IdProductoUnico + "";
            txtDescripcion.Text = Proyecto_Final.Program.Descripcion;
            txtMarca.Text = Proyecto_Final.Program.Marca;
            txtStock.Text = Proyecto_Final.Program.Stock + "";
            txtPVenta.Text = Proyecto_Final.Program.PrecioVenta + "";
        }

        private void FrmVentas_Activated(object sender, EventArgs e)
        {
            llenar_textbox();
        }

        private void btnBusquedaProducto_Click(object sender, EventArgs e)
        {

            Elegir_Producto C =new Elegir_Producto();
            C.ShowDialog();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsVenta V = new clsVenta();
            Decimal Porcentaje = 0; Decimal SubTotal;
           

            if (Proyecto_Final.Program.i > 9)
            {
                MessageBox.Show("Limite de transacciones", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
            else
            {
                    if (this.txtDocIdentidad.Text.Trim() != "")
                    {
                        if (txtDescripcion.Text.Trim() != "")
                        {
                            if (txtCantidad.Text.Trim() != "")
                            {
                                if (Convert.ToInt32(txtCantidad.Text) >= 0)
                                {
                                    if (Convert.ToInt32(txtCantidad.Text) <= Convert.ToInt32(txtStock.Text))
                                    {
                                        if (txtIgv.Text.Trim() != "")
                                        {
                                            if (Proyecto_Final.Program.product_ant == txtidprod.Text)
                                            {
                                                dataGridView1.Rows.RemoveAt(celula_ant);
                                                Proyecto_Final.Program.IdProducto[celula_ant] = Convert.ToInt32("-1");
                                                Proyecto_Final.Program.cantidad[celula_ant] = Convert.ToInt32("-1");
                                                lst.RemoveAt(celula_ant);

                                                //MessageBox.Show("Ya ingreso este producto", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else
                                            {
                                                cant_ant = 0;
                                            }
                                            V.IdProducto = Convert.ToInt32(txtidprod.Text);
                                            V.Descripcion = txtDescripcion.Text + " - " + txtMarca.Text;
                                            V.Cantidad = Convert.ToInt32(txtCantidad.Text)+cant_ant;
                                            cant_ant = V.Cantidad;
                                            V.PrecioVenta = Convert.ToDecimal(txtPVenta.Text);
                                            Porcentaje = (Convert.ToDecimal(txtIgv.Text) / 100) + 1;
                                            SubTotal = ((Convert.ToDecimal(txtPVenta.Text) * V.Cantidad) / Porcentaje);
                                            V.Igv = Math.Round(Convert.ToDecimal(SubTotal) * (Convert.ToDecimal(txtIgv.Text) / (100)), 2);
                                            V.SubTotal = Math.Round(SubTotal, 2);
                                            btnRegistrarVenta.Enabled = true;


                                            Proyecto_Final.Program.IdProducto[Proyecto_Final.Program.i] = Convert.ToInt32(txtidprod.Text);
                                            Proyecto_Final.Program.totalxproducto[Proyecto_Final.Program.i] = (V.Cantidad) * (Convert.ToInt32(txtPVenta.Text));
                                            Proyecto_Final.Program.cantidad[Proyecto_Final.Program.i] = V.Cantidad;
                                            Proyecto_Final.Program.cantidadstock[Proyecto_Final.Program.i] = Convert.ToInt32(txtStock.Text);
                                            Proyecto_Final.Program.i++;
                                            Proyecto_Final.Program.product_ant = txtidprod.Text;
                                            lst.Add(V);
                                            LlenarGrilla();
                                            Limpiar();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Por Favor Ingrese IVA", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            txtIgv.Focus();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Stock Insuficiente para Realizar la Venta.", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Cantidad Ingresada no Válida.", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                    txtCantidad.Clear();
                                    txtCantidad.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Por Favor Ingrese Cantidad a Vender.", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                txtCantidad.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por Favor Busque el Producto a Vender.", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por Favor Busque el Cliente a Vender.", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    }
                }
            }
        

        private void LlenarGrilla() {
            Decimal SumaSubTotal = 0; Decimal SumaIgv=0; Decimal SumaTotal=0;
            dataGridView1.Rows.Clear();
            for (int i = 0; i < lst.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = lst[i].IdVenta;
                dataGridView1.Rows[i].Cells[1].Value = lst[i].Cantidad;
                dataGridView1.Rows[i].Cells[2].Value = lst[i].Descripcion;
                dataGridView1.Rows[i].Cells[3].Value = lst[i].PrecioVenta;
                dataGridView1.Rows[i].Cells[4].Value = lst[i].SubTotal;
                dataGridView1.Rows[i].Cells[5].Value = lst[i].IdProducto;
                dataGridView1.Rows[i].Cells[6].Value = lst[i].Igv;
                SumaSubTotal += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                SumaIgv += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                celula_ant = i;
            }

            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1.Rows[lst.Count + 1].Cells[3].Value = "SUB-TOTAL  .";
            dataGridView1.Rows[lst.Count + 1].Cells[4].Value = SumaSubTotal;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[lst.Count + 2].Cells[3].Value = "      IVA           %";
            dataGridView1.Rows[lst.Count + 2].Cells[4].Value = SumaIgv;
            dataGridView1.Rows.Add();
            decimal descuento, sumadescuento=0;
            
            if (Proyecto_Final.Program.Cantidad_compras == 10)
            {
                descuento = 10;
                dataGridView1.Rows[lst.Count + celula].Cells[3].Value = "   DESC    10 %";
                sumadescuento=(SumaSubTotal + SumaIgv) / descuento;
                dataGridView1.Rows[lst.Count + celula].Cells[4].Value = sumadescuento;
                dataGridView1.Rows.Add();
                celula++;
            }

            if (Proyecto_Final.Program.Cantidad_compras == 20)
            {
                descuento = 5;
                dataGridView1.Rows[lst.Count + celula].Cells[3].Value = "     DESC    20 %";
                sumadescuento= (SumaSubTotal + SumaIgv) / descuento;
                dataGridView1.Rows[lst.Count + celula].Cells[4].Value = sumadescuento;
                dataGridView1.Rows.Add();
                celula++;
            }

            if (Proyecto_Final.Program.Cantidad_compras == 30)
            {
                descuento = 3;
                dataGridView1.Rows[lst.Count + celula].Cells[3].Value = "     DESC    30 %";
                sumadescuento = (SumaSubTotal + SumaIgv) / descuento;
                dataGridView1.Rows[lst.Count + celula].Cells[4].Value = sumadescuento;
                dataGridView1.Rows.Add();
                celula++;
            }

            dataGridView1.Rows[lst.Count + celula].Cells[3].Value = "     TOTAL     ";
            SumaTotal += SumaSubTotal + SumaIgv - sumadescuento;
            dataGridView1.Rows[lst.Count + celula].Cells[4].Value = SumaTotal;
            dataGridView1.ClearSelection();
        }

        private void Limpiar() {
            txtidprod.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtStock.Clear();
            txtPVenta.Clear();
            txtCantidad.Clear();
            txtCantidad.Focus();
            Proyecto_Final.Program.Descripcion = "";
            Proyecto_Final.Program.Stock = 0;
            Proyecto_Final.Program.Marca = "";
            Proyecto_Final.Program.PrecioVenta = 0;
            

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está Seguro que Desea Salir.?", "Clínica La Condesa", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes) {
                this.Close();
            }
        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0){
                if (dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected == true){
                    if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) != ""){
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    lst.RemoveAt(dataGridView1.CurrentRow.Index);
                        LlenarGrilla();
                        Proyecto_Final.Program.IdProducto[(dataGridView1.CurrentRow.Index)] = Convert.ToInt32("-1");
                        Proyecto_Final.Program.cantidad[(dataGridView1.CurrentRow.Index)] = Convert.ToInt32("-1");
                        MessageBox.Show("Producto Eliminado de la Lista Ok.","Clínica La Condesa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }else{
                      MessageBox.Show("No Existe Ningun Elemento en la Lista.", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      dataGridView1.ClearSelection();
                    }
                }else{
                 MessageBox.Show("Por Favor Seleccione Item a Eliminar de la Lista.", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else {
                MessageBox.Show("No Existe Ningun Elemento en la Lista","Clínica La Condesa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) {
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Selected = true;
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0){
                if (Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value) != ""){
                    try{
                        for (int i = 0; i < dataGridView1.Rows.Count; i++){
                            Decimal SumaIgv = 0; 
                            if (Convert.ToString(dataGridView1.Rows[i].Cells[2].Value) != ""){
                                SumaIgv += Convert.ToDecimal(dataGridView1.Rows[i].Cells[6].Value);
                                Proyecto_Final.Program.SumaSubTotal += Convert.ToDecimal(dataGridView1.Rows[i].Cells[4].Value);
                                Forma_pago V = new Forma_pago();
                                V.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                               // MessageBox.Show("Fila vacía", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }else{
                    MessageBox.Show("No Existe Ningún Elemento en la Lista.", "Clínica La Condesa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                MessageBox.Show("No Existe Ningún Elemento en la Lista.","Clínica La Condesa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)&& txtCantidad.TextLength < 3 || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                txtDocIdentidad.ResetText();
                txtDatos.ResetText();
                btnBusqueda.Enabled = false;
                Proyecto_Final.Program.IdCliente = 0;
                Proyecto_Final.Program.NombreCliente = "No registrado";
                Proyecto_Final.Program.ApellidoCliente = " ";
                Proyecto_Final.Program.Tipo_De_Cliente = "No regular";
                Proyecto_Final.Program.Cantidad_compras = 0;
                Proyecto_Final.Program.adeudocliente = 0;
                llenar_textbox();
                
            }
            else
            {
                btnBusqueda.Enabled = true;
                txtDocIdentidad.ResetText();
                txtDatos.ResetText();
            }
        }
    }
}

