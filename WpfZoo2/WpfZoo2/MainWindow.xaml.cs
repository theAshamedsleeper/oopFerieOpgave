using System;
using System.Windows;

namespace WpfZoo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, testforNameOFAnim
    {

        public MainWindow()
        {
            testforNameOFAnim.myAnimals.Add(testforNameOFAnim.lion1);
            testforNameOFAnim.myAnimals.Add(testforNameOFAnim.shark1);
            testforNameOFAnim.myAnimals.Add(testforNameOFAnim.parrot1);

            InitializeComponent();

        }

        private void Fish1_Click(object sender, RoutedEventArgs e)
        {
            FishStuff fishStuff = new FishStuff();
            fishStuff.Show();
        }

        public void Fish1_Initialized(object sender, EventArgs e)
        {
            Fish1.Content = testforNameOFAnim.shark1.NameOf();

        }
        private void Bird1_Click(object sender, RoutedEventArgs e)
        {
            BirdStuff birdStuff = new BirdStuff();
            birdStuff.Show();
        }

        private void Mammal1_Click(object sender, RoutedEventArgs e)
        {
            MammalStuff mammalStuff = new MammalStuff();
            mammalStuff.Show();
        }

        private void Mammal1Initialized(object sender, EventArgs e)
        {
            Mammal1.Content = testforNameOFAnim.lion1.NameOf();

        }

        private void Bird1_Initialized(object sender, EventArgs e)
        {
            Bird1.Content = testforNameOFAnim.parrot1.NameOf();

        }
    }
}
