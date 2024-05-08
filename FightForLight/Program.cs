using System.ComponentModel.DataAnnotations;

Weapon keyblade = new Weapon(12, "Keyblade");
Gladiator sora = new Gladiator(100, "Sora", keyblade.WeaponName);

Weapon gardian = new Weapon(22, "Le gardien");
Gladiator xehanort = new Gladiator(100, "Xehanort", gardian.WeaponName);

sora.ReceiveDamage(keyblade.Damage);
