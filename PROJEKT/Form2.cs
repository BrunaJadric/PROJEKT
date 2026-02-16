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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void odaberisliku_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string slika = openFileDialog1.FileName;
            pictureBox1.Load(slika);
        }
        
        private void spremi_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string slika = openFileDialog1.FileName;
            string zapis= textBox1IME.Text + "|" + textBox2VRSTA.Text + "|" + textBox3PASMINA.Text + "|" + musko.Checked + ";" + zensko.Checked + "|" + dob.Text + "|" + datumdolaska.Text + "|" + checkBox1CIJEPLJEN.Checked + "|" + checkBox2KASTRIRAN.Checked + "|" + textBox4NAPOMENA.Text + "|" + slika;
            Admin.UnosZivotinje(zapis);
        }
    }
}
