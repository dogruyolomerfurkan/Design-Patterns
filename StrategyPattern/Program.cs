using StrategyPattern.Characters;
using StrategyPattern.FightingBehaviors;

Character queen = new Queen(new BowAndArrowBehavior());

queen.Display();
queen.Fight();
queen.SetWeapon(new SwordBehavior());
queen.Fight();
