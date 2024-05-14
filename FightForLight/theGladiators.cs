public class Gladiator
{
    public int CurrentHealth { get; private set; }
    public string Name { get; private set; }
    public int Damage { get; private set; }
    public string AssignedWeapon { get; set; }
    public int Target { get; set; }

    public Gladiator(int pcurrentHealth, string pname, string passignedWeapon, int pdamage)
    {
        CurrentHealth = pcurrentHealth;
        Name = pname;
        AssignedWeapon = passignedWeapon;
        Damage = pdamage;

        Console.WriteLine("Combattant: " + Name);
        Console.WriteLine("Santé: " + CurrentHealth + " HP");
    }

    public void AttackTarget(Gladiator target)
    {
        if (target.CurrentHealth > 0 || CurrentHealth > 0)
        {
            target.CurrentHealth -= Damage;
            while (target.CurrentHealth <= 0 || CurrentHealth <= 0)
            {
                target.CurrentHealth = 0;
                CurrentHealth = 0;
                break;
            }
            Console.WriteLine(Name + " donne un coup, il inflige " + Damage + " pts de dégats. " + target.Name + " Point de vie restant: " + target.CurrentHealth + " points de vie");
        }
    }

    public void Die(string pname, Gladiator penemyName)
    {
        Name = pname;

        if (penemyName.CurrentHealth > 0 && CurrentHealth <= 0)
        {
            Console.WriteLine(Name + " à perdu");
            Console.WriteLine(penemyName.Name + " à gagné");

        }
        else if (penemyName.CurrentHealth <= 0 || CurrentHealth > 0)
        {
            Console.WriteLine(Name + " à gagné");
            Console.WriteLine(penemyName.Name + " à perdu");
        }
    }
}