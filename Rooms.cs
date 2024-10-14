namespace Game
{
    class Room
    {
        public Guid id;
        public string description;
        public List<Guid> pathIds;

        public Room(string description)
        {
            this.id = Guid.NewGuid();
            this.description = description;
            this.pathIds = new List<Guid>();
        }
    }
}