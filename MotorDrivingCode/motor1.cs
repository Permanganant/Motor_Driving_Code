using System;
using System.Collections.Generic;
using System.Text;

namespace suruskodu
{
    public class motor1
    {
        public int Vd(string speed_data)
        {
            string direction_speed = null;
            string speed = null;
            int hız = 0;
            direction_speed = speed_data.Substring(0, 1);
            int direction_speed_int = Convert.ToInt32(direction_speed);
            if (direction_speed_int == 0 || direction_speed_int == 1)
            {
                speed = speed_data.Substring(1, 3);
                int speed_int = Convert.ToInt32(speed);
                if (speed_int < 256 && speed_int > 0)
                {
                    hız = speed_int;
                }
                else
                {
                    Console.WriteLine("hız değeri hatalı");
                }

            }
            return hız;

        }
    }
}
