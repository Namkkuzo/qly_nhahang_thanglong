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
            DANG_NHAP,
            XEM_DANH_SACH_NHAN_VIEN,
        };
        public enum statusOrder
        {
            CHUA_NAU,
            DANG_NAU,
            DA_NAU_XONG,
        };
        public static Role? getRoleByString (String role)
        {
            switch (role)
            {
                case "DANG_NHAP": return Role.DANG_NHAP;
                case "XEM_DANH_SACH_NHAN_VIEN": return Role.XEM_DANH_SACH_NHAN_VIEN;
                default: return null;
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
