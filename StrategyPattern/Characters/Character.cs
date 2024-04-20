using StrategyPattern.FightingBehaviors;

namespace StrategyPattern.Characters;
public abstract class Character(IWeaponBehavior weaponBehavior)
{
    public void Fight()
    {
        weaponBehavior.UseWeapon();
    }

    public void SetWeapon(IWeaponBehavior newWeaponBehavior)
    {
        weaponBehavior = newWeaponBehavior;
        Console.WriteLine("Character uses : " + newWeaponBehavior.GetType().Name);
    }

    public void Display()
    {
        Console.WriteLine("Displaying current character");
    }
}
