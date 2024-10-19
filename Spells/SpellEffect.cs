namespace Game
{
    public interface ISpellEffect
    {
        void ApplyEffect(Character target); // Method to apply the effect on a target
    }

    public class DamageEffect : ISpellEffect
    {
        public int DamageAmount { get; set; }
        public int DamageOverTime { get; set; }
        public int Duration { get; set; }

        public DamageEffect(int damageAmount)
        {
            DamageAmount = damageAmount;
        }

        public void ApplyEffect(Character target)
        {
            target.CurrentHealth -= DamageAmount;
            // Logic for taking damage to be implemented later
        }
    }

    public class HealingEffect : ISpellEffect
    {
        public int HealingAmount { get; set; }
        public int HealingOverTime { get; set; }
        public int Duration { get; set; }

        public HealingEffect(int healingAmount)
        {
            HealingAmount = healingAmount;
        }

        public void ApplyEffect(Character target)
        {
            target.CurrentHealth += HealingAmount;
            // Logic for receiving healing to be implemented later
        }
    }

    public class BuffEffect : ISpellEffect
    {
        public string BuffType { get; set; } // e.g., "Shield"
        public int Duration { get; set; } // Duration in turns

        public BuffEffect(string buffType, int duration)
        {
            BuffType = buffType;
            Duration = duration;
        }

        public void ApplyEffect(Character target)
        {
            // Logic for receiving a buff to be implemented later
        }
    }

    public class DebuffEffect : ISpellEffect
    {
        public string DebuffType { get; set; } // e.g., "Slow"
        public int Duration { get; set; } // Duration in turns

        public DebuffEffect(string debuffType, int duration)
        {
            DebuffType = debuffType;
            Duration = duration;
        }

        public void ApplyEffect(Character target)
        {
            // Logic for receiving a debuff to be implemented later
        }
    }
}
