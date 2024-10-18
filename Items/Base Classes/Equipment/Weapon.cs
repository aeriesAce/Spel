using static Game.ItemTypes;

namespace Game
{
    public class Weapon : EquippableItem
    {
        public WeaponType Type { get; set; }
        public SpecificWeaponType SpecificType { get; set; }
        public int Damage { get; set; }
        public double AttackSpeed { get; set; }

        public Weapon (string name, ItemRarity rarity, int itemLevel, SpecificWeaponType specificType, int damage, double attackSpeed)
        : base(name, rarity, itemLevel)
        {
            SpecificType = specificType;
            Type = DetermineWeaponType(specificType);
            Damage = damage;
            AttackSpeed = attackSpeed;
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
    }
}