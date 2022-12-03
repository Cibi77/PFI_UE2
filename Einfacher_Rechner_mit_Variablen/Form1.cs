using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A2_2_5
{
    public partial class Form1 : Form
    {
        float resultat = 0;
        int zahl1 = 0;
        int zahl2 = 0;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPlus_Click(object sender, EventArgs e)
        {
            //TxtResultat.Text = Convert.ToString(Convert.ToInt32(TxtZahl1.Text) + Convert.ToInt32(TxtZahl2.Text));
            zahl1 = Convert.ToInt32(TxtZahl1.Text);
            zahl2 = Convert.ToInt32(TxtZahl2.Text);
            resultat = zahl1 + zahl2;
            TxtResultat.Text = Convert.ToString(resultat);

        }

        private void CmdMinus_Click(object sender, EventArgs e)
        {
            TxtResultat.Text = Convert.ToString(Convert.ToInt32(TxtZahl1.Text) - Convert.ToInt32(TxtZahl2.Text));
        }

        private void CmdMal_Click(object sender, EventArgs e)
        {
            TxtResultat.Text = Convert.ToString(Convert.ToInt32(TxtZahl1.Text) * Convert.ToInt32(TxtZahl2.Text));
        }

        private void CmdDurch_Click(object sender, EventArgs e)
        {
            TxtResultat.Text = Convert.ToString(Convert.ToInt32(TxtZahl1.Text) / Convert.ToInt32(TxtZahl2.Text));
        }
    }
}
