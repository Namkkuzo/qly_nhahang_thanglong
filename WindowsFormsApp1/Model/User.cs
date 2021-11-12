
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Helper;

namespace WindowsFormsApp1.Model
{
    public class User
    {
        // các thuộc tính của user
        public List<Constain.Role> listRole { get; set; }
        public Int32 id { get; set; }
        public String userName { get; set; }
        public String fullName { get; set; }
        public String phoneNumber { get; set; }
        public DateTime dateOfBirth { get; set; }
        public String passportNumber { get; set; }
        public String address { get; set; }
        public Int32 gender { get; set; }
        public String email { get; set; }
    }
}
