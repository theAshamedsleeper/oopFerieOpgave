using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfZoo2
{
    internal class Brid : Animal
    {
        private string myMood;
        public Brid(string name, int health, int legs, int age, int foodBar, bool canFly, string myMood) : base(name, health, legs, age, foodBar, canFly)
        {
            this.myMood = myMood;
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
        public int FoodBarlength()
        {
            return foodBar;
        }
        public string MyOverallMood()
        {
            if (foodBar >= 5)
            {
                myMood = mood.happy.ToString();
                return myMood;
            }
            else if (foodBar >= 2 && foodBar <= 3)
            {
                myMood = mood.okay.ToString();
                return myMood;
            }
            else if (foodBar >= 1 && foodBar <= 2)
            {
                myMood = mood.sad.ToString();
                return myMood;
            }
            return myMood;
        }
        public void DecreaseValues()
        {
            foodBar--;
        }
    }
}
