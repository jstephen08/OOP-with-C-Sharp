using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double batchNo = 0;
            try
            {
                batchNo = double.Parse(textBox1.Text);
            }

            catch(Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }

            if(batchNo>0 && batchNo < 100)
            {
                label2.Text = textBox1.Text;
                textBox1.Text = "";
            }

            else
            {
                label2.Text = "Message:Wrong Input";
            }
        }
    }
}
