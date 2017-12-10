namespace CharacterBuilder
{
    partial class frmSetCharacterAbilityStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetCharacterAbilityStats));
            this.btnSetCharacterAbilityStatsContinue = new System.Windows.Forms.Button();
            this.lblStrengthStat = new System.Windows.Forms.Label();
            this.lblAbilityStatsHeader = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtStrengthStat = new System.Windows.Forms.TextBox();
            this.btnStrengthRNG = new System.Windows.Forms.Button();
            this.txtStrengthStatDescription = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDexterityRNG = new System.Windows.Forms.Button();
            this.txtDexterityStat = new System.Windows.Forms.TextBox();
            this.lblDexterityStat = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnConstitutionRNG = new System.Windows.Forms.Button();
            this.txtConstitutionStat = new System.Windows.Forms.TextBox();
            this.lblConstitutionStat = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btnIntelligenceRNG = new System.Windows.Forms.Button();
            this.txtIntelligenceStat = new System.Windows.Forms.TextBox();
            this.lblIntelligenceStat = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnWisdomRNG = new System.Windows.Forms.Button();
            this.txtWisdomStat = new System.Windows.Forms.TextBox();
            this.lblWisdomStat = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.btnCharismaRNG = new System.Windows.Forms.Button();
            this.txtCharismaStat = new System.Windows.Forms.TextBox();
            this.lblCharismaStat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSetCharacterAbilityStatsContinue
            // 
            this.btnSetCharacterAbilityStatsContinue.Location = new System.Drawing.Point(354, 517);
            this.btnSetCharacterAbilityStatsContinue.Name = "btnSetCharacterAbilityStatsContinue";
            this.btnSetCharacterAbilityStatsContinue.Size = new System.Drawing.Size(100, 29);
            this.btnSetCharacterAbilityStatsContinue.TabIndex = 31;
            this.btnSetCharacterAbilityStatsContinue.Text = "Continue";
            this.btnSetCharacterAbilityStatsContinue.UseVisualStyleBackColor = true;
            this.btnSetCharacterAbilityStatsContinue.Click += new System.EventHandler(this.btnSetCharacterAbilityStatsContinue_Click);
            // 
            // lblStrengthStat
            // 
            this.lblStrengthStat.AutoSize = true;
            this.lblStrengthStat.Location = new System.Drawing.Point(62, 116);
            this.lblStrengthStat.Name = "lblStrengthStat";
            this.lblStrengthStat.Size = new System.Drawing.Size(66, 17);
            this.lblStrengthStat.TabIndex = 32;
            this.lblStrengthStat.Text = "Strength:";
            // 
            // lblAbilityStatsHeader
            // 
            this.lblAbilityStatsHeader.AutoSize = true;
            this.lblAbilityStatsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbilityStatsHeader.Location = new System.Drawing.Point(42, 37);
            this.lblAbilityStatsHeader.Name = "lblAbilityStatsHeader";
            this.lblAbilityStatsHeader.Size = new System.Drawing.Size(178, 32);
            this.lblAbilityStatsHeader.TabIndex = 33;
            this.lblAbilityStatsHeader.Text = "Ability Stats";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(226, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(430, 40);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "Manually enter an ability score from 3-18 or select random to get a random number" +
    " assigned for each score.";
            // 
            // txtStrengthStat
            // 
            this.txtStrengthStat.Enabled = false;
            this.txtStrengthStat.Location = new System.Drawing.Point(140, 113);
            this.txtStrengthStat.Name = "txtStrengthStat";
            this.txtStrengthStat.Size = new System.Drawing.Size(58, 22);
            this.txtStrengthStat.TabIndex = 35;
            // 
            // btnStrengthRNG
            // 
            this.btnStrengthRNG.Location = new System.Drawing.Point(217, 111);
            this.btnStrengthRNG.Name = "btnStrengthRNG";
            this.btnStrengthRNG.Size = new System.Drawing.Size(78, 42);
            this.btnStrengthRNG.TabIndex = 36;
            this.btnStrengthRNG.Text = "Str";
            this.btnStrengthRNG.UseVisualStyleBackColor = true;
            this.btnStrengthRNG.Click += new System.EventHandler(this.btnStrengthRNG_Click);
            // 
            // txtStrengthStatDescription
            // 
            this.txtStrengthStatDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtStrengthStatDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStrengthStatDescription.Location = new System.Drawing.Point(316, 113);
            this.txtStrengthStatDescription.Multiline = true;
            this.txtStrengthStatDescription.Name = "txtStrengthStatDescription";
            this.txtStrengthStatDescription.ReadOnly = true;
            this.txtStrengthStatDescription.Size = new System.Drawing.Size(430, 40);
            this.txtStrengthStatDescription.TabIndex = 37;
            this.txtStrengthStatDescription.Text = "Strength measures bodily power, athletic Training, and the extent to which you ca" +
    "n exert raw physical force.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(316, 179);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(430, 40);
            this.textBox2.TabIndex = 41;
            this.textBox2.Text = "Dexterity measures agility, reflexes, and balance.";
            // 
            // btnDexterityRNG
            // 
            this.btnDexterityRNG.Location = new System.Drawing.Point(217, 179);
            this.btnDexterityRNG.Name = "btnDexterityRNG";
            this.btnDexterityRNG.Size = new System.Drawing.Size(78, 42);
            this.btnDexterityRNG.TabIndex = 40;
            this.btnDexterityRNG.Text = "Dex";
            this.btnDexterityRNG.UseVisualStyleBackColor = true;
            this.btnDexterityRNG.Click += new System.EventHandler(this.btnStrengthRNG_Click);
            // 
            // txtDexterityStat
            // 
            this.txtDexterityStat.Enabled = false;
            this.txtDexterityStat.Location = new System.Drawing.Point(140, 179);
            this.txtDexterityStat.Name = "txtDexterityStat";
            this.txtDexterityStat.Size = new System.Drawing.Size(58, 22);
            this.txtDexterityStat.TabIndex = 39;
            // 
            // lblDexterityStat
            // 
            this.lblDexterityStat.AutoSize = true;
            this.lblDexterityStat.Location = new System.Drawing.Point(62, 182);
            this.lblDexterityStat.Name = "lblDexterityStat";
            this.lblDexterityStat.Size = new System.Drawing.Size(67, 17);
            this.lblDexterityStat.TabIndex = 38;
            this.lblDexterityStat.Text = "Dexterity:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(316, 245);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(430, 40);
            this.textBox4.TabIndex = 45;
            this.textBox4.Text = "Constitution measures health, stamina, and vital force.";
            // 
            // btnConstitutionRNG
            // 
            this.btnConstitutionRNG.Location = new System.Drawing.Point(217, 245);
            this.btnConstitutionRNG.Name = "btnConstitutionRNG";
            this.btnConstitutionRNG.Size = new System.Drawing.Size(78, 42);
            this.btnConstitutionRNG.TabIndex = 44;
            this.btnConstitutionRNG.Text = "Con";
            this.btnConstitutionRNG.UseVisualStyleBackColor = true;
            this.btnConstitutionRNG.Click += new System.EventHandler(this.btnStrengthRNG_Click);
            // 
            // txtConstitutionStat
            // 
            this.txtConstitutionStat.Enabled = false;
            this.txtConstitutionStat.Location = new System.Drawing.Point(140, 245);
            this.txtConstitutionStat.Name = "txtConstitutionStat";
            this.txtConstitutionStat.Size = new System.Drawing.Size(58, 22);
            this.txtConstitutionStat.TabIndex = 43;
            // 
            // lblConstitutionStat
            // 
            this.lblConstitutionStat.AutoSize = true;
            this.lblConstitutionStat.Location = new System.Drawing.Point(43, 248);
            this.lblConstitutionStat.Name = "lblConstitutionStat";
            this.lblConstitutionStat.Size = new System.Drawing.Size(86, 17);
            this.lblConstitutionStat.TabIndex = 42;
            this.lblConstitutionStat.Text = "Constitution:";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(316, 311);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(430, 40);
            this.textBox6.TabIndex = 49;
            this.textBox6.Text = "Intelligence measures mental acuity, accuracy of recall, and the ability to reaso" +
    "n.";
            // 
            // btnIntelligenceRNG
            // 
            this.btnIntelligenceRNG.Location = new System.Drawing.Point(217, 311);
            this.btnIntelligenceRNG.Name = "btnIntelligenceRNG";
            this.btnIntelligenceRNG.Size = new System.Drawing.Size(78, 42);
            this.btnIntelligenceRNG.TabIndex = 48;
            this.btnIntelligenceRNG.Text = "Int";
            this.btnIntelligenceRNG.UseVisualStyleBackColor = true;
            this.btnIntelligenceRNG.Click += new System.EventHandler(this.btnStrengthRNG_Click);
            // 
            // txtIntelligenceStat
            // 
            this.txtIntelligenceStat.Enabled = false;
            this.txtIntelligenceStat.Location = new System.Drawing.Point(140, 311);
            this.txtIntelligenceStat.Name = "txtIntelligenceStat";
            this.txtIntelligenceStat.Size = new System.Drawing.Size(58, 22);
            this.txtIntelligenceStat.TabIndex = 47;
            // 
            // lblIntelligenceStat
            // 
            this.lblIntelligenceStat.AutoSize = true;
            this.lblIntelligenceStat.Location = new System.Drawing.Point(46, 314);
            this.lblIntelligenceStat.Name = "lblIntelligenceStat";
            this.lblIntelligenceStat.Size = new System.Drawing.Size(83, 17);
            this.lblIntelligenceStat.TabIndex = 46;
            this.lblIntelligenceStat.Text = "Intelligence:";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(316, 377);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(430, 40);
            this.textBox8.TabIndex = 53;
            this.textBox8.Text = "Wisdom reflects how attuned you are to the world around you and represents percep" +
    "tiveness and intuition.\r\n";
            // 
            // btnWisdomRNG
            // 
            this.btnWisdomRNG.Location = new System.Drawing.Point(217, 377);
            this.btnWisdomRNG.Name = "btnWisdomRNG";
            this.btnWisdomRNG.Size = new System.Drawing.Size(78, 42);
            this.btnWisdomRNG.TabIndex = 52;
            this.btnWisdomRNG.Text = "Wis";
            this.btnWisdomRNG.UseVisualStyleBackColor = true;
            this.btnWisdomRNG.Click += new System.EventHandler(this.btnStrengthRNG_Click);
            // 
            // txtWisdomStat
            // 
            this.txtWisdomStat.Enabled = false;
            this.txtWisdomStat.Location = new System.Drawing.Point(140, 377);
            this.txtWisdomStat.Name = "txtWisdomStat";
            this.txtWisdomStat.Size = new System.Drawing.Size(58, 22);
            this.txtWisdomStat.TabIndex = 51;
            // 
            // lblWisdomStat
            // 
            this.lblWisdomStat.AutoSize = true;
            this.lblWisdomStat.Location = new System.Drawing.Point(67, 380);
            this.lblWisdomStat.Name = "lblWisdomStat";
            this.lblWisdomStat.Size = new System.Drawing.Size(62, 17);
            this.lblWisdomStat.TabIndex = 50;
            this.lblWisdomStat.Text = "Wisdom:";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(316, 443);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(430, 50);
            this.textBox10.TabIndex = 57;
            this.textBox10.Text = "Charisma measures your ability to interact effectively with others. It includes s" +
    "uch factors as confidence and eloquence, and it can represent a charming or comm" +
    "anding personality.";
            // 
            // btnCharismaRNG
            // 
            this.btnCharismaRNG.Location = new System.Drawing.Point(217, 443);
            this.btnCharismaRNG.Name = "btnCharismaRNG";
            this.btnCharismaRNG.Size = new System.Drawing.Size(78, 42);
            this.btnCharismaRNG.TabIndex = 56;
            this.btnCharismaRNG.Text = "Cha";
            this.btnCharismaRNG.UseVisualStyleBackColor = true;
            this.btnCharismaRNG.Click += new System.EventHandler(this.btnStrengthRNG_Click);
            // 
            // txtCharismaStat
            // 
            this.txtCharismaStat.Enabled = false;
            this.txtCharismaStat.Location = new System.Drawing.Point(140, 443);
            this.txtCharismaStat.Name = "txtCharismaStat";
            this.txtCharismaStat.Size = new System.Drawing.Size(58, 22);
            this.txtCharismaStat.TabIndex = 55;
            // 
            // lblCharismaStat
            // 
            this.lblCharismaStat.AutoSize = true;
            this.lblCharismaStat.Location = new System.Drawing.Point(58, 446);
            this.lblCharismaStat.Name = "lblCharismaStat";
            this.lblCharismaStat.Size = new System.Drawing.Size(71, 17);
            this.lblCharismaStat.TabIndex = 54;
            this.lblCharismaStat.Text = "Charisma:";
            // 
            // frmSetCharacterAbilityStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 588);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.btnCharismaRNG);
            this.Controls.Add(this.txtCharismaStat);
            this.Controls.Add(this.lblCharismaStat);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.btnWisdomRNG);
            this.Controls.Add(this.txtWisdomStat);
            this.Controls.Add(this.lblWisdomStat);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.btnIntelligenceRNG);
            this.Controls.Add(this.txtIntelligenceStat);
            this.Controls.Add(this.lblIntelligenceStat);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnConstitutionRNG);
            this.Controls.Add(this.txtConstitutionStat);
            this.Controls.Add(this.lblConstitutionStat);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnDexterityRNG);
            this.Controls.Add(this.txtDexterityStat);
            this.Controls.Add(this.lblDexterityStat);
            this.Controls.Add(this.txtStrengthStatDescription);
            this.Controls.Add(this.btnStrengthRNG);
            this.Controls.Add(this.txtStrengthStat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblAbilityStatsHeader);
            this.Controls.Add(this.lblStrengthStat);
            this.Controls.Add(this.btnSetCharacterAbilityStatsContinue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSetCharacterAbilityStats";
            this.Text = "Set Your Character\'s Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetCharacterAbilityStatsContinue;
        private System.Windows.Forms.Label lblStrengthStat;
        private System.Windows.Forms.Label lblAbilityStatsHeader;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtStrengthStat;
        private System.Windows.Forms.Button btnStrengthRNG;
        private System.Windows.Forms.TextBox txtStrengthStatDescription;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnDexterityRNG;
        private System.Windows.Forms.TextBox txtDexterityStat;
        private System.Windows.Forms.Label lblDexterityStat;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnConstitutionRNG;
        private System.Windows.Forms.TextBox txtConstitutionStat;
        private System.Windows.Forms.Label lblConstitutionStat;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnIntelligenceRNG;
        private System.Windows.Forms.TextBox txtIntelligenceStat;
        private System.Windows.Forms.Label lblIntelligenceStat;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnWisdomRNG;
        private System.Windows.Forms.TextBox txtWisdomStat;
        private System.Windows.Forms.Label lblWisdomStat;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button btnCharismaRNG;
        private System.Windows.Forms.TextBox txtCharismaStat;
        private System.Windows.Forms.Label lblCharismaStat;
    }
}