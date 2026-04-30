namespace WindowsFormsApp_hw
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.ListBox lstActivityLog;
        private System.Windows.Forms.Label lblActivityLog;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelTotals;

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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lstActivityLog = new System.Windows.Forms.ListBox();
            this.lblActivityLog = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelTotals = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panelInput.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelTotals.SuspendLayout();
            this.SuspendLayout();

            // Form
            this.Text = "Billing System";
            this.Size = new System.Drawing.Size(1200, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;

            // Title Label
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitle.Text = "Shop Billing System";
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Size = new System.Drawing.Size(1160, 40);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Input Panel
            this.panelInput.Location = new System.Drawing.Point(20, 70);
            this.panelInput.Size = new System.Drawing.Size(500, 150);
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);

            // Labels and TextBoxes
            this.lblProductName.Text = "Product Name:";
            this.lblProductName.Location = new System.Drawing.Point(20, 20);
            this.lblProductName.Size = new System.Drawing.Size(100, 25);

            this.txtProductName.Location = new System.Drawing.Point(130, 17);
            this.txtProductName.Size = new System.Drawing.Size(200, 27);

            this.lblQuantity.Text = "Quantity:";
            this.lblQuantity.Location = new System.Drawing.Point(20, 55);
            this.lblQuantity.Size = new System.Drawing.Size(100, 25);

            this.txtQuantity.Location = new System.Drawing.Point(130, 52);
            this.txtQuantity.Size = new System.Drawing.Size(100, 27);

            this.lblPrice.Text = "Price:";
            this.lblPrice.Location = new System.Drawing.Point(20, 90);
            this.lblPrice.Size = new System.Drawing.Size(100, 25);

            this.txtPrice.Location = new System.Drawing.Point(130, 87);
            this.txtPrice.Size = new System.Drawing.Size(100, 27);

            // Buttons Panel
            this.panelButtons.Location = new System.Drawing.Point(540, 70);
            this.panelButtons.Size = new System.Drawing.Size(640, 150);
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);

            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Location = new System.Drawing.Point(20, 20);
            this.btnAddItem.Size = new System.Drawing.Size(140, 40);
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            this.btnCalculateTotal.Text = "Calculate Total";
            this.btnCalculateTotal.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnCalculateTotal.ForeColor = System.Drawing.Color.White;
            this.btnCalculateTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculateTotal.Location = new System.Drawing.Point(180, 20);
            this.btnCalculateTotal.Size = new System.Drawing.Size(140, 40);
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);

            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnRemoveSelected.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelected.Location = new System.Drawing.Point(340, 20);
            this.btnRemoveSelected.Size = new System.Drawing.Size(140, 40);
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);

            this.btnClear.Text = "Clear All";
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(500, 20);
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.lblStatus.Text = "Ready";
            this.lblStatus.Location = new System.Drawing.Point(20, 100);
            this.lblStatus.Size = new System.Drawing.Size(600, 30);
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);

            // DataGridView
            this.dgvItems.Location = new System.Drawing.Point(20, 230);
            this.dgvItems.Size = new System.Drawing.Size(760, 250);
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.ReadOnly = true;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.MultiSelect = false;

            // Set up columns
            this.dgvItems.ColumnCount = 4;
            this.dgvItems.Columns[0].Name = "Product";
            this.dgvItems.Columns[0].Width = 200;
            this.dgvItems.Columns[1].Name = "Qty";
            this.dgvItems.Columns[1].Width = 80;
            this.dgvItems.Columns[2].Name = "Price";
            this.dgvItems.Columns[2].Width = 100;
            this.dgvItems.Columns[3].Name = "Item Total";
            this.dgvItems.Columns[3].Width = 120;

            // Totals Panel
            this.panelTotals.Location = new System.Drawing.Point(20, 490);
            this.panelTotals.Size = new System.Drawing.Size(760, 100);
            this.panelTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotals.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);

            this.lblSubtotal.Text = "Subtotal: 0.00";
            this.lblSubtotal.Location = new System.Drawing.Point(20, 15);
            this.lblSubtotal.Size = new System.Drawing.Size(200, 25);
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.lblDiscount.Text = "Discount (10%): 0.00";
            this.lblDiscount.Location = new System.Drawing.Point(20, 45);
            this.lblDiscount.Size = new System.Drawing.Size(250, 25);
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);

            this.lblTotal.Text = "Total: 0.00";
            this.lblTotal.Location = new System.Drawing.Point(20, 75);
            this.lblTotal.Size = new System.Drawing.Size(200, 25);
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);

            this.lblDateTime.Text = "Bill Date: --";
            this.lblDateTime.Location = new System.Drawing.Point(400, 15);
            this.lblDateTime.Size = new System.Drawing.Size(340, 70);
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // Activity Log
            this.lblActivityLog.Text = "Activity Log:";
            this.lblActivityLog.Location = new System.Drawing.Point(800, 70);
            this.lblActivityLog.Size = new System.Drawing.Size(380, 25);
            this.lblActivityLog.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.lstActivityLog.Location = new System.Drawing.Point(800, 100);
            this.lstActivityLog.Size = new System.Drawing.Size(380, 490);
            this.lstActivityLog.BackColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lstActivityLog.ForeColor = System.Drawing.Color.White;
            this.lstActivityLog.Font = new System.Drawing.Font("Consolas", 9F);

            // Add controls to form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.panelTotals);
            this.Controls.Add(this.lblActivityLog);
            this.Controls.Add(this.lstActivityLog);

            // Add controls to input panel
            this.panelInput.Controls.Add(this.lblProductName);
            this.panelInput.Controls.Add(this.txtProductName);
            this.panelInput.Controls.Add(this.lblQuantity);
            this.panelInput.Controls.Add(this.txtQuantity);
            this.panelInput.Controls.Add(this.lblPrice);
            this.panelInput.Controls.Add(this.txtPrice);

            // Add controls to buttons panel
            this.panelButtons.Controls.Add(this.btnAddItem);
            this.panelButtons.Controls.Add(this.btnCalculateTotal);
            this.panelButtons.Controls.Add(this.btnRemoveSelected);
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Controls.Add(this.lblStatus);

            // Add controls to totals panel
            this.panelTotals.Controls.Add(this.lblSubtotal);
            this.panelTotals.Controls.Add(this.lblDiscount);
            this.panelTotals.Controls.Add(this.lblTotal);
            this.panelTotals.Controls.Add(this.lblDateTime);

            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelTotals.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
