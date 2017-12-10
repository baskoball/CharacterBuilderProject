namespace CharacterBuilder
{
    partial class frmSelectCharacterRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectCharacterRace));
            this.label1 = new System.Windows.Forms.Label();
            this.cboSelectCharacterRace = new System.Windows.Forms.ComboBox();
            this.txtDragonbornDescription = new System.Windows.Forms.TextBox();
            this.txtDwarfDescription = new System.Windows.Forms.TextBox();
            this.txtElfDescription = new System.Windows.Forms.TextBox();
            this.txtHumanDescription = new System.Windows.Forms.TextBox();
            this.btnSelectCharacterRaceContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Race:";
            // 
            // cboSelectCharacterRace
            // 
            this.cboSelectCharacterRace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectCharacterRace.FormattingEnabled = true;
            this.cboSelectCharacterRace.Items.AddRange(new object[] {
            "Dragonborn",
            "Dwarf",
            "Elf",
            "Human"});
            this.cboSelectCharacterRace.Location = new System.Drawing.Point(140, 37);
            this.cboSelectCharacterRace.Name = "cboSelectCharacterRace";
            this.cboSelectCharacterRace.Size = new System.Drawing.Size(121, 24);
            this.cboSelectCharacterRace.TabIndex = 1;
            // 
            // txtDragonbornDescription
            // 
            this.txtDragonbornDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtDragonbornDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDragonbornDescription.Location = new System.Drawing.Point(49, 86);
            this.txtDragonbornDescription.Multiline = true;
            this.txtDragonbornDescription.Name = "txtDragonbornDescription";
            this.txtDragonbornDescription.ReadOnly = true;
            this.txtDragonbornDescription.Size = new System.Drawing.Size(884, 100);
            this.txtDragonbornDescription.TabIndex = 2;
            this.txtDragonbornDescription.Text = resources.GetString("txtDragonbornDescription.Text");
            // 
            // txtDwarfDescription
            // 
            this.txtDwarfDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtDwarfDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDwarfDescription.Location = new System.Drawing.Point(49, 192);
            this.txtDwarfDescription.Multiline = true;
            this.txtDwarfDescription.Name = "txtDwarfDescription";
            this.txtDwarfDescription.ReadOnly = true;
            this.txtDwarfDescription.Size = new System.Drawing.Size(884, 100);
            this.txtDwarfDescription.TabIndex = 3;
            this.txtDwarfDescription.Text = resources.GetString("txtDwarfDescription.Text");
            // 
            // txtElfDescription
            // 
            this.txtElfDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtElfDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtElfDescription.Location = new System.Drawing.Point(49, 298);
            this.txtElfDescription.Multiline = true;
            this.txtElfDescription.Name = "txtElfDescription";
            this.txtElfDescription.ReadOnly = true;
            this.txtElfDescription.Size = new System.Drawing.Size(884, 105);
            this.txtElfDescription.TabIndex = 4;
            this.txtElfDescription.Text = resources.GetString("txtElfDescription.Text");
            // 
            // txtHumanDescription
            // 
            this.txtHumanDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtHumanDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHumanDescription.Location = new System.Drawing.Point(49, 409);
            this.txtHumanDescription.Multiline = true;
            this.txtHumanDescription.Name = "txtHumanDescription";
            this.txtHumanDescription.ReadOnly = true;
            this.txtHumanDescription.Size = new System.Drawing.Size(884, 105);
            this.txtHumanDescription.TabIndex = 5;
            this.txtHumanDescription.Text = resources.GetString("txtHumanDescription.Text");
            // 
            // btnSelectCharacterRaceContinue
            // 
            this.btnSelectCharacterRaceContinue.Location = new System.Drawing.Point(358, 520);
            this.btnSelectCharacterRaceContinue.Name = "btnSelectCharacterRaceContinue";
            this.btnSelectCharacterRaceContinue.Size = new System.Drawing.Size(100, 29);
            this.btnSelectCharacterRaceContinue.TabIndex = 23;
            this.btnSelectCharacterRaceContinue.Text = "Continue";
            this.btnSelectCharacterRaceContinue.UseVisualStyleBackColor = true;
            this.btnSelectCharacterRaceContinue.Click += new System.EventHandler(this.btnSelectCharacterRaceContinue_Click);
            // 
            // frmSelectCharacterRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 588);
            this.Controls.Add(this.btnSelectCharacterRaceContinue);
            this.Controls.Add(this.txtHumanDescription);
            this.Controls.Add(this.txtElfDescription);
            this.Controls.Add(this.txtDwarfDescription);
            this.Controls.Add(this.txtDragonbornDescription);
            this.Controls.Add(this.cboSelectCharacterRace);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectCharacterRace";
            this.Text = "Select Your Character\'s Race";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSelectCharacterRace;
        private System.Windows.Forms.TextBox txtDragonbornDescription;
        private System.Windows.Forms.TextBox txtDwarfDescription;
        private System.Windows.Forms.TextBox txtElfDescription;
        private System.Windows.Forms.TextBox txtHumanDescription;
        private System.Windows.Forms.Button btnSelectCharacterRaceContinue;
    }
}