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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButtonNiesmiertelnik = new System.Windows.Forms.RadioButton();
            this.radioButtonGrawer = new System.Windows.Forms.RadioButton();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(243, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ile znaków?";
            this.toolTip2.SetToolTip(this.button1, "Przycisk oblicza ilośc znaków i sprawdza czy nie ma znaków niedozwolonych.\r\nW prz" +
        "ypadku nieśmiertelników zmienia znaki na duże i zamienia polskie na angielskie!");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(243, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 29);
            this.button3.TabIndex = 6;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButtonNiesmiertelnik
            // 
            this.radioButtonNiesmiertelnik.AutoSize = true;
            this.radioButtonNiesmiertelnik.Location = new System.Drawing.Point(16, 232);
            this.radioButtonNiesmiertelnik.Name = "radioButtonNiesmiertelnik";
            this.radioButtonNiesmiertelnik.Size = new System.Drawing.Size(151, 17);
            this.radioButtonNiesmiertelnik.TabIndex = 7;
            this.radioButtonNiesmiertelnik.Text = "Nieśmiertelnik (15 znaków)";
            this.radioButtonNiesmiertelnik.UseVisualStyleBackColor = true;
            // 
            // radioButtonGrawer
            // 
            this.radioButtonGrawer.AutoSize = true;
            this.radioButtonGrawer.Checked = true;
            this.radioButtonGrawer.Location = new System.Drawing.Point(16, 179);
            this.radioButtonGrawer.Name = "radioButtonGrawer";
            this.radioButtonGrawer.Size = new System.Drawing.Size(180, 17);
            this.radioButtonGrawer.TabIndex = 8;
            this.radioButtonGrawer.TabStop = true;
            this.radioButtonGrawer.Text = "Grawer (20 | 25 | 28 | 30 znaków)";
            this.radioButtonGrawer.UseVisualStyleBackColor = true;
            this.radioButtonGrawer.CheckedChanged += new System.EventHandler(this.radioButtonGrawer_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(317, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cofnij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 173);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wpisz tekst nieśmiertelnika/graweru:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(423, 153);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--Wybierz model z listy--",
            "Charge (20 znaków)",
            "Sidekick | Wingman (25 znaków)",
            "Surge | Wave (28 znaków)",
            "Rev (30 znaków)"});
            this.comboBox1.Location = new System.Drawing.Point(25, 202);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxResult.Location = new System.Drawing.Point(12, 274);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.ReadOnly = true;
            this.richTextBoxResult.Size = new System.Drawing.Size(399, 215);
            this.richTextBoxResult.TabIndex = 12;
            this.richTextBoxResult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 561);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButtonGrawer);
            this.Controls.Add(this.radioButtonNiesmiertelnik);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Nieśmiertelnik Tekst";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButtonNiesmiertelnik;
        private System.Windows.Forms.RadioButton radioButtonGrawer;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
    }
}

