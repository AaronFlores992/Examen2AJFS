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
        private Label lbl;
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
                CheckBox mxn = frmVentana.cB_Mxn;
                CheckBox usd = frmVentana.cB_Usd;
                CheckBox cad = frmVentana.cB_Cad;
                CheckBox euro = frmVentana.cB_Eur;
                CheckBox yen = frmVentana.cB_Jyp;

                List<CheckBox> list = new List<CheckBox>();
                list.Add(mxn);
                list.Add(usd);
                list.Add(cad);
                list.Add(euro);
                list.Add(yen);
                int x = 5;
                int y = 10;
                int x2 = 150;
                int y2 = 10;


                
                panel2.Controls.Clear();
                foreach (CheckBox cb in list) {
                    String nombre = cb.Text;
                    Boolean state = cb.Checked;
                    if (state == true) {
                        lbl = new Label();
                        
                        lbl.Text = nombre;
                        lbl.AutoSize = true;
                        lbl.Location = new Point(x, y);
                        y += 30;
                        panel2.Controls.Add(lbl);

                        Double valor = 0.0;
                        try
                        {
                            valor = Double.Parse(textBox1.Text);
                            if (comboBox2.Text == "MXN - Peso Mexicano")
                            {
                                TextBox txt = new TextBox();
                                txt.Location = new Point(x2, y2);
                                if (nombre.Equals("MXN - Peso Mexicano"))
                                {
                                    double resultado = aMxn(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("USD - Dólar Estadounidense"))
                                {
                                    double resultado = aMxn(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("CAD - Dólar Canadiense"))
                                {
                                    double resultado = aMxn(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("EUR - Euro"))
                                {
                                    double resultado = aMxn(valor, nombre);
                                    txt.Text = " € " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("JPY - Yen Japonés"))
                                {
                                    double resultado = aMxn(valor, nombre);
                                    txt.Text = " ¥ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                y2 += 30;

                            }
                            if (comboBox2.Text == "USD - Dólar Estadounidense")
                            {
                                TextBox txt = new TextBox();
                                txt.Location = new Point(x2, y2);
                                if (nombre.Equals("MXN - Peso Mexicano"))
                                {
                                    double resultado = aUsd(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("USD - Dólar Estadounidense"))
                                {
                                    double resultado = aUsd(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("CAD - Dólar Canadiense"))
                                {
                                    double resultado = aUsd(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("EUR - Euro"))
                                {
                                    double resultado = aUsd(valor, nombre);
                                    txt.Text = " € " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("JPY - Yen Japonés"))
                                {
                                    double resultado = aUsd(valor, nombre);
                                    txt.Text = " ¥ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                y2 += 30;
                            }
                            if (comboBox2.Text == "CAD - Dólar Canadiense")
                            {
                                TextBox txt = new TextBox();
                                txt.Location = new Point(x2, y2);
                                if (nombre.Equals("MXN - Peso Mexicano"))
                                {
                                    double resultado = aCad(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("USD - Dólar Estadounidense"))
                                {
                                    double resultado = aCad(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("CAD - Dólar Canadiense"))
                                {
                                    double resultado = aCad(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("EUR - Euro"))
                                {
                                    double resultado = aCad(valor, nombre);
                                    txt.Text = " € " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("JPY - Yen Japonés"))
                                {
                                    double resultado = aCad(valor, nombre);
                                    txt.Text = " ¥ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                y2 += 30;
                            }
                            if (comboBox2.Text == "EUR - Euro")
                            {
                                TextBox txt = new TextBox();
                                txt.Location = new Point(x2, y2);
                                if (nombre.Equals("MXN - Peso Mexicano"))
                                {
                                    double resultado = aEur(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("USD - Dólar Estadounidense"))
                                {
                                    double resultado = aEur(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("CAD - Dólar Canadiense"))
                                {
                                    double resultado = aEur(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("EUR - Euro"))
                                {
                                    double resultado = aEur(valor, nombre);
                                    txt.Text = " € " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("JPY - Yen Japonés"))
                                {
                                    double resultado = aEur(valor, nombre);
                                    txt.Text = " ¥ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                y2 += 30;
                            }
                            if (comboBox2.Text == "JPY - Yen Japonés")
                            {
                                TextBox txt = new TextBox();
                                txt.Location = new Point(x2, y2);
                                if (nombre.Equals("MXN - Peso Mexicano"))
                                {
                                    double resultado = aYen(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("USD - Dólar Estadounidense"))
                                {
                                    double resultado = aYen(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("CAD - Dólar Canadiense"))
                                {
                                    double resultado = aYen(valor, nombre);
                                    txt.Text = " $ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("EUR - Euro"))
                                {
                                    double resultado = aYen(valor, nombre);
                                    txt.Text = " € " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                if (nombre.Equals("JPY - Yen Japonés"))
                                {
                                    double resultado = aYen(valor, nombre);
                                    txt.Text = " ¥ " + resultado.ToString();
                                    panel2.Controls.Add(txt);
                                }
                                y2 += 30;
                            }
                        }
                        catch (Exception ex) {
                            panel2.Controls.Clear();
                            Label lbl2 = new Label();
                            lbl2.Text = "Datos Ingrados Incorrectos";
                            lbl2.AutoSize = true;
                            lbl2.Location = new Point(50, 50);
                            panel2.Controls.Add(lbl2);
                        }
                        
                        

                    }
                }
            }
        }


        private double aMxn(double valor, string moneda) {
            if (moneda == "MXN - Peso Mexicano") {
                return valor * 1;
            }
            else if (moneda == "USD - Dólar Estadounidense")
            {
                return valor * 0.05;
            }
            else if (moneda == "CAD - Dólar Canadiense")
            {
                return valor * 0.06;
            }
            else if (moneda == "EUR - Euro")
            {
                return valor * 0.04;
            }
            else
            {
                return valor * 5.32;
            }
        }

        private double aUsd(double valor, string moneda)
        {
            if (moneda == "MXN - Peso Mexicano")
            {
                return valor * 21.23;
            }
            else if (moneda == "USD - Dólar Estadounidense")
            {
                return valor * 1;
            }
            else if (moneda == "CAD - Dólar Canadiense")
            {
                return valor * 1.28;
            }
            else if (moneda == "EUR - Euro")
            {
                return valor * 0.89;
            }
            else
            {
                return valor * 113.05;
            }
        }
        private double aCad(double valor, string moneda)
        {
            if (moneda == "MXN - Peso Mexicano")
            {
                return valor * 16.55;
            }
            else if (moneda == "USD - Dólar Estadounidense")
            {
                return valor * 0.78;
            }
            else if (moneda == "CAD - Dólar Canadiense")
            {
                return valor * 1;
            }
            else if (moneda == "EUR - Euro")
            {
                return valor * 0.69;
            }
            else
            {
                return valor * 88.12;
            }
        }

        private double aEur(double valor, string moneda)
        {
            if (moneda == "MXN - Peso Mexicano")
            {
                return valor * 23.96;
            }
            else if (moneda == "USD - Dólar Estadounidense")
            {
                return valor * 1.13;
            }
            else if (moneda == "CAD - Dólar Canadiense")
            {
                return valor * 1.45;
            }
            else if (moneda == "EUR - Euro")
            {
                return valor * 1;
            }
            else
            {
                return valor * 127.56;
            }
        }

        private double aYen(double valor, string moneda)
        {
            if (moneda == "MXN - Peso Mexicano")
            {
                return valor * 0.1878;
            }
            else if (moneda == "USD - Dólar Estadounidense")
            {
                return valor * 0.0088;
            }
            else if (moneda == "CAD - Dólar Canadiense")
            {
                return valor * 0.0113;
            }
            else if (moneda == "EUR - Euro")
            {
                return valor * 0.0078;
            }
            else
            {
                return valor * 1;
            }
        }

        

    }
}
