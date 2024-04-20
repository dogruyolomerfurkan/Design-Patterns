namespace StrategyPattern.FightingBehaviors;
public sealed class KnifeBehavior : IWeaponBehavior
{
    public void UseWeapon()
    {
        Console.WriteLine("Cutting with knife!");
    }
}
