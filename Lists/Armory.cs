
public class Armory
{
    public List<Weapon> WeaponsList
    {
        get { return weaponsList; }
        set { weaponsList = value; }
        
    }
    List<Weapon> weaponsList = new List<Weapon>();

    public Armory(List<Weapon> weapons)
    {
        for (int i = 0; i < weaponsList.Count; i++)
        {
            Random rand = new Random();
            int randomWeapon = rand.Next(0, weaponsList.Count);
            Console.WriteLine(weapons.Count);
        }
    }
}

// faire une liste d'arme.
// mettre en plce la méthode random.
// boucler sur la liste d'arme de façon aléatoire pour attribuer une arme à un gladiateur.
// et faaire un console write pour afficher une arme et enchainer sur le combat.