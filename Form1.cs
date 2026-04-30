using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp_hw;

namespace WindowsFormsApp_hw
{
    public partial class Form1 : Form
    {
        public delegate bool ValidateItemDelegate(string productName, int quantity, double price);
        public Func<double, double> DiscountCalculator { get; set; }

        public event Action<string> OnItemAdded;
        public event Action<string> OnBillCalculated;
        public event Action<string> OnBillCleared;

        private BillingLogger logger;

        public Form1()
        {
            InitializeComponent();
            InitializeDelegatesAndEvents();
            InitializeLogger();
            SubscribeToEvents();
        }

        private void InitializeDelegatesAndEvents()
        { 
            DiscountCalculator = (subtotal) => subtotal * 0.9;
            OnItemAdded += (msg) => { };
            OnBillCalculated += (msg) => { };
            OnBillCleared += (msg) => { };
        }

        private void InitializeLogger()
        {
            logger = new BillingLogger(LogMessage);
        }

        private void SubscribeToEvents()
        {
            OnItemAdded += logger.OnItemAddedHandler;
            OnBillCalculated += logger.OnBillCalculatedHandler;
            OnBillCleared += logger.OnBillClearedHandler;
            OnItemAdded += (message) => {
                UpdateStatusLabel($"Item added: {message}");
            };
            OnBillCalculated += (message) => {
                UpdateStatusLabel($"Bill calculated: {message}");
            };
            OnBillCalculated += logger.OnBillCalculatedHandler;
            OnBillCleared += logger.OnBillClearedHandler;
        }

        private void UpdateStatusLabel(string message)
        {
            if (lblStatus.InvokeRequired)
            {
                lblStatus.Invoke(new Action(() => lblStatus.Text = message));
            }
            else
            {
                lblStatus.Text = message;
            }
        }

        private void LogMessage(string message)
        {
            if (lstActivityLog.InvokeRequired)
            {
                lstActivityLog.Invoke(new Action(() =>
                {
                    lstActivityLog.Items.Add(message);
                    lstActivityLog.TopIndex = lstActivityLog.Items.Count - 1;
                }));
            }
            else
            {
                lstActivityLog.Items.Add(message);
                lstActivityLog.TopIndex = lstActivityLog.Items.Count - 1;
            }
        }
        private bool ValidateItem(string productName, int quantity, double price)
        {
            if (string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("Product name cannot be empty!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (price <= 0)
            {
                MessageBox.Show("Price must be greater than 0!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            { 
                string productName = txtProductName.Text.Trim();

                if (!int.TryParse(txtQuantity.Text, out int quantity))
                {
                    MessageBox.Show("Please enter a valid quantity!", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txtPrice.Text, out double price))
                {
                    MessageBox.Show("Please enter a valid price!", "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ValidateItemDelegate validator = ValidateItem;
                if (!validator(productName, quantity, price))
                    return;
                double itemTotal = quantity * price;
                dgvItems.Rows.Add(productName, quantity, price.ToString("F2"), itemTotal.ToString("F2"));
                OnItemAdded?.Invoke($"{productName} x{quantity} = {itemTotal:F2}");
                txtProductName.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
                txtProductName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItems.Rows.Count == 0)
                {
                    MessageBox.Show("No items to calculate!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                double subtotal = 0;
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (row.Cells[3].Value != null)
                    {
                        subtotal += double.Parse(row.Cells[3].Value.ToString());
                    }
                }
                double discountedTotal = DiscountCalculator(subtotal);
                double discountAmount = subtotal - discountedTotal;
                lblSubtotal.Text = $"Subtotal: {subtotal:F2}";
                lblDiscount.Text = $"Discount (10%): {discountAmount:F2}";
                lblTotal.Text = $"Total: {discountedTotal:F2}";
                lblDateTime.Text = $"Bill Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
                string billMessage = $"Subtotal={subtotal:F2}, Discount={discountAmount:F2}, Total={discountedTotal:F2}";
                OnBillCalculated?.Invoke(billMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating total: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItems.SelectedRows.Count > 0)
                {
                    string productName = dgvItems.SelectedRows[0].Cells[0].Value?.ToString() ?? "Unknown";
                    dgvItems.Rows.RemoveAt(dgvItems.SelectedRows[0].Index);
                    LogMessage($"{DateTime.Now:HH:mm:ss} - Removed item: {productName}");
                }
                else
                {
                    MessageBox.Show("Please select an item to remove!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing item: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtProductName.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
                dgvItems.Rows.Clear();
                lblSubtotal.Text = "Subtotal: 0.00";
                lblDiscount.Text = "Discount (10%): 0.00";
                lblTotal.Text = "Total: 0.00";
                lblDateTime.Text = "Bill Date: --";
                OnBillCleared?.Invoke("All items cleared from bill");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
