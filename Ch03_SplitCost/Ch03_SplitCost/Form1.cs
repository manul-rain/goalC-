using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch03_SplitCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void culcButton_Click(object sender, EventArgs e)
        {
            int money = int.Parse(nonTaxBox.Text);
            const double tax = 0.08;
            double addTax = 0;
            int per = 0;
            int pnum = int.Parse(num.Text);
            int surp = 0;

            addTax = money;
            addTax *= (1 + tax);
            money = (int)addTax;

            per = money / pnum;
            perOne.Text = per + "円";

            surp = money % per;
            surplus.Text = surp + "円";

        }
    }
}
