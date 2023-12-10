namespace Problem_7.Gems
{
    internal class Gem : IGems
    {
        private int strength;
        private int agility;
        private int vitality;
        public int Strength { get { return strength; } set { strength = value; } }
        public int Agility { get { return agility; } set { agility = value; } }
        public int Vitality { get { return vitality; } set { vitality = value; } }

        public Gem(int strength, int agility, int vitality)
        {
            this.Strength = strength;
            this.Agility = agility;
            this.Vitality = vitality;
        }
    }
}
