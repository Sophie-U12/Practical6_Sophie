using Practical6_Sophie.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical6_Sophie.Models
{
    public class Bird : Animal, IAnimal, IBird
    {
        public event Action<string> BirdEvent;

        void IAnimal.Move()
        {
            Fly();
        }

        public void Fly()
        {
            BirdEvent?.Invoke("Птах летить");
        }
    }
}
