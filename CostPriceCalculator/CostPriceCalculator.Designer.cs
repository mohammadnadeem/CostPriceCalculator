namespace CostPriceCalculator
{
    partial class CostPriceCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSharesSold = new System.Windows.Forms.Label();
            this.lblSalePrice = new System.Windows.Forms.Label();
            this.lblDateOfSale = new System.Windows.Forms.Label();
            this.txtSharedSold = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.lblCostPriceOfRemainingShares = new System.Windows.Forms.Label();
            this.lblSharesRemaining = new System.Windows.Forms.Label();
            this.lblProfitLoss = new System.Windows.Forms.Label();
            this.lblCostPriceOfSharesSold = new System.Windows.Forms.Label();
            this.txtCostPriceOfRemainingShares = new System.Windows.Forms.TextBox();
            this.txtSharesRemaining = new System.Windows.Forms.TextBox();
            this.txtProfitLoss = new System.Windows.Forms.TextBox();
            this.txtCostPriceOfSharesSold = new System.Windows.Forms.TextBox();
            this.cmbCostingMethod = new System.Windows.Forms.ComboBox();
            this.lblCostingMethod = new System.Windows.Forms.Label();
            this.dtDateOfSale = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(145, 169);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSharesSold
            // 
            this.lblSharesSold.AutoSize = true;
            this.lblSharesSold.Location = new System.Drawing.Point(49, 23);
            this.lblSharesSold.Name = "lblSharesSold";
            this.lblSharesSold.Size = new System.Drawing.Size(64, 13);
            this.lblSharesSold.TabIndex = 1;
            this.lblSharesSold.Text = "Shares Sold";
            // 
            // lblSalePrice
            // 
            this.lblSalePrice.AutoSize = true;
            this.lblSalePrice.Location = new System.Drawing.Point(58, 75);
            this.lblSalePrice.Name = "lblSalePrice";
            this.lblSalePrice.Size = new System.Drawing.Size(55, 13);
            this.lblSalePrice.TabIndex = 2;
            this.lblSalePrice.Text = "Sale Price";
            // 
            // lblDateOfSale
            // 
            this.lblDateOfSale.AutoSize = true;
            this.lblDateOfSale.Location = new System.Drawing.Point(45, 119);
            this.lblDateOfSale.Name = "lblDateOfSale";
            this.lblDateOfSale.Size = new System.Drawing.Size(68, 13);
            this.lblDateOfSale.TabIndex = 3;
            this.lblDateOfSale.Text = "Date Of Sale";
            // 
            // txtSharedSold
            // 
            this.txtSharedSold.Location = new System.Drawing.Point(145, 23);
            this.txtSharedSold.Name = "txtSharedSold";
            this.txtSharedSold.Size = new System.Drawing.Size(100, 20);
            this.txtSharedSold.TabIndex = 5;
            this.txtSharedSold.Text = "120";
            this.txtSharedSold.Validating += new System.ComponentModel.CancelEventHandler(this.txtSharesSoldValidation);
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(145, 75);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(100, 20);
            this.txtSalePrice.TabIndex = 6;
            this.txtSalePrice.Text = "10.5";
            this.txtSalePrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalesPriceValidation);
            // 
            // lblCostPriceOfRemainingShares
            // 
            this.lblCostPriceOfRemainingShares.AutoSize = true;
            this.lblCostPriceOfRemainingShares.Location = new System.Drawing.Point(78, 359);
            this.lblCostPriceOfRemainingShares.Name = "lblCostPriceOfRemainingShares";
            this.lblCostPriceOfRemainingShares.Size = new System.Drawing.Size(158, 13);
            this.lblCostPriceOfRemainingShares.TabIndex = 8;
            this.lblCostPriceOfRemainingShares.Text = "Cost Price Of Remaining Shares";
            // 
            // lblSharesRemaining
            // 
            this.lblSharesRemaining.AutoSize = true;
            this.lblSharesRemaining.Location = new System.Drawing.Point(78, 311);
            this.lblSharesRemaining.Name = "lblSharesRemaining";
            this.lblSharesRemaining.Size = new System.Drawing.Size(93, 13);
            this.lblSharesRemaining.TabIndex = 9;
            this.lblSharesRemaining.Text = "Shares Remaining";
            // 
            // lblProfitLoss
            // 
            this.lblProfitLoss.AutoSize = true;
            this.lblProfitLoss.Location = new System.Drawing.Point(78, 266);
            this.lblProfitLoss.Name = "lblProfitLoss";
            this.lblProfitLoss.Size = new System.Drawing.Size(64, 13);
            this.lblProfitLoss.TabIndex = 10;
            this.lblProfitLoss.Text = "Profit / Loss";
            // 
            // lblCostPriceOfSharesSold
            // 
            this.lblCostPriceOfSharesSold.AutoSize = true;
            this.lblCostPriceOfSharesSold.Location = new System.Drawing.Point(78, 227);
            this.lblCostPriceOfSharesSold.Name = "lblCostPriceOfSharesSold";
            this.lblCostPriceOfSharesSold.Size = new System.Drawing.Size(129, 13);
            this.lblCostPriceOfSharesSold.TabIndex = 11;
            this.lblCostPriceOfSharesSold.Text = "Cost Price Of Shares Sold";
            // 
            // txtCostPriceOfRemainingShares
            // 
            this.txtCostPriceOfRemainingShares.Enabled = false;
            this.txtCostPriceOfRemainingShares.Location = new System.Drawing.Point(246, 352);
            this.txtCostPriceOfRemainingShares.Name = "txtCostPriceOfRemainingShares";
            this.txtCostPriceOfRemainingShares.Size = new System.Drawing.Size(100, 20);
            this.txtCostPriceOfRemainingShares.TabIndex = 12;
            // 
            // txtSharesRemaining
            // 
            this.txtSharesRemaining.Enabled = false;
            this.txtSharesRemaining.Location = new System.Drawing.Point(246, 308);
            this.txtSharesRemaining.Name = "txtSharesRemaining";
            this.txtSharesRemaining.Size = new System.Drawing.Size(100, 20);
            this.txtSharesRemaining.TabIndex = 13;
            // 
            // txtProfitLoss
            // 
            this.txtProfitLoss.Enabled = false;
            this.txtProfitLoss.Location = new System.Drawing.Point(246, 263);
            this.txtProfitLoss.Name = "txtProfitLoss";
            this.txtProfitLoss.Size = new System.Drawing.Size(100, 20);
            this.txtProfitLoss.TabIndex = 14;
            // 
            // txtCostPriceOfSharesSold
            // 
            this.txtCostPriceOfSharesSold.Enabled = false;
            this.txtCostPriceOfSharesSold.Location = new System.Drawing.Point(246, 220);
            this.txtCostPriceOfSharesSold.Name = "txtCostPriceOfSharesSold";
            this.txtCostPriceOfSharesSold.Size = new System.Drawing.Size(100, 20);
            this.txtCostPriceOfSharesSold.TabIndex = 15;
            // 
            // cmbCostingMethod
            // 
            this.cmbCostingMethod.FormattingEnabled = true;
            this.cmbCostingMethod.Location = new System.Drawing.Point(489, 15);
            this.cmbCostingMethod.Name = "cmbCostingMethod";
            this.cmbCostingMethod.Size = new System.Drawing.Size(121, 21);
            this.cmbCostingMethod.TabIndex = 16;
            // 
            // lblCostingMethod
            // 
            this.lblCostingMethod.AutoSize = true;
            this.lblCostingMethod.Location = new System.Drawing.Point(383, 18);
            this.lblCostingMethod.Name = "lblCostingMethod";
            this.lblCostingMethod.Size = new System.Drawing.Size(81, 13);
            this.lblCostingMethod.TabIndex = 18;
            this.lblCostingMethod.Text = "Costing Method";
            // 
            // dtDateOfSale
            // 
            this.dtDateOfSale.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOfSale.Location = new System.Drawing.Point(146, 119);
            this.dtDateOfSale.Name = "dtDateOfSale";
            this.dtDateOfSale.Size = new System.Drawing.Size(200, 20);
            this.dtDateOfSale.TabIndex = 19;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeftChanged += new System.EventHandler(this.btnCalculate_Click);
            // 
            // CostPriceCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtDateOfSale);
            this.Controls.Add(this.lblCostingMethod);
            this.Controls.Add(this.cmbCostingMethod);
            this.Controls.Add(this.txtCostPriceOfSharesSold);
            this.Controls.Add(this.txtProfitLoss);
            this.Controls.Add(this.txtSharesRemaining);
            this.Controls.Add(this.txtCostPriceOfRemainingShares);
            this.Controls.Add(this.lblCostPriceOfSharesSold);
            this.Controls.Add(this.lblProfitLoss);
            this.Controls.Add(this.lblSharesRemaining);
            this.Controls.Add(this.lblCostPriceOfRemainingShares);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.txtSharedSold);
            this.Controls.Add(this.lblDateOfSale);
            this.Controls.Add(this.lblSalePrice);
            this.Controls.Add(this.lblSharesSold);
            this.Controls.Add(this.btnCalculate);
            this.Name = "CostPriceCalculator";
            this.Text = "Cost Price Calculator";
            this.Load += new System.EventHandler(this.CostPriceCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSharesSold;
        private System.Windows.Forms.Label lblSalePrice;
        private System.Windows.Forms.Label lblDateOfSale;
        private System.Windows.Forms.TextBox txtSharedSold;
        private System.Windows.Forms.TextBox txtSalePrice;
        private System.Windows.Forms.Label lblCostPriceOfRemainingShares;
        private System.Windows.Forms.Label lblSharesRemaining;
        private System.Windows.Forms.Label lblProfitLoss;
        private System.Windows.Forms.Label lblCostPriceOfSharesSold;
        private System.Windows.Forms.TextBox txtCostPriceOfRemainingShares;
        private System.Windows.Forms.TextBox txtSharesRemaining;
        private System.Windows.Forms.TextBox txtProfitLoss;
        private System.Windows.Forms.TextBox txtCostPriceOfSharesSold;
        private System.Windows.Forms.ComboBox cmbCostingMethod;
        private System.Windows.Forms.Label lblCostingMethod;
        private System.Windows.Forms.DateTimePicker dtDateOfSale;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

