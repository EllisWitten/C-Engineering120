using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrivingLab
{
    public interface IMoveable
    {
        string Move();
        string Move(int times);
    }
}
