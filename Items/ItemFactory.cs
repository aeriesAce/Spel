namespace Game
{
    public static class ItemFactory
    {
        public static Weapon CreateWeapon(int id)
        {
            if (ItemDatabase.weapons.TryGetValue(id, out Weapon weapon))
            {
                return weapon;
            }
            else
            {
                Console.WriteLine($"Weapon ID {id} not found in ItemDatabase.");
                return null;
            }
        }

        public static Shield CreateShield(int id)
        {
            if (ItemDatabase.shields.TryGetValue(id, out Shield shield))
            {
                return shield;
            }
            else
            {
                Console.WriteLine($"Shield ID {id} not found in ItemDatabase.");
                return null;
            }
        }

        public static Relic CreateRelic(int id)
        {
            if (ItemDatabase.relics.TryGetValue(id, out Relic relic))
            {
                return relic;
            }
            else
            {
                Console.WriteLine($"Relic ID {id} not found in ItemDatabase.");
                return null;
            }
        }

        public static Armor CreateArmor(int id)
        {
            if (ItemDatabase.armors.TryGetValue(id, out Armor armor))
            {
                return armor;
            }
            else
            {
                Console.WriteLine($"Armor ID {id} not found in ItemDatabase.");
                return null;
            }
        }

        public static Accessory CreateAccessory(int id)
        {
            if (ItemDatabase.accessories.TryGetValue(id, out Accessory accessory))
            {
                return accessory;
            }
            else
            {
                Console.WriteLine($"Accessory ID {id} not found in ItemDatabase.");
                return null;
            }
        }

        public static Potion CreatePotion(int id)
        {
            if (ItemDatabase.potions.TryGetValue(id, out Potion potion))
            {
                return potion;
            }
            else
            {
                Console.WriteLine($"Potion ID {id} not found in ItemDatabase.");
                return null;
            }
        }

        public static QuestItem CreateQuestItem(int id)
        {
            if (ItemDatabase.questItems.TryGetValue(id, out QuestItem questItem))
            {
                return questItem;
            }
            else
            {
                Console.WriteLine($"Quest Item ID {id} not found in ItemDatabase.");
                return null;
            }
        }
    }
}
