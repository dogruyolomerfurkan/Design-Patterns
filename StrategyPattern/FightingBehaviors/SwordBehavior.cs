namespace StrategyPattern.FightingBehaviors;
public sealed class SwordBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("Swinging a sword!");
    }
}
