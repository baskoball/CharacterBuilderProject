namespace CharacterBuilder
{
    partial class frmBeginCharacter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBeginCharacter));
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.gboxGender = new System.Windows.Forms.GroupBox();
            this.rdoGenderMale = new System.Windows.Forms.RadioButton();
            this.rdoGenderFemale = new System.Windows.Forms.RadioButton();
            this.lblSelectGender = new System.Windows.Forms.Label();
            this.cboEyeColor = new System.Windows.Forms.ComboBox();
            this.lblEyeColor = new System.Windows.Forms.Label();
            this.cboHeightFeet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboHeightInches = new System.Windows.Forms.ComboBox();
            this.lblHeightFeet = new System.Windows.Forms.Label();
            this.lblHeightInches = new System.Windows.Forms.Label();
            this.txtCharacterWeight = new System.Windows.Forms.TextBox();
            this.lblCharacterWeight = new System.Windows.Forms.Label();
            this.lblWeightLbs = new System.Windows.Forms.Label();
            this.lblCharacterHairColor = new System.Windows.Forms.Label();
            this.cboHairColor = new System.Windows.Forms.ComboBox();
            this.lblCharacterAge = new System.Windows.Forms.Label();
            this.txtCharacterAge = new System.Windows.Forms.TextBox();
            this.lblCharacterSkin = new System.Windows.Forms.Label();
            this.txtCharacterSkin = new System.Windows.Forms.TextBox();
            this.btnBeginingCharacterContinue = new System.Windows.Forms.Button();
            this.gboxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Location = new System.Drawing.Point(37, 39);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(125, 17);
            this.lblCharacterName.TabIndex = 0;
            this.lblCharacterName.Text = "Character\'s Name:";
            this.lblCharacterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(173, 36);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(211, 22);
            this.txtCharacterName.TabIndex = 1;
            // 
            // gboxGender
            // 
            this.gboxGender.Controls.Add(this.rdoGenderFemale);
            this.gboxGender.Controls.Add(this.rdoGenderMale);
            this.gboxGender.Location = new System.Drawing.Point(173, 64);
            this.gboxGender.Name = "gboxGender";
            this.gboxGender.Size = new System.Drawing.Size(176, 60);
            this.gboxGender.TabIndex = 2;
            this.gboxGender.TabStop = false;
            // 
            // rdoGenderMale
            // 
            this.rdoGenderMale.AutoSize = true;
            this.rdoGenderMale.Location = new System.Drawing.Point(7, 22);
            this.rdoGenderMale.Name = "rdoGenderMale";
            this.rdoGenderMale.Size = new System.Drawing.Size(59, 21);
            this.rdoGenderMale.TabIndex = 0;
            this.rdoGenderMale.TabStop = true;
            this.rdoGenderMale.Text = "Male";
            this.rdoGenderMale.UseVisualStyleBackColor = true;
            // 
            // rdoGenderFemale
            // 
            this.rdoGenderFemale.AutoSize = true;
            this.rdoGenderFemale.Location = new System.Drawing.Point(72, 22);
            this.rdoGenderFemale.Name = "rdoGenderFemale";
            this.rdoGenderFemale.Size = new System.Drawing.Size(75, 21);
            this.rdoGenderFemale.TabIndex = 3;
            this.rdoGenderFemale.TabStop = true;
            this.rdoGenderFemale.Text = "Female";
            this.rdoGenderFemale.UseVisualStyleBackColor = true;
            // 
            // lblSelectGender
            // 
            this.lblSelectGender.AutoSize = true;
            this.lblSelectGender.Location = new System.Drawing.Point(100, 88);
            this.lblSelectGender.Name = "lblSelectGender";
            this.lblSelectGender.Size = new System.Drawing.Size(60, 17);
            this.lblSelectGender.TabIndex = 3;
            this.lblSelectGender.Text = "Gender:";
            // 
            // cboEyeColor
            // 
            this.cboEyeColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEyeColor.FormattingEnabled = true;
            this.cboEyeColor.Items.AddRange(new object[] {
            "Brown",
            "Blue",
            "Green",
            "Red",
            "Silver"});
            this.cboEyeColor.Location = new System.Drawing.Point(173, 215);
            this.cboEyeColor.Name = "cboEyeColor";
            this.cboEyeColor.Size = new System.Drawing.Size(121, 24);
            this.cboEyeColor.TabIndex = 6;
            // 
            // lblEyeColor
            // 
            this.lblEyeColor.AutoSize = true;
            this.lblEyeColor.Location = new System.Drawing.Point(90, 218);
            this.lblEyeColor.Name = "lblEyeColor";
            this.lblEyeColor.Size = new System.Drawing.Size(73, 17);
            this.lblEyeColor.TabIndex = 7;
            this.lblEyeColor.Text = "Eye Color:";
            // 
            // cboHeightFeet
            // 
            this.cboHeightFeet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHeightFeet.FormattingEnabled = true;
            this.cboHeightFeet.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboHeightFeet.Location = new System.Drawing.Point(173, 157);
            this.cboHeightFeet.Name = "cboHeightFeet";
            this.cboHeightFeet.Size = new System.Drawing.Size(52, 24);
            this.cboHeightFeet.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Height:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboHeightInches
            // 
            this.cboHeightInches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHeightInches.FormattingEnabled = true;
            this.cboHeightInches.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.cboHeightInches.Location = new System.Drawing.Point(257, 156);
            this.cboHeightInches.Name = "cboHeightInches";
            this.cboHeightInches.Size = new System.Drawing.Size(52, 24);
            this.cboHeightInches.TabIndex = 10;
            // 
            // lblHeightFeet
            // 
            this.lblHeightFeet.AutoSize = true;
            this.lblHeightFeet.Location = new System.Drawing.Point(231, 160);
            this.lblHeightFeet.Name = "lblHeightFeet";
            this.lblHeightFeet.Size = new System.Drawing.Size(20, 17);
            this.lblHeightFeet.TabIndex = 11;
            this.lblHeightFeet.Text = "ft.";
            // 
            // lblHeightInches
            // 
            this.lblHeightInches.AutoSize = true;
            this.lblHeightInches.Location = new System.Drawing.Point(315, 159);
            this.lblHeightInches.Name = "lblHeightInches";
            this.lblHeightInches.Size = new System.Drawing.Size(23, 17);
            this.lblHeightInches.TabIndex = 12;
            this.lblHeightInches.Text = "In.";
            // 
            // txtCharacterWeight
            // 
            this.txtCharacterWeight.Location = new System.Drawing.Point(173, 187);
            this.txtCharacterWeight.Name = "txtCharacterWeight";
            this.txtCharacterWeight.Size = new System.Drawing.Size(100, 22);
            this.txtCharacterWeight.TabIndex = 13;
            // 
            // lblCharacterWeight
            // 
            this.lblCharacterWeight.AutoSize = true;
            this.lblCharacterWeight.Location = new System.Drawing.Point(107, 190);
            this.lblCharacterWeight.Name = "lblCharacterWeight";
            this.lblCharacterWeight.Size = new System.Drawing.Size(56, 17);
            this.lblCharacterWeight.TabIndex = 14;
            this.lblCharacterWeight.Text = "Weight:";
            // 
            // lblWeightLbs
            // 
            this.lblWeightLbs.AutoSize = true;
            this.lblWeightLbs.Location = new System.Drawing.Point(280, 190);
            this.lblWeightLbs.Name = "lblWeightLbs";
            this.lblWeightLbs.Size = new System.Drawing.Size(30, 17);
            this.lblWeightLbs.TabIndex = 15;
            this.lblWeightLbs.Text = "lbs.";
            // 
            // lblCharacterHairColor
            // 
            this.lblCharacterHairColor.AutoSize = true;
            this.lblCharacterHairColor.Location = new System.Drawing.Point(88, 248);
            this.lblCharacterHairColor.Name = "lblCharacterHairColor";
            this.lblCharacterHairColor.Size = new System.Drawing.Size(75, 17);
            this.lblCharacterHairColor.TabIndex = 17;
            this.lblCharacterHairColor.Text = "Hair Color:";
            // 
            // cboHairColor
            // 
            this.cboHairColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHairColor.FormattingEnabled = true;
            this.cboHairColor.Items.AddRange(new object[] {
            "Black",
            "Blonde",
            "Blue",
            "Brown",
            "Gold",
            "Green",
            "Purple",
            "Red",
            "Silver",
            "White"});
            this.cboHairColor.Location = new System.Drawing.Point(173, 245);
            this.cboHairColor.Name = "cboHairColor";
            this.cboHairColor.Size = new System.Drawing.Size(121, 24);
            this.cboHairColor.TabIndex = 16;
            // 
            // lblCharacterAge
            // 
            this.lblCharacterAge.AutoSize = true;
            this.lblCharacterAge.Location = new System.Drawing.Point(123, 133);
            this.lblCharacterAge.Name = "lblCharacterAge";
            this.lblCharacterAge.Size = new System.Drawing.Size(37, 17);
            this.lblCharacterAge.TabIndex = 18;
            this.lblCharacterAge.Text = "Age:";
            // 
            // txtCharacterAge
            // 
            this.txtCharacterAge.Location = new System.Drawing.Point(173, 130);
            this.txtCharacterAge.Name = "txtCharacterAge";
            this.txtCharacterAge.Size = new System.Drawing.Size(100, 22);
            this.txtCharacterAge.TabIndex = 19;
            // 
            // lblCharacterSkin
            // 
            this.lblCharacterSkin.AutoSize = true;
            this.lblCharacterSkin.Location = new System.Drawing.Point(121, 278);
            this.lblCharacterSkin.Name = "lblCharacterSkin";
            this.lblCharacterSkin.Size = new System.Drawing.Size(39, 17);
            this.lblCharacterSkin.TabIndex = 20;
            this.lblCharacterSkin.Text = "Skin:";
            // 
            // txtCharacterSkin
            // 
            this.txtCharacterSkin.Location = new System.Drawing.Point(173, 275);
            this.txtCharacterSkin.Name = "txtCharacterSkin";
            this.txtCharacterSkin.Size = new System.Drawing.Size(100, 22);
            this.txtCharacterSkin.TabIndex = 21;
            // 
            // btnBeginingCharacterContinue
            // 
            this.btnBeginingCharacterContinue.Location = new System.Drawing.Point(173, 325);
            this.btnBeginingCharacterContinue.Name = "btnBeginingCharacterContinue";
            this.btnBeginingCharacterContinue.Size = new System.Drawing.Size(100, 29);
            this.btnBeginingCharacterContinue.TabIndex = 22;
            this.btnBeginingCharacterContinue.Text = "Continue";
            this.btnBeginingCharacterContinue.UseVisualStyleBackColor = true;
            this.btnBeginingCharacterContinue.Click += new System.EventHandler(this.btnBeginingCharacterContinue_Click);
            // 
            // frmBeginCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 407);
            this.Controls.Add(this.btnBeginingCharacterContinue);
            this.Controls.Add(this.txtCharacterSkin);
            this.Controls.Add(this.lblCharacterSkin);
            this.Controls.Add(this.txtCharacterAge);
            this.Controls.Add(this.lblCharacterAge);
            this.Controls.Add(this.lblCharacterHairColor);
            this.Controls.Add(this.cboHairColor);
            this.Controls.Add(this.lblWeightLbs);
            this.Controls.Add(this.lblCharacterWeight);
            this.Controls.Add(this.txtCharacterWeight);
            this.Controls.Add(this.lblHeightInches);
            this.Controls.Add(this.lblHeightFeet);
            this.Controls.Add(this.cboHeightInches);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboHeightFeet);
            this.Controls.Add(this.lblEyeColor);
            this.Controls.Add(this.cboEyeColor);
            this.Controls.Add(this.lblSelectGender);
            this.Controls.Add(this.gboxGender);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.lblCharacterName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBeginCharacter";
            this.Text = "Begining Character";
            this.gboxGender.ResumeLayout(false);
            this.gboxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.GroupBox gboxGender;
        private System.Windows.Forms.RadioButton rdoGenderFemale;
        private System.Windows.Forms.RadioButton rdoGenderMale;
        private System.Windows.Forms.Label lblSelectGender;
        private System.Windows.Forms.ComboBox cboEyeColor;
        private System.Windows.Forms.Label lblEyeColor;
        private System.Windows.Forms.ComboBox cboHeightFeet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHeightInches;
        private System.Windows.Forms.Label lblHeightFeet;
        private System.Windows.Forms.Label lblHeightInches;
        private System.Windows.Forms.TextBox txtCharacterWeight;
        private System.Windows.Forms.Label lblCharacterWeight;
        private System.Windows.Forms.Label lblWeightLbs;
        private System.Windows.Forms.Label lblCharacterHairColor;
        private System.Windows.Forms.ComboBox cboHairColor;
        private System.Windows.Forms.Label lblCharacterAge;
        private System.Windows.Forms.TextBox txtCharacterAge;
        private System.Windows.Forms.Label lblCharacterSkin;
        private System.Windows.Forms.TextBox txtCharacterSkin;
        private System.Windows.Forms.Button btnBeginingCharacterContinue;
    }
}