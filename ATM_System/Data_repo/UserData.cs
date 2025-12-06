using System;


namespace ATM_System.Data_repo
{   
    
    // 💡 This is NOT static and can be instantiated.
    public class UserData
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public decimal usdBalance { get; set; } // <--- Updated
        public decimal lrdBalance { get; set; } // <--- Updated
    }
}
