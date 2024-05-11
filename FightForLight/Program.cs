using System.ComponentModel.DataAnnotations;

Weapon keyblade = new Weapon("Keyblade", 12);
Gladiator sora = new Gladiator(110, "Sora", keyblade.WeaponName, keyblade.Damage);

Weapon gardian = new Weapon("Le gardien", 18);
Gladiator xehanort = new Gladiator(100, "Xehanort", gardian.WeaponName, gardian.Damage);

while (true)
{
    Console.ReadLine();
    sora.AttackTarget(xehanort);
    Console.ReadLine();
    xehanort.AttackTarget(sora);
    if (sora.CurrentHealth <= 0 || xehanort.CurrentHealth <= 0)
    {
        break;
    }
}
