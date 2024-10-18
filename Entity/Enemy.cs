namespace Game
{
    public class Enemy : Entity
    {
        public int Damage { get; set; }
        public int Armor { get; set; }
        public Enemy (string name, int health, int mana, int damage, int armor)
        : base (name, health, mana)
        {
            Damage = damage;
            Armor = armor;
        }
    }
}