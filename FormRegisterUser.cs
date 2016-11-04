using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Configuration;


namespace ConversionGameTool
{
   
    delegate void sendUserNameDelegate(String s);
    public partial class FormRegisterUser : Form
    {
        FormConversionGame fcg = new FormConversionGame();
        
        public FormRegisterUser()
        {
            InitializeComponent();
        }

        private void FormRegisterUser_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonUserRegistration_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\Evan\\Documents\\Visual Studio 2013\\Projects\\ConversionGameTool\\ConversionGameTool - V2.0\\DatabaseUserDeets.mdf';Integrated Security=True;");
            {//
                
                SqlCommand com = new SqlCommand("INSERT INTO UserDetails(Name, UserName, Email) VALUES(@Name, @UserName, @Email)", con);
                SqlCommand linkTables = new SqlCommand("INSERT INTO GameScores(UserName) VALUES(@UserName)", con);
                SqlCommand verify = new SqlCommand("SELECT Count(*) from UserDetails WHERE UserName like @UserName", con);
                verify.Parameters.AddWithValue("@UserName", userNameTextBox.Text);
                con.Open();
                int count = (int)verify.ExecuteScalar();
                if (count > 0 || userNameTextBox.Text == "")
                {
                    labelWarning.Text = "Please enter a unique Username";
                    count = 0;
                    userNameTextBox.Text = "";
                }
                else
                {
                    labelWarning.Text = "Thank you.  You are now registered.";

                    com.Parameters.AddWithValue("@Name", nameTextBox.Text);
                    com.Parameters.AddWithValue("@UserName", userNameTextBox.Text);
                    com.Parameters.AddWithValue("@Email", emailTextBox.Text);
                    //linkTables.Parameters.AddWithValue("@UserName", userNameTextBox.Text);
                   
                    string usersName = userNameTextBox.Text;
                    sendUserNameDelegate UserDelegate = new sendUserNameDelegate(fcg.getUserName);
                    UserDelegate(usersName);
                    fcg.Show();
                    com.ExecuteNonQuery();                    
                   // linkTables.ExecuteNonQuery();
                    
                    this.Validate();
                    this.userDetailsBindingSource.EndEdit();                  
                    this.tableAdapterManager.UpdateAll(this.databaseUserDeetsDataSet);
                    con.Close();
                    this.Close();
                }
                

            }
        }

        private void FormRegisterUser_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseUserDeetsDataSet.GameScores' table. You can move, or remove it, as needed.
           // this.gameScoresTableAdapter.Fill(this.databaseUserDeetsDataSet.GameScores);

        }

                  
    }
}
