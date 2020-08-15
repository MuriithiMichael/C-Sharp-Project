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
    public partial class Organizer : Form
    {
        public Organizer()
        {
            InitializeComponent();
        }
        // declaring global variable for sql connection
        SqlConnection con = new SqlConnection("Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI");
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox2.Text == "")
            {
                error = "Enter an Event ID for the Event to be searched for";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create a connection object
            SqlConnection eventConnection = new SqlConnection("Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI");


            // Open the connection to the database
            eventConnection.Open();


            //retrieve id from textbox
            string credentials = textBox2.Text;

            // 1. Instantiate a new command with a query and connection
            SqlCommand cmd = new SqlCommand("select * from Cevent", eventConnection);

            // 2. Call Execute reader to get query results
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {


                // get the id from the d base
                string id = (string)rdr["EID"];
                // Console.WriteLine(rdr[0]);
                if (id == credentials)
                {
                    MessageBox.Show("Successful Search!", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // get the name from the d base
                    string title = (string)rdr["Title"];
                    string budget = (string)rdr["Cost"];
                    //string duedate = (string)rdr["DueDate"];
                    textBox1.Text = title;
                    textBox8.Text = title;
                    textBox9.Text = budget;
                    textBox16.Text = title;
                 
                    // textBox20.Text = duedate;
                }
             
            }

            eventConnection.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //fetch the events under the selected category and populates the text box
            // TODO: This line of code loads data into the 'mkasaDataSet.Event' table. You can move, or remove it, as needed.
            String selected = "";
            if (radioButton1.Checked)
            {
                selected = "wedding";
            }
            if(radioButton2.Checked)
            {
                selected = "concert";
            }
            if (radioButton3.Checked)
            {
                selected = "product launches";
            }
            if (radioButton4.Checked)
            {
                selected = "conference";
            }
            if (radioButton5.Checked)
            {
                selected = "tournament";
            }
            if (radioButton6.Checked)
            {
                selected = "seminars";
            }
            if (radioButton7.Checked)
            {
                selected = "meetings";
            }
            if (radioButton8.Checked)
            {
                selected = "award ceremonies";
            }
            
            this.ceventTableAdapter.Fill(this.mkasaDataSet1.Cevent, selected);
            
        }

        private void Organizer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mkasaDataSet1.Cevent' table. You can move, or remove it, as needed.
            //this.ceventTableAdapter.Fill(this.mkasaDataSet1.Cevent);
           
            //displaying results for comboBox1
            SqlCommand cmd = new SqlCommand("SELECT * FROM Provider WHERE Category='Venue' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                   // string budget = (string)rdr["Cost"];
                    comboBox1.Items.Add(rdr["Name"]);
                    //textBox10.Text= budget;
                    
                }

                rdr.Close();
                rdr.Dispose();
                con.Close();
            }
               catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //displaying results for comboBox2
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Provider WHERE Category='Entertainment' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd1.ExecuteReader();

                while (rdr.Read())
                {
                    comboBox2.Items.Add(rdr["Name"]);
                    
                }

                rdr.Close();
                rdr.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //displaying results for comboBox3
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM Provider WHERE Category='Catering' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd2.ExecuteReader();

                while (rdr.Read())
                {
                    comboBox3.Items.Add(rdr["Name"]);
                    
                }

                rdr.Close();
                rdr.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //displaying results for comboBox4
            SqlCommand cmd3 = new SqlCommand("SELECT * FROM Provider WHERE Category='Security' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd3.ExecuteReader();

                while (rdr.Read())
                {
                    comboBox4.Items.Add(rdr["Name"]);
                    
                }

                rdr.Close();
                rdr.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //displaying results for comboBox5
            SqlCommand cmd5 = new SqlCommand("SELECT * FROM Provider WHERE Category='Design' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd5.ExecuteReader();

                while (rdr.Read())
                {
                    comboBox5.Items.Add(rdr["Name"]);
                    
                }

                rdr.Close();
                rdr.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





            //displaying values for textbox10
          

            //displaying values for textbox11
            //displaying values for textbox12
            //displaying values for textbox13
            //displaying values for textbox18
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
             
             textBox22.Text = (Convert.ToInt32(textBox10.Text) + Convert.ToInt32(textBox11.Text) + Convert.ToInt32(textBox12.Text) + Convert.ToInt32(textBox13.Text) + Convert.ToInt32(textBox18.Text)).ToString();
             if (Int32.Parse(textBox9.Text) > Int32.Parse(textBox22.Text))
             {
                 MessageBox.Show("Event budget is within the Client's budget. Save Financial Records", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             else
             {
                 MessageBox.Show("Event budget is beyond the Client's budget! Balance the selected providers untill the amount is within the Clients Budget", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
             /*if ()
             {
                 MessageBox.Show("Event budget is within the Client's budget. Save Financial Records", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     
             }
             else
             {
                 MessageBox.Show("Event budget is beyond the Client's budget! Balance the selected providers untill the amount is within the Clients Budget", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }*/
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd11 = new SqlCommand("SELECT Cost FROM Provider WHERE Name='" + comboBox1.Text + "' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd11.ExecuteReader();

                while (rdr.Read())
                {
                    string budget = (string)rdr["Cost"];

                    textBox10.Text = budget;

                }

                rdr.Close();
                rdr.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
              

           
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {


        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
            /*  //displaying value for textBox10
            SqlCommand cmd11 = new SqlCommand("SELECT Cost FROM Event WHERE Title='" + comboBox1.Text + "' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd11.ExecuteReader();

                while (rdr.Read())
                {
                    string budget = (string)rdr["Cost"];

                    textBox10.Text = budget;

                }

                rdr.Close();
                rdr.Dispose();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //displaying value for textBox11
             SqlCommand cmd12 = new SqlCommand("SELECT Cost FROM Event WHERE Title='" + comboBox2.Text + "' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd12.ExecuteReader();

                while (rdr.Read())
                {
                    string budget = (string)rdr["Cost"];

                    textBox11.Text = budget;

                }

                rdr.Close();
                rdr.Dispose();
                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //displaying value for textBox12
            SqlCommand cmd13 = new SqlCommand("SELECT Cost FROM Event WHERE Title='" + comboBox3.Text + "' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd13.ExecuteReader();

                while (rdr.Read())
                {
                    string budget = (string)rdr["Cost"];

                    textBox12.Text = budget;

                }

                rdr.Close();
                rdr.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //displaying value for textBox13
            SqlCommand cmd14 = new SqlCommand("SELECT Cost FROM Event WHERE Title='" + comboBox4.Text + "' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd14.ExecuteReader();

                while (rdr.Read())
                {
                    string budget = (string)rdr["Cost"];

                    textBox13.Text = budget;

                }

                rdr.Close();
                rdr.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //displaying value for textBox18
            SqlCommand cmd15 = new SqlCommand("SELECT Cost FROM Event WHERE Title='" + comboBox5.Text + "' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd15.ExecuteReader();

                while (rdr.Read())
                {
                    string budget = (string)rdr["Cost"];

                    textBox18.Text = budget;

                }

                rdr.Close();
                rdr.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //displaying value for textBox11
            SqlCommand cmd12 = new SqlCommand("SELECT Cost FROM Provider WHERE Name='" + comboBox2.Text + "' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd12.ExecuteReader();

                while (rdr.Read())
                {
                    string budget = (string)rdr["Cost"];

                    textBox11.Text = budget;

                }

                rdr.Close();
                rdr.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //displaying value for textBox12
            SqlCommand cmd13 = new SqlCommand("SELECT Cost FROM Provider WHERE Name='" + comboBox3.Text + "' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd13.ExecuteReader();

                while (rdr.Read())
                {
                    string budget = (string)rdr["Cost"];

                    textBox12.Text = budget;

                }

                rdr.Close();
                rdr.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            //displaying value for textBox13
            SqlCommand cmd14 = new SqlCommand("SELECT Cost FROM Provider WHERE Name='" + comboBox4.Text + "' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd14.ExecuteReader();

                while (rdr.Read())
                {
                    string budget = (string)rdr["Cost"];

                    textBox13.Text = budget;

                }

                rdr.Close();
                rdr.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            //displaying value for textBox18
            SqlCommand cmd15 = new SqlCommand("SELECT Cost FROM Provider WHERE Name='" + comboBox5.Text + "' ", con);
            try
            {

                con.Open();
                SqlDataReader rdr = cmd15.ExecuteReader();

                while (rdr.Read())
                {
                    string budget = (string)rdr["Cost"];

                    textBox18.Text = budget;

                }

                rdr.Close();
                rdr.Dispose();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox2.Text == "")
            {
                error = "Records cannot be saved before an event is searched. Make sure you search for an event that you want to plan ";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
            // Open the connection to the database
                   con.Open();

            //retrieve data from textboxes
            string eid = textBox2.Text;
            string venue = comboBox1.Text;
            string entertainment = comboBox2.Text;
            string  catering= comboBox3.Text;
            string security = comboBox4.Text;
            string design = comboBox5.Text;
           
            // prepare command string
            string insertString = @"insert into Planning
            (EID, Venue, Entertainment, Catering, Security, Design)
            values ('" + eid + "','" + venue + "','" + entertainment + "', '" + catering + "', '" + security + "', '" + design + "')";

            // 1. Instantiate a new command with a query and connection
            SqlCommand cmd = new SqlCommand(insertString, con);

            // 2. Call ExecuteNonQuery to send command
            cmd.ExecuteNonQuery();

            //display successful message
            MessageBox.Show("Saved successfully", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             catch
             {
                 MessageBox.Show("Saving Failed!", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

            //close connection
            con.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToInt32(textBox9.Text) - Convert.ToInt32(textBox22.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string error = "";
            if (textBox2.Text == "")
            {
                error = "Enter an Event ID for the Event to be searched for";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
                try
                {
                    // Open the connection to the database
                    con.Open();

                    //retrieve data from textboxes
                    string eid = textBox2.Text;
                    string title = textBox8.Text;
                    string venue = textBox10.Text;
                    string entertainment = textBox11.Text;
                    string catering = textBox12.Text;
                    string security = textBox13.Text;
                    string design = textBox18.Text;

                    // prepare command string
                    string insertString = @"insert into Finance
            (EID, Title, Venue, Entertainment, Catering, Security, Design)
            values ('" + eid + "','" + title + "','" + venue + "','" + entertainment + "', '" + catering + "', '" + security + "', '" + design + "')";

                    // 1. Instantiate a new command with a query and connection
                    SqlCommand cmd = new SqlCommand(insertString, con);

                    // 2. Call ExecuteNonQuery to send command
                    cmd.ExecuteNonQuery();

                    //display successful message
                    MessageBox.Show("Saved successfully", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Saving Failed!", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //close connection
                con.Close();
                tabControl1.SelectTab("tabPage5");
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox18.Clear();
                textBox22.Clear();
                textBox3.Clear();
                comboBox1.SelectedItem = null;
                comboBox2.SelectedItem = null;
                comboBox3.SelectedItem = null;
                comboBox4.SelectedItem = null;
                comboBox5.SelectedItem = null;
            }

        private void button3_Click_1(object sender, EventArgs e)
        {
         try
            {
                // Open the connection to the database
                con.Open();

                //retrieve data from textboxes
                string eid = textBox2.Text;
                string title = textBox1.Text;
                string status = comboBox6.Text;
                
                

                // prepare command string
                string insertString = @"insert into Status
            (EID, Title, Status, Egreening)
            values ('" + eid + "','" + title + "', '" + status + "', 'Waiting for Event Completion')";

                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(insertString, con);

                // 2. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();

                //display successful message
                MessageBox.Show("Status Set successfully", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Status Failed!", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //close connection
            con.Close();
            tabControl1.SelectTab("tabPage4");
        }
        


        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage2");
            comboBox6.SelectedItem = null;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
             try
             {
                 // Create a connection object
                 SqlConnection updateConnection = new SqlConnection();
                 updateConnection.ConnectionString = "Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI";

                 // Open the connection to the database
                 updateConnection.Open();
             String eventgreening="";
             if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
             {
                 eventgreening = "Succesfull Event greening";
             }
             else
             {
                 eventgreening = "Unsuccessfull Event Greening";
             }
              /*if( checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
              {

              }
                 if(checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
              {
               eventgreening= "Unsuccesfull Event greening: ALL environmental conservation procedures were followed";
              }
                 if(checkBox1.Checked && checkBox2.Checked)
              {
               eventgreening= "Unsuccesfull Event greening: ALL environmental conservation procedures were followed";
              }
                 if(checkBox1.Checked)
              {
               eventgreening= "UnSuccesfull Event greening: ALL environmental conservation procedures were followed";
              }
                 if(checkBox2.Checked)
              {
               eventgreening= "Succesfull Event greening: ALL environmental conservation procedures were followed";
              }
                 if( checkBox3.Checked)
              {
               eventgreening= "Succesfull Event greening: ALL environmental conservation procedures were followed";
              }
                 if( checkBox4.Checked)
              {
               eventgreening= "Succesfull Event greening: ALL environmental conservation procedures were followed";
              }
                 if(checkBox5.Checked)
              {
               eventgreening= "Succesfull Event greening: ALL environmental conservation procedures were followed";
              }
                 if(checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
              {
               eventgreening= "Succesfull Event greening: ALL environmental conservation procedures were followed";
              }*/
                 // prepare command string
                 string updateString = @"
                  update Status
                  set Status = ' Completed ', Egreening = '" + eventgreening + "' where Title = '" + textBox16.Text + "'";

                 // 1. Instantiate a new command with command text only
                 SqlCommand cmd = new SqlCommand(updateString);

                 // 2. Set the Connection property
                 cmd.Connection = updateConnection;

                 // 3. Call ExecuteNonQuery to send command
                 cmd.ExecuteNonQuery();




                 //display successful message
                 MessageBox.Show("Event Planning completed successfully!", "TMP Solutions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 updateConnection.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage4");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string error = "";
            if (textBox2.Text == "")
            {
                error = "Enter an Event ID for the Event to be searched for";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                // Open the connection to the database
                con.Open();

                //retrieve data from textboxes
                string eid = textBox2.Text;
                string venue = comboBox1.Text;
                string entertainment = comboBox2.Text;
                string catering = comboBox3.Text;
                string security = comboBox4.Text;
                string design = comboBox5.Text;

                // prepare command string
                string insertString = @"insert into Planning
            (EID, Venue, Entertainment, Catering, Security, Design)
            values ('" + eid + "','" + venue + "','" + entertainment + "', '" + catering + "', '" + security + "', '" + design + "')";

                // 1. Instantiate a new command with a query and connection
                SqlCommand cmd = new SqlCommand(insertString, con);

                // 2. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();

                //display successful message
                MessageBox.Show("Bookings Saved successfully", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Saving Failed!", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //close connection
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox18.Clear();
            textBox22.Clear();
            textBox3.Clear();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage4");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox4.SelectedItem = null;
            comboBox5.SelectedItem = null;
            
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox18.Clear();
            textBox22.Clear();
            textBox3.Clear();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string error = "";
            if (textBox2.Text == "")
            {
                error = "Records cannot be saved before an event is searched. Make sure you search for an event that you want to plan ";
                MessageBox.Show(error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
            // Open the connection to the database
                   con.Open();

            //retrieve data from textboxes
            string eid = textBox2.Text;
            string venue = comboBox1.Text;
            string entertainment = comboBox2.Text;
            string  catering= comboBox3.Text;
            string security = comboBox4.Text;
            string design = comboBox5.Text;
           
            // prepare command string
            string insertString = @"insert into Planning
            (EID, Venue, Entertainment, Catering, Security, Design)
            values ('" + eid + "','" + venue + "','" + entertainment + "', '" + catering + "', '" + security + "', '" + design + "')";

            // 1. Instantiate a new command with a query and connection
            SqlCommand cmd = new SqlCommand(insertString, con);

            // 2. Call ExecuteNonQuery to send command
            cmd.ExecuteNonQuery();

            //display successful message
            MessageBox.Show("Saved successfully", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
             catch
             {
                 MessageBox.Show("Saving Failed!", "TMP SOLUTIONS", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

            //close connection
            con.Close();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Create a connection object
                SqlConnection updateConnection = new SqlConnection();
                updateConnection.ConnectionString = "Data Source=(local);Initial Catalog=mkasa;Integrated Security=SSPI";

                // Open the connection to the database
                updateConnection.Open();
                String eventgreening = "";
                if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked && checkBox5.Checked)
                {
                    eventgreening = "Succesfull Event greening";
                }
                else
                {
                    eventgreening = "Unsuccessfull Event Greening";
                }
                
                // prepare command string
                string updateString = @"
                  update Status
                  set Status = ' Completed ', Egreening = '" + eventgreening + "' where Title = '" + textBox16.Text + "'";

                // 1. Instantiate a new command with command text only
                SqlCommand cmd = new SqlCommand(updateString);

                // 2. Set the Connection property
                cmd.Connection = updateConnection;

                // 3. Call ExecuteNonQuery to send command
                cmd.ExecuteNonQuery();




                //display successful message
                MessageBox.Show("Event Planning completed successfully!", "TMP Solutions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateConnection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBox16.Clear();
            textBox9.Clear();
            textBox8.Clear();
            textBox2.Clear();
            textBox1.Clear();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        

        
    }
}
