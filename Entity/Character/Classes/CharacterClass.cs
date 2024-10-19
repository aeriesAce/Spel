namespace Game
{
    public abstract class CharacterClass
    {
        // Properties every class has, such as armor type and weapon proficiencies
        public string ?ArmorProficiency { get; set; }
        public string ?WeaponProficiency { get; set; }
        
        // Placeholder for class-specific stats (e.g., Stamina, Dexterity)
        public Dictionary<string, int> BaseStats { get; set; }

        // Constructor to initialize general class features
        protected CharacterClass()
        {
            BaseStats = new Dictionary<string, int>();
        }

        // Abstract method to be implemented by each subclass to define their starting spells
        public abstract List<Spell> GetStartingSpells();
    }

    public enum CharacterClasses
    {
        Ranger, // "Hunter"
        Spellweaver, // "Mage"
        Berserker, // "Warrior"
        Occultist, // "Warlock"
        Cleric, // "Priest"
        Crusader // "Paladin"
    }
}