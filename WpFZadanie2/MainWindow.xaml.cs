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

namespace WpFZadanie2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void Click_Top_Button(object sender, RoutedEventArgs e)
        {
            foreach (Button item in UpperPanel.Children.OfType<Button>())
            {
                item.BorderBrush = Brushes.Yellow;
                item.Foreground = Brushes.Red;
                SpecialUpperButton.BorderBrush = item.BorderBrush;
                SpecialUpperButton.Foreground = item.Foreground;
            }
        }

        private void Cick_Left_Button(object sender, RoutedEventArgs e)
        {
            foreach (Button item in LeftPanel.Children.OfType<Button>())
            {
                item.BorderBrush = Brushes.Brown;
                item.Foreground = Brushes.Green;
                SpecialLeftButton.BorderBrush = item.BorderBrush;
                SpecialLeftButton.Foreground = item.Foreground;
            }
        }
 
        private void Click_Bottom_Button(object sender, RoutedEventArgs e)
        {
            foreach (Button item in BottomPanel.Children.OfType<Button>())
            {
                item.BorderBrush = Brushes.Orange;
                item.Foreground = Brushes.Blue;
              SpecialBottomButton.BorderBrush = item.BorderBrush;
              SpecialBottomButton.Foreground = item.Foreground;
            }
        }
        
    }
}
