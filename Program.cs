using Strategy_Pattern;
using Strategy_Pattern.Strategies;

Hero hero = new("Derty");

hero.Attack();

hero.SetWeapon(new Fist());

hero.Attack();

hero.SetWeapon(new Knife());

hero.Attack();

Console.ReadKey();