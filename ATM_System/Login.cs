using ATM_System.Data_repo;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM_System
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
           
        }


        //Delcaring the objects for use
        private ATM_DatabaseRepo _DataRepository = new ATM_DatabaseRepo();
        LandingPage landingPage = new LandingPage();
        ATM atm = new ATM();

    

        private void submit_Btn_Click(object sender, EventArgs e)
        {
            string cardNum = CardNumberTextBox.Text;
            string pinCode = PinNumberTextbox.Text;

            // Call the DAL method
            UserData loggedInUser = _DataRepository.VerifyUserAccountInDB(cardNum, pinCode);

            if (loggedInUser != null)
            {
                // Assign current user to the Users class
                Data_repo.Users.id = loggedInUser.id;
                Data_repo.Users.firstname = loggedInUser.firstname;
                Data_repo.Users.lastname = loggedInUser.lastname;

               
                // Successful login! Read the data from the 'loggedInUser' object
                MessageBox.Show($"Welcome, {loggedInUser.firstname}! Login Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atm.Show();

                this.Close();
                landingPage.Close();

            }
            else
            {
                // Failed login
                MessageBox.Show("Login Failed. Please check your card number and PIN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           


        }




    }
}
