namespace Strategy_Pattern.Strategies
{
    internal class Knife : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("attack by knife");
        }
    }
}