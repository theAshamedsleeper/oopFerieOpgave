using System;
using System.Windows;

namespace WpfZoo2
{
    /// <summary>
    /// Interaction logic for FishStuff.xaml
    /// </summary>
    public partial class MammalStuff : Window,testforNameOFAnim
    {
       

        public MammalStuff()
        {
            InitializeComponent();
        }
    
        private void ageValue_Initialized(object sender, EventArgs e)
        {
            // how old tha animal is.
            ageValue.Text = testforNameOFAnim.lion1.AgeOf().ToString();
        }

        private void healthValue_Initialized(object sender, EventArgs e)
        {
            // how healthy is the animal
            healthValue.Text = testforNameOFAnim.lion1.HealthOf().ToString();
        }

        private void legsValue_Initialized(object sender, EventArgs e)
        {
            //how many legs
            legsValue.Text = testforNameOFAnim.lion1.LegsOf().ToString();
        }

        private void foodValue_Initialized(object sender, EventArgs e)
        {
            //Displayes the hunger
            foodValue.Text = testforNameOFAnim.lion1.FoodBarlength().ToString() + " | 10";
            testforNameOFAnim.lion1.DecreaseValues();
        }

        private void MoodValue_Initialized(object sender, EventArgs e)
        {
            MoodValue.Text = testforNameOFAnim.lion1.MyOverallMood().ToString();
        }

        private void FoodDecrease_Click(object sender, RoutedEventArgs e)
        {
            foodValue_Initialized(sender, e);
            MoodValue_Initialized(sender, e);
        }
        private void MammalName1openWindow_Initialized(object sender, EventArgs e)
        {
            MammalName1openWindow.Text = testforNameOFAnim.lion1.NameOf();
        }
    }
}
