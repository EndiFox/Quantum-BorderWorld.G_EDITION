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
            
            private float dot(float first, float second)
            {
                static float cos(float a, float gip)
                {
                    float sum = a / gip;
                    return sum;
                }

                if ((first > 0) & (second > 0))
                {
                    float c = first * second * cos(first, second);
                    return c;
                }

                else
                {
                    return 0.0f;
                }
            }

            private float TreeCr(float ro, float rd, float x, float y)
            {
                return -(dot(ro, (x * y)) + rd) / dot(rd, (x * y));
            }
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
        }

        private static System.Timers.Timer aTimer;
        

        public struct Vector4 : IEquatable<System.Numerics.Vector4>, IFormattable
        {
            public bool Equals(System.Numerics.Vector4 other)
            {
                throw new NotImplementedException();
            }

            public string ToString(string format, IFormatProvider formatProvider)
            {
                throw new NotImplementedException();
            }
        }

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QB());
            
            //Functions\Timers\Any stuff
            
            static float dot(float first, float second)
            {
                
                static float cos(float a, float gip)
                {
                    float sum = a / gip;
                    return sum;
                }

                if ((first > 0) & (second > 0))
                {
                    float c = first * second * cos(first, second);
                    return c;
                }

                else
                {
                    return 0.0f;
                }
            }

            static float dotxy(float xa, float ya, float xb, float yb)
            {
                if ((xa > 0) ^ (ya > 0) ^ (xb > 0) ^ (yb > 0))
                {
                    float result = (xa * xb) + (ya * yb);
                    return result;
                }

                else 
                {
                    return 0.0f;
                }
            }
            
            static float plaIntersect(float ro, float rd, float p)
            {
                return -(dot(ro, 20.0f) + 20) / dot(rd, 20);
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
            float[,,] GlItemPos = new float[200, 200, 200];
            int[,] b = new int[39,39];
            int[,] stones_Mass = new int[40, 40];
            /// Basic ints and arrays

            /// Tree generator 
            //for (int i = 0; i != 78; i++)
            //{
            //    if (i == 78)
            //    {
            //        break;
            //    }
            //    
            //    int rndtrees = rnd.Next(-39, 39);
            //    b[i, i] = rndtrees;
            //
            //}
            /// Tree generator 

            ///Stone generator
            //for (int i = 0; i != 80; i++)
            //{
            //    if (i == 80)
            //    {
            //        break;
            //    }
            //
            //    int rndstones = rnd.Next(-40, 40);
            //    stones_Mass[i, i] = rndstones;
            //
            //}
            ///Stone generator

            ///Generator examples
            Player player1 = new Player();
            Tree tree1 = new Tree();
            ///Generator examples

            /// Main program         
            while (true) 
            {
                //plaIntersect(4.0f, 2.1f, 4.1f);

                for (int i = 0; i < w; i++) 
                {
                    //float fRayAngle = (player1.a - player1.fov / 2.0f) + (Convert.ToInt16(player1.x) / Convert.ToInt16(w)) * player1.fov;
                }
            }
        }
    }
}
