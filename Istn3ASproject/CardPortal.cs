using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Istn3ASproject
{
    public partial class CardPortal : Form
    {
        public static bool detailsEntered { get; set; }
        public CardPortal()
        {
            InitializeComponent();
        }

        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            string cardNum = txtCardNumber.Text;

            // Visa: Starts with 4, length 13 or 16
            if (cardNum.StartsWith("4"))
            {
                picCardType.Image = Image.FromFile("C:\\Users\\Student\\Source\\Repos\\ISTN3AS\\Istn3ASproject\\Resources\\visa.png");// Your Visa image
                picCardType.Visible = true;
                picCardType.SizeMode = PictureBoxSizeMode.Zoom;
                return;
            }

            // Mastercard: Starts with 51-55 or 2221-2720, length 16
            if (cardNum.StartsWith("5"))
            {
                picCardType.Image = Image.FromFile("C:\\Users\\Student\\Source\\Repos\\ISTN3AS\\Istn3ASproject\\Resources\\masterCard.png");// Your Mastercard image
                picCardType.Visible = true;
                picCardType.SizeMode = PictureBoxSizeMode.Zoom;
                return;
            }

            // No match
            picCardType.Visible = false;
        }

        private void btnConfirmBankCard_Click(object sender, EventArgs e)
        {
            

            int indexBank = cmbBank.SelectedIndex;

            if (indexBank == -1) { MessageBox.Show("Please Select a Bank"); }

            switch (indexBank)
            {
                case 0: picBankLogo.Image = Image.FromFile("C:\\Users\\Student\\Source\\Repos\\ISTN3AS\\Istn3ASproject\\Resources\\absa.png");
                    picBankLogo.Visible = true;
                    picBankLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    break;

                case 1:
                    picBankLogo.Image = Image.FromFile("C:\\Users\\Student\\Source\\Repos\\ISTN3AS\\Istn3ASproject\\Resources\\capitec.png");
                    picBankLogo.Visible = true;
                    picBankLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    break;

                case 2:    
                    picBankLogo.Image = Image.FromFile("C:\\Users\\Student\\Source\\Repos\\ISTN3AS\\Istn3ASproject\\Resources\\fnb.png");
                    picBankLogo.Visible = true;
                    picBankLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    break;

                case 3:   
                    picBankLogo.Image = Image.FromFile("C:\\Users\\Student\\Source\\Repos\\ISTN3AS\\Istn3ASproject\\Resources\\nedbank.png");
                    picBankLogo.Visible = true;
                    picBankLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    break;

                case 4:
                    picBankLogo.Image = Image.FromFile("C:\\Users\\Student\\Source\\Repos\\ISTN3AS\\Istn3ASproject\\Resources\\standardBank.png");
                    picBankLogo.Visible = true;
                    picBankLogo.SizeMode = PictureBoxSizeMode.Zoom;
                    break;
            }

            detailsEntered = true;

            frmPOS pos = Application.OpenForms.OfType<frmPOS>().FirstOrDefault();
            pos.isCardDetailsEntered(true);

           
            this.Hide();
           
           

        }
    }
}
