using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfZoo2
{
    public class Mammal : Animal
    {
        private int strenght;
        public Mammal(string name, int health, int legs, int age, int strenght, int foodBar, bool canFly) : base(name, health, legs, age, foodBar, canFly)
        {
            this.strenght = strenght;
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
