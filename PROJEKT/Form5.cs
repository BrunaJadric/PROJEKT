using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int i = 0;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            List<string> lista = Admin.Ucitaj();
            foreach (string s in lista)
            {
                Nasezivotinje.Items.Add(s.Replace("|", " "));

            }
        }

        private void Nasezivotinje_DoubleClick(object sender, EventArgs e)
        {
            i = Nasezivotinje.SelectedIndex;

        }

        private void Udomi_Click(object sender, EventArgs e)
        {
            Nasezivotinje.Items.RemoveAt(i);
            string zapis = textBox1datumu.Text + "|" + textBox2udomitelj + "|" + textBox3kontakt.Text;
            Admin.UnosUdomitelja(zapis);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
