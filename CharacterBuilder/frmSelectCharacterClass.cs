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
    public partial class frmSelectCharacterClass : Form
    {
        Player playerPickingClass;

        public frmSelectCharacterClass()
        {
            InitializeComponent();
        }
        public frmSelectCharacterClass(Player playerPickingRace)
        {
            playerPickingClass = playerPickingRace;
            InitializeComponent();
        }

        private void btnSelectCharacterClassContinue_Click(object sender, EventArgs e)
        {
            setCharacterClass();
            setClassTraits();

            frmSetCharacterAbilityStats settingCharacterAbilityStats = new frmSetCharacterAbilityStats(playerPickingClass);

            this.Hide();
            ////frmSetCharacterAbilityStats settingCharacterAbilityStats = new frmSetCharacterAbilityStats();
            settingCharacterAbilityStats.Show();
            settingCharacterAbilityStats.FormClosed += (s, args) => this.Close();
        }

        private void setCharacterClass()
        {
            EntityCharacterClass selectClass = EntityCharacterClass.Fighter;
            if (cboSelectCharacterClass.Text == "Cleric")
                selectClass = EntityCharacterClass.Cleric;
            else if (cboSelectCharacterClass.Text == "Fighter")
                selectClass = EntityCharacterClass.Fighter;
            else if (cboSelectCharacterClass.Text == "Rogue")
                selectClass = EntityCharacterClass.Rogue;
            else if (cboSelectCharacterClass.Text == "Wizard")
                selectClass = EntityCharacterClass.Wizard;
            else
            {
                MessageBox.Show("You must select a Class.");
                return;
            }
            
            playerPickingClass.CharacterClass = selectClass;

            return;
        }

        private void setClassTraits()
        {
            setClassArmor();
            setClassWeaponsAndAttack();
            setClassSkills();

            return;
        }

        private void setClassArmor()
        {
            EntityArmor armor = EntityArmor.Light;
            if (cboSelectCharacterClass.Text == "Cleric")
                armor = EntityArmor.Medium;
            else if (cboSelectCharacterClass.Text == "Fighter")
                armor = EntityArmor.Heavy;
            else if (cboSelectCharacterClass.Text == "Rogue")
                armor = EntityArmor.Light;
            else if (cboSelectCharacterClass.Text == "Wizard")
                armor = EntityArmor.None;

            playerPickingClass.Armor = armor;

            return;
        }

        private void setClassWeaponsAndAttack()
        {
            EntityWeapons weapon = EntityWeapons.Sword;
            EntityAttacks attack = EntityAttacks.Melee;
            if (cboSelectCharacterClass.Text == "Cleric")
            {
                weapon = EntityWeapons.Warhammer;
                attack = EntityAttacks.Melee;
            }
            else if (cboSelectCharacterClass.Text == "Fighter")
            {
                weapon = EntityWeapons.Sword;
                attack = EntityAttacks.Melee;
            }
            else if (cboSelectCharacterClass.Text == "Rogue")
            {
                weapon = EntityWeapons.Bow;
                attack = EntityAttacks.Range;
            }
            else if (cboSelectCharacterClass.Text == "Wizard")
            {
                weapon = EntityWeapons.Quaterstaff;
                attack = EntityAttacks.Spell;
            }

            playerPickingClass.Weapon = weapon;
            playerPickingClass.Attack = attack;

            return;
        }

        private void setClassSkills()
        {
            string skills = "";
            if (cboSelectCharacterClass.Text == "Cleric")
                skills = "Persuasion and Religion";
            else if (cboSelectCharacterClass.Text == "Fighter")
                skills = "Athletics and Survival";
            else if (cboSelectCharacterClass.Text == "Rogue")
                skills = "Deception and Stealth";
            else if (cboSelectCharacterClass.Text == "Wizard")
                skills = "Arcana and History";

            playerPickingClass.Skills = skills;

            return;
        }
    }
}
