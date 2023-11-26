using Practical6_Sophie.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical6_Sophie.Models
{
    public class Ungulate : Mammal, IAnimal
    {
        public event Action<string> UngulateEvent;
        public void Hoofbeat()
        {
            UngulateEvent?.Invoke("Парнокопитне тупцює копитами");
        }
    }
}
