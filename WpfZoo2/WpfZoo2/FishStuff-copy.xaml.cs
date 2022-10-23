using System;
using System.Windows;

namespace WpfZoo2
{
    /// <summary>
    /// Interaction logic for FishStuff.xaml
    /// </summary>
    public partial class FishStuff : Window,testforNameOFAnim
    {
       

        public FishStuff()
        {
            InitializeComponent();
        }

        private void FishName1openWindow_Initialized(object sender, EventArgs e)
        {
            FishName1openWindow.Text = testforNameOFAnim.shark1.NameOf();
        }

        private void ageValue_Initialized(object sender, EventArgs e)
        {
            // how old tha animal is.
            ageValue.Text = testforNameOFAnim.shark1.AgeOf().ToString();
        }

        private void healthValue_Initialized(object sender, EventArgs e)
        {
            // how healthy is the animal
            healthValue.Text = testforNameOFAnim.shark1.HealthOf().ToString();
        }

        private void legsValue_Initialized(object sender, EventArgs e)
        {
            //how many legs
            legsValue.Text = testforNameOFAnim.shark1.LegsOf().ToString();
        }

        private void foodValue_Initialized(object sender, EventArgs e)
        {
            //Displayes the hunger
            foodValue.Text = testforNameOFAnim.shark1.FoodBarlength().ToString() + " | 20";
            testforNameOFAnim.shark1.DecreaseValues();
        }

        private void MoodValue_Initialized(object sender, EventArgs e)
        {
            MoodValue.Text = testforNameOFAnim.shark1.MyOverallMood().ToString();
        }

        private void FoodDecrease_Click(object sender, RoutedEventArgs e)
        {
            foodValue_Initialized(sender, e);
            MoodValue_Initialized(sender, e);
        }
    }
}
