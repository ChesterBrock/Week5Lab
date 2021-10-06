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

namespace Week5Lab
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double yourSpeed = double.Parse(YourSpeedTextBox.Text);
            double speedLimit = double.Parse(SpeedLimitTextBox.Text);
            double fine = 0.00;

            if(yourSpeed <= speedLimit) {
                ResultLabel.Content = "Good Speed!";
                fine = 0.00;
            }
            else if(yourSpeed > speedLimit + 25){
                ResultLabel.Content = "Speeding/Penalty";
                fine = (yourSpeed - speedLimit) * 7 + 60 + 250;
            }
            else if(yourSpeed > speedLimit){
                ResultLabel.Content = "Speeding/No Penalty";
                fine = (yourSpeed - speedLimit) * 7 + 60;
            }
            MessageBox.Show("Your fine is: " + fine);

        }
    }
}
