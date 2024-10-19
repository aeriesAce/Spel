namespace Game
{
    public class Character : Entity
    {
        public int Level { get; set; }
        public double Experience { get; set; }
        public CharacterClass BaseClass { get; set; }
        public CharacterStats Stats { get; set; }
        public Spellbook Spellbook { get; set; }
        public Inventory Inventory { get; set; } = new Inventory();
        public Equipment Equipped { get; set; } = new Equipment();

        public Character (string name, int health, int mana, CharacterClass baseClass)
        : base (name, health, mana)
        {
            Level = 1; // Base level
            Experience = 0; // No experience from the start
            BaseClass = baseClass;
            
            // Base stats disregarding class choice
            var baseStats = new Dictionary<string, int>
            {
                { "Stamina", 5},
                { "Dexterity", 5},
                { "Charisma", 5},
                { "Intellect", 5},
            };
            
            // Initialize base stats based on chosen starter class
            Stats = new CharacterStats(this, baseStats, baseClass.BaseStats); 

            // Assign the spellbook based on the chosen class
            Spellbook = new Spellbook(this, baseClass.GetStartingSpells());

        }
    }
}