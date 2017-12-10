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
    public partial class frmSelectCharacterRace : Form
    {
        Player playerPickingRace;
        public frmSelectCharacterRace()
        {
            InitializeComponent();
        }
        public frmSelectCharacterRace(Player samePlayer)
        {
            playerPickingRace = samePlayer;
            InitializeComponent();
        }

        private void btnSelectCharacterRaceContinue_Click(object sender, EventArgs e)
        {
            //if (this.cboSelectCharacterRace.GetItemText(this.cboSelectCharacterRace.SelectedItem) == "Dragonborn")
            //{
            //    Player newCharacter = new Player();
            //    MessageBox.Show("Your name is: " + newCharacter.Name);
            //}
            //else if (cboSelectCharacterRace.SelectedText == "Dwarf") 
            //{
            //    //Dwarf newCharacter = new Dwarf();
            //}
            //else if (cboSelectCharacterRace.SelectedText == "Elf") 
            //{
            //    //Elf newCharacter = new Elf();
            //}
            //else if (cboSelectCharacterRace.SelectedText == "Human") 
            //{
            //    //Human newCharacter = new Human();
            //}
            //else
            //{
            //    MessageBox.Show("Error - Character Race was unable to be created.");
            //}
            setCharacterRace();
            setRaceTraits();

            frmSelectCharacterClass selectingCharacterClass = new frmSelectCharacterClass(playerPickingRace);

            this.Hide();
            //frmSelectCharacterClass selectingCharacterClass = new frmSelectCharacterClass();
            selectingCharacterClass.Show();
            selectingCharacterClass.FormClosed += (s, args) => this.Close();
        }

        private void setCharacterRace()
        {
            EntityCharacterRace race = EntityCharacterRace.Human;
            if (cboSelectCharacterRace.Text == "Dragonborn")
                race = EntityCharacterRace.Dragonborn;
            else if (cboSelectCharacterRace.Text == "Dwarf")
                race = EntityCharacterRace.Dwarf;
            else if (cboSelectCharacterRace.Text == "Elf")
                race = EntityCharacterRace.Elf;
            else if (cboSelectCharacterRace.Text == "Human")
                race = EntityCharacterRace.Human;
            else
            {
                MessageBox.Show("You must select a Race.");
                return;
            }

            playerPickingRace.CharacterRace = race;

            return;
        }

        private void setRaceTraits()
        {
            setAdditionalStats();
            setAdditionalTraits();
            setResistances();
            setLanguages();

            return;
        }

        private void setAdditionalStats()
        {
            if (cboSelectCharacterRace.Text == "Dragonborn")
            {
                playerPickingRace.StrengthAbility += 2;
                playerPickingRace.CharismaAbility += 1;
            }
            else if (cboSelectCharacterRace.Text == "Dwarf")
            {
                playerPickingRace.ConstitutionAbility += 2;
            }
            else if (cboSelectCharacterRace.Text == "Elf")
            {
                playerPickingRace.DexterityAbility += 2;
            }
            else if (cboSelectCharacterRace.Text == "Human")
            {
                playerPickingRace.StrengthAbility += 1;
                playerPickingRace.DexterityAbility += 1;
                playerPickingRace.ConstitutionAbility += 1;
                playerPickingRace.IntelligenceAbility += 1;
                playerPickingRace.WisdomAbility += 1;
                playerPickingRace.CharismaAbility += 1;
            }

            return;
        }

        private void setAdditionalTraits()
        {
            if (cboSelectCharacterRace.Text == "Dragonborn")
                playerPickingRace.BonusTraits = "Draconic Ancestry: You have a breath weapon that does 1d6 fire damage.";
            else if (cboSelectCharacterRace.Text == "Dwarf")
                playerPickingRace.BonusTraits = "Darkvision: Accustomed to life underground, you have superior vision in dark and dim Conditions. \nDwarven Resilience: You have advantage on saving throws against poison, and you have Resistance against poison damage.";             
            else if (cboSelectCharacterRace.Text == "Elf")
                playerPickingRace.BonusTraits = "Darkvision: Accustomed to twilit forests and the night sky, you have superior vision in dark and dim Conditions. \nTrance: Elves don’t need to sleep. Instead, they meditate deeply, remaining semiconscious, for 4 hours a day.";
            else if(cboSelectCharacterRace.Text == "Human")
            {
                playerPickingRace.StrengthAbility += 1;
                playerPickingRace.ConstitutionAbility += 1;
            }

            return;
        }

        private void setResistances()
        {
            if (cboSelectCharacterRace.Text == "Dragonborn")
                playerPickingRace.Resistance = "Fire Damage";

            return;
        }

        private void setLanguages()
        {
            if (cboSelectCharacterRace.Text == "Dragonborn")
                playerPickingRace.Languages = "Common and Draconic";
            else if (cboSelectCharacterRace.Text == "Dwarf")
                playerPickingRace.Languages = "Common and Dwarvish";
            else if (cboSelectCharacterRace.Text == "Elf")
                playerPickingRace.Languages = "Common and Elvish";
            else if (cboSelectCharacterRace.Text == "Human")
                playerPickingRace.Languages = "Common";

            return;
        }
    }
}
