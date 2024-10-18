namespace Game
{
    public class Entity
    {
        public string Name { get; set; }
        public int TotalHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int TotalMana { get; set; }
        public int CurrentMana { get; set; }
        public int Damage { get; set; }

        public Entity (string name, int health, int mana)
        {
            Name = name;
            TotalHealth = health;
            CurrentHealth = TotalHealth;
            TotalMana = mana;
            CurrentMana = TotalMana;
        }
    }
}