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
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            InicializarComponentes();
        }

        private void InicializarComponentes()
        {
            comboBox2.SelectedIndex = 0;
            botonCal.Click += new EventHandler(btnVentana_Click);
            
        }

        private void btnVentana_Click(Object sender, EventArgs e) { 
            Form2 frmVentana = new Form2();
            
            if (frmVentana.ShowDialog() == DialogResult.OK) { 
                /*
                String valorComboBox = comboBox2.SelectedValue.ToString();
                if (valorComboBox == "MXN - Peso Mexicano") {
                    Label lbl2 = new Label();
                    lbl2.Text = "Hola";
                    lbl2.Location = new Point(10, 10);
                    this.Controls.Add(lbl2);
                }*/
            }
        }
    }
}
