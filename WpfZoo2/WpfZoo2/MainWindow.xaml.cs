using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfZoo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,testforNameOFAnim
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
            Fish1.Content =testforNameOFAnim.shark1.NameOf();

        }
    }
}
