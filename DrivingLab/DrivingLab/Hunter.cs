using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLab
{
    public class Hunter : Person, IShootable
    {
        public IShootable Shooter{ get; set; }

        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        public Hunter() { }
        public string Shoot()
        {
            var firstName = _firstName;
            return $"{FullName}{Shooter.Shoot()}";
        }
    
        public override string ToString()
        {
            return $"{base.ToString()} Camera: {Shooter.Shoot()}";
        }
    }

    public class MonsterHunter : Hunter
    {
        private string? _weapon;

        public MonsterHunter(string fName, string lName, IShootable shooter, string weapon) : base(fName, lName, shooter)
        {
            _weapon = weapon;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Weapon: {_weapon}";
        }
    }
}

