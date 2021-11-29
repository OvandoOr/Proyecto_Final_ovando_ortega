namespace Empleado
{
    partial class Doctor
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
            this.label9 = new System.Windows.Forms.Label();
            this.tx_cedula = new System.Windows.Forms.TextBox();
            this.cb_espec = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tx_direccion = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_resp = new System.Windows.Forms.TextBox();
            this.cb_pregunta = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_estadoC = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txcontra = new System.Windows.Forms.TextBox();
            this.txnombreu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_sangre = new System.Windows.Forms.ComboBox();
            this.cmbEstado_Civil = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.Label();
            this.lblEscuela_procedencia = new System.Windows.Forms.Label();
            this.txtCURP = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.txtA_Materno = new System.Windows.Forms.Label();
            this.txtA_Paterno = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.btngua = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtEscuela_procedencia = new System.Windows.Forms.TextBox();
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
            this.groupBox2.Text = "Busqueda de doctores";
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
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tx_cedula);
            this.groupBox3.Controls.Add(this.cb_espec);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tx_direccion);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tx_resp);
            this.groupBox3.Controls.Add(this.cb_pregunta);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cb_estadoC);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dtpFecha);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txcontra);
            this.groupBox3.Controls.Add(this.txnombreu);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cb_sangre);
            this.groupBox3.Controls.Add(this.cmbEstado_Civil);
            this.groupBox3.Controls.Add(this.cmbSexo);
            this.groupBox3.Controls.Add(this.lblEscuela_procedencia);
            this.groupBox3.Controls.Add(this.txtCURP);
            this.groupBox3.Controls.Add(this.txtCorreo);
            this.groupBox3.Controls.Add(this.txtTelefono);
            this.groupBox3.Controls.Add(this.txtA_Materno);
            this.groupBox3.Controls.Add(this.txtA_Paterno);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.btngua);
            this.groupBox3.Controls.Add(this.cbSexo);
            this.groupBox3.Controls.Add(this.txtEscuela_procedencia);
            this.groupBox3.Controls.Add(this.tbCURP);
            this.groupBox3.Controls.Add(this.tbCorreo);
            this.groupBox3.Controls.Add(this.tbTelefono);
            this.groupBox3.Controls.Add(this.tba_Materno);
            this.groupBox3.Controls.Add(this.tba_Paterno);
            this.groupBox3.Controls.Add(this.tbnombre);
            this.groupBox3.Location = new System.Drawing.Point(12, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(787, 394);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registro de doctores";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 85;
            this.label9.Text = "Cédula";
            // 
            // tx_cedula
            // 
            this.tx_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_cedula.Location = new System.Drawing.Point(515, 25);
            this.tx_cedula.Name = "tx_cedula";
            this.tx_cedula.Size = new System.Drawing.Size(239, 26);
            this.tx_cedula.TabIndex = 84;
            this.tx_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_cedula_KeyPress);
            // 
            // cb_espec
            // 
            this.cb_espec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_espec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_espec.FormattingEnabled = true;
            this.cb_espec.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cb_espec.Location = new System.Drawing.Point(164, 351);
            this.cb_espec.Name = "cb_espec";
            this.cb_espec.Size = new System.Drawing.Size(178, 28);
            this.cb_espec.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 82;
            this.label8.Text = "Especialidad";
            // 
            // tx_direccion
            // 
            this.tx_direccion.Location = new System.Drawing.Point(515, 62);
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
            this.label7.Location = new System.Drawing.Point(436, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 80;
            this.label7.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(426, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 79;
            this.label6.Text = "Respuesta";
            // 
            // tx_resp
            // 
            this.tx_resp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_resp.Location = new System.Drawing.Point(513, 290);
            this.tx_resp.Name = "tx_resp";
            this.tx_resp.Size = new System.Drawing.Size(243, 26);
            this.tx_resp.TabIndex = 78;
            this.tx_resp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_resp_KeyPress);
            // 
            // cb_pregunta
            // 
            this.cb_pregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pregunta.DropDownWidth = 360;
            this.cb_pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_pregunta.FormattingEnabled = true;
            this.cb_pregunta.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cb_pregunta.Location = new System.Drawing.Point(515, 256);
            this.cb_pregunta.Name = "cb_pregunta";
            this.cb_pregunta.Size = new System.Drawing.Size(241, 28);
            this.cb_pregunta.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 76;
            this.label5.Text = "Pregunta de seguridad";
            // 
            // cb_estadoC
            // 
            this.cb_estadoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_estadoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_estadoC.FormattingEnabled = true;
            this.cb_estadoC.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cb_estadoC.Location = new System.Drawing.Point(164, 320);
            this.cb_estadoC.Name = "cb_estadoC";
            this.cb_estadoC.Size = new System.Drawing.Size(178, 28);
            this.cb_estadoC.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 328);
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
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "YYYY/MM/DD";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(164, 225);
            this.dtpFecha.MaxDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.MinDate = new System.DateTime(1917, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(177, 26);
            this.dtpFecha.TabIndex = 72;
            this.dtpFecha.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Contraseña";
            // 
            // txcontra
            // 
            this.txcontra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txcontra.Location = new System.Drawing.Point(513, 224);
            this.txcontra.Name = "txcontra";
            this.txcontra.Size = new System.Drawing.Size(243, 26);
            this.txcontra.TabIndex = 70;
            this.txcontra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txcontra_KeyPress);
            // 
            // txnombreu
            // 
            this.txnombreu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txnombreu.Location = new System.Drawing.Point(513, 192);
            this.txnombreu.Name = "txnombreu";
            this.txnombreu.Size = new System.Drawing.Size(243, 26);
            this.txnombreu.TabIndex = 69;
            this.txnombreu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txnombreu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Nombre de usuario";
            // 
            // cb_sangre
            // 
            this.cb_sangre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sangre.FormattingEnabled = true;
            this.cb_sangre.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor"});
            this.cb_sangre.Location = new System.Drawing.Point(164, 288);
            this.cb_sangre.Name = "cb_sangre";
            this.cb_sangre.Size = new System.Drawing.Size(178, 28);
            this.cb_sangre.TabIndex = 67;
            // 
            // cmbEstado_Civil
            // 
            this.cmbEstado_Civil.AutoSize = true;
            this.cmbEstado_Civil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado_Civil.Location = new System.Drawing.Point(16, 296);
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
            // 
            // lblEscuela_procedencia
            // 
            this.lblEscuela_procedencia.AutoSize = true;
            this.lblEscuela_procedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscuela_procedencia.Location = new System.Drawing.Point(1, 129);
            this.lblEscuela_procedencia.Name = "lblEscuela_procedencia";
            this.lblEscuela_procedencia.Size = new System.Drawing.Size(157, 20);
            this.lblEscuela_procedencia.TabIndex = 59;
            this.lblEscuela_procedencia.Text = "Escuela procedencia";
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
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(452, 159);
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
            this.btngua.Location = new System.Drawing.Point(570, 338);
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
            // 
            // txtEscuela_procedencia
            // 
            this.txtEscuela_procedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscuela_procedencia.Location = new System.Drawing.Point(166, 126);
            this.txtEscuela_procedencia.Name = "txtEscuela_procedencia";
            this.txtEscuela_procedencia.Size = new System.Drawing.Size(175, 26);
            this.txtEscuela_procedencia.TabIndex = 43;
            this.txtEscuela_procedencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbedad_KeyPress);
            // 
            // tbCURP
            // 
            this.tbCURP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCURP.Location = new System.Drawing.Point(165, 193);
            this.tbCURP.Name = "tbCURP";
            this.tbCURP.Size = new System.Drawing.Size(176, 26);
            this.tbCURP.TabIndex = 41;
            this.tbCURP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCURP_KeyPress);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(513, 159);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(243, 26);
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
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // tba_Materno
            // 
            this.tba_Materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tba_Materno.Location = new System.Drawing.Point(166, 94);
            this.tba_Materno.Name = "tba_Materno";
            this.tba_Materno.Size = new System.Drawing.Size(175, 26);
            this.tba_Materno.TabIndex = 36;
            this.tba_Materno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tba_Materno_KeyPress);
            // 
            // tba_Paterno
            // 
            this.tba_Paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tba_Paterno.Location = new System.Drawing.Point(166, 62);
            this.tba_Paterno.Name = "tba_Paterno";
            this.tba_Paterno.Size = new System.Drawing.Size(175, 26);
            this.tba_Paterno.TabIndex = 35;
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
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(811, 733);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Doctor";
            this.Text = "Doctores";
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
        private System.Windows.Forms.Label lblEscuela_procedencia;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.Label txtA_Materno;
        private System.Windows.Forms.Label txtA_Paterno;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Button btngua;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtEscuela_procedencia;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tba_Materno;
        private System.Windows.Forms.TextBox tba_Paterno;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cb_sangre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txcontra;
        private System.Windows.Forms.TextBox txnombreu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tx_resp;
        private System.Windows.Forms.ComboBox cb_pregunta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_estadoC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tx_direccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_espec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tx_cedula;
        private System.Windows.Forms.Label txtCURP;
        private System.Windows.Forms.TextBox tbCURP;
    }
}