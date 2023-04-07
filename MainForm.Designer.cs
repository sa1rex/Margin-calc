namespace MarginCalc
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox SellPriceTextBox;
        private System.Windows.Forms.TextBox BuyPriceTextBox;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Label BuyPriceLabel;
        private System.Windows.Forms.Label SellPriceLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TaxBuyLabel;
        private System.Windows.Forms.TextBox TaxBuyTextBox;
        private System.Windows.Forms.Label TaxSellLabel;
        private System.Windows.Forms.TextBox TaxSellTextBox;
        private System.Windows.Forms.Label BuyTaxLabel;
        private System.Windows.Forms.TextBox BuyTaxTextBox;
        private System.Windows.Forms.Label SellTaxLabel;
        private System.Windows.Forms.TextBox SellTaxTextBox;
        private System.Windows.Forms.Label ResultValueLabel;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SellPriceTextBox = new System.Windows.Forms.TextBox();
            this.BuyPriceTextBox = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.TaxBuyLabel = new System.Windows.Forms.Label();
            this.TaxBuyTextBox = new System.Windows.Forms.TextBox();
            this.TaxSellLabel = new System.Windows.Forms.Label();
            this.TaxSellTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.BuyPriceLabel = new System.Windows.Forms.Label();
            this.SellPriceLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // TitleLabel
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(228, 20);
            this.TitleLabel.TabIndex = 5;
            this.TitleLabel.Text = "Калькулятор процента прибыли";

            // BuyPriceLabel
            this.BuyPriceLabel.AutoSize = true;
            this.BuyPriceLabel.Location = new System.Drawing.Point(12, 32);
            this.BuyPriceLabel.Name = "BuyPriceLabel";
            this.BuyPriceLabel.Size = new System.Drawing.Size(71, 13);
            this.BuyPriceLabel.TabIndex = 6;
            this.BuyPriceLabel.Text = "Цена покупки:";

            // BuyTaxLabel
            this.BuyTaxLabel = new System.Windows.Forms.Label();
            this.BuyTaxLabel.AutoSize = true;
            this.BuyTaxLabel.Location = new System.Drawing.Point(260, 32);
            this.BuyTaxLabel.Name = "BuyTaxLabel";
            this.BuyTaxLabel.Size = new System.Drawing.Size(122, 13);
            this.BuyTaxLabel.TabIndex = 6;
            this.BuyTaxLabel.Text = "Налог на покупку (%):";
            this.Controls.Add(this.BuyTaxLabel);

            // BuyTaxTextBox
            this.BuyTaxTextBox = new System.Windows.Forms.TextBox();
            this.BuyTaxTextBox.Location = new System.Drawing.Point(388, 39);
            this.BuyTaxTextBox.Name = "BuyTaxTextBox";
            this.BuyTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.BuyTaxTextBox.TabIndex = 7;
            this.Controls.Add(this.BuyTaxTextBox);

            // SellTaxLabel
            this.SellTaxLabel = new System.Windows.Forms.Label();
            this.SellTaxLabel.AutoSize = true;
            this.SellTaxLabel.Location = new System.Drawing.Point(260, 68);
            this.SellTaxLabel.Name = "SellTaxLabel";
            this.SellTaxLabel.Size = new System.Drawing.Size(118, 13);
            this.SellTaxLabel.TabIndex = 8;
            this.SellTaxLabel.Text = "Налог на продажу (%):";
            this.Controls.Add(this.SellTaxLabel);

            // SellTaxTextBox
            this.SellTaxTextBox = new System.Windows.Forms.TextBox();
            this.SellTaxTextBox.Location = new System.Drawing.Point(388, 65);
            this.SellTaxTextBox.Name = "SellTaxTextBox";
            this.SellTaxTextBox.Size = new System.Drawing.Size(100, 20);
            this.SellTaxTextBox.TabIndex = 9;
            this.Controls.Add(this.SellTaxTextBox);

            // SellPriceLabel
            this.SellPriceLabel.AutoSize = true;
            this.SellPriceLabel.Location = new System.Drawing.Point(12, 68);
            this.SellPriceLabel.Name = "SellPriceLabel";
            this.SellPriceLabel.Size = new System.Drawing.Size(77, 13);
            this.SellPriceLabel.TabIndex = 7;
            this.SellPriceLabel.Text = "Цена продажи:";

            // SellPriceTextBox
            this.SellPriceTextBox.Location = new System.Drawing.Point(140, 65);
            this.SellPriceTextBox.Name = "SellPriceTextBox";
            this.SellPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.SellPriceTextBox.TabIndex = 0;

            // BuyPriceTextBox
            this.BuyPriceTextBox.Location = new System.Drawing.Point(140, 39);
            this.BuyPriceTextBox.Name = "BuyPriceTextBox";
            this.BuyPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.BuyPriceTextBox.TabIndex = 1;

            // ResultLabel
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 134);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(111, 13);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "Результат с налогами:";

            // ResultValueLabel
            this.ResultValueLabel = new System.Windows.Forms.Label();
            this.ResultValueLabel.AutoSize = true;
            this.ResultValueLabel.Location = new System.Drawing.Point(140, 134);
            this.ResultValueLabel.Name = "ResultValueLabel";
            this.ResultValueLabel.Size = new System.Drawing.Size(0, 13);
            this.ResultValueLabel.TabIndex = 11;
            this.Controls.Add(this.ResultValueLabel);

            // CalculateBtn
            this.CalculateBtn.Location = new System.Drawing.Point(15, 155);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(75, 23);
            this.CalculateBtn.TabIndex = 4;
            this.CalculateBtn.Text = "Рассчитать";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);

            // MainForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Icon = new System.Drawing.Icon("dollar.ico");
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SellPriceLabel);
            this.Controls.Add(this.BuyPriceLabel);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.TaxBuyLabel);
            this.Controls.Add(this.TaxBuyTextBox);
            this.Controls.Add(this.TaxSellLabel);
            this.Controls.Add(this.TaxSellTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.BuyPriceTextBox);
            this.Controls.Add(this.SellPriceTextBox);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
    }
