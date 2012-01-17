using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Threading;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        DispatcherTimer stopwatch = new DispatcherTimer();
        double counter = 0.0;

        // コンストラクター
        public MainPage()
        {
            InitializeComponent();

            stopwatch.Interval = TimeSpan.FromMilliseconds( 10 );
            stopwatch.Tick += new EventHandler( stopwatch_Tick );
        }

        private void button1_Click( object sender, RoutedEventArgs e )
        {
            if ( stopwatch.IsEnabled ) {
                stopwatch.Stop();
                counter = 0;
                button1.Content = "Start";
            }
            else {
                stopwatch.Start();
                button1.Content = "Stop";
            }
        }

        void stopwatch_Tick( object sender, EventArgs e )
        {
            counter += 0.1;
            textBlock1.Text = counter.ToString( "N2" );
        }
    }
}