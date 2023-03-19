using Inheritence;

/**
 * This program demonstrates the use of inheritence in C#.
 */

// Create a new mage with basic stats and a mage weapon
Mage mage =  new Mage("Gandalf", 100, 100, 100, null!);
mage.Attack();

// Create a new mage weapon and give it to the mage
MageWeapon mageWeapon = new MageWeapon();
mage.SetWeapon(mageWeapon);
mage.Attack();
mage.CastSpell();

// Create a new staff of frost and give it to the mage
StaffOfFrost staffOfFrost = new StaffOfFrost();
mage.SetWeapon(staffOfFrost);
mage.Attack();
staffOfFrost.Freeze();

Console.WriteLine(new string('-', 50));

// Create a new warrior with no weapon (Warrior inherits from Character)
Warrior warrior =  new Warrior("Aragon", 65, 43, 23, null!);
warrior.Attack();

// Create a new warrior weapon and give it to the warrior
WarriorWeapon warriorWeapon = new WarriorWeapon();
warrior.SetWeapon(warriorWeapon);
warrior.Attack();
warrior.Charge();

// Create a new axe of destruction and give it to the warrior
AxeOfDestruction axeOfDestruction = new AxeOfDestruction();
warrior.SetWeapon(axeOfDestruction);
warrior.Attack();
axeOfDestruction.Cleave();
