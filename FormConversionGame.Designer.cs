namespace ConversionGameTool
{
    partial class FormConversionGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelConvertNumber = new System.Windows.Forms.Label();
            this.labelConvertBaseFrom = new System.Windows.Forms.Label();
            this.labelConvertBaseTo = new System.Windows.Forms.Label();
            this.textBoxGameResponse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.buttonResetGame = new System.Windows.Forms.Button();
            this.linkRegisterUser = new System.Windows.Forms.LinkLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelNumOfCorrectAns = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonLeaderboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion Game";
            // 
            // buttonConverter
            // 
            this.buttonConverter.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConverter.Location = new System.Drawing.Point(24, 308);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(88, 45);
            this.buttonConverter.TabIndex = 1;
            this.buttonConverter.Text = "Use Converter";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(333, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Quit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Convert:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Of base:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "To base:";
            // 
            // labelConvertNumber
            // 
            this.labelConvertNumber.AutoSize = true;
            this.labelConvertNumber.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConvertNumber.Location = new System.Drawing.Point(112, 149);
            this.labelConvertNumber.Name = "labelConvertNumber";
            this.labelConvertNumber.Size = new System.Drawing.Size(0, 16);
            this.labelConvertNumber.TabIndex = 6;
            // 
            // labelConvertBaseFrom
            // 
            this.labelConvertBaseFrom.AutoSize = true;
            this.labelConvertBaseFrom.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConvertBaseFrom.Location = new System.Drawing.Point(112, 172);
            this.labelConvertBaseFrom.Name = "labelConvertBaseFrom";
            this.labelConvertBaseFrom.Size = new System.Drawing.Size(0, 16);
            this.labelConvertBaseFrom.TabIndex = 7;
            // 
            // labelConvertBaseTo
            // 
            this.labelConvertBaseTo.AutoSize = true;
            this.labelConvertBaseTo.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConvertBaseTo.Location = new System.Drawing.Point(112, 195);
            this.labelConvertBaseTo.Name = "labelConvertBaseTo";
            this.labelConvertBaseTo.Size = new System.Drawing.Size(0, 16);
            this.labelConvertBaseTo.TabIndex = 8;
            // 
            // textBoxGameResponse
            // 
            this.textBoxGameResponse.Location = new System.Drawing.Point(256, 168);
            this.textBoxGameResponse.Name = "textBoxGameResponse";
            this.textBoxGameResponse.Size = new System.Drawing.Size(126, 20);
            this.textBoxGameResponse.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(253, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Enter Response Here:";
            // 
            // buttonVerify
            // 
            this.buttonVerify.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerify.Location = new System.Drawing.Point(256, 195);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(126, 44);
            this.buttonVerify.TabIndex = 11;
            this.buttonVerify.Text = "Verify response";
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(256, 95);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(126, 51);
            this.buttonStartGame.TabIndex = 12;
            this.buttonStartGame.Text = "Start Game";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // buttonResetGame
            // 
            this.buttonResetGame.Location = new System.Drawing.Point(229, 308);
            this.buttonResetGame.Name = "buttonResetGame";
            this.buttonResetGame.Size = new System.Drawing.Size(88, 45);
            this.buttonResetGame.TabIndex = 13;
            this.buttonResetGame.Text = "Reset Game";
            this.buttonResetGame.UseVisualStyleBackColor = true;
            this.buttonResetGame.Click += new System.EventHandler(this.buttonResetGame_Click);
            // 
            // linkRegisterUser
            // 
            this.linkRegisterUser.AutoSize = true;
            this.linkRegisterUser.Location = new System.Drawing.Point(91, 65);
            this.linkRegisterUser.Name = "linkRegisterUser";
            this.linkRegisterUser.Size = new System.Drawing.Size(41, 13);
            this.linkRegisterUser.TabIndex = 14;
            this.linkRegisterUser.TabStop = true;
            this.linkRegisterUser.Text = "register";
            this.linkRegisterUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegisterUser_LinkClicked);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Location = new System.Drawing.Point(236, 20);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(0, 13);
            this.labelTimer.TabIndex = 15;
            // 
            // labelNumOfCorrectAns
            // 
            this.labelNumOfCorrectAns.AutoSize = true;
            this.labelNumOfCorrectAns.Location = new System.Drawing.Point(256, 246);
            this.labelNumOfCorrectAns.Name = "labelNumOfCorrectAns";
            this.labelNumOfCorrectAns.Size = new System.Drawing.Size(0, 13);
            this.labelNumOfCorrectAns.TabIndex = 16;
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(40, 65);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(54, 13);
            this.labelUserName.TabIndex = 17;
            this.labelUserName.Text = "1. Please,";
            // 
            // buttonLeaderboard
            // 
            this.buttonLeaderboard.Location = new System.Drawing.Point(126, 308);
            this.buttonLeaderboard.Name = "buttonLeaderboard";
            this.buttonLeaderboard.Size = new System.Drawing.Size(88, 45);
            this.buttonLeaderboard.TabIndex = 18;
            this.buttonLeaderboard.Text = "View Leaderboard";
            this.buttonLeaderboard.UseVisualStyleBackColor = true;
            this.buttonLeaderboard.Click += new System.EventHandler(this.buttonLeaderboard_Click);
            // 
            // FormConversionGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 397);
            this.Controls.Add(this.buttonLeaderboard);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelNumOfCorrectAns);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.linkRegisterUser);
            this.Controls.Add(this.buttonResetGame);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxGameResponse);
            this.Controls.Add(this.labelConvertBaseTo);
            this.Controls.Add(this.labelConvertBaseFrom);
            this.Controls.Add(this.labelConvertNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.label1);
            this.Name = "FormConversionGame";
            this.Text = "FormConversionGame";
            this.Load += new System.EventHandler(this.FormConversionGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelConvertNumber;
        private System.Windows.Forms.Label labelConvertBaseFrom;
        private System.Windows.Forms.Label labelConvertBaseTo;
        private System.Windows.Forms.TextBox textBoxGameResponse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonVerify;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Button buttonResetGame;
        private System.Windows.Forms.LinkLabel linkRegisterUser;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelNumOfCorrectAns;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonLeaderboard;
    }
}