using System;
using System.Collections.Generic;
using System.Text;

namespace suruskodu
{
    public class pid1
    {
        public double kp, kd, ki;//p, i and d constants for motors
        public double error, target, current_error;
        public double tolerance, output;
        public double oldError;
        public double computePID(double tolerance, double kp, double kd, double ki, double target)//function takes tolerance that means negligible for calculation, constants and targeted speed value
        {
           error = target - current_error;//calculates difference between target speed and current error

                if (tolerance < error && (-1) * tolerance < error)//pid calculation is performed if the error is greater than the tolerance
                {
                    output = kp * error + kd * (error - oldError) + ki * (error + oldError);//pid calculation
                    //oldError = error;// 
                    return output;//returns calculated error
                }
                                
            else
            {
                return target;//not necessary to calculate pid if the error is smaller than tolerance
            }
        }
    }
}
