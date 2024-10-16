namespace Game
{
    public class Inventory
    {
        public int Gold { get; set; }
        public List<Item> Items { get; set; }

        public Inventory (int gold, List<Item> items)
        {
            Gold = gold;
            Items = items;
        }
    }
}