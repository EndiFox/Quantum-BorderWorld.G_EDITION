namespace Q_BF
{
    public partial class MainWindow
    {
        class Player
        {
            
            public float playerX = 1.0f;
            public float playerZ = 1.0f;
            public float playerA = 0.0f;
            public float fov = 3.14159f / 4.0f;
            public float depth = 20.0f;
            public float speed = 5.0f;
            
            public float pMove()
            {
                float pSpeed = speed;
                float need1 = pSpeed / 2;
                float need2 = pSpeed / 6;
                float DOOM;

                if (pSpeed <= 100)
                {
                    DOOM = (speed * need1 + speed * need2) / speed;
                }
                else
                {
                    DOOM = (speed + (speed + speed / (need1 * need2))) / (speed / need2);
                }

                return DOOM;
                DOOM = 0.0f;
            }
        }

    }
}
