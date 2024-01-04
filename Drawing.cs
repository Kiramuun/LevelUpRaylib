using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace LevelUpRaylib
{
    internal class Drawing
    {
        Random posCircle = new Random();
        int xA, yA, r1, xB, yB, r2;

        public void Init()
        {
            xA = posCircle.Next(50, 950);
            yA = posCircle.Next(50, 950);
            r1 = posCircle.Next(5, 150);
            xB = posCircle.Next(50, 950);
            yB = posCircle.Next(50, 950);
            r2 = posCircle.Next(5, 150);
            
            
        }
        public void Render()
        {
            if(r1 > r2) { DrawCircle(xA, yA, r1, Color.RED); DrawCircle(xB, yB, r2, Color.VIOLET); }
            else { DrawCircle(xB, yB, r2, Color.VIOLET); DrawCircle(xA, yA, r1, Color.RED); }

            float distance(int xA, int yA, int xB, int yB)
            {
                float centreDist = MathF.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));


                return centreDist;
            }
            float f = distance(xA, yA, xB, yB);

            if (f <= (r1 + r2))
            {
                DrawText("Collisioooonnnn Captaiiinnnn !!!", 400, 50, 20, Color.BLACK);
            }
            else { DrawText($"Distance = {MathF.Round(f,0)}", 400, 50, 20, Color.BLACK); }
        }

        public void Text()
        {
            Init();
        }
    }
}
