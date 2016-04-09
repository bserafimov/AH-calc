using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Auction_House_Flip_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //var deposit = decimal.Parse(this.DepositBox.text);                    // enable for deposit things
                var deposit = 0M;
                var purch = decimal.Parse(this.PurchBox.Text);
                var sale = decimal.Parse(this.SaleBox.Text);
                var quantity = decimal.Parse(this.Quantity.Text);

                //var ProfitPer = ((sale * 0.95M) - purch - deposit) / quantity;        // replaces ln 28, with deposit calc included
                var ProfitPer = ((sale * 0.95M) - purch - deposit);                          // profit per item
                var Profit = ((sale * 0.95M) - purch - deposit) * quantity;                  // profit total
                ProfitPerBox.Text = ProfitPer.ToString("N2", CultureInfo.InvariantCulture);                               // prints profit per in profitper box
                TotalBox.Text = Profit.ToString("N2", CultureInfo.InvariantCulture);                                      // prints profit total in total box

                // break even calc + display
                
                var breven = purch * 20M / 19M;
                if (breven < 5)
                {
                    BreakEvenLabel.Text = breven.ToString("### ### ##0.#000");
                }
                else
                {
                    BreakEvenLabel.Text = breven.ToString("### ### ##0.#0");
                }




            }
            catch (Exception)
            {
                var error1 = "input numbers, you muppet!";
                PurchBox.Text = error1.ToString();
                SaleBox.Text = error1.ToString();
                ProfitPerBox.Text = error1.ToString();
                TotalBox.Text = error1.ToString();
                BreakEvenLabel.Text = error1.ToString();
            }
        }

        private void SaleBox_Enter_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(SaleBox.Text))
            {
                SaleBox.SelectionStart = 0;
                SaleBox.SelectionLength = SaleBox.Text.Length;
            }
        }
        private void SaleBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(SaleBox.Text))
            {
                SaleBox.SelectionStart = 0;
                SaleBox.SelectionLength = SaleBox.Text.Length;
            }
        }

        private void PurchBox_Enter(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(PurchBox.Text))
            {
                PurchBox.SelectionStart = 0;
                PurchBox.SelectionLength = PurchBox.Text.Length;
            }
        }
        private void PurchBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (!String.IsNullOrEmpty(PurchBox.Text))
            {
                PurchBox.SelectionStart = 0;
                PurchBox.SelectionLength = PurchBox.Text.Length;
            }
        }

    }
}
