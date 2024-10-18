namespace Game
{
    public class Equipment
    {
        // Weapons
        public Weapon? MainHand { get; set; }
        public Weapon? TwoHandWeapon { get; set; }
        public Weapon? RangedWeapon { get; set; }

        // Off-hand slot to manage all off-hand equippable items
        public OffHandSlot OffHand { get; set; } = new OffHandSlot();

        // Armor
        public Armor? Helmet { get; set; }
        public Armor? ChestArmor { get; set; }
        public Armor? Gloves { get; set; }
        public Armor? Belt { get; set; }
        public Armor? Pants { get; set; }
        public Armor? Boots { get; set; }

        // Accessories
        public Accessory? Cape { get; set; }
        public Accessory? Necklace { get; set; }
        public Accessory? RingOne { get; set; }
        public Accessory? RingTwo { get; set; }
    }

    // Sub-class for handling the off-hand
    public class OffHandSlot
    {
        public Weapon? Weapon { get; set; }
        public Shield? Shield { get; set; }
        public Relic? Relic { get; set; }

        public EquippableItem? GetCurrentOffHandItem()
        {
            if (Weapon != null) return Weapon;
            if (Shield != null) return Shield;
            if (Relic != null) return Relic;
            return null;
        }

        public void ClearOffHand()
        {
            Weapon = null;
            Shield = null;
            Relic = null;
        }

        public void EquipNewItem(EquippableItem newItem)
        {
            ClearOffHand();
            switch (newItem)
            {
                case Weapon weapon:
                    Weapon = weapon;
                    break;
                case Shield shield:
                    Shield = shield;
                    break;
                case Relic relic:
                    Relic = relic;
                    break;
                default:
                    throw new InvalidOperationException("Invalid off-hand item type.");
            }
        }
    }
}