using System;
using System.Windows.Forms;

namespace MarginCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            // ...

            if (double.TryParse(SellPriceTextBox.Text, out double sellPrice) &&
                double.TryParse(BuyPriceTextBox.Text, out double buyPrice) &&
                double.TryParse(SellTaxTextBox.Text, out double sellTax) &&
                double.TryParse(BuyTaxTextBox.Text, out double buyTax) &&
                sellPrice != 0)
            {
                double result = ((sellPrice * (1 - sellTax / 100) - buyPrice * (1 + buyTax / 100)) / sellPrice) * (1 - sellTax / 100) * 100;
                ResultValueLabel.Text = result.ToString("F2");
            }
            else
            {
                ResultValueLabel.Text = "Ошибка ввода";
            }
        }

    }
        }
