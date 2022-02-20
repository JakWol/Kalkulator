using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        


        public double? liczbaA = null;
        public double? liczbaB = null;
        public double? wynik = null;
        public char? znakOperacji=null;

        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private Boolean textBox_disableInput()
        {
            if (textBox1.Text.Length == 6)
            {
                textBox1.Text = textBox1.Text;
                return false;
            }
            return true;
        }

        private void jeden_Click(object sender, EventArgs e)
        {
            if (textBox_disableInput() == true)
            {
                textBox1.Text = textBox1.Text + "1";
            }
            
            
        }

        private void dwa_Click(object sender, EventArgs e)
        {
            if (textBox_disableInput() == true)
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void trzy_Click(object sender, EventArgs e)
        {
            if (textBox_disableInput() == true)
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void cztery_Click(object sender, EventArgs e)
        {
            if (textBox_disableInput() == true)
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void piec_Click(object sender, EventArgs e)
        {
            if (textBox_disableInput() == true)
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void szesc_Click(object sender, EventArgs e)
        {
            if (textBox_disableInput() == true)
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void siedem_Click(object sender, EventArgs e)
        {
            if (textBox_disableInput() == true)
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void osiem_Click(object sender, EventArgs e)
        {
            if (textBox_disableInput() == true)
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void dziewiec_Click(object sender, EventArgs e)
        {
            if (textBox_disableInput() == true)
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (textBox_disableInput() == true)
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" && liczbaA == null)
            {
                textBox1.Text = textBox1.Text;
                znakOperacji = null;
            } else if (znakOperacji == '*' || znakOperacji == '/' || znakOperacji == '+' || znakOperacji == '-')
            {
                textBox1.Text = "" + wynik;
                znakOperacji = null;
            } else 
            liczbaA = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            znakOperacji = '+';

        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && liczbaA == null)
            {
                textBox1.Text = textBox1.Text;
                znakOperacji = null;
            }
            else if(znakOperacji == '*' || znakOperacji == '/' || znakOperacji == '+' || znakOperacji == '-')
            {
                textBox1.Text = "" + wynik;
                znakOperacji = null;
            }
            else
            liczbaA = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            znakOperacji = '-';
        }

        private void rownaSie_Click(object sender, EventArgs e)
        {

            if(textBox1.Text == "")
            {
                textBox1.Text = textBox1.Text + wynik;
                znakOperacji = null;
            } else

             switch(znakOperacji)
            {
                case '+':

                    liczbaB = Convert.ToDouble(textBox1.Text);
                    wynik = liczbaA + liczbaB;
                    textBox1.Text = wynik+"";
                    znakOperacji = null;
                    break;
                case '-':
                    liczbaB = Convert.ToDouble(textBox1.Text);
                    wynik = liczbaA - liczbaB;
                    textBox1.Text = wynik + "";
                    znakOperacji = null;
                    break;
                case '*':
                    liczbaB = Convert.ToDouble(textBox1.Text);
                    wynik = liczbaA * liczbaB;
                    textBox1.Text = wynik + "";
                    znakOperacji = null;
                    break;
                case '/':
                    
                    liczbaB = Convert.ToDouble(textBox1.Text);
                    if (liczbaB == 0)
                    {
                        MessageBox.Show("Pamietaj megiero, nie dziel przez zero");
                        break;
                    }
                    wynik = liczbaA / liczbaB;
                    textBox1.Text = wynik + "";
                    znakOperacji = null;
                    break;

                default:
                    textBox1.Text = wynik + "" ;
                    break;

            }
            

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            liczbaA = null;
            liczbaB = null;
            wynik = null;
        }

        private void mnozenie_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && liczbaA == null)
            {
                textBox1.Text = textBox1.Text;
                znakOperacji = null;
            }
            else if (znakOperacji == '*'|| znakOperacji == '/' || znakOperacji == '+' || znakOperacji == '-')
            {
                textBox1.Text = "" + wynik;
                znakOperacji = null;
            }
            else
                liczbaA = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            znakOperacji = '*';
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && liczbaA == null)
            {
                textBox1.Text = textBox1.Text;
                znakOperacji = null;
            }
            else if (znakOperacji == '*' || znakOperacji == '/' || znakOperacji == '+' || znakOperacji == '-')
            {
                textBox1.Text = "" + wynik;
                znakOperacji = null;
            }
            else
                
            liczbaA = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            znakOperacji = '/';
        }

        private void przecinek_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('.'))
            {
                textBox1.Text = textBox1.Text;
            } else if (textBox1.Text == "")
            {
                textBox1.Text = "";
            }else
            textBox1.Text = textBox1.Text + '.';
            
            
        }

        private void pierwiastek_Click(object sender, EventArgs e)
        {
         
            if (textBox1.Text == "" && liczbaA == null)
            {
                MessageBox.Show("nullll");
                textBox1.Text = textBox1.Text;
                znakOperacji = null;
            }
            else if (liczbaA <= 0)
            {

                MessageBox.Show("Nie moge wykonac pierwiastka z liczby " + textBox1.Text);
            }
            else if (textBox1.Text != "")
            {
                liczbaA = Convert.ToDouble(textBox1.Text);
                liczbaA = Math.Sqrt(liczbaA.Value);
                textBox1.Text = liczbaA + "";
            }
        }
    }
}
