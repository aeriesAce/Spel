using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
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

static class Program
{
    static List<Room> rooms = new List<Room>();
    static List<Path> paths = new List<Path>();

    static void Main()
    {
        LoadJson();
        Room startArea = new Room("Isn't it wierd to just.. wake up?");
        Room grassField = new Room("The smell of grass calms you down");
        // Room outsideHouse = new Room("You look up at the crooked house, the door is slightly open");
        // Room lake = new Room("The lake glisters in the sun, is that a person?");
        // Room insideHouse = new Room("You look at the weirdo sleeping in his rocking chair");
        Room outsideDungeon = new Room("The gate looks heavy..");
        rooms.Add(startArea);
        rooms.Add(grassField);
        rooms.Add(outsideDungeon);


        //Path pathToHouse = new Path(outsideHouse.id, "You see a old house.", "Walk");
        Path pathToStartArea = new Path(startArea.id, "You look to your right, a narrow path leads between the trees", "Walk");
        Path pathToField = new Path(grassField.id, "A gentle breeze guides you forward.", "Follow");
        //Path pathInsideHouse = new Path(insideHouse.id, "The door creeks as you reach for it.", "Open");
        //Path pathToLake = new Path(lake.id, "You continue on the path through the trees, a small pond is in your way", "Jump");
        Path pathToDungeon = new Path(outsideDungeon.id, "A mountain looms in the distance, it's a long days march but if you sprint you will make it before night falls.", "Sprint");

        paths.Add(pathToStartArea);
        paths.Add(pathToField);
        paths.Add(pathToDungeon);

        startArea.pathIds.Add(pathToField.id); //ska gå till antingen fältet, utsidan huset eller sjön
        grassField.pathIds.Add(pathToDungeon.id);//fältet ska endast gå till dungeon entrance
        //outsideHouse.pathIds.Add(pathToField.id);//ska gå till antingen huset eller tillbaka
        //lake.pathIds.Add(pathInsideHouse.id); //ska bara gå att gå tillbaka
        //insideHouse.pathIds.Add(pathToLake.id); //ska bara gå att gå tillbaka till outsideHouse
        //outsideDungeon.pathIds.Add(pathToDungeon.id); //ska lägga till dungeon och ny path

        SaveToJson();

        Room currentRoom = startArea;
        Room nextRoom = grassField;
        Path path1 = pathToField;

        while (true)
        {
            Console.WriteLine(currentRoom.description);
            foreach (Guid pathId in currentRoom.pathIds)
            {
                Console.WriteLine($"{path1.description}");
                Console.WriteLine($"{path1.wordToGetThere}");
                break;
            }
            Console.Write("What will you do?:");
            string input = Console.ReadLine();

            foreach (Guid pathId in currentRoom.pathIds)
            {
                Path path = GetPathById(pathId);
                if (input == path.wordToGetThere)
                {
                    nextRoom = GetRoomById(pathId);
                    break;
                }
            }
        }
    }

    static Room GetRoomById(Guid ids)
    {
        foreach (Room room in rooms)
        {
            if (room.id == ids)
            {
                return room;
            }
        }
        return null;
    }
    static Path GetPathById(Guid ids)
    {
        foreach (Path path in paths)
        {
            if (path.id == ids)
            {
                return path;
            }
        }
        return null;
    }
    public static void SaveToJson()
    {
        // sparar listorna till JSON
        string roomsJson = JsonConvert.SerializeObject(rooms, Formatting.Indented);
        string pathsJson = JsonConvert.SerializeObject(paths, Formatting.Indented);

        File.WriteAllText("rooms.json", roomsJson);
        File.WriteAllText("paths.json", pathsJson);
    }
    public static void LoadJson()
    {
        // Ladda JSON och deserialisera listorna
        if (File.Exists("rooms.json"))
        {
            string roomsJson = File.ReadAllText("rooms.json");
            rooms = JsonConvert.DeserializeObject<List<Room>>(roomsJson);
        }

        if (File.Exists("paths.json"))
        {
            string pathsJson = File.ReadAllText("paths.json");
            paths = JsonConvert.DeserializeObject<List<Path>>(pathsJson);
        }
    }
}