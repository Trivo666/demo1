using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demologin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string u = txtuser.Text;
            string p = txtpw.Text;
            if(u=="admin"&&p=="admin")
            {
                MessageBox.Show("Login successful");
            }
        }
    }
}
