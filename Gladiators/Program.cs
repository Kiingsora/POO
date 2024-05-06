using System.ComponentModel.DataAnnotations;

Gladiator sora = new Gladiator(100, "Sora");
Weapon keyblade = new Weapon(10, "Keyblade");

while (sora.currentHealth > 0)
{
    sora.ReceiveDamage(keyblade.damage);
    if (sora.currentHealth <= 0)
    {
        sora.Die();
    }
}