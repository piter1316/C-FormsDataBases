using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PPiatekWindowsFormsHelloWorld2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Osoba osoba1 = new Osoba { Imie = textBoxImie.Text, Nazwisko = textBoxNazwisko.Text };
            List<Osoba> listaOsob = new List<Osoba>();
            listaOsob.Add(osoba1);


            comboBoxLista.Items.Add(osoba1.Imie + " " + osoba1.Nazwisko);

            //comboBoxLista.Items.Add(listaOsob[0]);



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            var last = comboBoxLista.Items.Count;
            comboBoxLista.Items.RemoveAt(last - 1);
        }

        private void textBoxImie_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}

