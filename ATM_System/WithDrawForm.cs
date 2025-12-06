using ATM_System.Data_repo;
using System;
using System.Windows.Forms;

namespace ATM_System
{
    public partial class WithDrawForm : Form
    {
        private readonly ATM_DatabaseRepo _dbRepo = new ATM_DatabaseRepo();

        // Property to signal the main ATM form that a withdrawal occurred and it should refresh
        public bool WithdrawalSuccessful { get; private set; } = false;

        public WithDrawForm()
        {
            InitializeComponent();
        }


        private void withdraw_btn_Click_1(object sender, EventArgs e)
        {

            int currentUserId = Data_repo.Users.id;
            bool success = false;
            bool transactionAttempted = false;

            // --- 1. USD Withdrawal Logic ---
            if (decimal.TryParse(USD_amount_value.Text, out decimal usdWithdrawal) && usdWithdrawal > 0)
            {
                transactionAttempted = true;
                if (usdWithdrawal > Data_repo.Users.usdBalance)
                {
                    MessageBox.Show("Insufficient USD balance for this withdrawal.", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if USD funds are insufficient
                }

                try
                {
                    int rowsAffected = _dbRepo.UpdateAccountForWithdrawal(currentUserId, usdWithdrawal, "USD");
                    if (rowsAffected > 0)
                    {
                        success = true;
                    }
                    else
                    {
                        // This is a database safety net, though the balance check above should prevent it
                        MessageBox.Show("USD withdrawal failed due to an unknown error (possibly concurrent access).", "Withdrawal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show($"USD Withdrawal Failed: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- 2. LRD Withdrawal Logic ---
            if (decimal.TryParse(LRD_amount_value.Text, out decimal lrdWithdrawal) && lrdWithdrawal > 0)
            {
                transactionAttempted = true;
                if (lrdWithdrawal > Data_repo.Users.lrdBalance)
                {
                    MessageBox.Show("Insufficient LRD balance for this withdrawal.", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Exit if LRD funds are insufficient
                }

                try
                {
                    int rowsAffected = _dbRepo.UpdateAccountForWithdrawal(currentUserId, lrdWithdrawal, "LRD");
                    if (rowsAffected > 0)
                    {
                        success = true;
                    }
                    else
                    {
                        MessageBox.Show("LRD withdrawal failed due to an unknown error (possibly concurrent access).", "Withdrawal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show($"LRD Withdrawal Failed: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- 3. Finalization ---
            if (success)
            {
                MessageBox.Show("Withdrawal Successful! Please take your cash.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.WithdrawalSuccessful = true; // Set flag for the calling form
                this.Close();
            }
            else if (!transactionAttempted)
            {
                MessageBox.Show("Please enter a valid amount greater than 0 in at least one currency field.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    
    }
}
