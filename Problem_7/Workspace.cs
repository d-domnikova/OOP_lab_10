using Problem_7.Weapons;
using Problem_7.Gems;

namespace Problem_7
{
    internal class Workspace
    {
        static void Main()
        {
            List<Weapon> weapons = new List<Weapon>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(';');
                if (input[0].ToLower() == "end") break;

                switch (input[0].ToLower())
                {
                    case "create":
                        string[] weaponTypeAndRarity = input[1].Split(' ');

                        Type typeOfWeapon = Type.GetType(weaponTypeAndRarity[1]);
                        var createWeapon = (Weapon)Activator.CreateInstance(typeOfWeapon, new object[] { input[2] });

                        increaseDamage(weaponTypeAndRarity[0], createWeapon);
                        weapons.Add(createWeapon);
                        break;

                    case "add":
                        int index = int.Parse(input[2]);
                        string[] gemTypeAndRarity = input[3].Split(' ');

                        Type typeOfGem = Type.GetType($"Problem_7.Gems.Types.{gemTypeAndRarity[1]}");
                        var createGem = (Gem)Activator.CreateInstance(typeOfGem);

                        increaseStats(gemTypeAndRarity[0], createGem);
                        foreach (Weapon weapon in weapons)
                        {
                            if (weapon.Name.ToLower() == input[1].ToLower()) 
                                addGem(weapon, index, createGem); 
                        }
                        break;

                    case "remove":
                        int indexOfSocket = int.Parse(input[2]);
                        foreach (Weapon weapon in weapons)
                        {
                            if (weapon.Name.ToLower() == input[1].ToLower())
                            {
                                for (int i = 0; i < weapon.ArrOfStats.GetLength(1); i++)
                                    weapon.ArrOfStats[indexOfSocket, i] = 0;
                            }
                        }
                        break;

                    case "print":
                        foreach (Weapon weapon in weapons)
                        {
                            if (weapon.Name.ToLower() == input[1].ToLower())
                                Console.WriteLine(weapon);
                        }
                        break;
                }
            }
        }

        static void increaseDamage(string rarity, Weapon weapon)
        {
            RaritiesOfWeapons rarities;
            Enum.TryParse(rarity, out rarities);

            int multiply = (int)rarities;

            weapon.MinDamage *= multiply;
            weapon.MaxDamage *= multiply;

        }

        static void addGem(Weapon weapon, int indexOfSocket, Gem gem)
        {
            int[] stats = { gem.Strength, gem.Agility, gem.Vitality };

            for (int i = 0; i < weapon.ArrOfStats.GetLength(1); i++)
            {
                weapon.ArrOfStats[indexOfSocket, i] = stats[i];
            }
        }

        static void increaseStats(string rarity, Gem gem)
        {
            ClarityOfGems rarities;
            Enum.TryParse(rarity, out rarities);

            int multiply = (int)rarities;

            gem.Strength *= multiply;
            gem.Agility *= multiply;
            gem.Vitality *= multiply;
        }

    }
}
