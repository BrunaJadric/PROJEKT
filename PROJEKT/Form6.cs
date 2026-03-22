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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Statistika_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            List<string> lista = Admin.Ucitaj();
            int brojac = 0;
            foreach (string s in lista)
            { 
                brojac++;
            }
            Statistika.Items.Add("Broj zivotinja u azilu: " + brojac);
            List<string> udomitelj = Admin.UcitajUdomitelje();
            int udomljenih = 0;
            foreach (string s in udomitelj)
            {
                udomljenih++;
            }
            Statistika.Items.Add("Broj udomljenih zivotinja: " + udomljenih);
            Statistika.Items.Add("Broj zivotinja koje su još uvijek u azilu: " + (brojac - udomljenih));
            Statistika.Items.Add("Prosječna dob zivotinja u azilu: " + Admin.ProsjecnaDob() + " godina");


        }
    }
}
