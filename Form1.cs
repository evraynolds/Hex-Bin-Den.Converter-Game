using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;
using System.Configuration;




namespace ConversionGameTool
{
    
    public partial class Form1 : Form
    {
        int baseFromInt = 0;
        int baseToInt = 0;
        string result = "";

        int testHexInt;
        int testDecInt;
        bool digitHexTestBool;
        bool digitDecTestBool;
        bool digitBinTestBool;

        public Form1()
        {
            InitializeComponent();
            
            comboBoxBaseConvertFrom.Items.Add("Decimal");
            comboBoxBaseConvertFrom.Items.Add("Binary");
            comboBoxBaseConvertFrom.Items.Add("Hexadecimal");

            comboBoxBaseConvertTo.Items.Add("Decimal");
            comboBoxBaseConvertTo.Items.Add("Binary");
            comboBoxBaseConvertTo.Items.Add("Hexadecimal");
        }

        
        private void buttonQuitForm_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        public string myConverterFun(string number, string numBaseFrom, string numBaseTo)
        {

            switch (numBaseFrom)
            {
                case "Decimal":
                    baseFromInt = 10;
                    break;
                case "Binary":
                    baseFromInt = 2;
                    break;
                case "Hexadecimal":
                    baseFromInt = 16;
                    break;
                default: break;
            }

            switch (numBaseTo)
            {
                case "Decimal":
                    baseToInt = 10;
                    break;
                case "Binary":
                    baseToInt = 2;
                    break;
                case "Hexadecimal":
                    baseToInt = 16;
                    break;
                default: break;
            }

            findNumberBase(number);

            if ((digitHexTestBool && numBaseFrom == "Hexadecimal") || (digitBinTestBool && numBaseFrom == "Binary")
                || (digitDecTestBool && numBaseFrom == "Decimal"))
            {
                result = Convert.ToString(Convert.ToInt32(number, baseFromInt), baseToInt);
                labelErrorMessage.Text = "";
            }
            else
            {
                labelErrorMessage.Text = "Please, enter a valid number.";
            }

            return result;
            
        }
        public void findNumberBase(string number)
        {
            testHexInt = 0;
            testDecInt = 0;
            digitHexTestBool = int.TryParse(number, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out testHexInt);
            digitDecTestBool = int.TryParse(number, out testDecInt);
            digitBinTestBool = true;

            foreach (var i in number)
            {
                if (i != '1' && i != '0')
                {
                    digitBinTestBool = false;
                }
            }
    
        }


        private void buttonConvert_Click(object sender, EventArgs e)
        {
            string result = "";
            string enteredNumber = textBoxEnterNumber.Text;
            string baseFromString = comboBoxBaseConvertFrom.SelectedItem.ToString();
            string baseToString = comboBoxBaseConvertTo.SelectedItem.ToString();
            
            result = myConverterFun(enteredNumber, baseFromString, baseToString );

            textBoxResult.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormConversionGame GameForm = new FormConversionGame();
            GameForm.Show();
            
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename='C:\\Users\\Evan\\Documents\\Visual Studio 2013\\Projects\\ConversionGameTool\\ConversionGameTool - V2.0\\DatabaseUserDeets.mdf';Integrated Security=True;");
            {

                
           /* string deleteRow = "DELETE FROM GameScores";
            SqlCommand com = new SqlCommand(deleteRow, con);
            con.Open();
            
            com.ExecuteNonQuery();
            con.Close();
            deleteRow = "TRUNCATE TABLE UserDetails";
            com = new SqlCommand(deleteRow, con);
            com.ExecuteNonQuery();
           */
            }
        }
       
    }
}
