using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.DataAccess;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void firstNameValueTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void prizePercentageLabel_Click(object sender, EventArgs e)
        {

        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm(sender, e))
            {
                MessageBox.Show("This works!");
                PrizeModel model = new PrizeModel(
                    placeNameValueTextBox.Text, 
                    PlaceNumberValueTextBox1.Text, 
                    priceAmountValueTextBox.Text, 
                    prizePercantageValueTextBox.Text);

                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                placeNameValueTextBox.Text = "";
                PlaceNumberValueTextBox1.Text = "";
                priceAmountValueTextBox.Text = "0";
                prizePercantageValueTextBox.Text = "0";
            }
            else
            {
                MessageBox.Show("This does not work!");
            }
        }

        private bool ValidateForm(object sender, EventArgs e)
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumberValidNumber = int.TryParse(PlaceNumberValueTextBox1.Text, out placeNumber);
            
            if (!placeNumberValidNumber)
            {
                output = false;
            }
            
            if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameValueTextBox.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(priceAmountValueTextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(priceAmountValueTextBox.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }
            
            

            return output;
        }

        private void headerLabel1_Click(object sender, EventArgs e)
        {

        }

    }
}
