namespace Game
{
    public class Prop
    {
        public string Name { get; set; }
        public PropType Type { get; set; }
        public List<Item> Content { get; set; } = new List<Item>();
    }

    public enum PropType
    {
        Object, // Book, document, things that can be picked up and looked at
        Container, // Chets, boxes, etc
        Furniture, // Chairs/benches for example, that the player can sit on
        NatureProp
    }
}