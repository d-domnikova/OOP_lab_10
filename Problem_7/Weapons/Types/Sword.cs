using Problem_7.Weapons;

internal class Sword : Weapon
{
    public string name;
    const int minDamage = 4;
    const int maxDamage = 6;
    const int sockets = 3;

    public Sword(string name) : base(name, minDamage, maxDamage, sockets)
    {
        this.name = name;
    }
}