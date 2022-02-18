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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Hallo.Text = "Hello Everyone";
        }

        private void btn_Set_Click(object sender, EventArgs e)
        {
            lbl_Hallo.Text = "Hello my friends again......";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            lbl_Hallo.Text = "Hallo has been canceled. Please press SET again";
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInForm login = new LogInForm();
            login.Show();
        }
    }
}
