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
           
            string slika = openFileDialog1.FileName;
            string spol = "";
            string kastriran = "";
            if(checkBox2KASTRIRAN.Checked==true)
            {
                kastriran="kastriran";
            }
            else
            {
                kastriran="nekastriran";
            }
            string cijepljen = "";
            if(checkBox1CIJEPLJEN.Checked==true)
            {
                cijepljen = "cijepljen";
            }
            else
            {
                cijepljen = "necijepljen";
            }
             if(musko.Checked==true)
            {
                spol = "musko";
            }
             else
            {
                spol = "zensko";
            }
            string zapis = textBox1IME.Text + "|" + textBox2VRSTA.Text + "|" + textBox3PASMINA.Text + "|" + spol + "|" + dob.Text + "|" + datumdolaska.Text + "|" + cijepljen + "|" + kastriran + "|" + textBox4NAPOMENA.Text + "|" + slika;
            Admin.UnosZivotinje(zapis);
            textBox1IME.Clear();
            textBox2VRSTA.Clear();
            textBox3PASMINA.Clear();
             musko.Checked = false;
             zensko.Checked = false;
             dob.Value = 0;
             datumdolaska.Value = DateTime.Now;
             checkBox1CIJEPLJEN.Checked = false;
             checkBox2KASTRIRAN.Checked = false;
             textBox4NAPOMENA.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
