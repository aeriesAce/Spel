namespace Game
{
    public class Ranger : CharacterClass
    {
        public Ranger()
        {
            ArmorProficiency = "Light armor";
            WeaponProficiency = "One-handed axes, bows, crossbows";

            BaseStats["Stamina"] = 3;
            BaseStats["Dexterity"] = 5;
            BaseStats["Charisma"] = 2;
            BaseStats["Intellect"] = 1;
        }

        // Abstract method to be implemented by each subclass to define their starting spells
        public override List<Spell> GetStartingSpells()
        {
            return new List<Spell>
            {
                SpellDatabase.GetSpell("Aimed Shot"),
                SpellDatabase.GetSpell("Volley"),
                SpellDatabase.GetSpell("Swift Strike")
            };
        }
    }
}