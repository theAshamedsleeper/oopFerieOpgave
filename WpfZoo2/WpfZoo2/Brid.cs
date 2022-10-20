using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfZoo2
{
    internal class Brid : Animal
    {
        public Brid(string name, int health, int legs, int age, int foodBar, bool canFly) : base(name, health, legs, age, foodBar, canFly)
        {

        }
        public void Fly()
        {
            Console.WriteLine("soaring through the sky");
        }
        public override void Eat()
        {
            base.Eat();
        }
        public override void Sleep()
        {
            Console.WriteLine("ZZZZZZZZZZZZZZZZZ");
        }
        public string NameOf()
        {
            return name;
        }
    }
}
