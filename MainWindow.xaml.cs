using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Math;

namespace Q_BF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static System.Timers.Timer aTimer;


        public MainWindow()
        {
            InitializeComponent();
        }
        
        Player player1 = new Player();
        Canvas canvas = new Canvas();
        Random rnd = new Random();
        public int width = 1280;
        public int height = 720;


        public void Canvas_KeyDown(object sender, KeyEventArgs e)
        {
            System.Timers.Timer timer1 = new System.Timers.Timer();
            
            while (true)
            {
                timer1.Start();

                if (e.Key == Key.W)
                {
                    player1.playerX = player1.pMove();
                    player1.playerZ = player1.pMove();
                }
                if (e.Key == Key.S)
                {
                    player1.playerX = player1.pMove(); 
                    player1.playerZ = player1.pMove(); 
                }
                if (e.Key == Key.D)
                {
                    player1.playerZ = (player1.speed * 0.80f) - 2;
                }
                if (e.Key == Key.A)
                {
                    player1.playerZ = (player1.speed * 0.80f) - 2;
                }
                
                timer1.Stop();
            }

        }

        //public void Proris()
        //{

        //}
       

        public void Canvas_GotFocus(object sender, RoutedEventArgs e)
        {
            int maxx = 40;
            int maxy = 40;
            System.Timers.Timer timer = new System.Timers.Timer();
            while (true)
            {
                timer.Start();
                
            }
        }
    }
}
