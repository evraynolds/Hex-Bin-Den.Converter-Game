namespace ConversionGameTool
{
    partial class FormUserGameScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelRightAns = new System.Windows.Forms.Label();
            this.labelWrongAns = new System.Windows.Forms.Label();
            this.labelTimeTaken = new System.Windows.Forms.Label();
            this.buttonReturnToGame = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Here is how your game score";
            // 
            // labelRightAns
            // 
            this.labelRightAns.AutoSize = true;
            this.labelRightAns.Location = new System.Drawing.Point(189, 122);
            this.labelRightAns.Name = "labelRightAns";
            this.labelRightAns.Size = new System.Drawing.Size(35, 13);
            this.labelRightAns.TabIndex = 1;
            this.labelRightAns.Text = "label2";
            // 
            // labelWrongAns
            // 
            this.labelWrongAns.AutoSize = true;
            this.labelWrongAns.Location = new System.Drawing.Point(189, 159);
            this.labelWrongAns.Name = "labelWrongAns";
            this.labelWrongAns.Size = new System.Drawing.Size(35, 13);
            this.labelWrongAns.TabIndex = 2;
            this.labelWrongAns.Text = "label3";
            // 
            // labelTimeTaken
            // 
            this.labelTimeTaken.AutoSize = true;
            this.labelTimeTaken.Location = new System.Drawing.Point(189, 189);
            this.labelTimeTaken.Name = "labelTimeTaken";
            this.labelTimeTaken.Size = new System.Drawing.Size(35, 13);
            this.labelTimeTaken.TabIndex = 3;
            this.labelTimeTaken.Text = "label4";
            // 
            // buttonReturnToGame
            // 
            this.buttonReturnToGame.Location = new System.Drawing.Point(117, 285);
            this.buttonReturnToGame.Name = "buttonReturnToGame";
            this.buttonReturnToGame.Size = new System.Drawing.Size(107, 46);
            this.buttonReturnToGame.TabIndex = 4;
            this.buttonReturnToGame.Text = "Return to the game";
            this.buttonReturnToGame.UseVisualStyleBackColor = true;
            this.buttonReturnToGame.Click += new System.EventHandler(this.buttonReturnToGame_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(189, 93);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(35, 13);
            this.labelUserName.TabIndex = 5;
            this.labelUserName.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Correct Answers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Wrong Answers:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Time Taken: ";
            // 
            // FormUserGameScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 363);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonReturnToGame);
            this.Controls.Add(this.labelTimeTaken);
            this.Controls.Add(this.labelWrongAns);
            this.Controls.Add(this.labelRightAns);
            this.Controls.Add(this.label1);
            this.Name = "FormUserGameScore";
            this.Text = "FormUserGameScore";
            this.Load += new System.EventHandler(this.FormUserGameScore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRightAns;
        private System.Windows.Forms.Label labelWrongAns;
        private System.Windows.Forms.Label labelTimeTaken;
        private System.Windows.Forms.Button buttonReturnToGame;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}