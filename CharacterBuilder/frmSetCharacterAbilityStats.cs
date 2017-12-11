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
    public partial class frmSetCharacterAbilityStats : Form
    {
        Player playerSetStats;
        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        bool strSet = false;
        bool dexSet = false;
        bool conSet = false;
        bool intSet = false;
        bool wisSet = false;
        bool chaSet = false;

        public frmSetCharacterAbilityStats()
        {
            InitializeComponent();
        }
        
        public frmSetCharacterAbilityStats(Player playerPickingClass)
        {
            playerSetStats = playerPickingClass;
            InitializeComponent();
        }

        private void btnSetCharacterAbilityStatsContinue_Click(object sender, EventArgs e)
        {
            if (txtStrengthStat.Text == "" || txtDexterityStat.Text == "" || txtConstitutionStat.Text == "" ||
                txtIntelligenceStat.Text == "" || txtWisdomStat.Text == "" || txtCharismaStat.Text == "")
            {
                MessageBox.Show("You must have a stat for each field.");
                return;
            }

            SetCharacterStats();

            frmDisplayCharacter displayingCharacter = new frmDisplayCharacter(playerSetStats);

            this.Hide();
            //frmDisplayCharacter displayingCharacter = new frmDisplayCharacter();
            displayingCharacter.Show();
            displayingCharacter.FormClosed += (s, args) => this.Close();
        }

        //Handles all of the Stat buttons because they all use RNG
        private void btnStrengthRNG_Click(object sender, EventArgs e)
        {
            int intStat = 0;
            Button btn = sender as Button;

            intStat = GetRandomNumber(3, 18);

            if(btn.Name == "btnStrengthRNG" && !strSet)
            {
                txtStrengthStat.Text = intStat.ToString();
                txtStrengthStat.Enabled = false;
            }
            else if(btn.Name == "btnDexterityRNG" && !dexSet)
            {
                txtDexterityStat.Text = intStat.ToString();
                txtDexterityStat.Enabled = false;
            }
            else if (btn.Name == "btnConstitutionRNG" && !dexSet)
            {
                txtConstitutionStat.Text = intStat.ToString();
                txtConstitutionStat.Enabled = false;
            }
            else if (btn.Name == "btnIntelligenceRNG" && !intSet)
            {
                txtIntelligenceStat.Text = intStat.ToString();
                txtIntelligenceStat.Enabled = false;
            }
            else if (btn.Name == "btnWisdomRNG" && !wisSet)
            {
                txtWisdomStat.Text = intStat.ToString();
                txtWisdomStat.Enabled = false;
            }
            else if (btn.Name == "btnCharismaRNG" && !chaSet)
            {
                txtCharismaStat.Text = intStat.ToString();
                txtCharismaStat.Enabled = false;
            }
        }

        //RNG
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }

        private void SetCharacterStats()
        {
            int intStr = Int32.Parse(txtStrengthStat.Text);
            int intDex = Int32.Parse(txtDexterityStat.Text);
            int intCon = Int32.Parse(txtConstitutionStat.Text);
            int intInt = Int32.Parse(txtIntelligenceStat.Text);
            int intWis = Int32.Parse(txtWisdomStat.Text);
            int intCha = Int32.Parse(txtCharismaStat.Text);

            playerSetStats.StrengthAbility += intStr;
            playerSetStats.DexterityAbility += intDex;
            playerSetStats.ConstitutionAbility += intCon;
            playerSetStats.IntelligenceAbility += intInt;
            playerSetStats.WisdomAbility += intWis;
            playerSetStats.CharismaAbility += intCha;

            if (playerSetStats.StrengthAbility >= 10 && !strSet)
            {
                intStr = (playerSetStats.StrengthAbility - 10) / 2;
                strSet = true;
            }
            else
                intStr = 0;

            if (playerSetStats.DexterityAbility >= 10 && !dexSet)
            {
                intDex = (playerSetStats.DexterityAbility - 10) / 2;
                dexSet = true;
            }
            else
                intDex = 0;

            if (playerSetStats.ConstitutionAbility >= 10 && !conSet)
            {
                intCon = (playerSetStats.ConstitutionAbility - 10) / 2;
                conSet = true;
            }
            else
                intCon = 0;

            if (playerSetStats.IntelligenceAbility >= 10 && !intSet)
            { 
                intInt = (playerSetStats.IntelligenceAbility - 10) / 2;
                intSet = true;
            }
            else
                intInt = 0;

            if (playerSetStats.WisdomAbility >= 10 && !wisSet)
            {
                intWis = (playerSetStats.WisdomAbility - 10) / 2;
                wisSet = true;
            }
            else
                intWis = 0;

            if (playerSetStats.CharismaAbility >= 10 && !chaSet)
            {
                intCha = (playerSetStats.CharismaAbility - 10) / 2;
                chaSet = true;
            }
            else
                intCha = 0;
            
            playerSetStats.StrengthModifier = "" + intStr;
            playerSetStats.DexterityModifier = "" + intDex;
            playerSetStats.ConstitutionModifier = "" + intCon;
            playerSetStats.IntelligenceModifier = "" + intInt;
            playerSetStats.WisdomModifier = "" + intWis;
            playerSetStats.CharismaModifier = "" + intCha;

            playerSetStats.StrengthSaving = playerSetStats.StrengthModifier;
            playerSetStats.DexteritySaving = playerSetStats.DexterityModifier;
            playerSetStats.ConstitutionSaving = playerSetStats.ConstitutionModifier;
            playerSetStats.IntelligenceSaving = playerSetStats.IntelligenceModifier;
            playerSetStats.WisdomSaving = playerSetStats.WisdomModifier;
            playerSetStats.CharismaSaving = playerSetStats.CharismaModifier;
        }
    }
}
