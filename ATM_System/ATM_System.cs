using ATM_System.Data_repo;
using System;
using System.Windows.Forms;

namespace ATM_System
{
    public partial class ATM : Form
    {

        public ATM()
        {
            InitializeComponent();
           
        }
        //Declaring the class Objects
        private ATM_DatabaseRepo UserDbRepo = new ATM_DatabaseRepo();
        DepositForm depositForm = new DepositForm();
        WithDrawForm withDrawForm = new WithDrawForm();



        //Perform these actions on when the page loads.
        private void ATM_Load(object sender, EventArgs e)
        {
            UserName.Text = Data_repo.Users.firstname + " " + Data_repo.Users.lastname;

        }

        //This is for the logout Button on click
        private void Logout_btn_Click(object sender, EventArgs e)
        {
            LandingPage landingPage = new LandingPage();
            landingPage.Show();
            this.Close();
        }




        //This is used to check the balance of the user account by the userID
        private void Check_Balance_Click(object sender, EventArgs e)
        {
            // 1. Get the current user ID from the static class
            int currentUserId = Data_repo.Users.id;

            try
            {
                // 2. Call the new DB method, which returns a tuple of both balances
                (decimal usd, decimal lrd) balances = UserDbRepo.GetCurrentBalances(currentUserId);

                // 3. Update the static Users balances for the current session state
                Data_repo.Users.usdBalance = balances.usd;
                Data_repo.Users.lrdBalance = balances.lrd;

                 USD_Value.Text = Convert.ToString(balances.usd);
                 LRD_value.Text = Convert.ToString(balances.lrd);

               
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("Could not retrieve balances due to a database error.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Deposit_Cash_Click(object sender, EventArgs e)
        {
           

            // ShowDialog blocks execution until the form is closed
            depositForm.ShowDialog();

            // After the dialog closes, check if the deposit succeeded
            if (depositForm.DepositSuccessful)
            {
                // Re-run the balance check method to fetch the updated balance from the DB
                Check_Balance_Click(sender, e);
            }

        }

        private void Transfer_Cash_btn_Click(object sender, EventArgs e)
        {

        }

        private void Withdraw_Cash_Click(object sender, EventArgs e)
        {
            
            withDrawForm.ShowDialog();

            // After the dialog closes, check if the withdrawal succeeded
            if (withDrawForm.WithdrawalSuccessful)
            {
                // Re-run the balance check method to fetch the updated balance from the DB
                Check_Balance_Click(sender, e);
            }
        }
    }
}
