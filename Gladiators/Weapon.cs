public class Weapon{

    public int damage;
    public string weaponName;

    public Weapon(int pdamage, string pweaponName){

        damage = pdamage;
        weaponName = pweaponName;

        Console.WriteLine("Arme: " + weaponName);
        Console.WriteLine("Dégat: " + damage + " pts");
    }
    
}