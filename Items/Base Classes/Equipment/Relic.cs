using static Game.ItemTypes;

namespace Game
{
    public class Relic : EquippableItem
    {
        // Properties here

        public Relic (string name, ItemRarity rarity, int itemLevel)
        : base(name, rarity, itemLevel)
        {
            
        }
    }
}