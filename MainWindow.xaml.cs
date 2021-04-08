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
        
        public class Player
        {
            float playerX = 1.0f;
            float playerY = 1.0f;
            float playerA = 0.0f;
            float fov = 3.14159f / 4.0f;
            float depth = 20.0f;
            float speed = 5.0f;
        }
        public void Proris()
        {
            int width = 1280;        
            int height = 720;         
            int maxx = 40;             
            int maxy = 40;

            while (true)
            {

            }
        }
    }
}
