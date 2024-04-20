using StrategyPattern.FightingBehaviors;

namespace StrategyPattern.Characters;
public sealed class Queen(IWeaponBehavior weaponBehavior) : Character(weaponBehavior)
{
}
