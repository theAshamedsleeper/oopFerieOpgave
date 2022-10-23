using System;
using System.Windows;

namespace WpfZoo2
{
    /// <summary>
    /// Interaction logic for FishStuff.xaml
    /// </summary>
    public partial class BirdStuff : Window,testforNameOFAnim
    {
       

        public BirdStuff()
        {
            InitializeComponent();
        }
        private void BirdName1openWindow_Initialized(object sender, EventArgs e)
        {
            BirdName1openWindow.Text = testforNameOFAnim.parrot1.NameOf();
        }
        private void ageValue_Initialized(object sender, EventArgs e)
        {
            // how old tha animal is.
            ageValue.Text = testforNameOFAnim.parrot1.AgeOf().ToString();
        }

        private void healthValue_Initialized(object sender, EventArgs e)
        {
            // how healthy is the animal
            healthValue.Text = testforNameOFAnim.parrot1.HealthOf().ToString();
        }

        private void legsValue_Initialized(object sender, EventArgs e)
        {
            //how many legs
            legsValue.Text = testforNameOFAnim.parrot1.LegsOf().ToString();
        }

        private void foodValue_Initialized(object sender, EventArgs e)
        {
            //Displayes the hunger
            foodValue.Text = testforNameOFAnim.parrot1.FoodBarlength().ToString() + " | 5";
            testforNameOFAnim.parrot1.DecreaseValues();
        }

        private void MoodValue_Initialized(object sender, EventArgs e)
        {
            MoodValue.Text = testforNameOFAnim.parrot1.MyOverallMood().ToString();
        }

        private void FoodDecrease_Click(object sender, RoutedEventArgs e)
        {
            foodValue_Initialized(sender, e);
            MoodValue_Initialized(sender, e);
        }

        
    }
}
