namespace Game
{
    class Enemy
    {
        public Guid id;
        public int damage;
        public int hp;
        public List<Guid> enemyIds;

        public Enemy(int damage, int hp)
        {
            this.id = Guid.NewGuid();
            this.damage = 20;
            this.hp = 100;
            this.enemyIds = new List<Guid>();
        }
    }
}