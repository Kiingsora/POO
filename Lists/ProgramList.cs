using System.ComponentModel.DataAnnotations;
Armory weapon = new Armory();
Gladiator sora = new Gladiator(110, "Sora", weapon.getRandomWeapon());
Gladiator xehanort = new Gladiator(100, "Xehanort",weapon.getRandomWeapon());

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




