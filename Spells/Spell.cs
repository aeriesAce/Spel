namespace Game
{
    public class Spell
    {
        public string Name { get; set; }
        public SpellType Type { get; set; }
        public int ManaCost { get; set; }
        public ElementType Element { get; set; }
        public List<ISpellEffect> Effects { get; set; }

        public Spell(string name, SpellType type, int manaCost, ElementType element, List<ISpellEffect> effects)
        {
            Name = name;
            Type = type;
            ManaCost = manaCost;
            Element = element;
            Effects = effects;
        }
    }

    public enum SpellType
    {
        Melee,
        Ranged,
        Magic
    }

    public enum ElementType
    {
        Fire,
        Water,
        Earth,
        Air,
        None // For spells without an elemental affinity, like "Slash"
    }
}