namespace Metin2;

/**
 * @brief This program is a overview of the OOP concepts.
 */
public class Program
{
    public static void Main()
    {
        // Create a player
        Player player = new Player("username", "password", "email", new WarriorCharacterModel());
        Console.WriteLine("Player created successfully!");
        
        // Create a character warrior and give it a weapon
        AbstractCharacterModel warrior = new WarriorCharacterModel("Warrior", 1, 0, 226, 23, 1);
        var newWeapon = new BattleSwordWeapon();
        player.SetWeapon(newWeapon);
        player.Attack();
        player.Defend();
        player.Move();
        player.Die();

        // Create a character ninja and give it a weapon
        AbstractCharacterModel archer = new NinjaCharacterModel("Archer", 58, 0, 2525, 234, 10);
        var soullessKnife = new SoullessKnifeWeapon();
        player.SetCharacter(archer);
        player.SetWeapon(soullessKnife);
        player.Attack();
        player.Defend();
        player.Move();
        player.Die();

        // Create a character shaman and give it a weapon
        AbstractCharacterModel sura = new SuraCharacterModel("Sura", 68, 90, 4955, 2893, 5);
        Weapon demonBlade = new DemonBladeWeapon();
        player.SetCharacter(sura);
        player.SetWeapon(demonBlade);
        player.Attack();
        player.Defend();
        player.Move();
        player.Die();
        
        // Create a character shaman and give it a weapon
        AbstractCharacterModel shaman = new ShamanCharacterModel("Shaman", 79, 40, 7899, 2345, 5);
        Weapon zodiacFan = new ZodiacFanWeapon();
        player.SetCharacter(shaman);
        player.SetWeapon(zodiacFan);
        player.Attack();
        player.Defend();
        player.Move();
        player.Die();
    }
}
