using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfZoo2
{
    public  class Fish : Animal
    {
        private bool canSwim;
        private string myMood;
        public Fish(string name, int health, int legs, int age, int foodBar, bool canFly,bool canSwim, string myMood) : base(name, health, legs, age, foodBar, canFly)
        {
            this.canSwim = canSwim;
            this.myMood = myMood;
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
        public int FoodBarlength()
        {
            return foodBar;
        }
        public string MyOverallMood()
        {
            if (foodBar >= 15)
            {
                myMood = mood.happy.ToString();
                return myMood;
            }
            else if (foodBar >= 10 && foodBar <=15)
            {
                myMood = mood.okay.ToString();
                return myMood;
            }
            else if (foodBar >= 1 && foodBar <= 10)
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
