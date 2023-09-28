using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "Gourav" && textBoxPassword.Text == "1234")
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Incorrect Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
