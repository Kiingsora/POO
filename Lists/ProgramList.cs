using System.ComponentModel.DataAnnotations;

Weapon keyblade = new Weapon("Keyblade", 15);
Weapon gardian = new Weapon("Le gardien", 17);
Weapon masamune = new Weapon("masamune", 22);
Weapon sabreLaser = new Weapon("sabreLaser", 21);
Weapon baguetteDeSorcier = new Weapon("baguetteDeSorcier", 22);

Gladiator sora = new Gladiator(110, "Sora", keyblade.WeaponName, keyblade.Damage);
Gladiator xehanort = new Gladiator(100, "Xehanort", gardian.WeaponName, gardian.Damage);

while (true)
{
    Console.ReadLine();
    sora.AttackTarget(xehanort);    
    Console.ReadLine();
    xehanort.AttackTarget(sora);

    if (sora.CurrentHealth <= 0)
    {
        sora.Die(sora.Name,xehanort);
        break;
    }
    else if (xehanort.CurrentHealth <= 0)
    {
        xehanort.Die(xehanort.Name,sora);
        break;
    }

}




