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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imieNazwiskoDB1DataSet1.Osoby' table. You can move, or remove it, as needed.
            this.osobyTableAdapter1.Fill(this.imieNazwiskoDB1DataSet1.Osoby);
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.osobyTableAdapter1.Update(this.imieNazwiskoDB1DataSet1.Osoby);
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.osobyTableAdapter1.Update(this.imieNazwiskoDB1DataSet1.Osoby);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int rowToDelete = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowToDelete);
            this.osobyTableAdapter1.Update(this.imieNazwiskoDB1DataSet1.Osoby);
        }
    }
}
