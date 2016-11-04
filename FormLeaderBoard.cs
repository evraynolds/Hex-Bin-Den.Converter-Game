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
    public partial class FormLeaderBoard : Form
    {
        int[] scoresInt = new int[10];
        string[] scoresString = new string[10];
        int counter = 0;
        public FormLeaderBoard()
        {
            InitializeComponent();
        }

        private void buttonBackToGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLeaderBoard_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\Evan\\Documents\\Visual Studio 2013\\Projects\\ConversionGameTool\\ConversionGameTool - V2.0\\DatabaseUserDeets.mdf';Integrated Security=True;");
            {
                con.Open();
                string nameQuery = "Select UserName FROM GameScores ORDER BY len(AnsCorrect), AnsCorrect DESC;";
                string scoreQuery = "Select AnsCorrect FROM GameScores ORDER BY len(AnsCorrect), AnsCorrect DESC;";
                SqlCommand scoreDisplayCom = new SqlCommand(scoreQuery, con);
                SqlCommand nameDisplayCom = new SqlCommand(nameQuery, con);
                
                SqlDataReader readNameData = nameDisplayCom.ExecuteReader();

                if (readNameData.Read())
                {
                    labelUserOne.Text = readNameData["UserName"].ToString();
                    
                }              
                if (readNameData.Read())
                {                   
                    labelUserTwo.Text = readNameData["UserName"].ToString();                  
                }              
                if (readNameData.Read())
                {                    
                    labelUserThree.Text = readNameData["UserName"].ToString();  
                }      
                if (readNameData.Read())
                {
                    labelUserFour.Text = readNameData["UserName"].ToString();   
                }
               
                if (readNameData.Read())
                {
                    labelUserFive.Text = readNameData["UserName"].ToString();                   
                }
               
                if (readNameData.Read())
                {
                    labelUserSix.Text = readNameData["UserName"].ToString();     
                }
               
                if (readNameData.Read())
                {
                    labelUserSeven.Text = readNameData["UserName"].ToString();
                }
               
                if (readNameData.Read())
                {
                    labelUserEight.Text = readNameData["UserName"].ToString();   
                }
               
                if (readNameData.Read())
                {            
                    labelUserNine.Text = readNameData["UserName"].ToString();   
                }
               
                if (readNameData.Read())
                {    
                    labelUserTen.Text = readNameData["UserName"].ToString();    
                }
               
                readNameData.Close();
                SqlDataReader readScoreData = scoreDisplayCom.ExecuteReader();
                
                if (readScoreData.Read())
                {
                    labelScoreOne.Text = readScoreData["AnsCorrect"].ToString();
                    scoresString[counter] = readScoreData["AnsCorrect"].ToString();
                    scoresInt[counter] = Int32.Parse(scoresString[0]);
                    counter++;
                }
                if (readScoreData.Read())
                {
                    labelScoreTwo.Text = readScoreData["AnsCorrect"].ToString();
                    scoresString[counter] = readScoreData["AnsCorrect"].ToString();
                    scoresInt[counter] = Int32.Parse(scoresString[0]);
                    counter++;
                }
                if (readScoreData.Read())
                {
                    labelScoreThree.Text = readScoreData["AnsCorrect"].ToString();
                    scoresString[counter] = readScoreData["AnsCorrect"].ToString();
                    scoresInt[counter] = Int32.Parse(scoresString[0]);
                    counter++;
                }
                if (readScoreData.Read())
                {
                    labelScoreFour.Text = readScoreData["AnsCorrect"].ToString();
                    scoresString[counter] = readScoreData["AnsCorrect"].ToString();
                    scoresInt[counter] = Int32.Parse(scoresString[0]);
                    counter++;
                }
                if (readScoreData.Read())
                {
                    labelScoreFive.Text = readScoreData["AnsCorrect"].ToString();
                    scoresString[counter] = readScoreData["AnsCorrect"].ToString();
                    scoresInt[counter] = Int32.Parse(scoresString[0]);
                    counter++;
                }
                if (readScoreData.Read())
                {
                    labelScoreSix.Text = readScoreData["AnsCorrect"].ToString();
                    scoresString[counter] = readScoreData["AnsCorrect"].ToString();
                    scoresInt[counter] = Int32.Parse(scoresString[0]);
                    counter++;
                }
                if (readScoreData.Read())
                {
                    labelScoreSeven.Text = readScoreData["AnsCorrect"].ToString();
                    scoresString[counter] = readScoreData["AnsCorrect"].ToString();
                    scoresInt[counter] = Int32.Parse(scoresString[0]);
                    counter++;
                }
                if (readScoreData.Read())
                {
                    labelScoreEight.Text = readScoreData["AnsCorrect"].ToString();
                    scoresString[counter] = readScoreData["AnsCorrect"].ToString();
                    scoresInt[counter] = Int32.Parse(scoresString[0]);
                    counter++;
                }
                if (readScoreData.Read())
                {
                    labelScoreNine.Text = readScoreData["AnsCorrect"].ToString();
                    scoresString[counter] = readScoreData["AnsCorrect"].ToString();
                    scoresInt[counter] = Int32.Parse(scoresString[0]);
                    counter++;
                }
                if (readScoreData.Read())
                {
                    labelScoreTen.Text = readScoreData["AnsCorrect"].ToString();
                    scoresString[counter] = readScoreData["AnsCorrect"].ToString();
                    scoresInt[counter] = Int32.Parse(scoresString[0]);
                    counter++;
                }
                readScoreData.Close();
                con.Close();
            }
        }
    }
}
