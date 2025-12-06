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

        private void Login_Load(object sender, EventArgs e)
        {// Failed login
            MessageBox.Show("These are the default Login Information\n" +
                "you can use to test the System:\n" +
                "\n\nDefault Accounts:\n" +
                "1. Samuel Barker, 1234567890123456, 1234 \n" +
                "2. Maria Garcia, 9876543210987654, 5678 \n" +
                "3. Ethan Smith, 1111222233334444 , 0001\n" +
                "4. Olivia Wang, 5555666677778888, 9999\n" +
                "5. Liam Brown, 4321098765432109, 1122\n" +
                "6. Sophia Lee,  6789012345678901, 3344\n" +
                "7. Noah Martinez,2468135790864201, 5566\n" +
                "8. Ava Taylor, 1357924680135792, 7788\n" +
                "9. Jackson Wilson, 0987654321098765, 9012\n" +
                "10. Chloe Anderson, 1020304050607080', 3456;", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
