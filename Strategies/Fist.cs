namespace Strategy_Pattern.Strategies
{
    internal class Fist : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("attack by fist");
        }
    }
}