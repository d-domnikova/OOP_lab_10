using Problem_7.Weapons;

internal class Axe : Weapon
{
    public string name;
    const int minDamage = 5;
    const int maxDamage = 10;
    const int sockets = 4;

    public Axe(string name) : base(name, minDamage, maxDamage, sockets) 
    {
        this.name = name;
    }
}