using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumCalisma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "Mikayil";
            ogr.Alani = 0;
            ogr.Alani = Alan.Sayisal;
            ogr.Alani = (Alan)10;
            Ogrenci ogr2 = new Ogrenci();
            ogr2.Adi = "Omar";
            ogr2.Cinsiyyeti = Cinsiyyet.Erkek;
            ogr2.Alani = (Alan)1;
            int sys = (int)Alan.Sayisal;
            MessageBox.Show(Enum.GetName(typeof(Alan),ogr2.Alani));
            string[] alanlar=Enum.GetNames(typeof(Alan));
        }
    }
}
