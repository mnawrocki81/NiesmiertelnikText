using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiesmiertelnikText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ChangeText(richTextBox1.Text);

            int count = richTextBox1.Lines.Count();
            label1.Text = "";

            for (int i = 0; i < count; i++)
            {

                label1.Text += ($"W {i + 1} linii jest {richTextBox1.Lines[i].Length} znaków. ");

                if (richTextBox1.Lines[i].Length > 15)
                    label1.Text += "ZA DUŻO ZNAKÓW!!!";

                label1.Text += ("\n");

            }

        }



        private string ChangeText(string text)
        {
            string newtext = text.ToUpper();
            string[,] polskieznaki = {
          { "Ą", "A" }, { "Ć", "C" }, { "Ę", "E" }, { "Ł", "L" }, { "Ń", "N" },
          { "Ó", "O" }, { "Ś", "S" }, { "Ź", "Z" }, { "Ż", "Z" }, { "Ü", "U" } };
            for (int i = 0; i < polskieznaki.GetLength(0); i++)
            {
                newtext = newtext.Replace(polskieznaki[i, 0], polskieznaki[i, 1]);
            }

            return newtext;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            label1.Text = "";
        }
    }
}
