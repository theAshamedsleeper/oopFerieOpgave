using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfZoo2
{
    internal class Fish : Animal
    {
        private bool canSwim;
        public Fish(string name, int health, int legs, int age, int foodBar, bool canFly,bool canSwim) : base(name, health, legs, age, foodBar, canFly)
        {
            this.canSwim = canSwim;
        }
        public override void Eat()
        {
            base.Eat();
        }
        public override void Sleep()
        {
            Console.WriteLine("Bubble bubble");
        }
        public string NameOf()
        {
            return name;
        }
        public int HealthOf()
        {
            return health;
        }
        public int AgeOf()
        {
            return age;
        }
        public int LegsOf()
        {
            return legs;
        }

    }
}
