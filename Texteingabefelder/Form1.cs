using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texteingabefelder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtmAusgeben_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = TxtVorname.Text + " " + TxtNachname.Text;
        }

        private void BtmLoeschen_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = "...";
            TxtVorname.Text = "";
            TxtNachname.Text = "";
         }
    }
}
