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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string error = "";
           if (textBox1.Text == "" && textBox2.Text == "")
            {
                error = "You have left a required field/s blank.";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (textBox2.TextLength < 8)
           {
               error = "Invalid Password Length.Please enter a minimum of 8 characters.";
               MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
           }
             
            // Create a connection object
            SqlConnection loginConnection = new SqlConnection("Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI");

            // Open the connection to the database
            loginConnection.Open();

            // Test the connection state
            if (loginConnection.State == ConnectionState.Open)
            {
                // instantiate sql command
                SqlCommand logincmd = loginConnection.CreateCommand();

                string identity = textBox1.Text;

                //Create an SQL Statement
                string sqlCommand = "SELECT * FROM  Person WHERE ID ='" + identity + "'";

                //assign statement to sql command
                logincmd.CommandText = sqlCommand;

                //execute command
                SqlDataReader loginReader = logincmd.ExecuteReader();

                //process data
                while (loginReader.Read())
                {
                    // get the password from the d base
                    string pass = (string)loginReader["Password"];

                    //get the id from the database
                    string identification = (string)loginReader["ID"];

                    //retrieve pass from the textbox
                    string credentials = textBox2.Text;



                    //check if pass matches Data Base
                    if (pass == credentials && identification == identity)
                    {
                        // get the accesslevel
                        string AccessLevel = (string)loginReader["AccessLevel"];

                        // succeful message display
                        MessageBox.Show("successful Login.", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (AccessLevel == "Organizer")
                        {
                            new Organizer().ShowDialog();

                        }
                        else if (AccessLevel == "Administrator")
                        {
                            new Admin().ShowDialog();

                        }
                       


                    }
                    else if (pass != credentials || identification != identity) 
                    {
                        MessageBox.Show("unsuccessful Login! please enter the correct credentials", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                        
                   /* else 
                    {
                        MessageBox.Show("unsuccessful Login! please enter the right id", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }*/
                }






            }
              
        }

        private void id_TextChanged(object sender, EventArgs e)
        {
           /* if (textBox1.Text != "")
            {
                MessageBox.Show("Please fill in the User ID", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Registration().ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
           /* WindowState = FormWindowState.Maximized;
            TopMost = true;
           */

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
