namespace Strategy_Pattern.Strategies
{
    internal class WaterGun : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("attack by water-gun!");
        }
    }
}