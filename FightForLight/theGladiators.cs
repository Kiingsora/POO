public class Gladiator
{
    private int _currentHealth;
    public int CurrentHealth
    {
        get { return _currentHealth; }
        set { _currentHealth = value; }
    }
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private int _damage;
    public int Damage
    {
        get { return _damage; }
        set { _damage = value; }
    }

    private string _assignedWeapon;
    public string AssignedWeapon
    {
        get { return _assignedWeapon; }
        set { _assignedWeapon = value; }
    }

    public Gladiator(int pcurrentHealth, string pname, string passignedWeapon)
    {
        _currentHealth = pcurrentHealth;
        _name = pname;
        _assignedWeapon = passignedWeapon;
        Console.WriteLine("Combattant: " + _name);
        Console.WriteLine("Santé: " + _currentHealth + " HP");
    }

    public void ReceiveDamage(int pdamage)
    {
        _damage = pdamage;
        while (_currentHealth > 0)
        {
            _currentHealth -= _damage;

            if (_currentHealth <= 0)
            {
                // pour éviter de tomber en négatif
                _currentHealth = 0;
                Die();
            }
            else
            {
                Console.WriteLine(_name + " reçois " + _damage + "pts de dégats, il lui reste " + _currentHealth + " points de vie");
            }
        }

    }

    public void Die()
    {
        Console.WriteLine("YOU DIED");
    }
}