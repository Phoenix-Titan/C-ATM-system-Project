using System;
using System.Windows.Forms;

namespace ATM_System
{
    public partial class LandingPage : Form
    {
       
        public LandingPage()
        {
            InitializeComponent();
            
        }


        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Btn_Click(object sender, EventArgs e)
        {   
            
                Login login = new Login();
                login.Show();
                this.Hide();
                
               
       
            
        }
    }
}
