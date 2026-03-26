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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Admin.Vrste().Distinct().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string kriterij = comboBox1.SelectedItem.ToString();
            List<string> vrste = Admin.PronadiPoVrsti(kriterij);
            foreach (string vrsta in vrste)
            {
                listBox1.Items.Add(vrsta.Replace("|", " "));
                
            }
        }

        private void osvježi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<string> lista = Admin.Ucitaj();
            foreach (string linija in lista)
            {
                listBox1.Items.Add(linija.Replace("|", " "));
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
