namespace Examen2AJFS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.botonCal = new System.Windows.Forms.Button();
            this.Conversiones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Moneda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Monto";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "MXN - Peso Mexicano",
            "USD - Dólar Estadounidense",
            "CAD - Dólar Canadiense",
            "EUR - Euro",
            "JPY - Yen Japonés"});
            this.comboBox2.Location = new System.Drawing.Point(12, 37);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(154, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(172, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // botonCal
            // 
            this.botonCal.Location = new System.Drawing.Point(172, 63);
            this.botonCal.Name = "botonCal";
            this.botonCal.Size = new System.Drawing.Size(75, 23);
            this.botonCal.TabIndex = 4;
            this.botonCal.Text = "Calcular";
            this.botonCal.UseVisualStyleBackColor = true;
            // 
            // Conversiones
            // 
            this.Conversiones.AutoSize = true;
            this.Conversiones.Location = new System.Drawing.Point(12, 125);
            this.Conversiones.Name = "Conversiones";
            this.Conversiones.Size = new System.Drawing.Size(71, 13);
            this.Conversiones.TabIndex = 5;
            this.Conversiones.Text = "Conversiones";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 374);
            this.Controls.Add(this.Conversiones);
            this.Controls.Add(this.botonCal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textMonto;
        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botonCal;
        private System.Windows.Forms.Label Conversiones;
    }
}

