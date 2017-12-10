using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder.Classes.CharacterRaces
{
    public class Player : Entity
    {
        #region Fields
        string characterAbilities;
        string characterResistances;
        string characterLanguages;
        string characterSkills;
        #endregion Fields

        #region Properties
        public string BonusTraits
        {
            get { return characterAbilities; }
            set { characterAbilities = value; }
        }
        public string Resistance
        {
            get { return characterResistances; }
            set { characterResistances = value; }
        }
        public string Languages
        {
            get { return characterLanguages; }
            set { characterLanguages = value; }
        }
        public string Skills
        {
            get { return characterSkills; }
            set { characterSkills = value; }
        }
        #endregion Properties

        #region Constructors
        //Default Constructor
        public Player() : base()    
        {
            characterAbilities = "";
            characterResistances = "";
            characterLanguages = "";
            characterSkills = "";
        }

        //Constructor when begining character
        public Player(int r_intHealth, string r_strName, EntityGender r_entGender, int r_intAge, int r_intHeightFeet, int r_intHeightInches,
                            string r_strWeight, EntityEyeColor r_entEyeColor, EntityHairColor r_entHairColor, string r_strSkin) : base()
        {
            intHealth = r_intHealth;
            strName = r_strName;
            entGender = r_entGender;
            intAge = r_intAge;
            intHeightFeet = r_intHeightFeet;
            intHeightInches = r_intHeightInches;
            strWeight = r_strWeight;
            entEyeColor = r_entEyeColor;
            entHairColor = r_entHairColor;
            strSkin = r_strSkin;
        }
        public Player(string r_strStrengthModifier,
                            string r_strDexterityModifier, string r_strConstitutionModifier, string r_strIntelligenceModifier,
                            string r_strWisdomModifier, string r_strCharismaModifier, string r_strStrengthSaving,
                            string r_strDexteritySaving, string r_strConstitutionSaving, string r_strIntelligenceSaving,
                            string r_strWisdomSaving, string r_strCharismaSaving) : base()
        {
            strStrengthModifier = r_strStrengthModifier;
            strDexterityModifier = r_strDexterityModifier;
            strConstitutionModifier = r_strConstitutionModifier;
            strIntelligenceModifier = r_strIntelligenceModifier;
            strWisdomModifier = r_strWisdomModifier;
            strCharismaModifier = r_strCharismaModifier;
            strStrengthSaving = r_strStrengthSaving;
            strDexteritySaving = r_strDexteritySaving;
            strConstitutionSaving = r_strConstitutionSaving;
            strIntelligenceSaving = r_strIntelligenceSaving;
            strWisdomSaving = r_strWisdomSaving;
            strCharismaSaving = r_strCharismaSaving;
        }
        public Player(int r_intStrengthAbility, int r_intDexterityAbility, int r_intConstitutionAbility,
                            int r_intIntelligenceAbility, int r_intWisdomAbility, int r_intCharismaAbility, EntityAttacks r_entAttacks, EntityArmor r_entArmor) : base()
        {
            //TODO need weapon and skills
            intStrengthAbility = r_intStrengthAbility;
            intDexterityAbility = r_intDexterityAbility;
            intConstitutionAbility = r_intConstitutionAbility;
            intIntelligenceAbility = r_intIntelligenceAbility;
            intWisdomAbility = r_intWisdomAbility;
            intCharismaAbility = r_intCharismaAbility;
            entArmor = r_entArmor;
            entAttack = r_entAttacks;
        }
        #endregion Constructors
    }
}
