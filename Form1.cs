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
            texto t = new texto();
            c.peso = Convert.ToDouble(textBox1.Text);
            c.altura = Convert.ToDouble(textBox2.Text);
            c.calc = c.peso / (c.altura * c.altura);
            label4.Text = c.calc.ToString();

            if(checkBox1.Checked == true)
            {
                g.gen = g.masc;
            }
            if (checkBox2.Checked == true)
            {
                g.gen = g.fem;
            }

            if(checkBox1.Checked ==true & checkBox2.Checked==true || checkBox1.Checked ==false & checkBox2.Checked==false)
            {
                MessageBox.Show("O seu género não está definido");
            }

            if(c.calc < 18.5)
            {
                label5.Text = "Sendo que o seu género é " + g.gen + " o seu Índice \n" +
                    "de Massa Corporal é " + c.calc.ToString() + " com isto você está\n" +
                    "abaixo da média (Magro, Menos que 27.5Kg) \n";
            }

            if (c.calc > 18.5 && c.calc < 24.9 )
            {
                label5.Text = "Sendo que o seu género é " + g.gen + " o seu Índice \n" +
                    "de Massa Corporal é " + c.calc.ToString() + " com isto você está\n" +
                    "dentro da média recomendada (Normal, de 27.5Kg a 37.1Kg) \n";
            }

            if (c.calc > 24.9 && c.calc < 30)
            {
                label5.Text = "Sendo que o seu género é " + g.gen + " o seu Índice \n" +
                    "de Massa Corporal é " + c.calc.ToString() + " com isto você \n" +
                    "ultrapassa a media recomendada (Sobrepeso, de 37.5Kg a 44.7Kg) \n";
            }

            if (c.calc > 30)
            {
                label5.Text = "Sendo que o seu género é " + g.gen + " o seu Índice \n" +
                    "de Massa Corporal é " + c.calc.ToString() + " com isto você está\n" +
                    "no nivel de Obesidade Morbida (Oesidade, Mais que 44.7Kg) \n";
            }

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
