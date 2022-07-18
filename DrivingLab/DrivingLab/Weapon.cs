using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLab
{
    public abstract class Weapon : IShootable
    {
        protected string _brand;

        public abstract string Shoot();
        public override string ToString()
        {
            return base.ToString();
        }
        public Weapon(string brand)
        {
            _brand = brand;
        }

    }

    public class LaserGun : Weapon
    {
        public LaserGun(string brand) : base(brand)
        {

        }
        public override string Shoot()
        {
            return $" has shot with their {_brand}, Zap!! ";
        }

    }

    public class WaterPistol : Weapon
    {
        public WaterPistol(string brand) : base(brand)
        {

        }
        public override string Shoot()
        {
            return $" has shot with their {_brand}, Splash!! ";
        }

    }
}
