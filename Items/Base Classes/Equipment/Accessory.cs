using static Game.ItemTypes;

namespace Game
{
    public class Accessory : EquippableItem
    {
        public AccessoryType Type { get; set; }
        
        public Accessory (string name, ItemRarity rarity, int itemLevel)
        : base(name, rarity, itemLevel)
        {
            
        }
    }
}