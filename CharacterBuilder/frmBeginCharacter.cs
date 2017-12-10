using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CharacterBuilder.Classes.CharacterRaces;

namespace CharacterBuilder
{
    public partial class frmBeginCharacter : Form
    {
        public frmBeginCharacter()
        {
            InitializeComponent();
        }

        private void cboCharacterRace_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBeginingCharacterContinue_Click(object sender, EventArgs e)
        {
            //frmSelectCharacterRace selectingCharacterRace;// = new frmSelectCharacterRace();
            frmDisplayCharacter displayingCharacter = new frmDisplayCharacter();

            Character newCharacter = new Character();
            //Player newPlayer = new Classes.CharacterRaces.Player();

            if (string.IsNullOrWhiteSpace(txtCharacterName.Text) || txtCharacterName.Text[0] == ' ' ) {
                MessageBox.Show("You must name the character.");
                return;
            }
            
            //string strGender = (string)(this.rdoGenderMale.Checked ? "Male" : "Female");
            //MessageBox.Show("You are a: " + strGender)
            int health = 10;
            string name = txtCharacterName.Text;
            EntityGender eGender;
            if (this.rdoGenderMale.Checked)
                eGender = EntityGender.Male;
            else if (this.rdoGenderFemale.Checked)
                eGender = EntityGender.Female;
            else
            { 
                MessageBox.Show("You must give your character a gender.");
                return;
            }
            string age = txtCharacterAge.Text;
            string heightFeet = cboHeightFeet.Text;
            string heightInches = cboHeightInches.Text;
            string weight = txtCharacterWeight.Text;
            EntityEyeColor eyeColor = EntityEyeColor.Blue; // = cboEyeColor.Text;
            if (cboEyeColor.Text == "Brown")
                eyeColor = EntityEyeColor.Brown;
            else if (cboEyeColor.Text == "Blue")
                eyeColor = EntityEyeColor.Blue;
            else if (cboEyeColor.Text == "Green")
                eyeColor = EntityEyeColor.Green;
            else if (cboEyeColor.Text == "Red")
                eyeColor = EntityEyeColor.Red;
            else if (cboEyeColor.Text == "Silver")
                eyeColor = EntityEyeColor.Silver;
            EntityHairColor hairColor = EntityHairColor.Black; // = cboHairColor.Text;
            if (cboHairColor.Text == "Black")
                hairColor = EntityHairColor.Black;
            else if (cboHairColor.Text == "Blonde")
                hairColor = EntityHairColor.Blonde;
            else if (cboHairColor.Text == "Blue")
                hairColor = EntityHairColor.Blue;
            else if (cboHairColor.Text == "Brown")
                hairColor = EntityHairColor.Brown;
            else if (cboHairColor.Text == "Gold")
                hairColor = EntityHairColor.Gold;
            else if (cboHairColor.Text == "Green")
                hairColor = EntityHairColor.Green;
            else if (cboHairColor.Text == "Red")
                hairColor = EntityHairColor.Red;
            else if (cboHairColor.Text == "Silver")
                hairColor = EntityHairColor.Silver;
            else if (cboHairColor.Text == "White")
                hairColor = EntityHairColor.White;
            else if (cboHairColor.Text == "Purple")
                hairColor = EntityHairColor.Purple;
            string skin = txtCharacterSkin.Text;

            //int convertAge = 0;
            //int convertHeightFeet = 0;
            //int convertHeightInches = 0;
            Player newPlayer = new Player(health, name, eGender, Int32.Parse(age), Int32.Parse(heightFeet),
                Int32.Parse(heightInches), weight, eyeColor, hairColor, skin);

            //frmDisplayCharacter displayCharacter = new frmDisplayCharacter(newPlayer);
            //displayCharacter.setFields(newPlayer);

            //frmDisplayCharacter displayCharacter = new frmDisplayCharacter(new Player(health, name, eGender, Int32.Parse(age), Int32.Parse(heightFeet),
            //    Int32.Parse(heightInches), weight, eyeColor, hairColor, skin));
            //displayCharacter.setFields(newPlayer);

            frmSelectCharacterRace selectingCharacterRace = new frmSelectCharacterRace(newPlayer);

            //Hide last form
            this.Hide();
            selectingCharacterRace.Show();
            selectingCharacterRace.FormClosed += (s, args) => this.Close(); 
        }
    }
}
