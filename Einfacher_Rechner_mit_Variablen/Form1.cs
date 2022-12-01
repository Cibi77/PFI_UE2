using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_A2_1_3
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPlus_Click(object sender, EventArgs e)
        {
            TxtResultat.Text = Convert.ToString(Convert.ToInt32(TxtZahl1.Text) + Convert.ToInt32(TxtZahl2.Text));
            

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
