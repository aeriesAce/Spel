namespace Game
{
    class Path
    {
        public Guid id;
        public Guid destinationRoom;
        public string description;
        public string wordToGetThere;

        public Path(Guid destination, string description, string wordToGetThere)
        {
            this.id = Guid.NewGuid();
            this.destinationRoom = destination;
            this.description = description;
            this.wordToGetThere = wordToGetThere;
        }
    }
}