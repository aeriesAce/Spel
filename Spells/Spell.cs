namespace Game
{
    public class Spell
    {
        public SpellType Type { get; set; }
    }

    public enum SpellType
    {
        Fire,
        Water,
        Earth,
        Air
    }
}