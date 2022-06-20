using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section2Project
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        public string convertMethod(int x)
        { 
            string remainderString = "";
            int remainder = 0;
            int y = Convert.ToInt32(txtConvert.Text);
            while (y != 0)

            {
                remainder = y % x;

                if (remainder == 10)
                {
                    remainderString = "A" + remainderString;
                }
                else if (remainder == 11)
                {
                    remainderString = "B" + remainderString;
                }
                else if (remainder == 12)
                {
                    remainderString = "C" + remainderString;
                }
                else if (remainder == 13)
                {
                    remainderString = "D" + remainderString;
                }
                else if (remainder == 14)
                {
                    remainderString = "E" + remainderString;
                }
                else if (remainder == 15)
                {
                    remainderString = "F" + remainderString;
                }
                else
                {
                    remainderString = remainder + remainderString;
                }
                y = (y - remainder) / x;
            }
            return remainderString;
        }

        private void txtConvert_TextChanged(object sender, EventArgs e)
        {
            if (txtConvert.Text != "" && txtBase.Text != "")
            {
                txtBase.Enabled = true;
            }
            else if (txtConvert.Text != "")
            {
                btnBinary.Enabled = true;
                btnHex.Enabled = true;
                btnOctal.Enabled = true;
                btnSix.Enabled = true;
                btnEleven.Enabled = true;
            }
            else
            {
                btnConvert.Enabled = false;
            }
        }

        private void txtBase_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConvert.Text = " ";
            txtBase.Text = " ";
            lblMessage.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            try
            {

                decimal d;

                if (decimal.TryParse(txtConvert.Text, out d))
                {
                    lblMessage.Text = "Please choose a whole number.";
                }

                int t;

                if (!Int32.TryParse(txtConvert.Text, out t))
                {
                    lblMessage.Text = "Please choose a whole number.";
                }

                else
                {
                    int x = 2;
                    string convertNum = this.convertMethod(x);
                    lblMessage.Text = "2x" + convertNum;
                }
            }
            catch (FormatException) { }
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            try
            {

                decimal d;

                if (decimal.TryParse(txtConvert.Text, out d))
                {
                    lblMessage.Text = "Please choose a whole number.";
                }

                int t;

                if (!Int32.TryParse(txtConvert.Text, out t))
                {
                    lblMessage.Text = "Please choose a whole number.";
                }

                else
                {
                    int x = 16;
                    string convertNum = this.convertMethod(x);
                    lblMessage.Text = "0x" + convertNum;
                }
            }
            catch (FormatException) { }
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            try
            {

                decimal d;

                if (decimal.TryParse(txtConvert.Text, out d))
                {
                    lblMessage.Text = "Please choose a whole number.";
                }

                int t;

                if (!Int32.TryParse(txtConvert.Text, out t))
                {
                    lblMessage.Text = "Please choose a whole number.";
                }

                else
                {
                    int x = 8;
                    string convertNum = this.convertMethod(x);
                    lblMessage.Text = "8x" + convertNum;
                }
            }
            catch (FormatException) { }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            try
            {

                decimal d;

                if (decimal.TryParse(txtConvert.Text, out d))
                {
                    lblMessage.Text = "Please choose a whole number.";
                }

                int t;

                if (!Int32.TryParse(txtConvert.Text, out t))
                {
                    lblMessage.Text = "Please choose a whole number.";
                }

                else
                {
                    int x = 6;
                    string convertNum = this.convertMethod(x);
                    lblMessage.Text = "6x" + convertNum;
                }
            }
            catch (FormatException) { }
        }

        private void btnEleven_Click(object sender, EventArgs e)
        {
            try
            {

                decimal d;

                if (decimal.TryParse(txtConvert.Text, out d))
                {
                    lblMessage.Text = "Please choose a whole number.";
                }

                int t;

                if (!Int32.TryParse(txtConvert.Text, out t))
                {
                    lblMessage.Text = "Please choose a whole number.";
                }

                else
                {
                    int x = 11;
                    string convertNum = this.convertMethod(x);
                    lblMessage.Text = "11x" + convertNum;
                }
            }
            catch (FormatException) { }
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                
                decimal d;

                if (decimal.TryParse(txtBase.Text, out d))
                {
                    lblMessage.Text = "Please choose a whole base ranging from 2 through 16";
                }

                int x; 

                if (!Int32.TryParse(txtBase.Text, out x))
                {
                    lblMessage.Text = "Please choose a whole base ranging from 2 through 16";
                }

                
                int userBase = (Convert.ToInt32(txtBase.Text));

                if (userBase < 2)
                {
                    lblMessage.Text = "Please choose a whole base ranging from 2 through 16";
                }
                if (userBase > 16)
                {
                    lblMessage.Text = "Please choose a whole base ranging from 2 through 16";
                }
                else
                {
                    string convertNum = this.convertMethod(x);
                    if (x == 16)
                        x = 0;
                    lblMessage.Text = x + "x" + convertNum;
                }
            }
            catch (FormatException) { }
        }

        private void lblBase_Click(object sender, EventArgs e)
        {

        }

        private void lblConvert_Click(object sender, EventArgs e)
        {

        }
    }
}
