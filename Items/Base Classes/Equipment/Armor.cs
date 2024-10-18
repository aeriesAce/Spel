using static Game.ItemTypes;

namespace Game
{
    public class Armor : EquippableItem
    {
        public ArmorType Type { get; set; }
        public SpecificArmorType SpecificType { get; set; }
        public int ArmorValue { get; set; }

        public Armor (string name, ItemRarity rarity, int itemLevel, int armorValue)
        : base(name, rarity, itemLevel)
        {
            ArmorValue = armorValue;
        }
    }
}