using StrategyPattern.FightingBehaviors;

namespace StrategyPattern.Characters;
public sealed class King(IWeaponBehavior weaponBehavior) : Character(weaponBehavior)
{
}
