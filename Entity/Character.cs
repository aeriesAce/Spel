namespace Game
{
    public class Character : Entity
    {
        public int Level { get; set; }
        public CharacterClass BaseClass { get; set; }
        public CharacterStats Stats { get; set; }
        public Spellbook Spellbook { get; set; }
        public Inventory Inventory { get; set; } = new Inventory();
        public Equipment Equipped { get; set; } = new Equipment();

        public Character (string name, int level)
        : base (name)
        {
            Level = level;
            Inventory = Inventory;
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