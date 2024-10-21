using static Game.ItemTypes;

namespace Game
{
    public static class ItemDatabase
    {
        public static Dictionary<int, Weapon> weapons = new Dictionary<int, Weapon>();
        public static Dictionary<int, Shield> shields = new Dictionary<int, Shield>();
        public static Dictionary<int, Relic> relics = new Dictionary<int, Relic>();
        public static Dictionary<int, Armor> armors = new Dictionary<int, Armor>();
        public static Dictionary<int, Accessory> accessories = new Dictionary<int, Accessory>();
        
        static ItemDatabase()
        {
            List<Weapon> weaponList = new List<Weapon>
            {
                // COMMON weapons
                // Starter Gear
                new Weapon("Shortsword", ItemRarity.Common, 5, SpecificWeaponType.LightSword),
                new Weapon("Broadsword", ItemRarity.Common, 5, SpecificWeaponType.HeavySword),
                new Weapon("Small Axe", ItemRarity.Common, 5, SpecificWeaponType.SmallAxe),
                new Weapon("Greataxe", ItemRarity.Common, 5, SpecificWeaponType.Greataxe),
                new Weapon("Mace", ItemRarity.Common, 5, SpecificWeaponType.Mace),
                new Weapon("Sledgehammer", ItemRarity.Common, 5, SpecificWeaponType.Sledgehammer),
                new Weapon("Dagger", ItemRarity.Common, 5, SpecificWeaponType.Dagger),
                new Weapon("Wooden Staff", ItemRarity.Common, 5, SpecificWeaponType.Staff),
                new Weapon("Bow", ItemRarity.Common, 5, SpecificWeaponType.Bow),
                new Weapon("Crossbow", ItemRarity.Common, 5, SpecificWeaponType.Crossbow),
                new Weapon("Wand", ItemRarity.Common, 5, SpecificWeaponType.Wand),
                
                // UNCOMMON Weapons
                new Weapon("Steel Sword", ItemRarity.Uncommon, 5, SpecificWeaponType.LightSword),
                new Weapon("Cutlass", ItemRarity.Uncommon, 5, SpecificWeaponType.LightSword),
                new Weapon("Sharpened Broadsword", ItemRarity.Uncommon, 5, SpecificWeaponType.HeavySword),
                new Weapon("Claymore", ItemRarity.Uncommon, 5, SpecificWeaponType.HeavySword),
                new Weapon("Sharpened Axe", ItemRarity.Uncommon, 5, SpecificWeaponType.SmallAxe),
                new Weapon("Hatchet", ItemRarity.Uncommon, 5, SpecificWeaponType.SmallAxe),
                new Weapon("Battleaxe", ItemRarity.Uncommon, 5, SpecificWeaponType.Greataxe),
                new Weapon("War Cleaver", ItemRarity.Uncommon, 5, SpecificWeaponType.Greataxe),
                new Weapon("Dwarven Mace", ItemRarity.Uncommon, 5, SpecificWeaponType.Mace),
                new Weapon("Warhammer", ItemRarity.Uncommon, 5, SpecificWeaponType.Mace),
                new Weapon("Dwarven Sledgehammer", ItemRarity.Uncommon, 5, SpecificWeaponType.Sledgehammer),
                new Weapon("Maul", ItemRarity.Uncommon, 5, SpecificWeaponType.Sledgehammer),
                new Weapon("Sharp Dagger", ItemRarity.Uncommon, 5, SpecificWeaponType.Dagger),
                new Weapon("Stiletto", ItemRarity.Uncommon, 5, SpecificWeaponType.Dagger),
                new Weapon("Runed Wooden Staff", ItemRarity.Uncommon, 5, SpecificWeaponType.Staff),
                new Weapon("Sturdy Oak Staff", ItemRarity.Uncommon, 5, SpecificWeaponType.Staff),
                new Weapon("Hunting Bow", ItemRarity.Uncommon, 5, SpecificWeaponType.Bow),
                new Weapon("Longbow", ItemRarity.Uncommon, 5, SpecificWeaponType.Bow),
                new Weapon("Mechanical Crossbow", ItemRarity.Uncommon, 5, SpecificWeaponType.Crossbow),
                new Weapon("Reinforced Crossbow", ItemRarity.Uncommon, 5, SpecificWeaponType.Crossbow),
                new Weapon("Mystic Wand", ItemRarity.Uncommon, 5, SpecificWeaponType.Wand),
                new Weapon("Runed Wand", ItemRarity.Uncommon, 5, SpecificWeaponType.Wand)
            };

            int id = 1;
            foreach (Weapon weapon in weaponList)
            {
                weapons.Add(id++, weapon);
            }

            List<Shield> shieldList = new List<Shield>
            {
                // COMMON shields
                new Shield("Wooden Shield", ItemRarity.Common, 5, 20), // Starter shield
            };

            id = 1;
            foreach (Shield shield in shieldList)
            {
                shields.Add(id++, shield);
            }

            List<Relic> relicList = new List<Relic>
            {
                // COMMON relics
                new Relic("Skull", ItemRarity.Common, 5), // Starter relic
            };

            id = 1;
            foreach (Relic relic in relicList)
            {
                relics.Add(id++, relic);
            }

            List<Armor> armorList = new List<Armor>
            {
                // COMMON armor pieces
                new Armor("Leather Shirt", ItemRarity.Common, 5, ArmorType.ChestArmor), // Starter armor
                new Armor("Leather Pants", ItemRarity.Common, 5, ArmorType.Pants), // Starter armor
                new Armor("Leather Helm", ItemRarity.Common, 5, ArmorType.Helmet),
                new Armor("Leather Gloves", ItemRarity.Common, 5, ArmorType.Gloves),
                new Armor("Leather Belt", ItemRarity.Common, 5, ArmorType.Belt),
                new Armor("Leather Boots", ItemRarity.Common, 5, ArmorType.Boots),
            };

            id = 1;
            foreach (Armor armor in armorList)
            {
                armors.Add(id++, armor);
            }

            List<Accessory> accessoryList = new List<Accessory>
            {
                // COMMON accessories
                new Accessory("Worn Cape", ItemRarity.Common, 5, AccessoryType.Cape),
            };

            id = 1;
            foreach (Accessory accessory in accessoryList)
            {
                accessories.Add(id++, accessory);
            }
        }
        public static Dictionary<int, Potion> potions = new Dictionary<int, Potion>(); // SKA FLYTTAS UPP OVAN 
        public static Dictionary<int, QuestItem> questItems = new Dictionary<int, QuestItem>(); // SKA FLYTTAS UPP OVAN
        public static Dictionary<int, Item> items = new Dictionary<int, Item>(); // SKA FLYTTAS UPP OVAN 
    }
}
