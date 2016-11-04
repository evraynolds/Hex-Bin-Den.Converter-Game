namespace ConversionGameTool
{
    partial class Form1
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
            this.buttonPlayGame = new System.Windows.Forms.Button();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonQuitForm = new System.Windows.Forms.Button();
            this.comboBoxBaseConvertFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBaseConvertTo = new System.Windows.Forms.ComboBox();
            this.textBoxEnterNumber = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion Tool";
            // 
            // buttonPlayGame
            // 
            this.buttonPlayGame.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlayGame.Location = new System.Drawing.Point(208, 260);
            this.buttonPlayGame.Name = "buttonPlayGame";
            this.buttonPlayGame.Size = new System.Drawing.Size(92, 42);
            this.buttonPlayGame.TabIndex = 1;
            this.buttonPlayGame.Text = "Play Game";
            this.buttonPlayGame.UseVisualStyleBackColor = true;
            this.buttonPlayGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonConvert
            // 
            this.buttonConvert.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(208, 174);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(92, 54);
            this.buttonConvert.TabIndex = 2;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonQuitForm
            // 
            this.buttonQuitForm.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuitForm.Location = new System.Drawing.Point(314, 260);
            this.buttonQuitForm.Name = "buttonQuitForm";
            this.buttonQuitForm.Size = new System.Drawing.Size(92, 42);
            this.buttonQuitForm.TabIndex = 10;
            this.buttonQuitForm.Text = "Quit";
            this.buttonQuitForm.UseVisualStyleBackColor = true;
            this.buttonQuitForm.Click += new System.EventHandler(this.buttonQuitForm_Click);
            // 
            // comboBoxBaseConvertFrom
            // 
            this.comboBoxBaseConvertFrom.FormattingEnabled = true;
            this.comboBoxBaseConvertFrom.Location = new System.Drawing.Point(32, 87);
            this.comboBoxBaseConvertFrom.Name = "comboBoxBaseConvertFrom";
            this.comboBoxBaseConvertFrom.Size = new System.Drawing.Size(123, 21);
            this.comboBoxBaseConvertFrom.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Convert from:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "To:";
            // 
            // comboBoxBaseConvertTo
            // 
            this.comboBoxBaseConvertTo.FormattingEnabled = true;
            this.comboBoxBaseConvertTo.Location = new System.Drawing.Point(32, 137);
            this.comboBoxBaseConvertTo.Name = "comboBoxBaseConvertTo";
            this.comboBoxBaseConvertTo.Size = new System.Drawing.Size(123, 21);
            this.comboBoxBaseConvertTo.TabIndex = 20;
            // 
            // textBoxEnterNumber
            // 
            this.textBoxEnterNumber.Location = new System.Drawing.Point(208, 88);
            this.textBoxEnterNumber.Name = "textBoxEnterNumber";
            this.textBoxEnterNumber.Size = new System.Drawing.Size(198, 20);
            this.textBoxEnterNumber.TabIndex = 21;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(208, 137);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(198, 20);
            this.textBoxResult.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Enter number to be converted here:";
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.Font = new System.Drawing.Font("Arial Unicode MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorMessage.Location = new System.Drawing.Point(208, 111);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(0, 16);
            this.labelErrorMessage.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 325);
            this.Controls.Add(this.labelErrorMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxEnterNumber);
            this.Controls.Add(this.comboBoxBaseConvertTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxBaseConvertFrom);
            this.Controls.Add(this.buttonQuitForm);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonPlayGame);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPlayGame;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.Button buttonQuitForm;
        private System.Windows.Forms.ComboBox comboBoxBaseConvertFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxBaseConvertTo;
        private System.Windows.Forms.TextBox textBoxEnterNumber;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelErrorMessage;
    }
}

