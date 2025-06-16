using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Istn3ASproject
{
    public partial class CardPortal : Form
    {
        public CardPortal()
        {
            InitializeComponent();
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            string cardNum = txtCardNumber.Text;

            // Visa: Starts with 4, length 13 or 16
            if (cardNum.StartsWith("4") && (cardNum.Length == 13 || cardNum.Length == 16))
            { 
                //picCardType.Image = Properties.Resources.; // Your Visa image
                picCardType.Visible = true;
                return;
            }

            // Mastercard: Starts with 51-55 or 2221-2720, length 16
            if ((cardNum.StartsWith("5") && cardNum.Length == 16 &&
                 cardNum[1] >= '1' && cardNum[1] <= '5') ||
                (cardNum.Length >= 4 && int.Parse(cardNum.Substring(0, 4)) >= 2221 &&
                 int.Parse(cardNum.Substring(0, 4)) <= 2720 && cardNum.Length == 16))
            {
               // picCardType.Image = Properties.Resources.mastercard; // Your Mastercard image
                picCardType.Visible = true;
                return;
            }

            // No match
            picCardType.Visible = false;
        }
    }
}
