using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Module
{
    public partial class Main : Form
    {
        User user { get; set; }

        public Main(User user)
        {
            this.user = user;
            InitializeComponent();
        }
    }
}
