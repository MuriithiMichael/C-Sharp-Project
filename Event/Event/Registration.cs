using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace Event
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // Create a connection object
            SqlConnection loginConnection = new SqlConnection("Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI");

            // Open the connection to the database
            loginConnection.Open();
           
            //retrieve data from textboxes
            string id = textBox1.Text;
            string fname = textBox2.Text;
            string mname = textBox3.Text;
            string lname = textBox4.Text;
            //string date = String.Format(dateTimePicker2.Text);

            string gender = "";
            if (radioButton1.Checked)
            {
                gender = "male";
            }
            else if (radioButton2.Checked)
            {
                gender = "female";
            }
            string accesslevel = comboBox1.Text; 
            string address = textBox5.Text;
            string password = textBox6.Text;

            //retrieve data from radio button


            // prepare command string
            string insertString = @"insert into Person
            (Id, FirstName, MiddleName, LastName, Gender, AccessLevel, Address, Password)
            values ('" + id + "','" + fname + "', '" + mname + "', '" + lname + "', '" + gender + "',  '" + accesslevel + "', '" + address + "','" + password + "')";

            // 1. Instantiate a new command with a query and connection
            SqlCommand cmd = new SqlCommand(insertString, loginConnection);

            // 2. Call ExecuteNonQuery to send command
            cmd.ExecuteNonQuery();

            //display successful message
            MessageBox.Show("Registration successfull", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // }
            // catch
            // {
            //     MessageBox.Show("unsuccessfull attempt. please try again with valid information or assign a non existing patient number.", "SWIFTLIGHT TECHNO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // }

            //close connection
            loginConnection.Close();
            new Login().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.SelectedItem = null; 
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Login().ShowDialog();
        }
    }
}
