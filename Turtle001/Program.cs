/* using System;
using Microsoft.SmallBasic.Library;

namespace Test{
    class Program
    {
        static void Main()
        {
            Turtle.Speed=7;
          for(int i=0;i<4;i++)  
          {
          Turtle.Move(100);
          Turtle.TurnLeft();
          Turtle.Move(80);
          Turtle.TurnLeft();
          Turtle.Move(60);
          Turtle.TurnLeft();
          Turtle.Move(40);
          Turtle.TurnLeft();
          Turtle.Turn(90);
          }
        }
    }
}

 */

/* using System;
using Microsoft.SmallBasic.Library;

namespace TurtleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 7;
            int N = 6;
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    Turtle.Move(30);
                    Turtle.Turn(360 / N);
                }
                Turtle.Turn(60);
            }


        }
    }
}  */

/* using System;
using Microsoft.SmallBasic.Library;

namespace Test
{
    class Program
    {
        static void Square(int len = 50, double k = 1)
        {
            for (int i = 0; i < 4; i++)
            {
                Turtle.Move(len * k);
                Turtle.TurnLeft();
            }
        }
        static void Main()
        {
            Turtle.Speed = 7;
            for (int i = 0; i < 4; i++)
            {
                Square(50, i);
                Turtle.PenUp();
                Turtle.Turn(145);
                Turtle.Move(45 * i);
                Turtle.PenDown();
                Turtle.Turn(-90);
            }
        }
    }
}
 */

// Рекурсионный узор

using System;
using Microsoft.SmallBasic.Library;

namespace TurtleTest2
{
    class Program
    {
        static void РекурсивныйУзор(int x, int y, int r)
        {
            GraphicsWindow.DrawEllipse(x - r / 2, y - r / 2, r, r);
            if (r > 50)
            {
                РекурсивныйУзор(x - r / 2, y, r / 2);
                РекурсивныйУзор(x + r / 2, y, r / 2);
                РекурсивныйУзор(x, y + r / 2, r / 2);
                РекурсивныйУзор(x, y - r / 2, r / 2);
            }

        }

        static void Main(string[] args)
        {
            GraphicsWindow.Width = 1000;
            GraphicsWindow.Height = 1000;
            РекурсивныйУзор(500, 500, 200);
        }
    }
}
