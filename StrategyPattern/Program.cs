using StrategyPattern.Characters;
using StrategyPattern.FightingBehaviors;

Console.WriteLine("Hello, World!");

Character queen = new Queen(new BowAndArrowBehavior());

queen.Display();
queen.Fight();
queen.SetWeapon(new SwordBehavior());
queen.Fight();