using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterBuilder.Classes.CharacterRaces
{
    public enum EntityGender { Male, Female}
    public enum EntityEyeColor { Brown, Blue, Green, Red, Silver}
    public enum EntityHairColor { Black, Blonde, Blue, Brown, Gold, Green, Purple, Red, Silver, White}
    public enum EntityAttacks { Area, Melee, Range, Spell }
    public enum EntityWeapons { Warhammer, Sword, Bow, Quaterstaff }
    public enum EntityCharacterRace { Dragonborn, Dwarf, Elf, Human}
    public enum EntityCharacterClass { Cleric, Fighter, Rogue, Wizard}
    public enum EntityArmor { Light, Medium, Heavy, All, None}

    public abstract class Entity
    {
        #region Fields
        //Private variables
        protected int intHealth;
        protected string strName;
        protected EntityGender entGender;
        protected int intAge, intHeightFeet, intHeightInches;
        protected string strWeight;
        protected EntityEyeColor entEyeColor;
        protected EntityHairColor entHairColor;
        protected string strSkin;
        //protected EntityWeapons entWeapon;
        //protected string strSkills;
        //protected string strLanguages;
        protected int intStrengthAbility, intDexterityAbility, intConstitutionAbility,
            intIntelligenceAbility, intWisdomAbility, intCharismaAbility;
        protected string strStrengthModifier, strDexterityModifier, strConstitutionModifier,
            strIntelligenceModifier, strWisdomModifier, strCharismaModifier;
        protected string strStrengthSaving, strDexteritySaving, strConstitutionSaving,
            strIntelligenceSaving, strWisdomSaving, strCharismaSaving;
        protected EntityAttacks entAttack;
        protected EntityWeapons entWeapon;
        protected EntityCharacterRace entCharacterRace;
        protected EntityCharacterClass entCharacterClass;
        protected EntityArmor entArmor;
        #endregion

        #region Properties
        //Allow access and manipulation of the object
        #region BeginingCharacter
        public int Health
        {
            get { return intHealth; }
            protected set { intHealth = value; }
        }
        public string Name
        {
            get { return strName; }
            protected set { strName = value; }
        }
        public EntityGender Gender
        {
            get { return entGender; }
            protected set { entGender = value; }
        }
        public int Age
        {
            get { return intAge; }
            protected set { intAge = value; }
        }
        public int HeightFeet
        {
            get { return intHeightFeet; }
            protected set { intHeightFeet = value; }
        }
        public int HeightInches
        {
            get { return intHeightInches; }
            protected set { intHeightInches = value; }
        }
        public string Weight
        {
            get { return strWeight; }
            protected set { strWeight = value; }
        }
        public EntityEyeColor EyeColor
        {
            get { return entEyeColor; }
            protected set { entEyeColor = value; }
        }
        public EntityHairColor HairColor
        {
            get { return entHairColor; }
            protected set { entHairColor = value; }
        }
        public string Skin
        {
            get { return strSkin; }
            protected set { strSkin = value; }
        }
        #endregion BeginingCharacter
        
        #region CharacterRace
        public EntityCharacterRace CharacterRace
        {
            get { return entCharacterRace; }
            set { entCharacterRace = value; }
        }
        #endregion CharacterRace

        #region CharacterClass
        public EntityCharacterClass CharacterClass
        {
            get { return entCharacterClass; }
            set { entCharacterClass = value; }
        }
        public EntityArmor Armor
        {
            get { return entArmor; }
            set { entArmor = value; }
        }
        public EntityWeapons Weapon
        {
            get { return entWeapon; }
            set { entWeapon = value; }
        }
        public EntityAttacks Attack
        {
            get { return entAttack; }
            set { entAttack = value; }
        }
        #endregion CharacterClass

        #region CharacterStats
        public int StrengthAbility
        {
            get { return intStrengthAbility; }
            set { intStrengthAbility = value; }
        }
        public string StrengthModifier
        {
            get { return strStrengthModifier; }
            set { strStrengthModifier = value; }
        }
        public string StrengthSaving
        {
            get { return strStrengthSaving; }
            set { strStrengthSaving = value; }
        }
        public int DexterityAbility
        {
            get { return intDexterityAbility; }
            set { intDexterityAbility = value; }
        }
        public string DexterityModifier
        {
            get { return strDexterityModifier; }
            set { strDexterityModifier = value; }
        }
        public string DexteritySaving
        {
            get { return strDexteritySaving; }
            set { strDexteritySaving = value; }
        }
        public int ConstitutionAbility
        {
            get { return intConstitutionAbility; }
            set { intConstitutionAbility = value; }
        }
        public string ConstitutionModifier
        {
            get { return strConstitutionModifier; }
            set { strConstitutionModifier = value; }
        }
        public string ConstitutionSaving
        {
            get { return strConstitutionSaving; }
            set { strConstitutionSaving = value; }
        }
        public int IntelligenceAbility
        {
            get { return intIntelligenceAbility; }
            set { intIntelligenceAbility = value; }
        }
        public string IntelligenceModifier
        {
            get { return strIntelligenceModifier; }
            set { strIntelligenceModifier = value; }
        }
        public string IntelligenceSaving
        {
            get { return strIntelligenceSaving; }
            set { strIntelligenceSaving = value; }
        }
        public int WisdomAbility
        {
            get { return intWisdomAbility; }
            set { intWisdomAbility = value; }
        }
        public string WisdomModifier
        {
            get { return strWisdomModifier; }
            set { strWisdomModifier = value; }
        }
        public string WisdomSaving
        {
            get { return strWisdomSaving; }
            set { strWisdomSaving = value; }
        }
        public int CharismaAbility
        {
            get { return intCharismaAbility; }
            set { intCharismaAbility = value; }
        }
        public string CharismaModifier
        {
            get { return strCharismaModifier; }
            set { strCharismaModifier = value; }
        }
        public string CharismaSaving
        {
            get { return strCharismaSaving; }
            set { strCharismaSaving = value; }
        }
        #endregion CharacterStats
       
        #endregion Properties

        #region Constructors
        //Create the object
        public Entity()
        {
            intHealth = 10;
            strName = "";
            entGender = EntityGender.Female;
            intAge = 20;
            intHeightFeet = 5;
            intHeightInches = 11;
            strWeight = "";
            entEyeColor = EntityEyeColor.Blue;
            entHairColor = EntityHairColor.Black;
            strSkin = "Weathered";
            intStrengthAbility = 0;
            intDexterityAbility = 0;
            intConstitutionAbility = 0;
            intIntelligenceAbility = 0;
            intWisdomAbility = 0;
            intCharismaAbility = 0;
            strStrengthModifier = "";
            strDexterityModifier = "";
            strConstitutionModifier = "";
            strIntelligenceModifier = "";
            strWisdomModifier = "";
            strCharismaModifier = "";
            strStrengthSaving = "";
            strDexteritySaving = "";
            strConstitutionSaving = "";
            strIntelligenceSaving = "";
            strWisdomSaving = "";
            strCharismaSaving = "";
            entAttack = EntityAttacks.Melee;
            entWeapon = EntityWeapons.Sword;
            entCharacterRace = EntityCharacterRace.Human;
            entCharacterClass = EntityCharacterClass.Fighter;
            entArmor = EntityArmor.Medium;
        }
        #endregion Constructors

        #region Methods
        //Things the object can do

        #endregion
    }
}
