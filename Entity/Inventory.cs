namespace Game
{
    public class Inventory
    {
        public int Gold { get; set; }
        public List<Item> ?Items { get; set; }
        public double CurrentWeight { get; set; } = 0;
        public double MaxWeight { get; set; } = 50;
        
        // Method for adding an item to the inventory
        public void AddItem(Item itemToAdd)
        {
            Items?.Add(itemToAdd);
        }

        // Method for removing a specific instance of an item from the inventory
        public void RemoveItem(Item itemToRemove)
        {
            var item = Items?.FirstOrDefault(i => i == itemToRemove);
            if (item != null)
            {
                Items?.Remove(item);
            }
            else
            {
                Console.WriteLine($"Item \"{itemToRemove.Name}\" not found in inventory.");
            }
        }
    }
}