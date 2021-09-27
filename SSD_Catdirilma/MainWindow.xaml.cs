using Microsoft.Maps.MapControl.WPF;
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

namespace SSD_Catdirilma
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var key = "0b0eJMyavCSNs5ZNIjAN~Hdg2wArZIRV_xrvQ2wocJA~AuB0ZpVQ-BwgPSmEKkZHUzSOGFIMFSdwpNoKJFk6-yzXcwX41Hww89Id1iFE_A90";
            var provider = new ApplicationIdCredentialsProvider(key);

            userMap.CredentialsProvider = provider;
            userMap.Center = new Location(40.37908374120511, 49.847537925130474);
            userMap.ZoomLevel = 13.6;

            Pushpin pushpin1 = new Pushpin();
            Pushpin pushpin2 = new Pushpin();

            pushpin1.Location = new Location(40.37908374120511, 49.847537925130474);
            pushpin2.Location = new Location(40.47908374120511, 49.947537925130474);

            userMap.Children.Add(pushpin1);
            userMap.Children.Add(pushpin2);

        }
    }
}
