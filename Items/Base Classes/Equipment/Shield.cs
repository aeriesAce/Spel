using static Game.ItemTypes;

namespace Game
{
    public class Shield : EquippableItem
    {
        public double BlockChance { get; set; }

        public Shield (string name, ItemRarity rarity, int itemLevel, double blockChance)
        : base(name, rarity, itemLevel)
        {
            BlockChance = blockChance;
        }
    }
}