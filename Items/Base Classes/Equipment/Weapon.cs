using static Game.ItemTypes;

namespace Game
{
    public class Weapon : EquippableItem
    {
        public SpecificWeaponType SpecificType { get; set; }
        public WeaponType Type { get; set; }
        public int Damage { get; set; }
        public double AttackSpeed { get; set; }

        public Weapon (string name, ItemRarity rarity, int itemLevel, SpecificWeaponType specificType)
        : base(name, rarity, itemLevel)
        {
            SpecificType = specificType;
            Type = DetermineWeaponType(specificType);
            Damage = CalculateDamage(itemLevel, Type, rarity);
            AttackSpeed = CalculateAttackSpeed(specificType);
        }

        private WeaponType DetermineWeaponType(SpecificWeaponType specificType)
        {
            switch (specificType)
            {
                case SpecificWeaponType.LightSword:
                case SpecificWeaponType.SmallAxe:
                case SpecificWeaponType.Mace:
                case SpecificWeaponType.Dagger:
                    return WeaponType.OneHanded;
                case SpecificWeaponType.HeavySword:
                case SpecificWeaponType.Greataxe:
                case SpecificWeaponType.Sledgehammer:
                case SpecificWeaponType.Staff:
                    return WeaponType.TwoHanded;
                case SpecificWeaponType.Bow:
                case SpecificWeaponType.Crossbow:
                case SpecificWeaponType.Wand:
                    return WeaponType.Ranged;
                default:
                    return WeaponType.OneHanded;
            }
        }

        private int CalculateDamage(int itemLevel, WeaponType type, ItemRarity rarity)
        {
            return rarity switch
            {
                ItemRarity.Common => type switch // COMMON Weapon damage calculation
                {
                    WeaponType.OneHanded => itemLevel * 2,
                    WeaponType.TwoHanded => itemLevel * 4,
                    WeaponType.Ranged => itemLevel * 3,
                    _ => itemLevel * 3 // Fallback value
                },
                ItemRarity.Uncommon => type switch // UNCOMMON Weapon damage calculation
                {
                    WeaponType.OneHanded => (int)(itemLevel * 2.5),
                    WeaponType.TwoHanded => itemLevel * 5,
                    WeaponType.Ranged => itemLevel * 4,
                    _ => itemLevel * 3 // Fallback value
                },
                ItemRarity.Rare => type switch // RARE Weapon damage calculation
                {
                    WeaponType.OneHanded => (int)(itemLevel * 2.5),
                    WeaponType.TwoHanded => itemLevel * 5,
                    WeaponType.Ranged => itemLevel * 4,
                    _ => itemLevel * 3 // Fallback value
                },
                ItemRarity.Epic => type switch // EPIC Weapon damage calculation
                {
                    WeaponType.OneHanded => (int)(itemLevel * 2.5),
                    WeaponType.TwoHanded => itemLevel * 5,
                    WeaponType.Ranged => itemLevel * 4,
                    _ => itemLevel * 3 // Fallback value
                },
                _ => type switch
                {
                    WeaponType.OneHanded => itemLevel * 2,
                    WeaponType.TwoHanded => itemLevel * 4,
                    WeaponType.Ranged => itemLevel * 3,
                    _ => itemLevel * 3 // Fallback value
                }
            };
        }

        private double CalculateAttackSpeed(SpecificWeaponType specificType)
        {
            return specificType switch {
                SpecificWeaponType.LightSword => 1.2,
                SpecificWeaponType.HeavySword => 2.4,
                SpecificWeaponType.SmallAxe => 1.4,
                SpecificWeaponType.Greataxe => 2.8,
                SpecificWeaponType.Mace => 1.6,
                SpecificWeaponType.Sledgehammer => 3.2,
                SpecificWeaponType.Dagger => 1.0,
                SpecificWeaponType.Staff => 2.0,
                _ => 1.5 // Fallback value
            };
        }
    }
}