using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_System.Data_repo
{
    public static class Users
    {
  

        public static int id { get; set; }
        public static string firstname{ get; set; }
        public static string lastname{ get; set; }
        public static decimal usdBalance { get; set; } // <--- Updated
        public static decimal lrdBalance { get; set; } // <--- Updated

    }
}
