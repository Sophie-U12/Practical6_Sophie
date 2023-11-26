using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical6_Sophie.Models
{
    public class Mammal : Animal
    {
        public event Action<string> MammalEvent;

        public void Feed()
        {
            MammalEvent?.Invoke("Ссавець харчується");
        }
    }
}
