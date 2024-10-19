namespace Game
{
    public class SpellDatabase
    {
        public static Dictionary<string, Spell> Spells { get; private set; } = new Dictionary<string, Spell>();

        static SpellDatabase()
        {
            // Initialize with basic spells
            LoadSpells();
        }

        private static void LoadSpells()
        {
            Spells.Add("Slash", new Spell(
                name: "Slash",
                type: SpellType.Melee,
                manaCost: 5,
                element: ElementType.None,
                effects: new List<ISpellEffect> { new DamageEffect(10)
                }));

            Spells.Add("Swift Strike", new Spell(
                name: "Swift Strike",
                type: SpellType.Melee,
                manaCost: 5,
                element: ElementType.None,
                effects: new List<ISpellEffect> { new DamageEffect(5)
                }));

            Spells.Add("Fireball", new Spell(
                name: "Fireball",
                type: SpellType.Magic,
                manaCost: 20,
                element: ElementType.Fire,
                effects: new List<ISpellEffect> { new DamageEffect(25)
                }));

            Spells.Add("Freeze", new Spell(
                name: "Freeze",
                type: SpellType.Magic,
                manaCost: 15,
                element: ElementType.Water,
                effects: new List<ISpellEffect> {
                    new DamageEffect(10),
                    new DebuffEffect("Slow", 2) // Slows the target for 2 turns
                }));

            Spells.Add("Aimed Shot", new Spell(
                name: "Aimed Shot",
                type: SpellType.Ranged,
                manaCost: 10,
                element: ElementType.None,
                effects: new List<ISpellEffect> { new DamageEffect(15)
                }));

            Spells.Add("Volley", new Spell(
                name: "Volley",
                type: SpellType.Ranged,
                manaCost: 20,
                element: ElementType.None,
                effects: new List<ISpellEffect> { new DamageEffect(12), new DamageEffect(12) // Hits twice
                })); 
        }

        // Method to retrieve a spell by name
        public static Spell GetSpell(string spellName)
        {
            if (Spells.ContainsKey(spellName))
            {
                return Spells[spellName];
            }
            return null; // If the spell doesn't exist
        }
    }
}