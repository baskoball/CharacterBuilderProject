namespace CharacterBuilder
{
    partial class frmWelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcomeScreen));
            this.lblCharacterBuilder = new System.Windows.Forms.Label();
            this.btnBegin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCharacterBuilder
            // 
            this.lblCharacterBuilder.AutoSize = true;
            this.lblCharacterBuilder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCharacterBuilder.Font = new System.Drawing.Font("Matura MT Script Capitals", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacterBuilder.Location = new System.Drawing.Point(30, 296);
            this.lblCharacterBuilder.Name = "lblCharacterBuilder";
            this.lblCharacterBuilder.Size = new System.Drawing.Size(349, 53);
            this.lblCharacterBuilder.TabIndex = 0;
            this.lblCharacterBuilder.Text = "Character Builder";
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(160, 383);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(97, 37);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // frmWelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 485);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.lblCharacterBuilder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmWelcomeScreen";
            this.Text = "Character Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCharacterBuilder;
        private System.Windows.Forms.Button btnBegin;
    }
}

