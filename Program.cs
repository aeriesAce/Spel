using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
namespace Game
{
          //skapa paths, items, enemies i room klassen
        //4 room, 3 paths
        // 1 till 9, a - f
        //guid generator online
        //bygga rummen i en editor
        //ange i rummen, monster items mm
        //admin metod för att 
    static class Program
    {
        static List<Room> rooms = new List<Room>();
        static void Main()
        {
            LoadJson();
            //SaveToJson();

            //Kallar på Id på första rummet genom new Guid, söker igeom idt genom GetRoombyId
            Room currentRoom = GetRoomById(rooms, new Guid("9d8a188c-bdcd-4d14-963f-c09957fde60f"));
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
                foreach(var items in Path.)
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