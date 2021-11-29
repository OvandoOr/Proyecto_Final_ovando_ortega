namespace Empleado
{
    partial class inventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_sum = new System.Windows.Forms.Button();
            this.but_res = new System.Windows.Forms.Button();
            this.cbprov = new System.Windows.Forms.ComboBox();
            this.tbcantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.Label();
            this.txtA_Materno = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.btngua = new System.Windows.Forms.Button();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbmarca = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.but_sum);
            this.groupBox1.Controls.Add(this.but_res);
            this.groupBox1.Controls.Add(this.cbprov);
            this.groupBox1.Controls.Add(this.tbcantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDomicilio);
            this.groupBox1.Controls.Add(this.txtA_Materno);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.btngua);
            this.groupBox1.Controls.Add(this.tbPrecio);
            this.groupBox1.Controls.Add(this.tbmarca);
            this.groupBox1.Controls.Add(this.tbnombre);
            this.groupBox1.Location = new System.Drawing.Point(16, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro y agregar producto";
            // 
            // but_sum
            // 
            this.but_sum.Location = new System.Drawing.Point(643, 32);
            this.but_sum.Name = "but_sum";
            this.but_sum.Size = new System.Drawing.Size(39, 29);
            this.but_sum.TabIndex = 73;
            this.but_sum.Text = "+";
            this.but_sum.UseVisualStyleBackColor = true;
            this.but_sum.Click += new System.EventHandler(this.but_sum_Click);
            // 
            // but_res
            // 
            this.but_res.Location = new System.Drawing.Point(512, 31);
            this.but_res.Name = "but_res";
            this.but_res.Size = new System.Drawing.Size(39, 29);
            this.but_res.TabIndex = 72;
            this.but_res.Text = "-";
            this.but_res.UseVisualStyleBackColor = true;
            this.but_res.Click += new System.EventHandler(this.but_res_Click);
            // 
            // cbprov
            // 
            this.cbprov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbprov.FormattingEnabled = true;
            this.cbprov.Location = new System.Drawing.Point(512, 66);
            this.cbprov.Name = "cbprov";
            this.cbprov.Size = new System.Drawing.Size(170, 28);
            this.cbprov.TabIndex = 71;
            this.cbprov.SelectedIndexChanged += new System.EventHandler(this.cbprov_SelectedIndexChanged);
            this.cbprov.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbprov_KeyPress);
            // 
            // tbcantidad
            // 
            this.tbcantidad.Location = new System.Drawing.Point(553, 34);
            this.tbcantidad.Name = "tbcantidad";
            this.tbcantidad.Size = new System.Drawing.Size(84, 26);
            this.tbcantidad.TabIndex = 70;
            this.tbcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcantidad_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Fecha de ingreso";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(512, 98);
            this.dtpFecha.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(170, 26);
            this.dtpFecha.TabIndex = 66;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged_1);
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(374, 69);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(81, 20);
            this.txtTelefono.TabIndex = 55;
            this.txtTelefono.Text = "Proveedor";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.AutoSize = true;
            this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(374, 36);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(73, 20);
            this.txtDomicilio.TabIndex = 54;
            this.txtDomicilio.Text = "Cantidad";
            // 
            // txtA_Materno
            // 
            this.txtA_Materno.AutoSize = true;
            this.txtA_Materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_Materno.Location = new System.Drawing.Point(29, 101);
            this.txtA_Materno.Name = "txtA_Materno";
            this.txtA_Materno.Size = new System.Drawing.Size(109, 20);
            this.txtA_Materno.TabIndex = 52;
            this.txtA_Materno.Text = "Precio unitario";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AutoSize = true;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(29, 69);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(53, 20);
            this.txtDescripcion.TabIndex = 51;
            this.txtDescripcion.Text = "Marca";
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(29, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(65, 20);
            this.txtNombre.TabIndex = 50;
            this.txtNombre.Text = "Nombre";
            // 
            // btngua
            // 
            this.btngua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngua.Location = new System.Drawing.Point(542, 147);
            this.btngua.Name = "btngua";
            this.btngua.Size = new System.Drawing.Size(140, 50);
            this.btngua.TabIndex = 49;
            this.btngua.Text = "Guardar";
            this.btngua.UseVisualStyleBackColor = true;
            this.btngua.Click += new System.EventHandler(this.btngua_Click);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.Location = new System.Drawing.Point(143, 95);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(205, 26);
            this.tbPrecio.TabIndex = 36;
            this.tbPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrecio_KeyPress);
            // 
            // tbmarca
            // 
            this.tbmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmarca.Location = new System.Drawing.Point(143, 63);
            this.tbmarca.Name = "tbmarca";
            this.tbmarca.Size = new System.Drawing.Size(205, 26);
            this.tbmarca.TabIndex = 35;
            this.tbmarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmarca_KeyPress);
            // 
            // tbnombre
            // 
            this.tbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnombre.Location = new System.Drawing.Point(143, 31);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(205, 26);
            this.tbnombre.TabIndex = 34;
            this.tbnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnombre_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(713, 307);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(460, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(20, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 88);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda de producto";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(316, 58);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(44, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ID";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(145, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Marca";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nombre";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(277, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(561, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(460, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(656, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 540);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "inventario";
            this.Text = "Inventario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.Label txtDomicilio;
        private System.Windows.Forms.Label txtA_Materno;
        private System.Windows.Forms.Label txtDescripcion;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Button btngua;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbmarca;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.TextBox tbcantidad;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbprov;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button but_sum;
        private System.Windows.Forms.Button but_res;
    }
}