namespace Game
{
    public class AdminMethods
    {
        public static void TestMenu()
        {
            string[] adminMenu = ["Character Creation", "Inventory", "Equipment", "Show Stats", "Combat"];
            for (int i = 0; i < adminMenu.Length; i++)
            {
                Console.WriteLine($"[{i+1}] {adminMenu[i]}");
            }
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: CharacterCreation.CreateCharacter(); break;
                case 2: break;
                case 3: break;
                case 4: break;
                case 5: break;
            }
        }
    }
}