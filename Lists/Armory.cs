
public class Armory
{
    public List<Weapon> weaponList = new List<Weapon>();
    Weapon keyblade = new Weapon("une keyblade", 20);
    Weapon gardian = new Weapon("le gardien", 23);
    Weapon masamune = new Weapon("la masamune", 22);
    Weapon sabreLaser = new Weapon("le sabreLaser", 21);
    Weapon baguetteDeSorcier = new Weapon("la baguetteDeSorcier", 17);

    public Armory()
    {
        weaponList.Clear();
        weaponList.Add(keyblade);
        weaponList.Add(gardian);
        weaponList.Add(masamune);
        weaponList.Add(sabreLaser);
        weaponList.Add(baguetteDeSorcier);
    }

    public Weapon getRandomWeapon()
    {
        Random rand = new Random();
        int randomWeapon = rand.Next(0, weaponList.Count);

        Weapon weapon = weaponList[randomWeapon];
        return weapon;
    }
}

// faire une liste d'arme.
// mettre en place la méthode random.
// boucler sur la liste d'arme de façon aléatoire pour attribuer une arme à un gladiateur.
// et faaire un console write pour afficher une arme et enchainer sur le combat.