namespace Problem_7.Gems.Types
{
    internal class Emerald : Gem
    {
        const int strength = 1;
        const int agility = 4;
        const int vitality = 9;

        public Emerald() : base(strength, agility, vitality) { }
    }
}
