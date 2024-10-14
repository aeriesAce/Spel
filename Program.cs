using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
namespace Game
{
    static class Program
    {
        static List<Room> rooms = new List<Room>();
        //skapa paths, items, enemies i room klassen
        //4 room, 3 paths

        static void Main()
        {
            LoadJson();
            Room startArea = new Room("You are in the StartArea");
            Room grassField = new Room("You are in the Grassfield.");
            Room outsideHouse = new Room("You are outside A house");
            Room lake = new Room("You are in front of A lake");

            rooms.Add(startArea);
            rooms.Add(grassField);
            rooms.Add(outsideHouse);
            rooms.Add(lake);

            Path pathToHouse = new Path(outsideHouse.id, "You see a old house.", "Walk");
            Path pathToField = new Path(grassField.id, "A gentle breeze guides you forward.", "Follow");
            Path pathToLake = new Path(lake.id, "You continue on the path through the trees, a small pond is in your way", "Jump");

            startArea.paths.Add(pathToField);
            grassField.paths.Add(pathToLake);
            grassField.paths.Add(pathToHouse);
            //problem med att den inte vill ladda det andra rummet om samma rum har fler än 2 paths
            //men det funkar om jag inte använder startarea??

            SaveToJson();

            Room currentRoom = startArea;
            //använder bool för att kontrollera ogiltig inmatning
            bool foundPath = false;

            while (true)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("Choose [q] to end the program \n");
                Console.WriteLine(currentRoom.description);
                foreach (Path path in currentRoom.paths)
                {
                    Room destination = GetRoomById(rooms, path.destinationRoom);
                    Console.WriteLine($"Path to: {destination.description}");
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"Word to get there: {path.wordToGetThere}");
                    Console.WriteLine("--------------------------");
                }
                Console.Write("What will you do?: ");
                string input = Console.ReadLine();
                Console.Clear();

                if (input == "q")
                {
                    Console.WriteLine("GoodBye");
                    break;
                }
                foreach (Path path in currentRoom.paths)
                {
                    if (input == path.wordToGetThere)
                    {
                        currentRoom = GetRoomById(rooms, path.destinationRoom);
                        foundPath = true;
                        Console.WriteLine($"Path information: {path.description}");
                        break;
                    }
                    if (!foundPath)
                    {
                        Console.WriteLine("You cannot go there... Try again: ");
                        break;
                    }
                }
            }
        }
        static Room GetRoomById(List<Room> allRooms, Guid id)
        {
            foreach (Room room in allRooms)
            {
                if (room.id == id)
                {
                    return room;
                }
            }
            return null;
        }
        public static void SaveToJson()
        {
            // sparar listorna till JSON
            string roomsJson = JsonConvert.SerializeObject(rooms, Formatting.Indented);

            File.WriteAllText("rooms.json", roomsJson);
        }
        public static void LoadJson()
        {
            // Ladda JSON och deserialisera listorna
            if (File.Exists("rooms.json"))
            {
                string roomsJson = File.ReadAllText("rooms.json");
                rooms = JsonConvert.DeserializeObject<List<Room>>(roomsJson);
            }
        }
    }
}