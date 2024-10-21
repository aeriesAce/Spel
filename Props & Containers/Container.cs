namespace Game
{
    public class Container : Prop
    {
        public ContainerType Type { get; set; }
        public List<Item> Content { get; set; } = new List<Item>();
        public bool IsLocked { get; set; }
        public bool IsLockPickable { get; set; }
    }

    public enum ContainerType
    {
        Chest,
        Cupboard,
        Drawer,
        Box
    }
}