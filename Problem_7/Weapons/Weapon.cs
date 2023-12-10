namespace Problem_7.Weapons
{
    internal class Weapon : IWeapon
    {
        private string name;
        private int minDamage;
        private int maxDamage;
        private int sockets;

        public string Name { get { return name; } set { name = value; } }
        public int MinDamage { get { return minDamage; } set { minDamage = value; } }
        public int MaxDamage { get { return maxDamage; } set { maxDamage = value; } }
        public int Sockets { get { return sockets; } set { sockets = value; } }

        private int[,] arrOfStats;
        public int[,] ArrOfStats { get { return arrOfStats; } set { arrOfStats = value; } }
        public Weapon(string name, int minDamage, int maxDamage, int sockets)
        {
            this.Name = name;
            this.MinDamage = minDamage; 
            this.MaxDamage = maxDamage; 
            this.Sockets = sockets;
            arrOfStats = new int[Sockets, 3];
        }

        private string calculateStats()
        {
            int[] tempArr = new int[3];
            for (int i = 0; i < arrOfStats.GetLength(0); i++)
            {
                for (int j = 0; j < arrOfStats.GetLength(1); j++) { tempArr[j] += arrOfStats[i, j]; }
            }

            return $"+{tempArr[0]} Strenght, +{tempArr[1]} Agillity, +{tempArr[2]} Vitality";
        }

        public override string? ToString()
        {
            return $"{Name}: {minDamage}-{maxDamage} Damage, {calculateStats()}";
        }
    }
}
