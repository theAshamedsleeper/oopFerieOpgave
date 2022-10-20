using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfZoo2
{
    internal interface testforNameOFAnim
    {
        static List<Animal> myAnimals = new List<Animal>();

        public static Mammal lion1 = new Mammal("Lion", 10, 4, 6, 10, 10, false);
        static Brid parrot1 = new Brid("Parrot", 2, 2, 15, 5, true);
        static Fish shark1 = new Fish("Tiger Shark", 20, 0, 13, 20, false, true);
    }
}
