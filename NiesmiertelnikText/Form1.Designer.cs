namespace NiesmiertelnikText
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButtonNiesmiertelnik = new System.Windows.Forms.RadioButton();
            this.radioButtonGrawer = new System.Windows.Forms.RadioButton();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 51);
            this.richTextBox1.MaxLength = 1000;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(365, 132);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = ".";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(190, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ile znaków?";
            this.toolTip2.SetToolTip(this.button1, "Przycisk oblicza ilośc znaków i sprawdza czy nie ma znaków niedozwolonych.\r\nW prz" +
        "ypadku nieśmiertelników zmienia znaki na duże i zamienia polskie na angielskie!");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wpisz tekst nieśmiertelnika/graweru:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(313, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 49);
            this.button3.TabIndex = 6;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButtonNiesmiertelnik
            // 
            this.radioButtonNiesmiertelnik.AutoSize = true;
            this.radioButtonNiesmiertelnik.Checked = true;
            this.radioButtonNiesmiertelnik.Location = new System.Drawing.Point(16, 200);
            this.radioButtonNiesmiertelnik.Name = "radioButtonNiesmiertelnik";
            this.radioButtonNiesmiertelnik.Size = new System.Drawing.Size(151, 17);
            this.radioButtonNiesmiertelnik.TabIndex = 7;
            this.radioButtonNiesmiertelnik.TabStop = true;
            this.radioButtonNiesmiertelnik.Text = "Nieśmiertelnik (15 znaków)";
            this.radioButtonNiesmiertelnik.UseVisualStyleBackColor = true;
            // 
            // radioButtonGrawer
            // 
            this.radioButtonGrawer.AutoSize = true;
            this.radioButtonGrawer.Location = new System.Drawing.Point(16, 223);
            this.radioButtonGrawer.Name = "radioButtonGrawer";
            this.radioButtonGrawer.Size = new System.Drawing.Size(120, 17);
            this.radioButtonGrawer.TabIndex = 8;
            this.radioButtonGrawer.Text = "Grawer (28 znaków)";
            this.radioButtonGrawer.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cofnij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 501);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButtonGrawer);
            this.Controls.Add(this.radioButtonNiesmiertelnik);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Nieśmiertelnik Tekst";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButtonNiesmiertelnik;
        private System.Windows.Forms.RadioButton radioButtonGrawer;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button button2;
    }
}

