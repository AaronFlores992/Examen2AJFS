using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2AJFS
{
    public partial class Form2 : Form
    {
        public CheckBox cB_Mxn;
        public CheckBox cB_Usd;
        public CheckBox cB_Cad;
        public CheckBox cB_Eur;
        public CheckBox cB_Jyp;
        

        public Form2()
        {
            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            agregarCheckBox();
            botonCancelar.Click += new EventHandler(btnCancelar_Click);
            botonAceptar.Click += new EventHandler(btnAceptar_Click);
        }

        private void agregarCheckBox() {
            Form1 form1 = new Form1();
            String valorSeleccionado = "";

            valorSeleccionado = form1.comboBox2.Text;

            cB_Mxn = new CheckBox();
            cB_Usd = new CheckBox();
            cB_Cad = new CheckBox();
            cB_Eur = new CheckBox();
            cB_Jyp = new CheckBox();

            cB_Mxn.Text = "MXN - Peso Mexicano";
            cB_Usd.Text = "USD - Dólar Estadounidense";
            cB_Cad.Text = "CAD - Dólar Canadiense";
            cB_Eur.Text = "EUR - Euro";
            cB_Jyp.Text = "JPY - Yen Japonés";

            cB_Mxn.AutoSize = true;
            cB_Usd.AutoSize = true;
            cB_Cad.AutoSize = true;
            cB_Eur.AutoSize = true;
            cB_Jyp.AutoSize = true;

            cB_Mxn.Location = new Point(10, 20);
            cB_Usd.Location = new Point(10, 60);
            cB_Cad.Location = new Point(10, 100);
            cB_Eur.Location = new Point(10, 140);
            cB_Jyp.Location = new Point(10, 180);

            this.Controls.Add(cB_Mxn);
            this.Controls.Add(cB_Usd);
            this.Controls.Add(cB_Cad);
            this.Controls.Add(cB_Eur);
            this.Controls.Add(cB_Jyp);

        }

        private void btnCancelar_Click(Object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnAceptar_Click(Object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }
}
