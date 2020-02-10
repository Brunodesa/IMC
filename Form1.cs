using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            genero g = new genero();
            calcula c = new calcula();
            c.peso = Convert.ToDouble(textBox1.Text);
            c.altura = Convert.ToDouble(textBox2.Text);
            c.calc = c.peso / (c.altura * c.altura);
            label4.Text = c.calc.ToString();

            if(checkBox1.Checked == true)
            {
                g.gen = "masculino";
            }
            if (checkBox2.Checked == true)
            {
                g.gen = "feminino";
            }

            label5.Text = "Sendo que o seu género é " + g.gen + " o seu Índice \nde Massa Corporal é " + c.calc.ToString() + ".";

            if(checkBox1.Checked ==true & checkBox2.Checked==true || checkBox1.Checked ==false & checkBox2.Checked==false)
            {
                MessageBox.Show("O seu género não está definido");
            }

            /*if(c.peso > 22)
            {
                MessageBox.Show("Peso Abaixo da Média Recomendada");
            }*/

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Application.StartupPath + "\\Resources\\help.chm");
        }
    }
}
