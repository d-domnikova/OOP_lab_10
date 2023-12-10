namespace Problem_7.Weapons
{
    interface IWeapon { 
    
        string Name { get; set; }
        int MinDamage { get; set; }
        int MaxDamage { get; set; }
        int Sockets { get; set; }
    }
}
