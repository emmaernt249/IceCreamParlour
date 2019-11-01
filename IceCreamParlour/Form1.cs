using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace IceCreamParlour
{
    public partial class Form1 : Form
    {
        Double baseCone = 1.70;
        Double BaseVanilla = 1;
        Double DrinkInput = 2;
        Double Dip = 0.50;
        Double TaxRate = 0.13;

        int coneAmount;
        int DrinkAmount;
        int DipAmount; 
        double Subtotal;
        double Tax;
        double Total;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // get values from the inputs and put them into 
            coneAmount = Convert.ToInt32(coneInput.Text);
            DrinkAmount = Convert.ToInt32(DrinkOutput.Text);
            DipAmount = Convert.ToInt32(DipOutput.Text);

            Subtotal = baseCone * coneAmount + DrinkAmount * DrinkInput + Dip * DipAmount;
            Tax = TaxRate * Subtotal;
            Total = Subtotal + Tax;

            subTotalOutput.Text = Subtotal.ToString("C");
            OutputTax.Text = Tax.ToString("C");
            TotalOutput.Text = Total.ToString("C");
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Refresh(); 
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush receiptBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);

            g.DrawString("I scream's ice cream", drawFont, receiptBrush, 260, 100);
            Thread.Sleep(500);

            g.DrawString("I scream's ice cream", drawFont, receiptBrush, 260, 100);
            g.DrawString("Cones : " + coneAmount, drawFont, receiptBrush, 260, 120);
            g.DrawString("@     $" + coneAmount * baseCone + BaseVanilla, drawFont, receiptBrush, 370, 120);
            Thread.Sleep(500);

            g.DrawString("drinks : " + DrinkAmount, drawFont, receiptBrush, 260, 140);
            g.DrawString("@     $" + DrinkAmount * DrinkInput, drawFont, receiptBrush, 370, 140);
            Thread.Sleep(500);

            g.DrawString("Dip   : " + DipAmount, drawFont, receiptBrush, 260, 160);
            g.DrawString("@     $" + DipAmount * Dip, drawFont, receiptBrush, 370, 160);
            Thread.Sleep(500);

            g.DrawString("Subtotal  : @     " + Subtotal.ToString("C"), drawFont, receiptBrush, 260, 200);
            Thread.Sleep(500);

            g.DrawString("Total   : ", drawFont, receiptBrush, 260, 220);
            g.DrawString("@     " + Total.ToString("C"), drawFont, receiptBrush, 370, 220);
            Thread.Sleep(500);

            g.DrawString("Tax   : ", drawFont, receiptBrush, 260, 240);
            g.DrawString("@     " + Tax.ToString("C"), drawFont, receiptBrush, 370, 240);
            Thread.Sleep(500);

            g.DrawString("Have a great day! ", drawFont, receiptBrush, 260, 280);
          
        }
    }
}
