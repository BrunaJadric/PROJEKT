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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int i = 0;

        private void Form3_Load(object sender, EventArgs e)
        {
            List<string> lista= Admin.Ucitaj();
            foreach(string linija in lista)
            {
                listBox1.Items.Add(linija.Replace("|", " "));
            }
            string[] prvi = lista[0].Split('|');
            textBox1ime.Text = prvi[0];
            textBox2vrsta.Text = prvi[1];
            textBox3pasmina.Text = prvi[2];
            textBox4spol.Text = prvi[3];
            textBox5dob.Text = prvi[4];
            textBox6datumdolaska.Text = prvi[5];
            textBox7cijepljen.Text = prvi[6];
            textBox8kastriran.Text = prvi[7];
            textBox9napomena.Text = prvi[8];
            pictureBox1.Load(prvi[9]);


        }

        private void button2naprijed_Click(object sender, EventArgs e)
        {
            List<string> lista = Admin.Ucitaj();
            i++;
            if (i < lista.Count)
            {
                string[] prvi = lista[i].Split('|');
                textBox1ime.Text = prvi[0];
                textBox2vrsta.Text = prvi[1];
                textBox3pasmina.Text = prvi[2];
                textBox4spol.Text = prvi[3];
                textBox5dob.Text = prvi[4];
                textBox6datumdolaska.Text = prvi[5];
                textBox7cijepljen.Text = prvi[6];
                textBox8kastriran.Text = prvi[7];
                textBox9napomena.Text = prvi[8];
                pictureBox1.Load(prvi[9]);
            }
            else
            {
                i = 0;
                string[] prvi = lista[i].Split('|');
                textBox1ime.Text = prvi[0];
                textBox2vrsta.Text = prvi[1];
                textBox3pasmina.Text = prvi[2];
                textBox4spol.Text = prvi[3];
                textBox5dob.Text = prvi[4];
                textBox6datumdolaska.Text = prvi[5];
                textBox7cijepljen.Text = prvi[6];
                textBox8kastriran.Text = prvi[7];
                textBox9napomena.Text = prvi[8];
                pictureBox1.Load(prvi[9]);

            }

        }

        private void button1natrag_Click(object sender, EventArgs e)
        {
            List<string> lista = Admin.Ucitaj();
            i--;
            if (i >= 0)
            {
                string[] prvi = lista[i].Split('|');
                textBox1ime.Text = prvi[0];
                textBox2vrsta.Text = prvi[1];
                textBox3pasmina.Text = prvi[2];
                textBox4spol.Text = prvi[3];
                textBox5dob.Text = prvi[4];
                textBox6datumdolaska.Text = prvi[5];
                textBox7cijepljen.Text = prvi[6];
                textBox8kastriran.Text = prvi[7];
                textBox9napomena.Text = prvi[8];
                pictureBox1.Load(prvi[9]);
            }
            else
            {
                i = lista.Count - 1;
                string[] prvi = lista[i].Split('|');
                textBox1ime.Text = prvi[0];
                textBox2vrsta.Text = prvi[1];
                textBox3pasmina.Text = prvi[2];
                textBox4spol.Text = prvi[3];
                textBox5dob.Text = prvi[4];
                textBox6datumdolaska.Text = prvi[5];
                textBox7cijepljen.Text = prvi[6];
                textBox8kastriran.Text = prvi[7];
                textBox9napomena.Text = prvi[8];
                pictureBox1.Load(prvi[9]);
            }
        }
    }
}
