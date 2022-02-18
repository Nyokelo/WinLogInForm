using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLogInForm
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            
            string id = txt_UserID.Text;
            string pass = txt_Password.Text;
            if (id == "isaac nana" && pass == "28061532")
            {
               Hide();
                Form1 f = new Form1();
                
                f.Show();
           }
            else
              {
                MessageBox.Show("User Id or password is incorrect");
              }
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void txt_Reset_Click(object sender, EventArgs e)
        {
            txt_UserID.Text = "";
            txt_Password.Text = "";
        }
    }
}
