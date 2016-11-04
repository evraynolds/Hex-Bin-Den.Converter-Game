namespace ConversionGameTool
{
    partial class FormRegisterUser
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label emailLabel;
            this.buttonUserRegistration = new System.Windows.Forms.Button();
            this.databaseUserDeetsDataSet = new ConversionGameTool.DatabaseUserDeetsDataSet();
            this.userDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userDetailsTableAdapter = new ConversionGameTool.DatabaseUserDeetsDataSetTableAdapters.UserDetailsTableAdapter();
            this.tableAdapterManager = new ConversionGameTool.DatabaseUserDeetsDataSetTableAdapters.TableAdapterManager();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.labelWarning = new System.Windows.Forms.Label();
            this.gameScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameScoresTableAdapter = new ConversionGameTool.DatabaseUserDeetsDataSetTableAdapters.GameScoresTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseUserDeetsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameScoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(91, 122);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Name:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(91, 148);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 6;
            userNameLabel.Text = "User Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(91, 174);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // buttonUserRegistration
            // 
            this.buttonUserRegistration.Location = new System.Drawing.Point(160, 259);
            this.buttonUserRegistration.Name = "buttonUserRegistration";
            this.buttonUserRegistration.Size = new System.Drawing.Size(100, 46);
            this.buttonUserRegistration.TabIndex = 3;
            this.buttonUserRegistration.Text = "Register";
            this.buttonUserRegistration.UseVisualStyleBackColor = true;
            this.buttonUserRegistration.Click += new System.EventHandler(this.buttonUserRegistration_Click);
            // 
            // databaseUserDeetsDataSet
            // 
            this.databaseUserDeetsDataSet.DataSetName = "DatabaseUserDeetsDataSet";
            this.databaseUserDeetsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userDetailsBindingSource
            // 
            this.userDetailsBindingSource.DataMember = "UserDetails";
            this.userDetailsBindingSource.DataSource = this.databaseUserDeetsDataSet;
            // 
            // userDetailsTableAdapter
            // 
            this.userDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GameScoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ConversionGameTool.DatabaseUserDeetsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserDetailsTableAdapter = this.userDetailsTableAdapter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDetailsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(160, 119);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDetailsBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(160, 145);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.userNameTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userDetailsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(160, 171);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.ForeColor = System.Drawing.Color.Red;
            this.labelWarning.Location = new System.Drawing.Point(91, 75);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(0, 13);
            this.labelWarning.TabIndex = 10;
            // 
            // gameScoresBindingSource
            // 
            this.gameScoresBindingSource.DataMember = "GameScores";
            this.gameScoresBindingSource.DataSource = this.databaseUserDeetsDataSet;
            // 
            // gameScoresTableAdapter
            // 
            this.gameScoresTableAdapter.ClearBeforeFill = true;
            // 
            // FormRegisterUser
            // 
            this.ClientSize = new System.Drawing.Size(423, 398);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.buttonUserRegistration);
            this.Name = "FormRegisterUser";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FormRegisterUser_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.databaseUserDeetsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameScoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUserRegistration;
        private DatabaseUserDeetsDataSet databaseUserDeetsDataSet;
        private System.Windows.Forms.BindingSource userDetailsBindingSource;
        private DatabaseUserDeetsDataSetTableAdapters.UserDetailsTableAdapter userDetailsTableAdapter;
        private DatabaseUserDeetsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.BindingSource gameScoresBindingSource;
        private DatabaseUserDeetsDataSetTableAdapters.GameScoresTableAdapter gameScoresTableAdapter;

    }
}