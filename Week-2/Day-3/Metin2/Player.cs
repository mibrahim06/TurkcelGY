namespace Metin2;

/**
 * @brief This class represents a player in the game.
 */
public class Player
{
    private string _username;
    private string _password;
    private string _email;
    private AbstractCharacterModel _character;
    private Weapon _weapon;

    // Default constructor
    public Player()
    {
        this._username = "username";
        this._password = "test123";
        this._email = "empty@gmail.com";
        this._character = null;
        this._weapon = null;
    }
    
    // Constructor with parameters
    public Player(string username, string password, string email, AbstractCharacterModel character)
    {
        this._username = username;
        this._password = password;
        this._email = email;
        this._character = character;
    }
    
    public void Attack()
    {
        if (this._weapon != null)
        {
            this._weapon.Attack();
        }
        else
        {
           Console.WriteLine("You don't have a weapon!");
        }
    }
    
    public void Defend()
    {
        this._character.Defend();
    }
    
    public void Move()
    {
        this._character.Move();
    }
    
    public void Die()
    {
        this._character.Die();
    }

    // Getters and setters
    public string GetUsername()
    {
        return _username;
    }
    
    public void SetUsername(string username)
    {
        this._username = username;
    }
    
    public string GetPassword()
    {
        return _password;
    }
    
    public void SetPassword(string password)
    {
        this._password = password;
    }
    
    public string GetEmail()
    {
        return _email;
    }
    
    public void SetEmail(string email)
    {
        this._email = email;
    }
    
    public AbstractCharacterModel GetCharacter()
    {
        return _character;
    }
    
    public void SetCharacter(AbstractCharacterModel character)
    {
        this._character = character;
        Console.WriteLine("Character changed to " + character.GetName() + "!");
    }
    
    public Weapon GetWeapon()
    {
        return _weapon;
    }
    
    public void SetWeapon(Weapon weapon)
    {
        this._weapon = weapon;
    }
}