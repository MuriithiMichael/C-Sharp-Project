using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace epmos
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Login().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Registration().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
