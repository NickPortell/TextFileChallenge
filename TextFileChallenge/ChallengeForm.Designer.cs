using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace TextFileChallenge
{
    partial class ChallengeForm
    {
        private string fileName;
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.agePicker = new System.Windows.Forms.NumericUpDown();
            this.isAliveLabel = new System.Windows.Forms.Label();
            this.isAliveCheckbox = new System.Windows.Forms.CheckBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.saveListButton = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.agePicker)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(26, 28);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(508, 63);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Text File Challenge";
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 31;
            this.usersListBox.Location = new System.Drawing.Point(465, 119);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(516, 500);
            this.usersListBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(34, 119);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(160, 32);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(188, 116);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(236, 39);
            this.firstNameText.TabIndex = 3;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(188, 181);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(236, 39);
            this.lastNameText.TabIndex = 5;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(34, 184);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(159, 32);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(34, 250);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(74, 32);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Age:";
            // 
            // agePicker
            // 
            this.agePicker.Location = new System.Drawing.Point(188, 248);
            this.agePicker.Name = "agePicker";
            this.agePicker.Size = new System.Drawing.Size(89, 39);
            this.agePicker.TabIndex = 7;
            // 
            // isAliveLabel
            // 
            this.isAliveLabel.AutoSize = true;
            this.isAliveLabel.Location = new System.Drawing.Point(34, 314);
            this.isAliveLabel.Name = "isAliveLabel";
            this.isAliveLabel.Size = new System.Drawing.Size(114, 32);
            this.isAliveLabel.TabIndex = 8;
            this.isAliveLabel.Text = "Is Alive:";
            // 
            // isAliveCheckbox
            // 
            this.isAliveCheckbox.AutoSize = true;
            this.isAliveCheckbox.Location = new System.Drawing.Point(188, 324);
            this.isAliveCheckbox.Name = "isAliveCheckbox";
            this.isAliveCheckbox.Size = new System.Drawing.Size(15, 14);
            this.isAliveCheckbox.TabIndex = 9;
            this.isAliveCheckbox.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(34, 494);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(390, 64);
            this.addUserButton.TabIndex = 10;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            // 
            // saveListButton
            // 
            this.saveListButton.Location = new System.Drawing.Point(34, 564);
            this.saveListButton.Name = "saveListButton";
            this.saveListButton.Size = new System.Drawing.Size(390, 64);
            this.saveListButton.TabIndex = 11;
            this.saveListButton.Text = "Save List";
            this.saveListButton.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(40, 362);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(249, 36);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TestExample.csv";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(40, 404);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(302, 36);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "StandardDataSet.csv";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(40, 446);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(313, 36);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "AdvancedDataSet.csv";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // ChallengeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 653);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.saveListButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.isAliveCheckbox);
            this.Controls.Add(this.isAliveLabel);
            this.Controls.Add(this.agePicker);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "ChallengeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text File Challenge by Tim Corey";
            ((System.ComponentModel.ISupportInitialize)(this.agePicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            #region My Code

                //
                // AddUserButton
                //
                this.addUserButton.Click += AddUserButton_Click;
                //
                // SaveListButton
                //
                this.saveListButton.Click += SaveListButton_Click;
                //
                // RadioButton1
                //
                this.radioButton1.Click += RadioButton1_Click;
                //
                // RadioButton2
                //
                this.radioButton2.Click += RadioButton2_Click;
                //
                // RadioButton3
                //
                this.radioButton3.Click += RadioButton3_Click;


            
            
            #endregion
        }



        #endregion

        private void RadioButton3_Click(object sender, EventArgs e)
        {
            users.Clear();
            //fileName = radioButton3.Text;
            fileName = "AdvancedDataSet.csv";
            ReadUserModelListFromFile(@"F:\Weekly Challenges\WriteToTextFile\TextFileChallenge\" + fileName);

        }

        private void RadioButton2_Click(object sender, EventArgs e)
        {
            users.Clear();
            //fileName = radioButton2.Text;
            fileName = "StandardDataSet.csv";
            ReadUserModelListFromFile(@"F:\Weekly Challenges\WriteToTextFile\TextFileChallenge\" + fileName);
        }

        private void RadioButton1_Click(object sender, EventArgs e)
        {
            users.Clear();
            fileName = radioButton1.Text;
            ReadUserModelListFromFile(@"F:\Weekly Challenges\WriteToTextFile\TextFileChallenge\" + fileName);
        }

        private void AddUserButton_Click(object sender, System.EventArgs e)
        {
            UserModel user = new UserModel();
            user.FirstName = firstNameText.Text;
            user.LastName = lastNameText.Text;
            user.Age = int.Parse(agePicker.Value.ToString());
            user.IsAlive = isAliveCheckbox.Checked;
            users.Add(user);
        }

        public void ReadUserModelListFromFile(string directory)
        {
            //List<UserModel> modelList = new List<UserModel>();

            List<string> FirstNames = new List<string>();
            List<string> LastNames = new List<string>();
            List<string> AgeList = new List<string>();
            List<string> IsAliveList = new List<string>();

            using (var reader = new StreamReader(@"" + directory))
            {
                int fName=-1;
                int lName=-1;
                int age=-1;
                int alive=-1;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    
                    if(fName == -1)
                    {
                        for (int i = 0; i < 4; i++)
                        {

                            switch (values[i])
                            {
                                case "FirstName":
                                    {
                                        fName = i;
                                        FirstNames.Add(values[i]);
                                        break;
                                    }
                                case "LastName":
                                    {
                                        lName = i;
                                        LastNames.Add(values[i]);
                                        break;
                                    }
                                case "Age":
                                    {
                                        age = i;
                                        AgeList.Add(values[i]);
                                        break;
                                    }
                                case "IsAlive":
                                    {
                                        alive = i;
                                        IsAliveList.Add(values[i]);
                                        break;
                                    }
                            }

                        }
                    }
                    else if(fName >= 0 && fName < 4)
                    {
                        FirstNames.Add(values[fName]);
                        LastNames.Add(values[lName]);
                        AgeList.Add(values[age]);
                        IsAliveList.Add(values[alive]);

                    }

                }
            }

            for (int i = 1; i < FirstNames.Count; i++)
            {
                UserModel user = new UserModel();
                user.FirstName = FirstNames[i];
                user.LastName = LastNames[i];
                user.Age = int.Parse(AgeList[i]);

                if (IsAliveList[i] == "True" || IsAliveList[i] == "1")
                {
                    user.IsAlive = true;
                }
                else if (IsAliveList[i] == "False" || IsAliveList[i] == "0")
                {
                    user.IsAlive = false;
                }

                //modelList.Add(user);
                users.Add(user);
            }

            //return modelList;
        }

        private void SaveListButton_Click(object sender, System.EventArgs e)
        {
            string fileName = "";

            if (radioButton1.Checked)
            {
                fileName = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                fileName = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                fileName = radioButton3.Text;
            }

            //Read list from file
            if (fileName != "")
            {
                ReadUserModelListFromFile(@"F:\Weekly Challenges\WriteToTextFile\TextFileChallenge\" + fileName);
            }
            else
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "You did not enter a file name. Cancel this operation?";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Closes the parent form.
                    this.Close();
                }
            }


            Type type = typeof(UserModel);
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p => p.Name != "DisplayText");

            using (var writer = new StreamWriter(@"F:\Weekly Challenges\WriteToTextFile\TextFileChallenge\" + fileName))
            {
                writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                foreach (UserModel u in users)
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(u, null))));
                }

            }

            users.Clear();

            //firstNameText.DataBindings.Add(new Binding("Text", users, "FirstName"));
            //lastNameText.DataBindings.Add(new Binding("Text", users, "LastName"));
            //agePicker.DataBindings.Add(new Binding("Number", users, "Age"));
            //isAliveCheckbox.DataBindings.Add(new Binding("Bool", users, "IsAlive"));
        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ListBox usersListBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.NumericUpDown agePicker;
        private System.Windows.Forms.Label isAliveLabel;
        private System.Windows.Forms.CheckBox isAliveCheckbox;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button saveListButton;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;


        #region Copy Of My Code
        //private void MyCode()
        //{

        //    this.headerLabel = new System.Windows.Forms.Label();
        //    this.usersListBox = new System.Windows.Forms.ListBox();
        //    this.firstNameLabel = new System.Windows.Forms.Label();
        //    this.firstNameText = new System.Windows.Forms.TextBox();
        //    this.lastNameText = new System.Windows.Forms.TextBox();
        //    this.lastNameLabel = new System.Windows.Forms.Label();
        //    this.ageLabel = new System.Windows.Forms.Label();
        //    this.agePicker = new System.Windows.Forms.NumericUpDown();
        //    this.isAliveLabel = new System.Windows.Forms.Label();
        //    this.isAliveCheckbox = new System.Windows.Forms.CheckBox();
        //    this.addUserButton = new System.Windows.Forms.Button();
        //    this.saveListButton = new System.Windows.Forms.Button();
        //    this.radioButton1 = new System.Windows.Forms.RadioButton();
        //    this.radioButton2 = new System.Windows.Forms.RadioButton();
        //    this.radioButton3 = new System.Windows.Forms.RadioButton();

        //    //
        //    // AddUserButton
        //    //
        //    this.addUserButton.Click += AddUserButton_Click;
        //    //
        //    // SaveListButton
        //    //
        //    this.saveListButton.Click += SaveListButton_Click;
        //    //
        //    // RadioButton1
        //    //
        //    this.radioButton1.Click += RadioButton1_Click;
        //    //
        //    // RadioButton2
        //    //
        //    this.radioButton2.Click += RadioButton2_Click;
        //    //
        //    // RadioButton3
        //    //
        //    this.radioButton3.Click += RadioButton3_Click;


        //}
        //private void RadioButton3_Click(object sender, EventArgs e)
        //{
        //    users.Clear();
        //    //fileName = radioButton3.Text;
        //    fileName = "AdvancedDataSet.csv";
        //    ReadUserModelListFromFile(@"F:\Weekly Challenges\WriteToTextFile\TextFileChallenge\" + fileName);

        //}

        //private void RadioButton2_Click(object sender, EventArgs e)
        //{
        //    users.Clear();
        //    //fileName = radioButton2.Text;
        //    fileName = "StandardDataSet.csv";
        //    ReadUserModelListFromFile(@"F:\Weekly Challenges\WriteToTextFile\TextFileChallenge\" + fileName);
        //}

        //private void RadioButton1_Click(object sender, EventArgs e)
        //{
        //    users.Clear();
        //    fileName = radioButton1.Text;
        //    ReadUserModelListFromFile(@"F:\Weekly Challenges\WriteToTextFile\TextFileChallenge\" + fileName);
        //}

        //private void AddUserButton_Click(object sender, System.EventArgs e)
        //{
        //    UserModel user = new UserModel();
        //    user.FirstName = firstNameText.Text;
        //    user.LastName = lastNameText.Text;
        //    user.Age = int.Parse(agePicker.Value.ToString());
        //    user.IsAlive = isAliveCheckbox.Checked;
        //    users.Add(user);
        //}

        //public void ReadUserModelListFromFile(string directory)
        //{
        //    //List<UserModel> modelList = new List<UserModel>();

        //    List<string> FirstNames = new List<string>();
        //    List<string> LastNames = new List<string>();
        //    List<string> AgeList = new List<string>();
        //    List<string> IsAliveList = new List<string>();

        //    using (var reader = new StreamReader(@"" + directory))
        //    {

        //        while (!reader.EndOfStream)
        //        {
        //            var line = reader.ReadLine();
        //            var values = line.Split(',');

        //            FirstNames.Add(values[0]);
        //            LastNames.Add(values[1]);
        //            AgeList.Add(values[2]);
        //            IsAliveList.Add(values[3]);
        //        }
        //    }

        //    for (int i = 1; i < FirstNames.Count; i++)
        //    {
        //        UserModel user = new UserModel();
        //        user.FirstName = FirstNames[i];
        //        user.LastName = LastNames[i];
        //        user.Age = int.Parse(AgeList[i]);

        //        if (IsAliveList[i] == "True" || IsAliveList[i] == "1")
        //        {
        //            user.IsAlive = true;
        //        }
        //        else if (IsAliveList[i] == "False" || IsAliveList[i] == "0")
        //        {
        //            user.IsAlive = false;
        //        }

        //        //modelList.Add(user);
        //        users.Add(user);
        //    }

        //    //return modelList;
        //}

        //private void SaveListButton_Click(object sender, System.EventArgs e)
        //{
        //    string fileName = "";

        //    if (radioButton1.Checked)
        //    {
        //        fileName = radioButton1.Text;
        //    }
        //    else if (radioButton2.Checked)
        //    {
        //        fileName = radioButton2.Text;
        //    }
        //    else if (radioButton3.Checked)
        //    {
        //        fileName = radioButton3.Text;
        //    }

        //    //Read list from file
        //    if (fileName != "")
        //    {
        //        ReadUserModelListFromFile(@"F:\Weekly Challenges\WriteToTextFile\TextFileChallenge\" + fileName);
        //    }
        //    else
        //    {
        //        // Initializes the variables to pass to the MessageBox.Show method.
        //        string message = "You did not enter a file name. Cancel this operation?";
        //        string caption = "Error Detected in Input";
        //        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
        //        DialogResult result;

        //        // Displays the MessageBox.
        //        result = MessageBox.Show(message, caption, buttons);
        //        if (result == System.Windows.Forms.DialogResult.Yes)
        //        {
        //            // Closes the parent form.
        //            this.Close();
        //        }
        //    }


        //    Type type = typeof(UserModel);
        //    var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance).Where(p => p.Name != "DisplayText");

        //    using (var writer = new StreamWriter(@"F:\Weekly Challenges\WriteToTextFile\TextFileChallenge\" + fileName))
        //    {
        //        writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

        //        foreach (UserModel u in users)
        //        {
        //            writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(u, null))));
        //        }

        //    }

        //    users.Clear();

        //    //firstNameText.DataBindings.Add(new Binding("Text", users, "FirstName"));
        //    //lastNameText.DataBindings.Add(new Binding("Text", users, "LastName"));
        //    //agePicker.DataBindings.Add(new Binding("Number", users, "Age"));
        //    //isAliveCheckbox.DataBindings.Add(new Binding("Bool", users, "IsAlive"));
        //}
        #endregion
    }
}

