using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calcu : Form
    {
        double pt  ;
        double st ;
        string operacion;
        public Calcu()
        {
            InitializeComponent();
        }
        ClasesCalculadora.Suma suma = new ClasesCalculadora.Suma();
        ClasesCalculadora.Resta resta = new ClasesCalculadora.Resta();
        ClasesCalculadora.Multiplicacion multiplicacion = new ClasesCalculadora.Multiplicacion();
        ClasesCalculadora.Division division = new ClasesCalculadora.Division();
        ClasesCalculadora.Porcentaje porcentaje = new ClasesCalculadora.Porcentaje();

        private void btncero_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "0";
            txtcabezera.Text = txtcabezera.Text + "0";
        }

        private void btnuno_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "1";
            txtcabezera.Text = txtcabezera.Text + "1";
        }

        private void btndos_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "2";
            txtcabezera.Text = txtcabezera.Text + "2";
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "3";
            txtcabezera.Text = txtcabezera.Text + "3";
        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
             txtresultados.Text = txtresultados.Text + "4";
            txtcabezera.Text = txtcabezera.Text + "4";
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "5";
            txtcabezera.Text = txtcabezera.Text + "5";

        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "6";
            txtcabezera.Text = txtcabezera.Text + "6";

        }

        private void btnsiete_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "7";
            txtcabezera.Text = txtcabezera.Text + "7";

        }

        private void btnocho_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "8";
            txtcabezera.Text = txtcabezera.Text + "8";

        }

        private void btnnueve_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + "9";
            txtcabezera.Text = txtcabezera.Text + "9";

        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            txtresultados.Text = txtresultados.Text + ",";
            txtcabezera.Text = txtcabezera.Text + ",";
            btnpunto.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnmas_Click(object sender, EventArgs e)
        {
            operacion = "+";
            pt = double.Parse(txtresultados.Text);
            txtresultados.Clear();
            txtcabezera.Text = txtcabezera.Text + "+";
            btnpunto.Enabled = true;

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            pt = double.Parse(txtresultados.Text);
            txtcabezera.Text = txtcabezera.Text + "-";
            txtresultados.Clear();
            btnpunto.Enabled = true;

        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operacion = "*";
            pt = double.Parse(txtresultados.Text);
            txtcabezera.Text = txtcabezera.Text + "*";
            txtresultados.Clear();
            btnpunto.Enabled = true;

        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            operacion = "/";
            pt = double.Parse(txtresultados.Text);
            txtcabezera.Text = txtcabezera.Text + "/";
            txtresultados.Clear();
            btnpunto.Enabled = true;

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            st = double.Parse(txtresultados.Text);

            double SUM;
            double RES;
            double Mult;
            double Div;
            double Porc;
            switch(operacion)
            {
                case "+":
                    SUM = suma.Sumar((pt), (st));
                    txtresultados.Text = SUM.ToString();
                    break;
                case "-":
                    RES = resta.Restar((pt), (st));
                    txtresultados.Text = RES.ToString();
                    break;
                case "/":
                    Div = division.Dividir((pt), (st));
                    txtresultados.Text = Div.ToString();
                    break;
                case "*":
                    Mult = multiplicacion.Multiplicar((pt), (st));
                    txtresultados.Text = Mult.ToString();
                    break;
                case "%":
                    Porc = porcentaje.PorCiento((pt), (st));
                    txtresultados.Text = Porc.ToString();
                    break;


            }

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtresultados.Text="";
            if (txtcabezera.Text.Length > 0)
                txtcabezera.Text = txtcabezera.Text.Remove(txtcabezera.Text.Length -1);



        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            if (txtresultados.Text.Length > 0)
                txtresultados.Text = txtresultados.Text.Remove(txtresultados.Text.Length - 1);
            if (txtcabezera.Text.Length > 0)
                txtcabezera.Text = txtcabezera.Text.Remove(txtcabezera.Text.Length - 1);
        }

        private void btnborrartodo_Click(object sender, EventArgs e)
        {
            txtresultados.Clear();
            txtcabezera.Clear();
        }

        private void btnsigno_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtresultados.Text);
            x = ((x) * (-1));
            txtresultados.Text = x.ToString();
            txtcabezera.Text = x.ToString();
        }

        private void btnexponente_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtresultados.Text);
            x = (x*x);
            txtresultados.Text = x.ToString();
            txtcabezera.Text = x.ToString();
        }

        private void btnraiz_Click(object sender, EventArgs e)
        {
            
            operacion = "√";
            pt = double.Parse(txtresultados.Text);
            txtcabezera.Text = txtcabezera.Text + "√";
            txtresultados.Clear();
            btnpunto.Enabled = true;
            txtresultados.Text = Math.Sqrt(pt).ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = double.Parse(txtresultados.Text);
            x = (1 / (x));
            txtresultados.Text = x.ToString();
            txtcabezera.Text = x.ToString();
        }

        private void btnporcentaje_Click(object sender, EventArgs e)
        {
            operacion = "%";
            pt = double.Parse(txtresultados.Text);
            txtcabezera.Text = txtcabezera.Text + "%";
            txtresultados.Clear();
            btnpunto.Enabled = true;

        }
    }
}
