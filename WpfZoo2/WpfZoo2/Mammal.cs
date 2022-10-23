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
        private string myMood;

        public Mammal(string name, int health, int legs, int age, int strenght, int foodBar, bool canFly, string myMood ) : base(name, health, legs, age, foodBar, canFly)
        {
            this.strenght = strenght;
            this.myMood = myMood;
        }
        public int HealthOf()
        {
            return health;
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
            if (foodBar >= 10)
            {
                myMood = mood.happy.ToString();
                return myMood;
            }
            else if (foodBar >= 4 && foodBar <= 6)
            {
                myMood = mood.okay.ToString();
                return myMood;
            }
            else if (foodBar >= 1 && foodBar <= 4)
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

