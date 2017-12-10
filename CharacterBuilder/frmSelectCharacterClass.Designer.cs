namespace CharacterBuilder
{
    partial class frmSelectCharacterClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectCharacterClass));
            this.btnSelectCharacterClassContinue = new System.Windows.Forms.Button();
            this.txtWizardDescription = new System.Windows.Forms.TextBox();
            this.txtRogueDescription = new System.Windows.Forms.TextBox();
            this.txtFighterDescription = new System.Windows.Forms.TextBox();
            this.txtClericDescription = new System.Windows.Forms.TextBox();
            this.cboSelectCharacterClass = new System.Windows.Forms.ComboBox();
            this.lblSelectCharacterClass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelectCharacterClassContinue
            // 
            this.btnSelectCharacterClassContinue.Location = new System.Drawing.Point(354, 517);
            this.btnSelectCharacterClassContinue.Name = "btnSelectCharacterClassContinue";
            this.btnSelectCharacterClassContinue.Size = new System.Drawing.Size(100, 29);
            this.btnSelectCharacterClassContinue.TabIndex = 30;
            this.btnSelectCharacterClassContinue.Text = "Continue";
            this.btnSelectCharacterClassContinue.UseVisualStyleBackColor = true;
            this.btnSelectCharacterClassContinue.Click += new System.EventHandler(this.btnSelectCharacterClassContinue_Click);
            // 
            // txtWizardDescription
            // 
            this.txtWizardDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtWizardDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWizardDescription.Location = new System.Drawing.Point(45, 406);
            this.txtWizardDescription.Multiline = true;
            this.txtWizardDescription.Name = "txtWizardDescription";
            this.txtWizardDescription.ReadOnly = true;
            this.txtWizardDescription.Size = new System.Drawing.Size(810, 105);
            this.txtWizardDescription.TabIndex = 29;
            this.txtWizardDescription.Text = "Wizard\r\n              As a wizard, you gain the following Class Features.\r\n      " +
    "        Armor: none\r\n              Weapons: quarterstaffs\r\n              Skills:" +
    " Arcana and History\r\n\r\n";
            // 
            // txtRogueDescription
            // 
            this.txtRogueDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtRogueDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRogueDescription.Location = new System.Drawing.Point(45, 295);
            this.txtRogueDescription.Multiline = true;
            this.txtRogueDescription.Name = "txtRogueDescription";
            this.txtRogueDescription.ReadOnly = true;
            this.txtRogueDescription.Size = new System.Drawing.Size(810, 105);
            this.txtRogueDescription.TabIndex = 28;
            this.txtRogueDescription.Text = "Rogue\r\n              As a rogue, you have the following Class Features.\r\n        " +
    "      Armor: Light Armor\r\n              Weapons: Bows\r\n              Skills: Dec" +
    "eption and Stealth\r\n";
            // 
            // txtFighterDescription
            // 
            this.txtFighterDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtFighterDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFighterDescription.Location = new System.Drawing.Point(45, 189);
            this.txtFighterDescription.Multiline = true;
            this.txtFighterDescription.Name = "txtFighterDescription";
            this.txtFighterDescription.ReadOnly = true;
            this.txtFighterDescription.Size = new System.Drawing.Size(810, 100);
            this.txtFighterDescription.TabIndex = 27;
            this.txtFighterDescription.Text = "Fighter\r\n              As a fighter, you gain the following Class Features.\r\n    " +
    "          Armor: Heavy Armor\r\n              Weapons: Swords\r\n              Skill" +
    "s: Athletics and Survival\r\n";
            // 
            // txtClericDescription
            // 
            this.txtClericDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtClericDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClericDescription.Location = new System.Drawing.Point(45, 83);
            this.txtClericDescription.Multiline = true;
            this.txtClericDescription.Name = "txtClericDescription";
            this.txtClericDescription.ReadOnly = true;
            this.txtClericDescription.Size = new System.Drawing.Size(772, 100);
            this.txtClericDescription.TabIndex = 26;
            this.txtClericDescription.Text = resources.GetString("txtClericDescription.Text");
            // 
            // cboSelectCharacterClass
            // 
            this.cboSelectCharacterClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectCharacterClass.FormattingEnabled = true;
            this.cboSelectCharacterClass.Items.AddRange(new object[] {
            "Cleric",
            "Fighter",
            "Rogue",
            "Wizard"});
            this.cboSelectCharacterClass.Location = new System.Drawing.Point(136, 34);
            this.cboSelectCharacterClass.Name = "cboSelectCharacterClass";
            this.cboSelectCharacterClass.Size = new System.Drawing.Size(121, 24);
            this.cboSelectCharacterClass.TabIndex = 25;
            // 
            // lblSelectCharacterClass
            // 
            this.lblSelectCharacterClass.AutoSize = true;
            this.lblSelectCharacterClass.Location = new System.Drawing.Point(42, 37);
            this.lblSelectCharacterClass.Name = "lblSelectCharacterClass";
            this.lblSelectCharacterClass.Size = new System.Drawing.Size(89, 17);
            this.lblSelectCharacterClass.TabIndex = 24;
            this.lblSelectCharacterClass.Text = "Select Class:";
            // 
            // frmSelectCharacterClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 588);
            this.Controls.Add(this.btnSelectCharacterClassContinue);
            this.Controls.Add(this.txtWizardDescription);
            this.Controls.Add(this.txtRogueDescription);
            this.Controls.Add(this.txtFighterDescription);
            this.Controls.Add(this.txtClericDescription);
            this.Controls.Add(this.cboSelectCharacterClass);
            this.Controls.Add(this.lblSelectCharacterClass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectCharacterClass";
            this.Text = "Select Your Character\'s Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectCharacterClassContinue;
        private System.Windows.Forms.TextBox txtWizardDescription;
        private System.Windows.Forms.TextBox txtRogueDescription;
        private System.Windows.Forms.TextBox txtFighterDescription;
        private System.Windows.Forms.TextBox txtClericDescription;
        private System.Windows.Forms.ComboBox cboSelectCharacterClass;
        private System.Windows.Forms.Label lblSelectCharacterClass;
    }
}