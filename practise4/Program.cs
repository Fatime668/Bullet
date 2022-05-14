using System;

namespace practise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletCapacity;
            int bulletCount;
            bool check = true;

            do
            {
                Console.WriteLine("BulletCapacity daxil edin");
                bulletCapacity = Convert.ToInt32(Console.ReadLine());
            } while (bulletCapacity<0 || bulletCapacity == 0);
            do
            {
                Console.WriteLine("BulletCount daxil edin");
                bulletCount = Convert.ToInt32(Console.ReadLine());
            } while (bulletCount < 0 || bulletCount>bulletCapacity || bulletCount == 0);
            Weapon wp = new Weapon(bulletCapacity, bulletCount);
            wp.BulletCapacity = bulletCapacity;
            wp.BulletCount = bulletCount;
            do
            {
                Console.WriteLine("0: İnformasiya almaq üçün");
                Console.WriteLine("1: Shoot metodu üçün");
                Console.WriteLine("2: Fire metodu üçün");
                Console.WriteLine("3: GetRemainBulletCount metodu üçün");
                Console.WriteLine("4: Reload metodu üçün");
                Console.WriteLine("5: ChangeFireMode metodu üçün");
                Console.WriteLine("6: Proqramdan dayandırmaq üçün");

                switch (Console.ReadLine())
                {
                    case "0":
                        break;
                    case "1":
                        wp.Shoot();
                        break;
                    case "2":
                        wp.Fire();
                        break;
                    case "3":
                        Console.WriteLine(wp.GetRemaindBulletCount()); 
                        break;
                    case "4":
                        wp.Reload();
                        break;
                    case "5":
                        wp.ChangeFireMode();
                        break;
                    case "6":
                        check = false;
                        break;
                    default:
                        break;
                }
            } while (check);




           
            
        }
    }
}
