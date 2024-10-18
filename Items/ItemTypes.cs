namespace Game
{
    public static class ItemTypes
    {
        public enum ItemType
        {
            Weapon,
            Shield,
            Relic,
            Armor,
            Accessory,
            Potion,
            QuestItem
        }
        public enum WeaponType
        {
            OneHanded,
            TwoHanded,
            Ranged
        }

        public enum SpecificWeaponType
        {
            LightSword,
            HeavySword,
            SmallAxe,
            Greataxe,
            Mace,
            Sledgehammer,
            Dagger,
            Staff,
            Bow,
            Crossbow,
            Wand
        }

        public enum ArmorType
        {
            Helmet,
            ChestArmor,
            Gloves,
            Belt,
            Pants,
            Boots
        }

        public enum SpecificArmorType
        {
            Cloth,
            Leather,
            Chainmail,
            Plate
        }

        public enum AccessoryType
        {
            Cape,
            Necklace,
            Ring
        }

        public enum ItemRarity
        {
            Common,
            Uncommon,
            Rare,
            Epic,
            Legendary
        }
    }
}
