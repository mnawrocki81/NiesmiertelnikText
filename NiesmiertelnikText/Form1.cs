using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Collections;
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

        string previusText = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = "";

            if (radioButtonNiesmiertelnik.Checked)
            {

                previusText = richTextBox1.Text;
                richTextBox1.Text = ChangeText(richTextBox1.Text);
                NiesmiertelnikCount();
                CheckText();

            }

            if (radioButtonGrawer.Checked)
            {
                previusText = richTextBox1.Text;
                richTextBox1.Text = richTextBox1.Text;
                GrawerCount();
                CheckText();

            }
        }


        private string ChangeText(string text)
        {
            string newtext = text.ToUpper();
            string[,] polishmarks = {
          { "Ą", "A" }, { "Ć", "C" }, { "Ę", "E" }, { "Ł", "L" }, { "Ń", "N" },
          { "Ó", "O" }, { "Ś", "S" }, { "Ź", "Z" }, { "Ż", "Z" }, { "Ü", "U" },
          { "Ä", "A" }, { "Ö", "O" } };

            for (int i = 0; i < polishmarks.GetLength(0); i++)
            {
                newtext = newtext.Replace(polishmarks[i, 0], polishmarks[i, 1]);
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


        private void CheckText()
        {

            string signs = "";
            string letters = "";

            ArrayList badSign = new ArrayList();

            if (radioButtonNiesmiertelnik.Checked)
            {
                letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                signs = "!()?.,'@~ &*:/\"\n+-";
            }
            else
            {
                letters = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPQRSTUVWXYZŻŹ";
                signs = "!()?.,'@~ &*:/\"\n+-%";
            }

            string numbers = "0123456789";

            for (int i = 0; i < richTextBox1.Text.Length; i++)
            {
                bool goodSign = false;

                for (int j = 0; j < signs.Length; j++)
                {
                    if (richTextBox1.Text[i].Equals(signs[j]))
                    {
                        goodSign = true;
                        break;
                    }
                }

                if (goodSign == false)
                {
                    for (int j = 0; j < letters.Length; j++)
                    {
                        if (string.Equals(richTextBox1.Text[i].ToString(), letters[j].ToString(), StringComparison.OrdinalIgnoreCase))
                        {
                            goodSign = true;
                            break;
                        }
                    }
                }

                if (goodSign == false)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (richTextBox1.Text[i].Equals(numbers[j]))
                        {
                            goodSign = true;
                            break;
                        }
                    }
                }

                if (goodSign == false)
                {
                    badSign.Add(i);
                }
            }

            if (badSign.Count > 0)
                MessageBox.Show("Tekst zawiera niedozwolne znaki! Popraw podświetlone i zaznaczone na czerwono znaki!");

            foreach (int sign in badSign)
            {
                richTextBox1.Select(sign, 1);
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.SelectionFont = new Font("Sans Serif", 12, FontStyle.Bold);
                richTextBox1.SelectionBackColor = Color.White;
            }
        }

        private void GrawerCount()
        {
            int count = richTextBox1.Lines.Count();

            label1.Text = ($"W linii jest {richTextBox1.Lines[0].Length} znaków. ");

            if (richTextBox1.Lines[0].Length > 28)
                label1.Text += "ZA DUŻO ZNAKÓW!!!";

            if (count > 1)
                label1.Text += ("\nDOZWOLONA MAX. 1 LINIA! POPRAW TEKST!");
        }

        private void NiesmiertelnikCount()
        {
            int count = richTextBox1.Lines.Count();

            for (int i = 0; i < count; i++)
            {
                if (i > 4)
                {
                    label1.Text += ("DOZWOLONE MAX. 5 LINII! POPRAW TEKST!");
                    break;
                }

                label1.Text += ($"W {i + 1} linii jest {richTextBox1.Lines[i].Length} znaków. ");

                if (richTextBox1.Lines[i].Length > 15)
                    label1.Text += "ZA DUŻO ZNAKÓW!!!";

                label1.Text += ("\n");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = previusText;
        }


    }
}