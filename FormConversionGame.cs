using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Configuration;



namespace ConversionGameTool
{
    
    //public delegate string DelegateNumberForMyConverter(string convertedNumber, string firstBase, string secondBase);
    public delegate void sendUserNameAgainDelegate(string s);
    public partial class FormConversionGame : Form
    {
        private Stopwatch gameTimer;
        Random randomNum;
        string[] theBase = new string[] { "Decimal", "Binary", "Hexadecimal" };
        int[] numBase = new int[] { 10, 2, 16 };

        int rndNumBase1;
        int rndNumBase2;
        int rndBase1;
        int rndBase2;
        int rndNumCon;
        string compareAnswer = "YourResponse";
        string response = "";
        int counter = 0;
        int wrongAns = 0;
        int totalQuestions = 10;
        int numOfQs = 0;
        string nameForData;

        public FormConversionGame()
        {
            
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 FormMain = new Form1();
            FormMain.Show();      
        }

        private void FormConversionGame_Load(object sender, EventArgs e)
        {
            labelUserName.Hide();
            linkRegisterUser.Hide();
            buttonLeaderboard.Hide();
            buttonVerify.Hide();
          /*  if (labelUserName.Text == "1. Please,")
            {
                buttonStartGame.Hide();
            }*/
        }
        
        public void buttonStartGame_Click(object sender, EventArgs e)
        {
            gameTimer = new Stopwatch();
            timer.Enabled = true;
            gameTimer.Start();

            buttonStartGame.Enabled = false;
            buttonVerify.Show();
            buttonVerify_Click(sender, e); 
            
        }

        public void randomBaseIntFun()
        {
            randomNum = new Random();
            rndNumBase1 = randomNum.Next(0, theBase.Length);
            rndNumBase2 = randomNum.Next(0, theBase.Length);

            while (rndNumBase1 == rndNumBase2)
            {
                rndNumBase2 = randomNum.Next(0, theBase.Length);
            }
        }

        private int randomNumberFun()
        {
            randomNum = new Random();
            rndNumCon = randomNum.Next(1, 256);

            return rndNumCon;       
        }

        private void randomBaseStringFun()
        {
            randomNum = new Random();
             rndBase1 = randomNum.Next(0, theBase.Length);
             rndBase2 = randomNum.Next(0, theBase.Length);

            while (rndBase1 == rndBase2)
            {
                rndBase2 = randomNum.Next(0, theBase.Length);
            }
            labelConvertBaseFrom.Text = theBase[rndBase2];
            labelConvertBaseTo.Text = theBase[rndBase1];
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            response = textBoxGameResponse.Text;
            string actualAnswer;

            randomBaseStringFun();
            randomBaseIntFun();

            string base1 = labelConvertBaseFrom.Text;
            string base2 = labelConvertBaseTo.Text;

            int numToConvert = 0;
            numToConvert = randomNumberFun();

            string stringNumToConvert = numToConvert.ToString();


            string newGameNumString = Convert.ToString(Convert.ToInt32(stringNumToConvert, 10), numBase[rndNumBase2]);
            actualAnswer = Convert.ToString(Convert.ToInt32(newGameNumString, numBase[rndNumBase2]), numBase[rndNumBase1]);

            if (compareAnswer == response)
            {
                counter += 1;
                

            }
            else
            {
                wrongAns += 1;
                
            }

            labelNumOfCorrectAns.Text = "Num. of correct answers: " + counter + " out of " + numOfQs;
            numOfQs += 1;

            compareAnswer = actualAnswer;
            labelConvertNumber.Text = newGameNumString;

            labelConvertBaseFrom.Text = theBase[rndNumBase2];
            labelConvertBaseTo.Text = theBase[rndNumBase1];

            textBoxGameResponse.Text = "";

            if ((counter + wrongAns) == totalQuestions)
            {
                string captureTime = labelTimer.Text;
                
                calculateScore(counter, wrongAns, captureTime, nameForData);
            }
        }

        public void calculateScore(int rightAns, int wrongAns, string time, string useName)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\Evan\\Documents\\Visual Studio 2013\\Projects\\ConversionGameTool\\ConversionGameTool - V2.0\\DatabaseUserDeets.mdf';Integrated Security=True;");
            {

                SqlCommand yourScore = new SqlCommand("INSERT INTO GameScores(UserName, AnsCorrect, AnsWrong, TimeTaken) VALUES(@UserName, @AnsCorrect, @AnsWrong, @TimeTaken)", con);
                con.Open();
                yourScore.Parameters.AddWithValue("@UserName", useName);
                yourScore.Parameters.AddWithValue("@AnsCorrect", rightAns);
                yourScore.Parameters.AddWithValue("@AnsWrong", wrongAns);
                yourScore.Parameters.AddWithValue("@TimeTaken", time);
                yourScore.ExecuteNonQuery();
                con.Close();
            }
            FormUserGameScore fugs = new FormUserGameScore();
            sendUserNameAgainDelegate UserDelegate = new sendUserNameAgainDelegate(fugs.getUserName);
            UserDelegate(nameForData);
           
            timer.Stop();
            labelTimer.Text = "";
            
            fugs.Show();
        }

        private void buttonResetGame_Click(object sender, EventArgs e)
        {
            buttonStartGame.Enabled = true;
      
            counter = 0;
            wrongAns = 0;
            labelConvertNumber.Text = "";
            labelNumOfCorrectAns.Text = "";
            labelConvertBaseFrom.Text = "";
            labelConvertBaseTo.Text = "";
            timer.Stop();
            labelTimer.Text = "";

            string fullGameTime = gameTimer.Elapsed.ToString();
        }

        private void linkRegisterUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterUser fru = new FormRegisterUser();
            fru.Show();
            this.Close();       
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = "Timer: " + gameTimer.Elapsed.Minutes.ToString("") + ":" +
           gameTimer.Elapsed.Seconds.ToString("00");
        }

        public void getUserName(string s)
        {
            nameForData = s;
            labelUserName.Text = "Please, answer these ten questions.  Good luck, " + s;
            linkRegisterUser.Hide();
            buttonStartGame.Enabled = true;
        }

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            FormLeaderBoard flb = new FormLeaderBoard();
            flb.Show();
        }
    }
}
