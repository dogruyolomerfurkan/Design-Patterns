namespace StrategyPattern.FightingBehaviors;
public sealed class BowAndArrowBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("Attacking an arrow with a bow!");
    }
}
