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
        
        public class Player
        {
            public float x = 0.0f;
            public float y = 0.0f;
            public float z = 0.0f;
            public float fov = 3.14159f / 3;
            public float a = 0.0f;
            public float depth = 30.0f;
            public float health = 100.0f;
            public int armor = 0;
            public int hunger = 200;
            public float mana = 10;
            public int[] inventory = new int[10];
            public string[] names = new string[10];
            public int[] ids = new int[10];
        }

        [STAThread]
        static void Main()
        {
            //Functions\Timers\Any stuff

            static float cos(float a, float gip)
            {
                float sum = a / gip;
                return sum;
            }

            static float sin(float b, float gip)
            {
                float sum = b / gip;
                return sum;
            }

            static float tg(float anti, float pril)
            {
                float sum = anti / pril;
                return sum;
            }

            static float ctg(float pril, float anti)
            {
                float sum = pril / anti;
                return sum;
            }

            static float tg1(float a, float b, float gip)
            {
                float a1 = a;
                float a2 = sin(a1, gip);
                float b1 = b;
                float b2 = cos(b1, gip);
                float sum = a2 / b2;
                return sum;
            }

            static float ctg1(float a, float b, float gip)
            {
                float a1 = a;
                float a2 = cos(a1, gip);
                float b1 = b;
                float b2 = sin(b1, gip);
                float sum = a2 / b2;
                return sum;
            }

            static float dot(float first, float second)
            {
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

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QB());

            while (true) 
            {
                //plaIntersect(4.0f, 2.1f, 4.1f);

                for (int i = 0; i < w; i++) 
                {
                    float fRayAngle = (player1.a - (player1.fov / 2.0f)) + (Convert.ToInt16(player1.x) / Convert.ToInt16(w)) * player1.fov;
                    
                    //QB.Equals.fRayAngle;
                }
            }
        }
    }
}
