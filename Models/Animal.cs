using Practical6_Sophie.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical6_Sophie.Models
{
    public class Animal : IAnimal
    {
        public event Action<string> AnimalEvent;

        public void Move()
        {
            AnimalEvent?.Invoke("Тварина рухається");
        }
    }
}
