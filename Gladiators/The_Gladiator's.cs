public class Gladiator
{
    public int currentHealth;
    public string name;
    public int damage;

    public Gladiator(int pcurrentHealth, string pname)
    {
        currentHealth = pcurrentHealth;
        name = pname;
        Console.WriteLine("Combattant: " + pname);
        Console.WriteLine("Santé: " + pcurrentHealth + " HP");
    }

    public void ReceiveDamage(int pdamage)
    {
        damage = pdamage;
        currentHealth -= damage;
        Console.WriteLine(name + " reçois " + damage + "pts de dégats, il lui reste " + currentHealth + " points de vie");
    }

    public void Die()
    {
        Console.WriteLine("YOU DIED");
    }
}