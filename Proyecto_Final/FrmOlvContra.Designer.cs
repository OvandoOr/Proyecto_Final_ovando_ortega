namespace Proyecto_Final
{
    partial class FrmOlvContra
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.butt_ingre = new System.Windows.Forms.Button();
            this.tx_respuesta = new System.Windows.Forms.RichTextBox();
            this.butt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(301, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // butt_ingre
            // 
            this.butt_ingre.Location = new System.Drawing.Point(12, 132);
            this.butt_ingre.Name = "butt_ingre";
            this.butt_ingre.Size = new System.Drawing.Size(94, 23);
            this.butt_ingre.TabIndex = 2;
            this.butt_ingre.Text = "Ingresar";
            this.butt_ingre.UseVisualStyleBackColor = true;
            this.butt_ingre.Click += new System.EventHandler(this.butt_ingre_Click);
            // 
            // tx_respuesta
            // 
            this.tx_respuesta.Location = new System.Drawing.Point(12, 60);
            this.tx_respuesta.Name = "tx_respuesta";
            this.tx_respuesta.Size = new System.Drawing.Size(301, 66);
            this.tx_respuesta.TabIndex = 3;
            this.tx_respuesta.Text = "";
            // 
            // butt_cancelar
            // 
            this.butt_cancelar.Location = new System.Drawing.Point(205, 132);
            this.butt_cancelar.Name = "butt_cancelar";
            this.butt_cancelar.Size = new System.Drawing.Size(98, 23);
            this.butt_cancelar.TabIndex = 4;
            this.butt_cancelar.Text = "Cancelar";
            this.butt_cancelar.UseVisualStyleBackColor = true;
            this.butt_cancelar.Click += new System.EventHandler(this.butt_cancelar_Click);
            // 
            // FrmOlvContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 176);
            this.Controls.Add(this.butt_cancelar);
            this.Controls.Add(this.tx_respuesta);
            this.Controls.Add(this.butt_ingre);
            this.Controls.Add(this.comboBox1);
            this.Name = "FrmOlvContra";
            this.Text = "Olvide mi contraseña";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button butt_ingre;
        private System.Windows.Forms.RichTextBox tx_respuesta;
        private System.Windows.Forms.Button butt_cancelar;
    }
}