namespace Game
{
    public class CharacterStats
    {
        private Character _hero;
        public Dictionary<string, int> Stats { get; set; } = new Dictionary<string, int>();

        public CharacterStats(Character hero, Dictionary<string, int> baseStats, Dictionary<string, int> classStats)
        {
            _hero = hero;
            Stats = new Dictionary<string, int>();

            // Add base stats
            foreach (var stat in baseStats)
            {
                Stats[stat.Key] = stat.Value;
            }

            // Add or override with class-specific stats
            foreach (var stat in classStats)
            {
                // If a stat already exists, combine them
                if (Stats.ContainsKey(stat.Key))
                {
                    Stats[stat.Key] += stat.Value; // Sum the stats
                }
                else
                {
                    Stats[stat.Key] = stat.Value;
                }
            }
        }

        // Method for retrieving value for a specific stat
        public int GetStat(string statName)
        {
            if (Stats.ContainsKey(statName))
            {
                return Stats[statName];
            }

            return 0; // Default value if stat does not exist
        }
    }
}