using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class Form1 : Form
    {
        double amount;
        double w_pln;
        double exchangeValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fromList.SelectedItem.ToString() == toList.SelectedItem.ToString())
            {
                displayLabel.Text = convertFrom_box.Text;
            }
            #region PLNtoOTHER
            if ((fromList.SelectedItem.ToString() == "PLN") && (toList.SelectedItem.ToString() == "USD"))
            {
                amount = Convert.ToDouble(convertFrom_box.Text);
                exchangeValue = amount * 0.28;
                displayLabel.Text = exchangeValue.ToString() + toList.SelectedItem.ToString();
                exchangeRateLabel.Text = "1 USD = 3.57 PLN";
            }
            if ((fromList.SelectedItem.ToString() == "PLN") && (toList.SelectedItem.ToString() == "EUR"))
            {
                amount = Convert.ToDouble(convertFrom_box.Text);
                exchangeValue = amount * 0.24;
                displayLabel.Text = exchangeValue.ToString() + toList.SelectedItem.ToString();
                exchangeRateLabel.Text = "1 EUR = 4.20 PLN";
            }
            if ((fromList.SelectedItem.ToString() == "PLN") && (toList.SelectedItem.ToString() == "GBP"))
            {
                amount = Convert.ToDouble(convertFrom_box.Text);
                exchangeValue = amount * 0.21;
                displayLabel.Text = exchangeValue.ToString() + toList.SelectedItem.ToString();
                exchangeRateLabel.Text = "1 GBP = 4.79 PLN";
            }
            #endregion
            #region EURtoOTHER
            if ((fromList.SelectedItem.ToString() == "EUR") && (toList.SelectedItem.ToString() == "PLN"))
            {
                amount = Convert.ToDouble(convertFrom_box.Text);
                exchangeValue = amount / 0.24;
                displayLabel.Text = exchangeValue.ToString() + toList.SelectedItem.ToString();
                exchangeRateLabel.Text = "1 EUR = 4.20 PLN";
            }
            if ((fromList.SelectedItem.ToString() == "EUR") && (toList.SelectedItem.ToString() == "USD"))
            {
                amount = Convert.ToDouble(convertFrom_box.Text);
                exchangeValue = amount / 0.24 * 0.28;
                displayLabel.Text = exchangeValue.ToString() + toList.SelectedItem.ToString();
                exchangeRateLabel.Text = "1 EUR = 1.18 USD";
            }
            if ((fromList.SelectedItem.ToString() == "EUR") && (toList.SelectedItem.ToString() == "GBP"))
            {
                amount = Convert.ToDouble(convertFrom_box.Text);
                exchangeValue = amount / 0.24 * 0.21;
                displayLabel.Text = exchangeValue.ToString() + toList.SelectedItem.ToString();
                exchangeRateLabel.Text = "1 EUR = 0.88 GBP";
            }
            #endregion
            #region USDtoOTHER
            if ((fromList.SelectedItem.ToString() == "USD") && (toList.SelectedItem.ToString() == "PLN"))
            {
                amount = Convert.ToDouble(convertFrom_box.Text);
                exchangeValue = amount / 0.28;
                displayLabel.Text = exchangeValue.ToString() + toList.SelectedItem.ToString();
                exchangeRateLabel.Text = "1 USD = 3.57 PLN";
            }
            if ((fromList.SelectedItem.ToString() == "USD") && (toList.SelectedItem.ToString() == "EUR"))
            {
                amount = Convert.ToDouble(convertFrom_box.Text);
                exchangeValue = amount / 0.28 * 0.24;
                displayLabel.Text = exchangeValue.ToString() + toList.SelectedItem.ToString();
                exchangeRateLabel.Text = "1 USD = 0.85 USD";
            }
            if ((fromList.SelectedItem.ToString() == "USD") && (toList.SelectedItem.ToString() == "GBP"))
            {
                amount = Convert.ToDouble(convertFrom_box.Text);
                exchangeValue = amount / 0.28 * 0.21;
                displayLabel.Text = exchangeValue.ToString() + toList.SelectedItem.ToString();
                exchangeRateLabel.Text = "1 USD = 0.75 GBP";
            }
            #endregion
            #region GBPtoOTHER
            if ((fromList.SelectedItem.ToString() == "GBP") && (toList.SelectedItem.ToString() == "PLN"))
            {
                amount = Convert.ToDouble(convertFrom_box.Text);
                exchangeValue = amount / 0.21;
                displayLabel.Text = exchangeValue.ToString() + toList.SelectedItem.ToString();
                exchangeRateLabel.Text = "1 PLN = 4.79 GBP";
            }
            if ((fromList.SelectedItem.ToString() == "GBP") && (toList.SelectedItem.ToString() == "USD"))
            {
                amount = Convert.ToDouble(convertFrom_box.Text);
                exchangeValue = amount / 0.24 * 0.28;
                displayLabel.Text = exchangeValue.ToString() + toList.SelectedItem.ToString();
                exchangeRateLabel.Text = "1 EUR = 1.18 USD";
            }
            if ((fromList.SelectedItem.ToString() == "GBP") && (toList.SelectedItem.ToString() == "EUR"))
            {
                amount = Convert.ToDouble(convertFrom_box.Text);
                exchangeValue = amount / 0.24 * 0.21;
                displayLabel.Text = exchangeValue.ToString() + toList.SelectedItem.ToString();
                exchangeRateLabel.Text = "1 EUR = 0.88 GBP";
            }
            #endregion
        }

        private void convertFrom_box_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
