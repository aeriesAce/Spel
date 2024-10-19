namespace Game
{
    public static class CharacterCreation
    {
        public static Character CreateCharacter()
        {
            Console.WriteLine("You wake up, not sure about where you are. Fear strikes you as you realize you don't even know who you are.");
            Console.WriteLine("You look around and find yourself in a broken tent. The ground feels wet, and the wind is howling outside.");

            string name = null;
            int health = 50;
            int mana = 30;

            while (name == null) // Loops through the options until everything has been checked.
            {
                Console.WriteLine("In the tent, there is a small bag, a worn book, and an unknown object."); // SOMETHING = some object related to class choice (?)
                Console.WriteLine("What do you want to do?");

                string itemToInvestigate = Console.ReadLine();
                itemToInvestigate.ToLower();

                if (itemToInvestigate == "book" || itemToInvestigate == "look at book" || itemToInvestigate == "pick up book" || itemToInvestigate == "take book")
                {
                    name = GenerateName();
                }
                else if (itemToInvestigate == "bag" || itemToInvestigate == "small bag" || itemToInvestigate == "look at bag" || itemToInvestigate == "look at small bag" || itemToInvestigate == "search bag" || itemToInvestigate == "take bag")
                {
                    Console.WriteLine("You grab the bag and open it.");
                }
                else if (itemToInvestigate == "unknown" || itemToInvestigate == "unknown object" || itemToInvestigate == "look at unknown object" || itemToInvestigate == "pick up unknown object")
                {
                    Console.WriteLine("You pick up some item.");
                }
            }

            Character hero = new Character(name, health, mana, new Ranger());
            return hero;
        }

        #region nameAndClassGeneration

        // Name
        public static string GenerateName()
        {
            Console.WriteLine("You carefully pick up the book. Its leather cover is worn, dirty and bloodied.");
            Console.WriteLine("You open the first page. In the top, it states the name of who have written the book.");
            Console.Write("Author: ");
            string name = ValidateCharacterName();
            return name;
        }

        private static string ValidateCharacterName()
        {
            string name = "";
            bool isValidName = false;

            while (!isValidName)
            {
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("- 'Even though very faint, I am certain it says something.'");
                }
                else if (!name.All(char.IsLetter))
                {
                    Console.WriteLine("- 'I am pretty sure the name only contains letters.'");
                }
                else
                {
                    isValidName = true;
                }
            }

            return name;
        }

        public static void GenerateClass()
        {

        }

        #endregion
    }
}