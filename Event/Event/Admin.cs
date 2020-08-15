using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Event
{
    public partial class Admin : Form
    {
        // declaring global variable for sql connection
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI");
        SqlCommand cmdEvent= new SqlCommand();
        SqlCommand cmdProvider = new SqlCommand();
        SqlDataAdapter daEvent = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder cb;
        DataTable dt = new DataTable();
        public Admin()
        {
            InitializeComponent();
        }
        private void control()
        {
            dataGridView3.DataSource = ds;
            dataGridView3.DataMember = "Cevent";
            textBox1.DataBindings.Add("Text", ds, "Cevent.EID");
            textBox6.DataBindings.Add("Text", ds, "Cevent.Title");
            textBox15.DataBindings.Add("Text", ds, "Cevent.Type");
            textBox16.DataBindings.Add("Text", ds, "Cevent.Venue");
            textBox17.DataBindings.Add("Text", ds, "Cevent.Cost");
            textBox19.DataBindings.Add("Text", ds, "Cevent.DueDate");
            textBox18.DataBindings.Add("Text", ds, "Cevent.Details");
            textBox26.DataBindings.Add("Text", ds, "Cevent.CID");
        }
        private void control1()
        {
            dataGridView2.DataSource = ds;
            dataGridView2.DataMember = "Person";
            textBox5.DataBindings.Add("Text", ds, "Person.ID");
            textBox3.DataBindings.Add("Text", ds, "Person.FirstName");
            textBox11.DataBindings.Add("Text", ds, "Person.MiddleName");
            textBox12.DataBindings.Add("Text", ds, "Person.LastName");
            textBox13.DataBindings.Add("Text", ds, "Person.Gender");
            textBox22.DataBindings.Add("Text", ds, "Person.AccessLevel");
            textBox14.DataBindings.Add("Text", ds, "Person.Address");
            textBox21.DataBindings.Add("Text", ds, "Person.Password");
        }
        private void control2()
        {
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Client";
            textBox2.DataBindings.Add("Text", ds, "Client.CID");
            textBox4.DataBindings.Add("Text", ds, "Client.FName");
            textBox7.DataBindings.Add("Text", ds, "Client.MName");
            textBox8.DataBindings.Add("Text", ds, "Client.LName");
            textBox9.DataBindings.Add("Text", ds, "Client.Gender");
            textBox10.DataBindings.Add("Text", ds, "Client.Address");
            textBox20.DataBindings.Add("Text", ds, "Client.Password");
        }
        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
           
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mkasaDataSet1.Provider' table. You can move, or remove it, as needed.
            this.ProviderTableAdapter.Fill(this.mkasaDataSet1.Provider);


            this.reportViewer2.RefreshReport();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mkasaDataSet.Client' table. You can move, or remove it, as needed.
           // this.clientTableAdapter.Fill(this.mkasaDataSet.Client);

            //this.reportViewer1.RefreshReport();

            con.Open();
            cmdEvent = new SqlCommand("Select * from Client", con);
            daEvent = new SqlDataAdapter(cmdEvent);
            daEvent.Fill(ds, "Client");
            //daEvent.Fill(dt, "Event");
            control2();
            cb = new SqlCommandBuilder(daEvent);
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mkasaDataSet.Person' table. You can move, or remove it, as needed.
            //this.personTableAdapter.Fill(this.mkasaDataSet.Person, "Organizer");

            con.Open();
            cmdEvent = new SqlCommand("Select * from Person where AccessLevel= 'Organizer'", con);
            daEvent = new SqlDataAdapter(cmdEvent);
            daEvent.Fill(ds, "Person");
            //daEvent.Fill(dt, "Event");
            control1();
            cb = new SqlCommandBuilder(daEvent);
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mkasaDataSet.Event' table. You can move, or remove it, as needed.
            //this.eventTableAdapter.Fill(this.mkasaDataSet.Event,textBox19.Text);

            con.Open();
            cmdEvent = new SqlCommand("Select * from Cevent", con);
            daEvent = new SqlDataAdapter(cmdEvent);
            daEvent.Fill(ds, "Cevent");
            //daEvent.Fill(dt, "Event");
            control();
            cb = new SqlCommandBuilder(daEvent);
            con.Close();
           
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 
            

           /*( if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textBox2.Text = row.Cells["CID"].Value.ToString();
                textBox4.Text = row.Cells["Fname"].Value.ToString();
                textBox7.Text = row.Cells["Mname"].Value.ToString();
                textBox8.Text = row.Cells["Lname"].Value.ToString();
                textBox9.Text = row.Cells["Gender"].Value.ToString();
                textBox10.Text = row.Cells["Address"].Value.ToString();
                textBox20.Text = row.Cells["Password"].Value.ToString();
            }*/
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];

                textBox5.Text = row.Cells["ID"].Value.ToString();
                textBox3.Text = row.Cells["FirstName"].Value.ToString();
                textBox11.Text = row.Cells["MiddleName"].Value.ToString();
                textBox12.Text = row.Cells["LastName"].Value.ToString();
                //textBox13.Text = row.Cells["Gender"].Value.ToString();
                textBox22.Text = row.Cells["AccessLevel"].Value.ToString();
                //textBox14.Text = row.Cells["Address"].Value.ToString();
                //textBox21.Text = row.Cells["Password"].Value.ToString();
            }*/
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView3_DoubleClick(object sender, EventArgs e)
        {
          /*  try
            {

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Event where EID=" +
                    Convert.ToInt16(dataGridView3.SelectedRows[0].Cells[0].Value.ToString()) + " ", con);
                da.Fill(dt);

                // displaying records into the textbox
                textBox1.Text = dt.Rows[0][0].ToString();
                textBox6.Text = dt.Rows[0][1].ToString();
                textBox15.Text = dt.Rows[0][2].ToString();
                textBox16.Text = dt.Rows[0][3].ToString();
                textBox17.Text = dt.Rows[0][4].ToString();
                textBox18.Text = dt.Rows[0][5].ToString();
            }



            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            */
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Cevent"].AddNew();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox1.Text == "")
            {
                error = "Enter an Event ID for the new event";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.BindingContext[ds, "Cevent"].EndCurrentEdit();
            if(ds.HasChanges()==true)
            {
                try
                {
                    daEvent.Update(ds, "Cevent");
                    MessageBox.Show(" Added Successfully!");
                }
                catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox2.Text == "")
            {
                error = "CID field cannot be blank.";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           /* else if (textBox2.TextLength < 8)
            {
                error = "Invalid Password Length.Please enter a minimum of 8 characters.";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            try
            {
                // Create a connection object
                SqlConnection updateConnection = new SqlConnection();
                updateConnection.ConnectionString = "Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI";

                // Open the connection to the database
                updateConnection.Open();

                // prepare command string
                string updateString = @"
                 update Client
                 set FName = '" + textBox4.Text + "', MName = '" + textBox7.Text + "', LName = '" + textBox8.Text + "', Gender = '" + textBox9.Text + "', Address = '" + textBox10.Text + "', Password = '" + textBox20.Text + "' where CID = '" + textBox2.Text + "'";

                // 1. Instantiate a new command with command text only
                SqlCommand cmd = new SqlCommand(updateString);

                // 2. Set the Connection property
                cmd.Connection = updateConnection;

                // 3. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();




                //display successful message
                MessageBox.Show("Update  Successfull", "TMP Solutions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox1.Text == "")
            {
                error = "Select an event to be deleted";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Create a connection object
                SqlConnection deleteConnection = new SqlConnection();
                deleteConnection.ConnectionString = "Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI";

                // Open the connection to the database
                deleteConnection.Open();

                // prepare command string
                string deleteString = @"
                 delete from Cevent where EID = '" + textBox1.Text + "'";

                // 1. Instantiate a new command with command text only
                SqlCommand cmd = new SqlCommand(deleteString);

                // 2. Set the Connection property
                cmd.Connection = deleteConnection;

                // 3. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();




                //display successful message
                MessageBox.Show("Delete  Successfull", "TMP Solutions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deleteConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            int delrow;
            delrow = this.BindingContext[ds, "Cevent"].Position;
            this.BindingContext[ds, "Cevent"].RemoveAt(delrow);
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox1.Text == "")
            {
                error = "Select the event to be editted";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Create a connection object
                SqlConnection updateConnection = new SqlConnection();
                updateConnection.ConnectionString = "Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI";

                // Open the connection to the database
                updateConnection.Open();

                // prepare command string
                string updateString = @"
                 update Cevent
                 set Title = '" + textBox6.Text + "', Type = '" + textBox15.Text + "', Venue = '" + textBox16.Text + "', Cost = '" + textBox17.Text + "', DueDate = '" + textBox19.Text + "', Details = '" + textBox18.Text + "',CID = '" + textBox26.Text + "' where EID = '" + textBox1.Text + "'";

                // 1. Instantiate a new command with command text only
                SqlCommand cmd = new SqlCommand(updateString);

                // 2. Set the Connection property
                cmd.Connection = updateConnection;

                // 3. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();




                //display successful message
                MessageBox.Show("Update  Successfull", "TMP Solutions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            /*try
            {
            con.Open();
            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = con;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = " UPDATE Cevent SET Title='"+ textBox6.Text +"', Type='"+ textBox15.Text +"', Venue='"+ textBox16.Text +"', Cost= '"+textBox17.Text+"'  WHERE EID='"+ textBox1.Text +"' ";
            cmdUpdate.ExecuteNonQuery();
                MessageBox.Show("Update Successfull!");
                con.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Person"].AddNew();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox5.Text == "")
            {
                error = "A new/updated event requires an event ID";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.BindingContext[ds, "Person"].EndCurrentEdit();
            if(ds.HasChanges()==true)
            {
                try
                {
                    daEvent.Update(ds, "Person");
                    MessageBox.Show("Added Successfully!");
                }
                catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
        }
    }

        private void button6_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox5.Text == "")
            {
                error = "Select an event to be deleted";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Create a connection object
                SqlConnection deleteConnection = new SqlConnection();
                deleteConnection.ConnectionString = "Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI";

                // Open the connection to the database
                deleteConnection.Open();

                // prepare command string
                string deleteString = @"
                 delete from Person where ID = '" + textBox5.Text + "'";

                // 1. Instantiate a new command with command text only
                SqlCommand cmd = new SqlCommand(deleteString);

                // 2. Set the Connection property
                cmd.Connection = deleteConnection;

                // 3. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();




                //display successful message
                MessageBox.Show("Delete  Successfull", "TMP Solutions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deleteConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
            int delrow;
            delrow = this.BindingContext[ds, "Person"].Position;
            this.BindingContext[ds, "Person"].RemoveAt(delrow);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox5.Text == "")
            {
                error = "Select an event to be editted.";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        try
            {
                // Create a connection object
                SqlConnection updateConnection = new SqlConnection();
                updateConnection.ConnectionString = "Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI";

                // Open the connection to the database
                updateConnection.Open();

                // prepare command string
                string updateString = @"
                 update Person
                 set FirstName = '" + textBox3.Text + "', MiddleName = '" + textBox11.Text + "', LastName = '" + textBox12.Text + "', Gender = '" + textBox13.Text + "', AccessLevel = '" + textBox22.Text + "', Address = '" + textBox14.Text + "', Password = '" + textBox21.Text + "' where ID = '" + textBox3.Text + "'";

                // 1. Instantiate a new command with command text only
                SqlCommand cmd = new SqlCommand(updateString);

                // 2. Set the Connection property
                cmd.Connection = updateConnection;

                // 3. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();




                //display successful message
                MessageBox.Show("Update  Successfull", "TMP Solutions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Client"].AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox2.Text == "")
            {
                error = "Select an event to be deleted.";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Create a connection object
                SqlConnection deleteConnection = new SqlConnection();
                deleteConnection.ConnectionString = "Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI";

                // Open the connection to the database
                deleteConnection.Open();

                // prepare command string
                string deleteString = @"
                 delete from Client where CID = '" + textBox2.Text + "'";

                // 1. Instantiate a new command with command text only
                SqlCommand cmd = new SqlCommand(deleteString);

                // 2. Set the Connection property
                cmd.Connection = deleteConnection;

                // 3. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();




                //display successful message
                MessageBox.Show("Delete  Successfull", "TMP Solutions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deleteConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int delrow;
            delrow = this.BindingContext[ds, "Client"].Position;
            this.BindingContext[ds, "Client"].RemoveAt(delrow);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox2.Text == "")
            {
                error = "Enter a client ID for the new Client ";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.BindingContext[ds, "Client"].EndCurrentEdit();
            if (ds.HasChanges() == true)
            {
                try
                {
                    daEvent.Update(ds, "Client");
                    MessageBox.Show("Added Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "Provider"].AddNew();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox24.Text == "")
            {
                error = "Select the provider to be editted";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Create a connection object
                SqlConnection updateConnection = new SqlConnection();
                updateConnection.ConnectionString = "Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI";

                // Open the connection to the database
                updateConnection.Open();

                // prepare command string
                string updateString = @"
                 update Provider
                 set Name = '" + textBox23.Text + "', Category = '" + comboBox1.Text + "', Cost = '" + textBox25.Text + "' where PID = '" + textBox24.Text + "'";

                // 1. Instantiate a new command with command text only
                SqlCommand cmd = new SqlCommand(updateString);

                // 2. Set the Connection property
                cmd.Connection = updateConnection;

                // 3. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();




                //display successful message
                MessageBox.Show("Update  Successfull", "TMP Solutions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox5.Text == "")
            {
                error = "Select the provider to be deleted";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Create a connection object
                SqlConnection deleteConnection = new SqlConnection();
                deleteConnection.ConnectionString = "Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI";

                // Open the connection to the database
                deleteConnection.Open();

                // prepare command string
                string deleteString = @"
                 delete from Provider where PID = '" + textBox24.Text + "'";

                // 1. Instantiate a new command with command text only
                SqlCommand cmd = new SqlCommand(deleteString);

                // 2. Set the Connection property
                cmd.Connection = deleteConnection;

                // 3. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();




                //display successful message
                MessageBox.Show("Delete  Successfull", "TMP Solutions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                deleteConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int delrow;
            delrow = this.BindingContext[ds, "Provider"].Position;
            this.BindingContext[ds, "Provider"].RemoveAt(delrow);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox24.Text == "")
            {
                error = "Enter the provider ID for the new provider ";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.BindingContext[ds, "Provider"].EndCurrentEdit();
            if (ds.HasChanges() == true)
            {
                try
                {
                    daEvent.Update(ds, "Provider");
                    MessageBox.Show("Added Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            con.Open();
            cmdProvider = new SqlCommand("Select * from Provider", con);
            daEvent = new SqlDataAdapter(cmdProvider);
            daEvent.Fill(ds, "Provider");
            //daEvent.Fill(dt, "Event");
            dataGridView4.DataSource = ds;
            dataGridView4.DataMember = "Provider";
            textBox23.DataBindings.Add("Text", ds, "Provider.Name");
            comboBox1.DataBindings.Add("Text", ds, "Provider.Category");
            textBox25.DataBindings.Add("Text", ds, "Provider.Cost");
            textBox24.DataBindings.Add("Text", ds, "Provider.PID");
            
            cb = new SqlCommandBuilder(daEvent);
            con.Close();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            Close();
        }

       
}
    }
