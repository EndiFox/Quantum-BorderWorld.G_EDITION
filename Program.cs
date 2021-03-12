using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows;
using System.Timers;


namespace kaskk
{
    static class BQWorld
    {

        public class Item
        {
            float x = 0.0f;
            float y = 0.0f;
            float z = 0.0f;
            int id = 0;
            int k = 0;
            string name = null;
        }
        
        public class Tree
        {
            float x = 0.0f;
            float y = 0.0f;
            float z = 0.0f;
            bool cutted = false;
            int stage = 0;
            int intreetimer = 0;
        }
        public class Axe
        {
            float x = 0.0f;
            float y = 0.0f;
            float z = 0.0f;
            bool aleb = false;
            bool standart = false;
            int usage = 0;
            int damage = 0;
            int manahave = 0;
            int id = 0;
            int level = 0;
        }
        
        public class Player
        {
            float x = 0.0f;
            float y = 0.0f;
            float z = 0.0f;
            float fov = 3.14159f / 3;
            float a = 0.0f;
            float depth = 30.0f;
            float health = 100.0f;
            int armor = 0;
            int hunger = 200;
            float mana = 10;
            int[] inventory = new int[10];
            string[] names = new string[10];
            int[] ids = new int[10];
            //float plaIntersect(in vec3 ro, in vec3 rd, in vec4 p)
            //{
            //    return -(dot(ro, p.xyz) + p.w) / dot(rd, p.xyz);
            //}
        }

        private static System.Timers.Timer aTimer;

        public struct Vector4 : IEquatable<System.Numerics.Vector4>, IFormattable; 


        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QB());
            
            //Functions\Timers\Any stuff
            
            static void dot(float ro, float rd)
            {
                
            }

            //Functions\Timers\Any stuff

            /// Basic ints and arrays
            Random rnd = new Random();
            int w = 1280;
            int h = 720;
            float maxX = 40.0f;
            float maxY = 40.0f;
            float minX = -40.0f;
            float minY = -40.0f;
            float maxZ = 20.0f;
            float minZ = -20.0f;
            float[,,] GlItemPos = new float[20000, 20000, 20000];
            int[,] b = new int[39,39];
            int[,] stones_Mass = new int[40, 40];
            /// Basic ints and arrays

            /// Tree generator 
            for (int i = 0; i != 78; i++ )
            {
                if (i == 78)
                {
                    break;
                }
                
                int rndtrees = rnd.Next(-39, 39);
                b[i, i] = rndtrees;

            }
            /// Tree generator 

            ///Stone generator
            for (int i = 0; i != 80; i++)
            {
                if (i == 80)
                {
                    break;
                }

                int rndstones = rnd.Next(-40, 40);
                stones_Mass[i, i] = rndstones;

            }
            ///Stone generator

            ///Generator examples
            Player player1 = new Player();
            ///Generator examples

            /// Main program         
            while (true) 
            {

            }
        }
    }
}
