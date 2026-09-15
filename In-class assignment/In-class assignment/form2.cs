using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_class_assignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Username.Text == "" || Password.Text == "" || ConfirmPassword.Text == "")
                {
                    throw new Exception("Please fill all fields.");
                }

                if (Username.Text.Length <= 2)
                {
                    throw new Exception("Username must have more than 2 characters.");
                }

                if (Password.Text != ConfirmPassword.Text)
                {
                    throw new Exception("Passwords do not match.");
                }

                MessageBox.Show("Sign-up Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
