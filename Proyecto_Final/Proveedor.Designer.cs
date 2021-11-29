namespace Empleado
{
    partial class Proveedores
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
            this.txtEscuela_procedencia = new System.Windows.Forms.Label();
            this.txtCURP = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.Label();
            this.txtA_Materno = new System.Windows.Forms.Label();
            this.txtA_Paterno = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.Label();
            this.btngua = new System.Windows.Forms.Button();
            this.tbRFC = new System.Windows.Forms.TextBox();
            this.tbdicc = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tba_Rsocial = new System.Windows.Forms.TextBox();
            this.tba_giro = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.Size = new System.Drawing.Size(656, 171);
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
            this.groupBox1.Size = new System.Drawing.Size(696, 307);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
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
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(20, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 88);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de proveedores";
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
            this.radioButton2.Size = new System.Drawing.Size(57, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Giro";
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtEscuela_procedencia);
            this.groupBox3.Controls.Add(this.txtCURP);
            this.groupBox3.Controls.Add(this.txtCorreo);
            this.groupBox3.Controls.Add(this.txtTelefono);
            this.groupBox3.Controls.Add(this.txtA_Materno);
            this.groupBox3.Controls.Add(this.txtA_Paterno);
            this.groupBox3.Controls.Add(this.txtNombre);
            this.groupBox3.Controls.Add(this.btngua);
            this.groupBox3.Controls.Add(this.tbRFC);
            this.groupBox3.Controls.Add(this.tbdicc);
            this.groupBox3.Controls.Add(this.tbCorreo);
            this.groupBox3.Controls.Add(this.tbTelefono);
            this.groupBox3.Controls.Add(this.tba_Rsocial);
            this.groupBox3.Controls.Add(this.tba_giro);
            this.groupBox3.Controls.Add(this.tbnombre);
            this.groupBox3.Location = new System.Drawing.Point(12, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(696, 311);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registro de proveedores";
            // 
            // txtEscuela_procedencia
            // 
            this.txtEscuela_procedencia.AutoSize = true;
            this.txtEscuela_procedencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscuela_procedencia.Location = new System.Drawing.Point(15, 129);
            this.txtEscuela_procedencia.Name = "txtEscuela_procedencia";
            this.txtEscuela_procedencia.Size = new System.Drawing.Size(42, 20);
            this.txtEscuela_procedencia.TabIndex = 59;
            this.txtEscuela_procedencia.Text = "RFC";
            // 
            // txtCURP
            // 
            this.txtCURP.AutoSize = true;
            this.txtCURP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCURP.Location = new System.Drawing.Point(372, 96);
            this.txtCURP.Name = "txtCURP";
            this.txtCURP.Size = new System.Drawing.Size(75, 20);
            this.txtCURP.TabIndex = 57;
            this.txtCURP.Text = "Dirección";
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoSize = true;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(372, 28);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(57, 20);
            this.txtCorreo.TabIndex = 56;
            this.txtCorreo.Text = "Correo";
            // 
            // txtTelefono
            // 
            this.txtTelefono.AutoSize = true;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(372, 62);
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
            this.txtA_Materno.Size = new System.Drawing.Size(100, 20);
            this.txtA_Materno.TabIndex = 52;
            this.txtA_Materno.Text = "Razon social";
            // 
            // txtA_Paterno
            // 
            this.txtA_Paterno.AutoSize = true;
            this.txtA_Paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA_Paterno.Location = new System.Drawing.Point(15, 65);
            this.txtA_Paterno.Name = "txtA_Paterno";
            this.txtA_Paterno.Size = new System.Drawing.Size(39, 20);
            this.txtA_Paterno.TabIndex = 51;
            this.txtA_Paterno.Text = "Giro";
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
            this.btngua.Location = new System.Drawing.Point(536, 129);
            this.btngua.Name = "btngua";
            this.btngua.Size = new System.Drawing.Size(140, 50);
            this.btngua.TabIndex = 49;
            this.btngua.Text = "Guardar";
            this.btngua.UseVisualStyleBackColor = true;
            this.btngua.Click += new System.EventHandler(this.btngua_Click);
            // 
            // tbRFC
            // 
            this.tbRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRFC.Location = new System.Drawing.Point(166, 126);
            this.tbRFC.Name = "tbRFC";
            this.tbRFC.Size = new System.Drawing.Size(175, 26);
            this.tbRFC.TabIndex = 43;
            this.tbRFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRFC_KeyPress);
            // 
            // tbdicc
            // 
            this.tbdicc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdicc.Location = new System.Drawing.Point(499, 91);
            this.tbdicc.Name = "tbdicc";
            this.tbdicc.Size = new System.Drawing.Size(176, 26);
            this.tbdicc.TabIndex = 41;
            this.tbdicc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbdicc_KeyPress);
            // 
            // tbCorreo
            // 
            this.tbCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCorreo.Location = new System.Drawing.Point(500, 25);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(176, 26);
            this.tbCorreo.TabIndex = 40;
            this.tbCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCorreo_KeyPress);
            // 
            // tbTelefono
            // 
            this.tbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(500, 59);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(176, 26);
            this.tbTelefono.TabIndex = 39;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // tba_Rsocial
            // 
            this.tba_Rsocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tba_Rsocial.Location = new System.Drawing.Point(166, 94);
            this.tba_Rsocial.Name = "tba_Rsocial";
            this.tba_Rsocial.Size = new System.Drawing.Size(175, 26);
            this.tba_Rsocial.TabIndex = 36;
            this.tba_Rsocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tba_Rsocial_KeyPress);
            // 
            // tba_giro
            // 
            this.tba_giro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tba_giro.Location = new System.Drawing.Point(166, 62);
            this.tba_giro.Name = "tba_giro";
            this.tba_giro.Size = new System.Drawing.Size(175, 26);
            this.tba_giro.TabIndex = 35;
            this.tba_giro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tba_giro_KeyPress);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 511);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
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
        private System.Windows.Forms.Label txtEscuela_procedencia;
        private System.Windows.Forms.Label txtCURP;
        private System.Windows.Forms.Label txtCorreo;
        private System.Windows.Forms.Label txtTelefono;
        private System.Windows.Forms.Label txtA_Materno;
        private System.Windows.Forms.Label txtA_Paterno;
        private System.Windows.Forms.Label txtNombre;
        private System.Windows.Forms.Button btngua;
        private System.Windows.Forms.TextBox tbRFC;
        private System.Windows.Forms.TextBox tbdicc;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tba_Rsocial;
        private System.Windows.Forms.TextBox tba_giro;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}