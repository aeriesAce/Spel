using static Game.ItemTypes;

namespace Game
{
    public class Armor : EquippableItem
    {
        public ArmorType Type { get; set; }
        public SpecificArmorType SpecificType { get; set; }
        public int ArmorValue { get; set; }

        public Armor (string name, ItemRarity rarity, int itemLevel, ArmorType type)
        : base(name, rarity, itemLevel)
        {
            ArmorValue = CalculateArmorValue(type, itemLevel);
        }

        private int CalculateArmorValue(ArmorType type, int itemLevel)
        {
            return type switch
            {
                ArmorType.Helmet => itemLevel * 2,
                ArmorType.ChestArmor => itemLevel * 4,
                ArmorType.Gloves => itemLevel * 2,
                ArmorType.Belt => itemLevel * 1,
                ArmorType.Pants => itemLevel * 3,
                ArmorType.Boots => itemLevel * 2,
                _ => itemLevel * 2 // Fallback value
            };
        }
    }
}