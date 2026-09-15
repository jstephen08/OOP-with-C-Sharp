using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_class_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Username.Text == "" || Password.Text == "")
                {
                    throw new Exception("Please fill all fields.");
                }
                if (Username.Text.Length <= 2)
                {
                    throw new Exception("Username must have more than 2 characters.");
                }
                MessageBox.Show("Login Successful");
                {
                    Catch(Exception ex){
                        MessageBox.Show(Exception.Message);
                    }
                }
            }
        }
    }
}
