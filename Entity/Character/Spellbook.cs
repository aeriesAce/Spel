namespace Game
{
    public class Spellbook
    {
        private Character _hero;
        public List<Spell> Spells { get; set; } = new List<Spell>();

        public Spellbook(Character hero, List<Spell> spells)
        {
            _hero = hero;
            Spells = spells;
        }
    }
}