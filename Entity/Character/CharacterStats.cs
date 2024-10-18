namespace Game
{
    public class CharacterStats
    {
        private Character _hero;
        public int Stamina { get; set; }

        public CharacterStats(Character hero, int stamina)
        {
            _hero = hero;
            Stamina = stamina;
        }
    }
}