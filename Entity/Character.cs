namespace Game
{
    public class Character : Entity
    {
        public int Level { get; set; }
        public Inventory Inventory { get; set; }

        public Character (string name, int level, List<Item> Inventory)
        : base (name)
        {
            Level = level;
            Inventory = Inventory;
        }
    }
}