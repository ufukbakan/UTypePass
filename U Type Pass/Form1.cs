using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U_Type_Pass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string U1_Sifreleme(string gelensifre)
        {
            char[] gelen_sifre_karakterleri = new char[gelensifre.Length];
            for (short i=0; i< gelensifre.Length; i++)
            {
                gelen_sifre_karakterleri[i] = gelensifre[i];
                short temp;
                temp = (short) gelen_sifre_karakterleri[i];
                if(temp <= 57 && temp >= 48)
                {
                    if (temp % 57 != temp)
                        temp = (short) (48 + (temp % 57));
                    else
                    {
                        temp = (short)(temp * 1.1 - 3);
                    }

                }
                else
                {
                    temp = (short) (temp / 2 + 60);
                }
                gelen_sifre_karakterleri[i] = (char)(temp);

            }
            return (new string(gelen_sifre_karakterleri));
        }

        private string U2_Sifreleme(string gelensifre)
        {
            char[] gelen_sifre_karakterleri = new char[gelensifre.Length];
            for (short i = 0; i < gelensifre.Length; i++)
            {
                gelen_sifre_karakterleri[i] = gelensifre[i];
                short temp;
                temp = (short)gelen_sifre_karakterleri[i];
                if (temp <= 57 && temp >= 48)
                {
                    if (temp % 57 != temp)
                        temp = (short)((temp - 2));
                    else
                    {
                        temp = (short)(temp - 3);
                    }

                }
                else
                {
                    if (temp % 2 == 0)
                        temp = (short)(temp + 2);
                    else
                        temp = (short)(temp + 1);

                }
                gelen_sifre_karakterleri[i] = (char)(temp);

            }

            return (new string(gelen_sifre_karakterleri));
        }

        private string U3_Sifreleme (string gelensifre)
        {
            char[] gelen_sifre_karakterleri = new char[(gelensifre.Length)*2];
            for (short i = 0; i < gelensifre.Length; i++)
            {
                gelen_sifre_karakterleri[i] = gelensifre[i];
                short temp;
                temp = (short)gelen_sifre_karakterleri[i];
                if (temp <= 57 && temp >= 48)
                {
                    if (temp % 57 != temp)
                        temp = (short)((temp - 2));
                    else
                    {
                        temp = (short)(temp - 3);
                    }

                }
                else
                {
                    if (temp % 2 == 0)
                        temp = (short)(temp + 2);
                    else
                        temp = (short)(temp + 4);

                }
                gelen_sifre_karakterleri[i] = (char)(temp);
                gelen_sifre_karakterleri[gelensifre.Length*2 - i - 1] = (char)(temp);

            }

            return (new string(gelen_sifre_karakterleri));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = U1_Sifreleme(textBox1.Text);
            textBox3.Text = textBox2.Text.ToUpper();
            textBox4.Text = U2_Sifreleme(textBox1.Text);
            textBox5.Text = textBox4.Text.ToUpper();
            textBox6.Text = U3_Sifreleme(textBox1.Text);
            textBox7.Text = textBox6.Text.ToUpper();

        }
    }
}
