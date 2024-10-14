namespace Game
{
    public class Item
    {
        public Guid id;
        public string name;
        public int damage;
        public int durability;
        public int block;
        List<Guid> itemId;

        public Item(string name, int damage, int durability, int block)
        {
            this.id = Guid.NewGuid();
            this.name = name;
            this.damage = damage;
            this.durability = durability;
            this.block = block;
            this.itemId = new List<Guid>();
        }
    }
    public class Sword : Item
    {
        public Sword() : base("Sword", 10, 5, 0) { }
    }
    public class Shield : Item
    {
        public Shield() : base("Shield", 0, 20, 15) { }
    }
    public class Bandage : Item
    {
        public Bandage() : base("Bandage", 0, 3,0){}
    }
}