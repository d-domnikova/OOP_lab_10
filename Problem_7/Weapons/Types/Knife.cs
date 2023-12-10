using Problem_7.Weapons;

internal class Knife : Weapon
{
    public string name;
    const int minDamage = 3;
    const int maxDamage = 4;
    const int sockets = 2;

    public Knife(string name) : base(name, minDamage, maxDamage, sockets) 
    {
    this.name = name;
    }
}