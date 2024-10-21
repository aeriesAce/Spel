namespace Game
{
    public class NPC : Entity
    {
        public NPCType Type { get; set; }
        public NPCSize Size { get; set; }
        public bool IsHostile { get; set; }
        public NPC (string name, int totalHealth, int totalMana, int armor, int damage, bool isHostile)
        : base (name, totalHealth, totalMana, damage, armor)
        {
            IsHostile = isHostile;
        }
    }

    public enum NPCType
    {
        Humanoid,
        Dragon,
        Beast,
        Elemental,
        Undead
    }

    public enum NPCSize
    {
        Minor,
        Regular,
        Lesser,
        Boss
    }
}