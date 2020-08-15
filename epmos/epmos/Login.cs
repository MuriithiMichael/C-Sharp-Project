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


namespace epmos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a connection object
            SqlConnection loginConnection = new SqlConnection("Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI");

            // Open the connection to the database
            loginConnection.Open();

            // Test the connection state
            if (loginConnection.State == ConnectionState.Open)
            {
                // instantiate sql command
                SqlCommand logincmd = loginConnection.CreateCommand();

                //Retrieve ID from the textbox
                string identity = id.Text;
                string credentials = password.Text;

                //Create an SQL Statement
                string sqlCommand = "select * from Reg where Id ='" + identity + "' and Password ='" + credentials + "'" ;

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
                    



                    //check if pass matches Data Base
                    if (pass == credentials && identification == identity)
                    {
                        // get the accesslevel
                        string AccessLevel = (string)loginReader["accessLevel"];

                        // succeful message display
                        MessageBox.Show("successful Login.", "SWIFTLIGHT TECHNO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (AccessLevel == "Organizer")
                        {
                            new Organizer().ShowDialog();

                        }
                        else if (AccessLevel == "administrator")
                        {
                            new Administrator().ShowDialog();

                        }
                       


                    }
                    else if (pass != credentials || identification != identity)
                    {
                        MessageBox.Show("unsuccessful Login! please enter the right password", "SWIFTLIGHT TECHNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("unsuccessful Login! please enter the right id", "SWIFTLIGHT TECHNO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }






            }
              
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Registration().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
