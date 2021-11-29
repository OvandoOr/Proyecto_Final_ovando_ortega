namespace Empleado
{
    partial class Empleado
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_areaC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_puesto = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tx_telemer = new System.Windows.Forms.TextBox();
            this.tx_direccion = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_estadoC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cb_sangre = new System.Windows.Forms.ComboBox();
            this.cmbEstado_Civil = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.Label();
            this.txtCURP = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.txtA_Materno = new System.Windows.Forms.Label();
            this.txtA_Paterno = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.btngua = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.tbCURP = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tba_Materno = new System.Windows.Forms.TextBox();
            this.tba_Paterno = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(761, 171);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 307);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(570, 67);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 36);
            this.button4.TabIndex = 9;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(20, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 88);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de empleados";
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
            this.radioButton2.Size = new System.Drawing.Size(101, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Apellido P.";
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
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(671, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Eliminar ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cb_areaC);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cb_puesto);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tx_telemer);
            this.groupBox3.Controls.Add(this.tx_direccion);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cb_estadoC);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtpFecha);
            this.groupBox3.Controls.Add(this.cb_sangre);
            this.groupBox3.Controls.Add(this.cmbEstado_Civil);
            this.groupBox3.Controls.Add(this.cmbSexo);
            this.groupBox3.Controls.Add(this.txtCURP);
            this.groupBox3.Controls.Add(this.txtCorreo);
            this.groupBox3.Controls.Add(this.txtTelefono);
            this.groupBox3.Controls.Add(this.txtA_Materno);
            this.groupBox3.Controls.Add(this.txtA_Paterno);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.btngua);
            this.groupBox3.Controls.Add(this.cbSexo);
            this.groupBox3.Controls.Add(this.tbCURP);
            this.groupBox3.Controls.Add(this.tbCorreo);
            this.groupBox3.Controls.Add(this.tbTelefono);
            this.groupBox3.Controls.Add(this.tba_Materno);
            this.groupBox3.Controls.Add(this.tba_Paterno);
            this.groupBox3.Controls.Add(this.tbnombre);
            this.groupBox3.Location = new System.Drawing.Point(12, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(787, 333);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registro de empleados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(457, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 89;
            this.label2.Text = "Área";
            // 
            // cb_areaC
            // 
            this.cb_areaC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_areaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_areaC.FormattingEnabled = true;
            this.cb_areaC.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cb_areaC.Location = new System.Drawing.Point(515, 230);
            this.cb_areaC.Name = "cb_areaC";
            this.cb_areaC.Size = new System.Drawing.Size(240, 28);
            this.cb_areaC.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 87;
            this.label1.Text = "Tipo de trabajador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_puesto
            // 
            this.cb_puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_puesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_puesto.FormattingEnabled = true;
            this.cb_puesto.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cb_puesto.Location = new System.Drawing.Point(163, 290);
            this.cb_puesto.Name = "cb_puesto";
            this.cb_puesto.Size = new System.Drawing.Size(178, 28);
            this.cb_puesto.TabIndex = 86;
            this.cb_puesto.SelectedIndexChanged += new System.EventHandler(this.cb_puesto_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 20);
            this.label9.TabIndex = 85;
            this.label9.Text = "Telefono emergencia";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tx_telemer
            // 
            this.tx_telemer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_telemer.Location = new System.Drawing.Point(166, 126);
            this.tx_telemer.Name = "tx_telemer";
            this.tx_telemer.Size = new System.Drawing.Size(175, 26);
            this.tx_telemer.TabIndex = 84;
            this.tx_telemer.TextChanged += new System.EventHandler(this.tx_telemer_TextChanged);
            this.tx_telemer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_cedula_KeyPress);
            // 
            // tx_direccion
            // 
            this.tx_direccion.Location = new System.Drawing.Point(515, 33);
            this.tx_direccion.Name = "tx_direccion";
            this.tx_direccion.Size = new System.Drawing.Size(240, 87);
            this.tx_direccion.TabIndex = 81;
            this.tx_direccion.Text = "";
            this.tx_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Dirección";
            // 
            // cb_estadoC
            // 
            this.cb_estadoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estadoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estadoC.FormattingEnabled = true;
            this.cb_estadoC.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cb_estadoC.Location = new System.Drawing.Point(515, 196);
            this.cb_estadoC.Name = "cb_estadoC";
            this.cb_estadoC.Size = new System.Drawing.Size(240, 28);
            this.cb_estadoC.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Estado civil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Fecha de nacimiento";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Checked = false;
            this.dtpFecha.CustomFormat = "YYYY/MM/DD";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(164, 225);
            this.dtpFecha.MinDate = new System.DateTime(1917, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(177, 26);
            this.dtpFecha.TabIndex = 72;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // cb_sangre
            // 
            this.cb_sangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sangre.FormattingEnabled = true;
            this.cb_sangre.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cb_sangre.Location = new System.Drawing.Point(515, 160);
            this.cb_sangre.Name = "cb_sangre";
            this.cb_sangre.Size = new System.Drawing.Size(240, 28);
            this.cb_sangre.TabIndex = 67;
            // 
            // cmbEstado_Civil
            // 
            this.cmbEstado_Civil.AutoSize = true;
            this.cmbEstado_Civil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado_Civil.Location = new System.Drawing.Point(386, 167);
            this.cmbEstado_Civil.Name = "cmbEstado_Civil";
            this.cmbEstado_Civil.Size = new System.Drawing.Size(114, 20);
            this.cmbEstado_Civil.TabIndex = 64;
            this.cmbEstado_Civil.Text = "Tipo de sangre";
            // 
            // cmbSexo
            // 
            this.cmbSexo.AutoSize = true;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.Location = new System.Drawing.Point(15, 261);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(45, 20);
            this.cmbSexo.TabIndex = 63;
            this.cmbSexo.Text = "Sexo";
            this.cmbSexo.Click += new System.EventHandler(this.cmbSexo_Click);
            // 
            // txtCURP
            // 
            this.txtCURP.AutoSize = true;
            this.txtCURP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCURP.Location = new System.Drawing.Point(16, 198);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(54, 20);
            this.txtCURP.TabIndex = 57;
            this.txtCURP.Text = "CURP";
            this.txtCURP.Click += new System.EventHandler(this.txtCURP_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(443, 129);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(57, 20);
            this.txtCorreo.TabIndex = 56;
            this.txtCorreo.Text = "Correo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(16, 164);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(71, 20);
            this.txtTelefono.TabIndex = 55;
            this.txtTelefono.Text = "Telefono";
            this.txtTelefono.Click += new System.EventHandler(this.txtTelefono_Click);
            // 
            // txtA_Materno
            // 
            this.txtA_Materno.AutoSize = true;
            this.txtA_Materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_Materno.Location = new System.Drawing.Point(15, 97);
            this.txtA_Materno.Name = "txtA_Materno";
            this.txtA_Materno.Size = new System.Drawing.Size(128, 20);
            this.txtA_Materno.TabIndex = 52;
            this.txtA_Materno.Text = "Apellido Materno";
            this.txtA_Materno.Click += new System.EventHandler(this.txtA_Materno_Click);
            // 
            // txtA_Paterno
            // 
            this.txtA_Paterno.AutoSize = true;
            this.txtA_Paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_Paterno.Location = new System.Drawing.Point(15, 65);
            this.txtA_Paterno.Name = "txtA_Paterno";
            this.txtA_Paterno.Size = new System.Drawing.Size(125, 20);
            this.txtA_Paterno.TabIndex = 51;
            this.txtA_Paterno.Text = "Apellido Paterno";
            this.txtA_Paterno.Click += new System.EventHandler(this.txtA_Paterno_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AutoSize = true;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(15, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(65, 20);
            this.txtNombre.TabIndex = 50;
            this.txtNombre.Text = "Nombre";
            // 
            // btngua
            // 
            this.btngua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngua.Location = new System.Drawing.Point(602, 273);
            this.btngua.Name = "btngua";
            this.btngua.Size = new System.Drawing.Size(140, 50);
            this.btngua.TabIndex = 49;
            this.btngua.Text = "Guardar";
            this.btngua.UseVisualStyleBackColor = true;
            this.btngua.Click += new System.EventHandler(this.btngua_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbSexo.Location = new System.Drawing.Point(164, 256);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(178, 28);
            this.cbSexo.TabIndex = 46;
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            // 
            // tbCURP
            // 
            this.tbCURP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCURP.Location = new System.Drawing.Point(165, 193);
            this.tbCURP.Name = "tbCURP";
            this.tbCURP.Size = new System.Drawing.Size(176, 26);
            this.tbCURP.TabIndex = 41;
            this.tbCURP.TextChanged += new System.EventHandler(this.tbCURP_TextChanged);
            this.tbCURP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCURP_KeyPress);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(515, 128);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(240, 26);
            this.tbCorreo.TabIndex = 40;
            this.tbCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCorreo_KeyPress);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(166, 161);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(176, 26);
            this.tbTelefono.TabIndex = 39;
            this.tbTelefono.TextChanged += new System.EventHandler(this.tbTelefono_TextChanged);
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // tba_Materno
            // 
            this.tba_Materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tba_Materno.Location = new System.Drawing.Point(166, 94);
            this.tba_Materno.Name = "tba_Materno";
            this.tba_Materno.Size = new System.Drawing.Size(175, 26);
            this.tba_Materno.TabIndex = 36;
            this.tba_Materno.TextChanged += new System.EventHandler(this.tba_Materno_TextChanged);
            this.tba_Materno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tba_Materno_KeyPress);
            // 
            // tba_Paterno
            // 
            this.tba_Paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tba_Paterno.Location = new System.Drawing.Point(166, 62);
            this.tba_Paterno.Name = "tba_Paterno";
            this.tba_Paterno.Size = new System.Drawing.Size(175, 26);
            this.tba_Paterno.TabIndex = 35;
            this.tba_Paterno.TextChanged += new System.EventHandler(this.tba_Paterno_TextChanged);
            this.tba_Paterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tba_Paterno_KeyPress);
            // 
            // tbnombre
            // 
            this.tbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnombre.Location = new System.Drawing.Point(164, 30);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(175, 26);
            this.tbnombre.TabIndex = 34;
            this.tbnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbnombre_KeyPress);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 200;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 660);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Empleado";
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label cmbEstado_Civil;
        private System.Windows.Forms.Label cmbSexo;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.Label txtA_Materno;
        private System.Windows.Forms.Label txtA_Paterno;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Button btngua;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tba_Materno;
        private System.Windows.Forms.TextBox tba_Paterno;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cb_sangre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cb_estadoC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tx_direccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tx_telemer;
        private System.Windows.Forms.Label txtCURP;
        private System.Windows.Forms.TextBox tbCURP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_puesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_areaC;
    }
}