using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLab
{
    public class Airplane : Vehicle, IMoveable
    {
        private string _airline = "";

        public int Altitude { get; private set;}

        public Airplane (int capacity) : base(capacity)
        {

        }

        public Airplane (int capacity, int speed, string airline) : base(capacity, speed)
        {
            _airline = airline; 

        }
        public override string Move()
        {
            return $"{base.Move()}, at and altitude of {Altitude}";
        }
        public override string Move(int times)
        {
            return $"{base.Move(times)}, at and altitude of {Altitude}";
        }

        public void Ascend (int height)
        {
            if(height <= 0)
            {
                throw new ArgumentOutOfRangeException("Input must be more than 0");
            }
            Altitude += height;
        }

        public void Descend(int height)
        {
            if (height <= 0)
            {
                throw new ArgumentOutOfRangeException("Input must be more than 0");
            }else if (height > Altitude)
            {
                throw new ArgumentOutOfRangeException("This would cause a crash");
            }
            Altitude -= height;
        }

        public override string ToString()
        {
            return $"Thank you for flying with {_airline}, {base.ToString()} altitude: {Altitude}."; 
        }
    }
}
