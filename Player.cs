namespace Game
{
    class Player
    {
        public Guid id;
        public string name;
        public int hp;
        public int damage;
        public List<Guid> playerId;

        public Player(string name, int hp, int damage)
        {
            this.id = Guid.NewGuid();
            this.name = name;
            this.hp = 100;
            this.damage = 20;
            this.playerId = new List<Guid>();
        }
    }
}