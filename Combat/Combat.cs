namespace Game
{
    public static class Combat
    {
        public static void CombatSimulation()
        {
            // Generates a hero
            Character hero = new Character("HeroName", 50, 20, new Ranger());

            // Generates an enemy
            NPC enemy = new NPC("Forest Troll", 40, 15, 7, 20, true);

            StartCombat(hero, enemy);
        }

        public static void Encounter(Character hero)
        {
            // Check IF it's a story-encounter
            // Which will call the following method:
            StoryEncounter(hero);

            // Or IF it's a regular encounter
            // Which will call the following method:
            RegularEncounter(hero);
        }

        public static void StoryEncounter(Character hero)
        {
            // Code for story encounter
        }

        public static void RegularEncounter(Character hero)
        {
            // string enemy = "Random Enemy"; // Temporary variable for enemy

            // First, determine enemies with the following method:
            DetermineEnemies();
            // Then, generate the enemy party with the following method:
            // Party enemyParty = ???;
            // Generates an enemy
            NPC enemy = new NPC("Forest Troll", 40, 15, 7, 20, true);

            // Then, start the combat with the following method:
            StartCombat(hero, enemy);
        }

        private static void DetermineEnemies()
        {
            // First, check biome
            string biome = DetermineBiome();

            // Then randomize enemy size and type

            // Then generate and return the enemy/enemies
        }

        private static string DetermineBiome()
        {
            // Check what biome it is
            string biome = "Plains";

            // Then return that biome
            return biome;
        }

        private static void StartCombat(Character hero, NPC enemy)
        {
            // Loop the following method to simulate rounds
            StartRound(hero, enemy);
        }

        private static void StartRound(Character hero, NPC enemy)
        {
            Console.WriteLine($"You encounter a {enemy.Name}!");
            List<string> heroActions = new List<string>();
            List<string> enemyActions = new List<string>();
            
            string[] combatOptions = ["Attack", "Cast spell", "Open inventory", "Run away"];

            while (true)
            {
                // Method for players turn:
                PlayerTurn(hero, combatOptions);

                // Method for enemies turn (to generate their actions):
                EnemyTurn(enemy);

                // Method for resolving player/enemy actions:
                ResolveActions(heroActions, enemyActions);

                // Method for end of round (to simulate regeneration, cooldown ticks, etc)
                EndOfTurn();

                if (CheckEndCondition(hero, enemy))
                {
                    EndCombat();
                    break;
                }
            }
        }

        private static void PlayerTurn(Character hero, string[] combatOptions)
        {
            Console.WriteLine($"It is time to decide, {hero.Name}. What will you do?");
            Console.WriteLine($"{combatOptions[0]}  |  {combatOptions[1]}  |  {combatOptions[2]}  |  {combatOptions[3]}");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "attack":
                break;
                
                case "spell":
                break;
                
                case "inventory":
                break;
                
                case "run":
                break;
                
            }
        }

        private static void EnemyTurn(NPC enemy)
        {

        }

        private static void ResolveActions(List<string> heroActions, List<string> enemyActions)
        {

        }

        private static void EndOfTurn()
        {

        }

        private static bool CheckEndCondition(Character hero, NPC enemy)
        {
            // Check if either team has no members with HP > 0
            bool allHeroesDefeated = true;
            bool allEnemiesDefeated = true;

            return allHeroesDefeated || allEnemiesDefeated;
        }

        private static void EndCombat()
        {
            CombatRewards();
        }

        private static void CombatRewards()
        {
            AssignExp();
            DropLoot();
        }

        private static void AssignExp()
        {

        }

        private static void DropLoot()
        {

        }
    }
}