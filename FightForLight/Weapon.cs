public class Weapon{

    private int _damage;
    public int Damage{
        get{return _damage;}
    }
    private string _weaponName;
    public string WeaponName{
        get{ return _weaponName;}
        set{ _weaponName = value;}
    }

    public Weapon(int pdamage, string pweaponName){

        _damage = pdamage;
        _weaponName = pweaponName;
        Console.WriteLine("Arme: " + _weaponName);
        Console.WriteLine("Dégat: " + _damage + " pts");
    }
}