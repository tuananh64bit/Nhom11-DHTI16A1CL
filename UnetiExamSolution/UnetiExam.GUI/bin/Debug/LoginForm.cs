using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnetiExam.GUI;

namespace UnetiExam.GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
<<<<<<< HEAD
=======

>>>>>>> 0575c294f1aa0a26d253fa4f52e75dcdc6d8b104
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
<<<<<<< HEAD
            if (txtPassword.Text == "password")
=======
            if (txtPassword.Text == "123")
>>>>>>> 0575c294f1aa0a26d253fa4f52e75dcdc6d8b104
            {
                
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
<<<<<<< HEAD
=======
                mainForm.SetUsername(txtUsername.Text); // Assuming MainForm has a method to set the username
>>>>>>> 0575c294f1aa0a26d253fa4f52e75dcdc6d8b104
            }
            else
            {
                MessageBox.Show("Invalid password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
=======

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheckBox.Checked)
            {
                txtPassword.PasswordChar = '\0';
            } else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
>>>>>>> 0575c294f1aa0a26d253fa4f52e75dcdc6d8b104
    }
}
