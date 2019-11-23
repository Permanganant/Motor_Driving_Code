using System;
using System.Collections.Generic;
using System.Text;

namespace suruskodu
{
    public class encoder1
    {
        public DateTime oldTime = DateTime.Now;//this line measures the beginning time 
        public DateTime newTime = new DateTime();
        public double time_range;
        public double doEncoder(int pinA, int pinB, int state)//this function takes speed from motor function, target speed and ??? state ne ki 
        {

            int pulse_counter = 0;
            float wheel_r = 5;
            if (pinA != state)//this line activated if state and motor speed are not equal
            {
                newTime = DateTime.Now;//measures the time while speeds are different
                if (pinB != pinA)//this line activated if target speed and motor speeds are different from each other
                {
                    pulse_counter++;//counts every different state
                    Console.WriteLine("+ direction");
                }
            }
            else
            {
                pulse_counter--;
                Console.WriteLine("- direction");
            }
            time_range = (newTime - oldTime).TotalMilliseconds;//calculates the passing time of pulses 
            double motor_speed = (2 * 3.14 * wheel_r) / (time_range);//calculates speed by dividing perimeter of wheel to time
            Console.WriteLine("encoder motor speed");
            Console.WriteLine(motor_speed);
            return motor_speed;//returns the value of calculated encoder speed
        }
    }
}
