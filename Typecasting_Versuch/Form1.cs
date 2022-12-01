using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typecasting_Versuch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdCalculate_Click(object sender, EventArgs e)
        {
            double var1 = 123.45454;
            int var2 = (int)var1;
            TxtResult.Text = Convert.ToString(var2);
        }
    }
}
