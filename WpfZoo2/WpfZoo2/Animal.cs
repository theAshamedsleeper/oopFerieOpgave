using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfZoo2
{
    enum mood {sad=1, okay=2, happy=3 };
    public abstract class Animal
    {
        protected string name;
        protected int health;
        protected int legs;
        protected int age;
        protected int foodBar;
        protected bool canFly;

        public Animal(string name, int health, int legs, int age, int foodBar, bool canFly)
        {
            this.name = name;
            this.health = health;
            this.legs = legs;
            this.age = age;
            this.foodBar = foodBar;
            this.canFly = canFly;
        }
        public virtual void Eat()
        {
            Console.WriteLine("..Gulp..");
        }
        public abstract void Sleep();
    }
}
