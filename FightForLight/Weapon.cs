public class Weapon{

    private int _damage;
    public int Damage{
        get{return _damage;}
        set{_damage = value;}
    }

    private string _weaponName;
    public string WeaponName{
        get{ return _weaponName;}
        set{ _weaponName = value;}
    }

    public Weapon( string pweaponName, int pdamage){

        _damage = pdamage;
        _weaponName = pweaponName;
    }
}