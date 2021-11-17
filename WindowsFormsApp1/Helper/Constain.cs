using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Helper
{
    
    public class Constain
    {
        public static String connectingString = @"Data Source=DESKTOP-DQ1BOMO\SQLEXPRESS;Initial Catalog=Foody;Integrated Security=True";
        public enum Role
        {
            HR,
            NHA_BEP,
            THU_NGAN,
            NO_ROLE
        };
        public enum statusOrder
        {
            CHUA_NAU,
            DANG_NAU,
            DA_NAU_XONG
        };
        public static Role? getRoleByString (String role)
        {
            switch (role)
            {
                case "HR": return Role.HR;
                case "NHA_BEP": return Role.NHA_BEP;
                case "THU_NGAN": return Role.THU_NGAN;
                default: return Role.NO_ROLE;
            }
        }

        public static statusOrder? getStatusOrderByInt (int role)
        {
            switch (role)
            {
                case 0: return statusOrder.CHUA_NAU;
                case 1: return statusOrder.DANG_NAU;
                default: return statusOrder.DA_NAU_XONG;
            }
        }
    }
}
