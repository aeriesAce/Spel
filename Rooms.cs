namespace Game
{
    class Room
    {
        public List<Path> paths = new List<Path>();
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