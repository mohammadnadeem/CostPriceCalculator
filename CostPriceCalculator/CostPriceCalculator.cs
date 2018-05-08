using CostPriceCalculator.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CostPriceCalculator
{
    public partial class CostPriceCalculator : Form
    {
        InventoryService _inventoryService;
        public CostPriceCalculator()
        {
            InitializeComponent();
        }

        private void CostPriceCalculator_Load(object sender, EventArgs e)
        {
            cmbCostingMethod.DataSource = Enum.GetValues(typeof(CostingMethod));
            _inventoryService = new InventoryService();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(errorProvider1.GetError(txtSharedSold))
                && string.IsNullOrEmpty(errorProvider1.GetError(txtSalePrice)) // text fields validations
                )
            {
                #region Read Input and Create Order
                Order order = new Order();
                order.NumberOfShares = Convert.ToInt32(txtSharedSold.Text);
                order.Price = Convert.ToDecimal(txtSalePrice.Text);
                order.SellDate = dtDateOfSale.Value;
                CostingMethod costingMethod;
                Enum.TryParse<CostingMethod>(cmbCostingMethod.SelectedValue.ToString(), out costingMethod);
                #endregion

                try
                {
                    // Proess input
                    OrderInvoice orderInvoice = _inventoryService.FulfillOrder(order, costingMethod);

                    #region Show Order Invoice on Form
                    txtCostPriceOfRemainingShares.Text = orderInvoice.CostPriceOfRemainingShares.ToString();
                    txtCostPriceOfSharesSold.Text = orderInvoice.CostPriceOfSoldShares.ToString();
                    txtSharesRemaining.Text = orderInvoice.RemainingShares.ToString();
                    txtProfitLoss.Text = orderInvoice.ProfitLoss.ToString();
                    #endregion
                }
                catch (InventoryException ex)
                {
                    MessageBox.Show(ex.Message, "Inventory Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unhandled Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void txtSharesSoldValidation(object sender, CancelEventArgs e)
        {
            Match match = Regex.Match(txtSharedSold.Text, @"^[1-9]\d*$",
            RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                e.Cancel = true;
                txtSharedSold.Focus();
                errorProvider1.SetError(txtSharedSold, "Enter a positive integer value.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }

        private void txtSalesPriceValidation(object sender, CancelEventArgs e)
        {
            Match match = Regex.Match(txtSalePrice.Text, @"^\d*(\.\d{1,2})?$",
            RegexOptions.IgnoreCase);

            if (!match.Success)
            {
                e.Cancel = true;
                txtSalePrice.Focus();
                errorProvider1.SetError(txtSalePrice, "Enter a positive decimal value. e.g 11.2");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.Clear();
            }
        }
    }
}
