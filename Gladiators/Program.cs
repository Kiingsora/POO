using System.ComponentModel.DataAnnotations;

Gladiator sora = new Gladiator(100, "Sora");
Weapon keyblade = new Weapon(12, "Keyblade");

sora.ReceiveDamage(keyblade.damage);