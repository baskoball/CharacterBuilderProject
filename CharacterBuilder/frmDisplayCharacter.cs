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
    public partial class frmDisplayCharacter : Form
    {
        Player displayingPlayer;

        public frmDisplayCharacter()
        {
            InitializeComponent();
        }

        public frmDisplayCharacter(Player playerSetStats)
        {
            displayingPlayer = playerSetStats;
            InitializeComponent();
            setFields(displayingPlayer);
        }

        public void setFields(Player displayingPlayer)
        {
            //Player displayPlayer = new Classes.CharacterRaces.Player();
            txtDisplayCharacterName.Text = displayingPlayer.Name;
            txtDisplayCharacterGender.Text = displayingPlayer.Gender.ToString();
            txtDisplayCharacterAge.Text = displayingPlayer.Age.ToString();
            txtDisplayCharacterHeight.Text = displayingPlayer.HeightFeet.ToString() + " ft. " + displayingPlayer.HeightInches.ToString() + " in.";
            txtDisplayCharacterWeight.Text = displayingPlayer.Weight;
            txtDisplayCharacterEyeColor.Text = displayingPlayer.EyeColor.ToString();
            txtDisplayCharacterHairColor.Text = displayingPlayer.HairColor.ToString();
            txtDisplayCharacterSkin.Text = displayingPlayer.Skin;
            txtDisplayCharacterRace.Text = displayingPlayer.CharacterRace.ToString();
            txtDisplayCharacterClass.Text = displayingPlayer.CharacterClass.ToString();

            //Ability Stats - Ability
            txtDisplayStrStat.Text = displayingPlayer.StrengthAbility.ToString();
            txtDisplayDexStat.Text = displayingPlayer.DexterityAbility.ToString();
            txtDisplayConStat.Text = displayingPlayer.ConstitutionAbility.ToString();
            txtDisplayIntStat.Text = displayingPlayer.IntelligenceAbility.ToString();
            txtDisplayWisStat.Text = displayingPlayer.WisdomAbility.ToString();
            txtDisplayChaStat.Text = displayingPlayer.CharismaAbility.ToString();
            //Ability Stats - Modifiers
            txtDisplayStrMod.Text = displayingPlayer.StrengthModifier;
            txtDisplayDexMod.Text = displayingPlayer.DexterityModifier;
            txtDisplayConMod.Text = displayingPlayer.ConstitutionModifier;
            txtDisplayIntMod.Text = displayingPlayer.IntelligenceModifier;
            txtDisplayWisMod.Text = displayingPlayer.WisdomModifier;
            txtDisplayChaMod.Text = displayingPlayer.CharismaModifier;
            //Ability Stats - Saving
            txtDisplayStrSaving.Text = displayingPlayer.StrengthSaving;
            txtDisplayDexSaving.Text = displayingPlayer.DexteritySaving;
            txtDisplayConSaving.Text = displayingPlayer.ConstitutionSaving;
            txtDisplayIntSaving.Text = displayingPlayer.IntelligenceSaving;
            txtDisplayWisSaving.Text = displayingPlayer.WisdomSaving;
            txtDisplayChaSaving.Text = displayingPlayer.CharismaSaving;

            //Additional Character Information
            txtDisplayRaceAttributes.Text += displayingPlayer.BonusTraits;
            txtDisplayResistances.Text += displayingPlayer.Resistance;
            txtDisplayLanguages.Text += displayingPlayer.Languages;
            txtDisplayArmor.Text += displayingPlayer.Armor;
            txtDisplayAttacks.Text += displayingPlayer.Attack + " with " + displayingPlayer.Weapon;
            txtDisplaySkills.Text += displayingPlayer.Skills;
        }
    }
}
