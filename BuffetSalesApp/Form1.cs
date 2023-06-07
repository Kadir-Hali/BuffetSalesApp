using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuffetSalesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kasaTutar = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, cay, su, bilet, toplam;
            misir = Convert.ToInt16(TxtMisir.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            su = Convert.ToInt16(TxtSu.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            toplam = misir * 40 + su * 7 + cay * 10 + bilet * 70;
            LblToplam.Text = toplam.ToString() + " TL";

            kasaTutar = kasaTutar + toplam;
            LblKasa.Text = kasaTutar.ToString() + " TL";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtMisir.Text = "";
            TxtCay.Text = "";
            TxtSu.Text = "";
            TxtBilet.Text = "";
            this.ActiveControl = TxtMisir;
        }
    }
}
