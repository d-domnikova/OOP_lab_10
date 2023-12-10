namespace Problem_7.Gems.Types
{
    internal class Ruby : Gem
    {
        const int strength = 7;
        const int agility = 2;
        const int vitality = 5;

        public Ruby() : base(strength, agility, vitality) { }
    }
}
