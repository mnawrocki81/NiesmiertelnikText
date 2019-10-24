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
            comboBox1.SelectedIndex = 0;
        }

        
        string previusText = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            previusText = richTextBox1.Text;
            TextTrimEnd();
            string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            

            if (radioButtonNiesmiertelnik.Checked)
            {
                CountTheCharacters(5,15);
                ChangeText();
                CheckText();
            }

            if (radioButtonGrawer.Checked) 
            {

                if (selectedItem.Contains("Charge (20 znaków)"))
                    CountTheCharacters(1, 20);
                else if (selectedItem.Contains("Sidekick | Wingman (25 znaków)"))
                    CountTheCharacters(1, 25);
                else if (selectedItem.Contains("Surge | Wave (28 znaków)"))
                    CountTheCharacters(1, 28);
                else if (selectedItem.Contains("Rev (30 znaków)"))
                    CountTheCharacters(1, 30);


                richTextBox1.Text = richTextBox1.Text;
                CheckText();
            }
        }
        
        private void TextTrimEnd()
        {
            int count = richTextBox1.Lines.Count();
            string tempRichTextBox1 = "";

            for (int i=0; i<count; i++)
            {
                tempRichTextBox1 += richTextBox1.Lines[i].TrimEnd();

                if (i != count - 1)
                    tempRichTextBox1 += "\n";
            }

            richTextBox1.Text = tempRichTextBox1;

        }
     
        private void ChangeText()
        {
            richTextBox1.Text = richTextBox1.Text.ToUpper();
            string[,] polishmarks = {
          { "Ą", "A" }, { "Ć", "C" }, { "Ę", "E" }, { "Ł", "L" }, { "Ń", "N" },
          { "Ó", "O" }, { "Ś", "S" }, { "Ź", "Z" }, { "Ż", "Z" }, { "Ü", "U" },
          { "Ä", "A" }, { "Ö", "O" } };

            for (int i = 0; i < polishmarks.GetLength(0); i++)
            {
                richTextBox1.Text = richTextBox1.Text.Replace(polishmarks[i, 0], polishmarks[i, 1]);
            }
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
                letters = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPQRSŚTUVWXYZŻŹ";
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


        private void CountTheCharacters(int numberOfLines, int numberOfCharacters)
        {
            int countTheLines = richTextBox1.Lines.Count();

            for (int i = 0; i < countTheLines; i++)
            {

                label1.Text += ($"W {i + 1} linii jest {richTextBox1.Lines[i].Length} znaków. ");

                if (richTextBox1.Lines[i].Length > numberOfCharacters)
                    label1.Text += $"ZA DUŻO ZNAKÓW O {richTextBox1.Lines[i].Length - numberOfCharacters} !!!";

                label1.Text += ("\n");
                
                if (i == numberOfLines - 1 && countTheLines > numberOfLines)
                    label1.Text += ($"DOZWOLONA MAX. ILOŚĆ LINII: {numberOfLines}! POPRAW TEKST!\n");
                    
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            label1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = previusText;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonGrawer_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}