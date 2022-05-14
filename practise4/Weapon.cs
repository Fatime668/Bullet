using System;
using System.Collections.Generic;
using System.Text;

namespace practise4
{
    class Weapon
    {
        private int _bulletCapacity;
        public int BulletCapacity { get => _bulletCapacity;
            set
            {
                if (value>0)
                {
                    _bulletCapacity = value;
                }
            }
        }
        private int _bulletCount;
        public int BulletCount
        {
            get => _bulletCount;
            set
            {
                if (value > 0)
                {
                    _bulletCount = value;
                }
            }
        }
        public bool IsAutomatic { get; set; }
        public Weapon()
        {

        }
        public Weapon(int bulletcapacity,int bulletcount)
        {
            BulletCapacity = bulletcapacity;
            BulletCount = bulletcount;
        }

        public void Shoot()
        {
            if (BulletCount>0)
            {
                Console.WriteLine(--BulletCount) ;
            }
            else{
                Console.WriteLine("Gulle yoxdur");
            }
        }
        public void Fire()
        {
            if (BulletCount > 0 )
            {
                if (IsAutomatic)
                {
                    Console.WriteLine(BulletCapacity = 0);
                }
                else
                {
                    Console.WriteLine(--BulletCount);
                }
            }
        }
        public int GetRemaindBulletCount()
        {
            if (BulletCapacity != BulletCount)
            {
                return BulletCapacity - BulletCount;
            }
            return BulletCount;
        }

        public void Reload()
        {
            int count;
            if (BulletCount != BulletCapacity)
            {
                count = BulletCapacity - BulletCount;
                BulletCount += count;
                Console.WriteLine(BulletCount);
            }
            else
            {
                Console.WriteLine("You don't need reload");
            }
        }
        public void ChangeFireMode()
        {
            if (IsAutomatic == true)
            {
                IsAutomatic = false;
                Console.WriteLine("Firemode: " + IsAutomatic);
            }
            else
            {
                IsAutomatic = true;
                Console.WriteLine("Firemode: " + IsAutomatic);

            }
        }

    }
}
