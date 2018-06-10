namespace PPiatekWindowsFormsHelloWorld2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PokazMessageBox = new System.Windows.Forms.Button();
            this.imie = new System.Windows.Forms.Label();
            this.nazwisko = new System.Windows.Forms.Label();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.comboBoxLista = new System.Windows.Forms.ComboBox();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PokazMessageBox
            // 
            this.PokazMessageBox.Location = new System.Drawing.Point(162, 118);
            this.PokazMessageBox.Name = "PokazMessageBox";
            this.PokazMessageBox.Size = new System.Drawing.Size(110, 23);
            this.PokazMessageBox.TabIndex = 0;
            this.PokazMessageBox.Text = "Utwórz";
            this.PokazMessageBox.UseVisualStyleBackColor = true;
            this.PokazMessageBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // imie
            // 
            this.imie.AutoSize = true;
            this.imie.Location = new System.Drawing.Point(27, 28);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(32, 13);
            this.imie.TabIndex = 1;
            this.imie.Text = "Imię: ";
            // 
            // nazwisko
            // 
            this.nazwisko.AutoSize = true;
            this.nazwisko.Location = new System.Drawing.Point(27, 66);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(59, 13);
            this.nazwisko.TabIndex = 2;
            this.nazwisko.Text = "Nazwisko: ";
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(86, 21);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 3;
            this.textBoxImie.TextChanged += new System.EventHandler(this.textBoxImie_TextChanged);
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(86, 63);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 4;
            // 
            // comboBoxLista
            // 
            this.comboBoxLista.FormattingEnabled = true;
            this.comboBoxLista.Location = new System.Drawing.Point(30, 194);
            this.comboBoxLista.Name = "comboBoxLista";
            this.comboBoxLista.Size = new System.Drawing.Size(212, 21);
            this.comboBoxLista.TabIndex = 5;
            this.comboBoxLista.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(30, 118);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 23);
            this.buttonUsun.TabIndex = 6;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "pokaż dane";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "pokaz liste osób";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.comboBoxLista);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.PokazMessageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PokazMessageBox;
        private System.Windows.Forms.Label imie;
        private System.Windows.Forms.Label nazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.ComboBox comboBoxLista;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

