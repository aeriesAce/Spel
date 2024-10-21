namespace Game
{
    public class Entity
    {
        public string Name { get; set; }
        public int TotalHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int TotalMana { get; set; }
        public int CurrentMana { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; }

        public Entity (string name, int totalHealth, int totalMana, int armor, int damage)
        {
            Name = name;
            TotalHealth = totalHealth;
            CurrentHealth = TotalHealth;
            TotalMana = totalMana;
            CurrentMana = TotalMana;
            Armor = armor;
            Damage = damage;
        }
    }
}