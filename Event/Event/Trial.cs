using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Event
{
    public partial class Trial : Form
    {
        public Trial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(textBox1.Text) > Int32.Parse(textBox2.Text))
            {
                MessageBox.Show("TextBox1 is greater than TextBox2.Proceed and save the financial records", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("TextBox2 is greater than TextBox1. Balance the service providers  appropriately in the planning phase", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
