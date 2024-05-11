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

    private int _target;
    public int Target
    {
        get => _target;
        set => _target = value;
    }

    public Gladiator(int pcurrentHealth, string pname, string passignedWeapon, int pdamage)
    {
        _currentHealth = pcurrentHealth;
        _name = pname;
        _assignedWeapon = passignedWeapon;
        _damage = pdamage;

        Console.WriteLine("Combattant: " + _name);
        Console.WriteLine("Santé: " + _currentHealth + " HP");
    }

    public void AttackTarget(Gladiator target)
    {
        target.CurrentHealth -= _damage;
        Console.WriteLine(_name + " donne un coup, il inflige " + _damage + " pts de dégats. "+ target._name +" Point de vie restant: " + target._currentHealth + " points de vie");

        if (target._currentHealth <= 0 || _currentHealth <= 0 )
        {
            _currentHealth = 0;
            target._currentHealth = 0;
            Die(_name);
        }
    }
    public void Die(string _name)
    {
        Console.WriteLine(_name + " à gagné");
    }
}