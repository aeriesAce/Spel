namespace Game
{
    public class Potion : Item
    {
        public string AffectedStats { get; set; }
        public int Amount { get; set; }
        public int AmountOverTime { get; set; }
        public int Duration { get; set; }

        public Potion (string name, string affectedStats, int amount, int amountOverTime, int duration)
        : base(name)
        {
            AffectedStats = affectedStats;
            Amount = amount;
            AmountOverTime = amountOverTime;
            Duration = duration;
        }
    }
}