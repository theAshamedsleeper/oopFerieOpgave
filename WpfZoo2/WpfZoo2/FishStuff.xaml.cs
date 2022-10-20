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

            ageValue.Text = testforNameOFAnim.shark1.AgeOf().ToString();
        }
    }
}
