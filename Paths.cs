using System.IO.Pipes;

namespace Game
{
    class Path
    {
        public Guid id;
        public Guid destinationRoom;
        public string description;
        public string wordToGetThere;

        //lista, ska ändras till dictionary, för föremål som går att plocka upp mm längs med vägarna.
        List<Item> itemOnPath;
        //lista, ska ändras till dictionary, för NPCS man kan träffa mm längs med pathen.
        //List<NPC> npcOnPath;

        public Path(Guid destination, string description, string wordToGetThere)
        {
            this.id = Guid.NewGuid();
            this.destinationRoom = destination;
            this.description = description;
            this.wordToGetThere = wordToGetThere;
            this.itemOnPath = new List<Item>();
            //this.npcOnPath = new List<NPC>();
        }

    }
}