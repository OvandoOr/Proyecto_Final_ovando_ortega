namespace Proyecto_Final
{
    partial class Restaurar_contraseña
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_contra = new System.Windows.Forms.TextBox();
            this.tx_contra1 = new System.Windows.Forms.TextBox();
            this.butt_acep = new System.Windows.Forms.Button();
            this.butt_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre.Location = new System.Drawing.Point(12, 25);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(63, 20);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su nueva contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reingrese su contraseña";
            // 
            // tx_contra
            // 
            this.tx_contra.Location = new System.Drawing.Point(246, 69);
            this.tx_contra.Name = "tx_contra";
            this.tx_contra.Size = new System.Drawing.Size(219, 20);
            this.tx_contra.TabIndex = 3;
            this.tx_contra.UseSystemPasswordChar = true;
            // 
            // tx_contra1
            // 
            this.tx_contra1.Location = new System.Drawing.Point(246, 118);
            this.tx_contra1.Name = "tx_contra1";
            this.tx_contra1.Size = new System.Drawing.Size(219, 20);
            this.tx_contra1.TabIndex = 4;
            this.tx_contra1.UseSystemPasswordChar = true;
            // 
            // butt_acep
            // 
            this.butt_acep.Location = new System.Drawing.Point(175, 159);
            this.butt_acep.Name = "butt_acep";
            this.butt_acep.Size = new System.Drawing.Size(142, 23);
            this.butt_acep.TabIndex = 5;
            this.butt_acep.Text = "Aceptar";
            this.butt_acep.UseVisualStyleBackColor = true;
            this.butt_acep.Click += new System.EventHandler(this.butt_acep_Click);
            // 
            // butt_close
            // 
            this.butt_close.Location = new System.Drawing.Point(323, 159);
            this.butt_close.Name = "butt_close";
            this.butt_close.Size = new System.Drawing.Size(142, 23);
            this.butt_close.TabIndex = 6;
            this.butt_close.Text = "Salir";
            this.butt_close.UseVisualStyleBackColor = true;
            this.butt_close.Click += new System.EventHandler(this.butt_close_Click);
            // 
            // Restaurar_contraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 194);
            this.Controls.Add(this.butt_close);
            this.Controls.Add(this.butt_acep);
            this.Controls.Add(this.tx_contra1);
            this.Controls.Add(this.tx_contra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "Restaurar_contraseña";
            this.Text = "Cambiar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_contra;
        private System.Windows.Forms.TextBox tx_contra1;
        private System.Windows.Forms.Button butt_acep;
        private System.Windows.Forms.Button butt_close;
    }
}