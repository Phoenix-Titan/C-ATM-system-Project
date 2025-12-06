using ATM_System.Data_repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_System
{
    public partial class DepositForm : Form
    {
        private readonly ATM_DatabaseRepo _dbRepo = new ATM_DatabaseRepo();

        // Property to signal the main ATM form that a deposit occurred and it should refresh
        public bool DepositSuccessful { get; private set; } = false;

        public DepositForm()
        {
            InitializeComponent();
        }

        private void Deposit_cash_Click(object sender, EventArgs e)
        {
            int currentUserId = Data_repo.Users.id;
            bool success = false;

            // --- 1. USD Deposit Logic ---
            if (double.TryParse(USD_Value.Text, out double usdDeposit) && usdDeposit > 0)
            {
                try
                {
                    // Use decimal for financial calculations
                    int rowsAffected = _dbRepo.UpdateAccountBalance(currentUserId, (decimal)usdDeposit, "USD");
                    if (rowsAffected > 0)
                    {
                        success = true;
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show($"USD Deposit Failed: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit if USD deposit fails
                }
            }

            // --- 2. LRD Deposit Logic ---
            if (double.TryParse(LRD_Value.Text, out double lrdDeposit) && lrdDeposit > 0)
            {
                try
                {
                    // Use decimal for financial calculations
                    int rowsAffected = _dbRepo.UpdateAccountBalance(currentUserId, (decimal)lrdDeposit, "LRD");
                    if (rowsAffected > 0)
                    {
                        success = true;
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show($"LRD Deposit Failed: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit if LRD deposit fails
                }
            }

            // --- 3. Finalization ---
            if (success)
            {
                MessageBox.Show("Deposit Successful! Your balance has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DepositSuccessful = true; // Set flag for the calling form
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid amount greater than 0 in at least one currency field.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
