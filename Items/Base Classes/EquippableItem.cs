using static Game.ItemTypes;

namespace Game
{
    public class EquippableItem : Item
    {
        public ItemRarity Rarity { get; set; }
        public int ItemLevel { get; set; }
        public int Durability { get; set; } = 100;
        public float Weight { get; set; }

        public EquippableItem (string name, ItemRarity rarity, int itemLevel)
        : base(name)
        {
            Rarity = rarity;
            ItemLevel = itemLevel;
        }
    }
}