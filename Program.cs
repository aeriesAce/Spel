using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
namespace Game
{
    static class Program
    {
        static List<Room> rooms = new List<Room>();
        static List<Path> paths = new List<Path>();
        static List<Enemy> enemies = new List<Enemy>();
        static List<Item> items = new List<Item>();

        static void Main()
        {
            LoadJson();
            Room startArea = new Room("Isn't it wierd to just.. wake up?");
            Room grassField = new Room("The smell of grass calms you down.");
            Room outsideHouse = new Room("You look at the weirdo sleeping in his rocking chair");
            Room lake = new Room("The lake glisters in the sun, is that a person?");
            Room outsideDungeon = new Room("The gate looks heavy..");
            Room dungeonStart = new Room("All you can hear is the echo of the dripping water.");
            Room firstRoom = new Room("It's quite dark.. If only you had some light. The dark tunnels forks in three directions.");
            Room secondRoom = new Room("A small growl could be heard.");
            Room thirdRoom = new Room("The door seems to be locked.");
            Room deadEnd = new Room("It seems like you've reached a dead end.");
            rooms.Add(startArea);
            rooms.Add(grassField);
            rooms.Add(lake);
            rooms.Add(outsideHouse);
            rooms.Add(outsideDungeon);
            rooms.Add(dungeonStart);
            rooms.Add(firstRoom);
            rooms.Add(secondRoom);
            rooms.Add(thirdRoom);
            rooms.Add(deadEnd);

            Path pathToHouse = new Path(outsideHouse.id, "You see a old house.", "Walk");
            Path pathToField = new Path(grassField.id, "A gentle breeze guides you forward.", "Follow");
            Path pathToLake = new Path(lake.id, "You continue on the path through the trees, a small pond is in your way", "Jump");
            Path pathToDungeon = new Path(outsideDungeon.id, "A mountain looms in the distance, it's a long days march but if you sprint you will make it before night falls.", "Sprint");
            Path pathInsideDungeon = new Path(dungeonStart.id, "The huge gate make you shiver, will you go in?", "Go");
            Path pathToFirstRoom = new Path(firstRoom.id, "You swallow your fear and slowly make your way in.", "Sneak");
            Path pathToSecondRoom = new Path(secondRoom.id, "A creature suddenly appears.", "Attack");
            Path pathToThirdRoom = new Path(thirdRoom.id, "What will you do to continue?", "Unlock");
            paths.Add(pathToField);
            paths.Add(pathToHouse);
            paths.Add(pathToLake);
            paths.Add(pathToDungeon);
            paths.Add(pathInsideDungeon);
            paths.Add(pathToFirstRoom);
            paths.Add(pathToSecondRoom);
            paths.Add(pathToThirdRoom);

            startArea.pathIds.Add(pathToField.id); //ska gå till fältet
            grassField.pathIds.Add(pathToHouse.id);//fältet ska gå till dungeon entrance, utsidan huset eller sjön
            grassField.pathIds.Add(pathToDungeon.id);
            grassField.pathIds.Add(pathToLake.id);
            outsideHouse.pathIds.Add(pathToField.id);//ska gå till antingen huset eller tillbaka
            lake.pathIds.Add(pathToField.id); //ska bara gå att gå tillbaka
            outsideDungeon.pathIds.Add(dungeonStart.id); //ska lägga till dungeon och ny path
            dungeonStart.pathIds.Add(firstRoom.id);
            firstRoom.pathIds.Add(secondRoom.id);
            firstRoom.pathIds.Add(thirdRoom.id);
            SaveToJson();

            Room currentRoom = startArea;

            while (true)
            {
                Console.WriteLine(currentRoom.description);
                foreach (Guid pathId in currentRoom.pathIds)
                {
                    Path paths = GetPathById(pathId);
                    Console.WriteLine(paths.description);
                    Console.WriteLine(paths.wordToGetThere);
                    break;
                }
                //den gör som den ska, problemet nu är bara att allt körs
                if (currentRoom == grassField)
                {
                    foreach (Guid pathId in grassField.pathIds)
                    {
                        Path multiplePaths = GetPathById(pathId);
                        Console.WriteLine($"Type {multiplePaths.wordToGetThere} to where you want to go.");
                    }
                }
                Console.Write("What will you do?:");
                string input = Console.ReadLine();
                //använder bool för att kontrollera ogiltig inmatning
                bool foundPath = false;

                foreach (Guid pathId in currentRoom.pathIds)
                {
                    Path path = GetPathById(pathId);
                    if (input == path.wordToGetThere)
                    {
                        currentRoom = GetRoomById(path.destination);
                        foundPath = true;
                        break;
                    }
                }
                if (!foundPath)
                {
                    Console.WriteLine("You cannot go there... Try again:");
                }
                if (currentRoom == thirdRoom)
                {
                    //programmet avslutas här tillfälligt
                    Console.WriteLine(currentRoom.description);
                    break;
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
            string enemiesJson = JsonConvert.SerializeObject(enemies, Formatting.Indented);
            string itemsJson = JsonConvert.SerializeObject(items, Formatting.Indented);

            File.WriteAllText("rooms.json", roomsJson);
            File.WriteAllText("paths.json", pathsJson);
            File.WriteAllText("enemies.json", enemiesJson);
            File.WriteAllText("items.json", itemsJson);
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
            if (File.Exists("enemies.json"))
            {
                string enemiesJson = File.ReadAllText("enemies.json");
                enemies = JsonConvert.DeserializeObject<List<Enemy>>(enemiesJson);
            }
            if (File.Exists("items.json"))
            {
                string itemsJson = File.ReadAllText("itemsJson");
                items = JsonConvert.DeserializeObject<List<Item>>(itemsJson);
            }
        }
    }
}