namespace Game
{
    public class Party
    {
        public List<Character> Characters { get; private set; } = new List<Character>();
        public List<Enemy> Enemies { get; private set; } = new List<Enemy>();

        public void AddCharacter(Character newCharacter)
        {
            if (Characters.Count < 4)
            {
                Characters.Add(newCharacter);
            }
            else
            {
                Console.WriteLine("Hero team is full!");
            }
        }

        public void AddEnemy(Enemy newEnemy)
        {
            if (Enemies.Count < 4)
            {
                Enemies.Add(newEnemy);
            }
            else
            {
                Console.WriteLine("Enemy team is full!");
            }
        }
    }
}
