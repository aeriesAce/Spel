namespace Game
{
    public static class Combat
    {
        public static void CombatSimulation()
        {
            // Generates a hero
            Character hero = new Character("HeroName", 50, 20, CharacterClass.Ranger);

            // Generates an enemy
            Enemy enemy = new Enemy("Forest Troll", 40, 15, 7, 20);

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
            Enemy enemy = new Enemy("Forest Troll", 40, 15, 7, 20);

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

        private static void StartCombat(Character hero, Enemy enemy)
        {
            // Loop the following method to simulate rounds
            StartRound(hero, enemy);
        }

        private static void StartRound(Character hero, Enemy enemy)
        {
            List<string> heroActions = new List<string>();
            List<string> enemyActions = new List<string>();

            while (true)
            {
                // Method for players turn:
                PlayerTurn(hero);

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

        private static void PlayerTurn(Character hero)
        {

        }

        private static void EnemyTurn(Enemy enemy)
        {

        }

        private static void ResolveActions(List<string> heroActions, List<string> enemyActions)
        {

        }

        private static void EndOfTurn()
        {

        }

        private static bool CheckEndCondition(Character hero, Enemy enemy)
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