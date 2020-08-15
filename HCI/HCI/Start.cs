using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HCI
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Shopping().ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new Savings().ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Bills().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Transport().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Rent().ShowDialog();
        }
    }
}
