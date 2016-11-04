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
    public partial class FormUserGameScore : Form
    {
        string nameForData;
        public FormUserGameScore()
        {
            InitializeComponent();
        }
        public void getUserName(string usersName)
        {
            nameForData = usersName;
            
              
        }
        public void FormUserGameScore_Load(object sender, EventArgs e)
        {FormConversionGame fcg = new FormConversionGame();
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\Evan\\Documents\\Visual Studio 2013\\Projects\\ConversionGameTool\\ConversionGameTool - V2.0\\DatabaseUserDeets.mdf';Integrated Security=True;");
            {

                string com = "Select * FROM GameScores WHERE UserName = @UserName";
                SqlCommand scoreDisplayCom = new SqlCommand(com, con);
                scoreDisplayCom.Parameters.AddWithValue("UserName", nameForData);

                con.Open();
                
                
               
                SqlDataReader readData = scoreDisplayCom.ExecuteReader();
                
                readData.Read();
                labelUserName.Text = readData["UserName"].ToString();
                labelRightAns.Text = readData["AnsCorrect"].ToString();
                labelWrongAns.Text = readData["AnsWrong"].ToString();
                labelTimeTaken.Text = readData["TimeTaken"].ToString();

                readData.Close();
                con.Close();
            }
        }

        private void buttonReturnToGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
