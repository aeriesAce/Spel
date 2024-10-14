namespace Game
{
    class Path
    {
        public Guid id;
        public Guid destination;
        public string description;
        public string wordToGetThere;

        public Path(Guid destination, string description, string wordToGetThere)
        {
            this.id = Guid.NewGuid();
            this.destination = destination;
            this.description = description;
            this.wordToGetThere = wordToGetThere;
        }
    }
}