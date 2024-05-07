public class Gladiator
{
    public int currentHealth;
    public string name;
    public int damage;

    public Gladiator(int pcurrentHealth, string pname)
    {
        currentHealth = pcurrentHealth;
        name = pname;
        Console.WriteLine("Combattant: " + name);
        Console.WriteLine("Santé: " + currentHealth + " HP");
    }

    public void ReceiveDamage(int pdamage)
    {
        damage = pdamage;
        while (currentHealth > 0)
        {            
            currentHealth -= damage;

            if (currentHealth <= 0)
            {
                // pour éviter de tomber en négatif
                currentHealth = 0;
                Die();
            }
            else
            {
                Console.WriteLine(name + " reçois " + damage + "pts de dégats, il lui reste " + currentHealth + " points de vie");
            }
        }

    }

    public void Die()
    {
        Console.WriteLine("YOU DIED");
    }
}