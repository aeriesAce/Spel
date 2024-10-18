namespace Game
{
    public class Character : Entity
    {
        public int Level { get; set; }
        public double Experience { get; set; }
        public CharacterClass BaseClass { get; set; }
        public CharacterStats Stats { get; set; }
        // public Spellbook Spellbook { get; set; }
        public Inventory Inventory { get; set; } = new Inventory();
        public Equipment Equipped { get; set; } = new Equipment();

        public Character (string name, int health, int mana, CharacterClass baseClass/*,  Spellbook spellbook*/)
        : base (name, health, mana)
        {
            Level = 1; // Base level
            Experience = 0; // Base experience
            BaseClass = baseClass;

            // Create an empty spell list (or pre-populate it with spells if needed)
            List<Spell> spellList = new List<Spell>(); // This can be empty or contain initial spells
            // Spellbook = new Spellbook(this, spellList);

            Stats = new CharacterStats(this, 5); // Initialize base stats
        }
    }

    public enum CharacterClass
    {
        Ranger, // "Hunter"
        Spellweaver, // "Mage"
        Berserker, // "Warrior"
        Occultist, // "Warlock"
        Cleric, // "Priest"
        Crusader // "Paladin"
    }
}