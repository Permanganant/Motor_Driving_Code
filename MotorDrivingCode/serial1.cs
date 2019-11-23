using System;
using System.Collections.Generic;
using System.Text;

namespace suruskodu
{
    public class serial1
    {
        public string Serial(string message1, int motornumber)//This function takes data from 13 motors and takes the motor number that will using 
        {
            int datastart=0;
            string motorbits = null;
            int flag1 = 0; 
            int flag2 = 0;
            string data = message1;
            char[] chardata = data.ToCharArray();
            int len = chardata.Length;//This function takes the lenght of char array


            for (int x = 0; x < len; x++)//keeps the array in choosen boundaries while the looping 
            {
                if (data[x] == 'S' && data[x + 53] == 'F')//this part checks S for the beggining and F for the end 
                {
                    
                    flag2++;//this line counts if data has 52 bit from S to F
                    datastart = x;//this line indicates where the S is in data
                }


            }
            for (int i = datastart + 1; i < datastart + 53; i++)//this part checks the data from S to F
            {
                
                if (char.IsNumber(data[i]))//this part checks if the data is number or not
                {
                    flag1++;//this line counts if data consists of numbers
                }   
            }
            if (flag1 == 52 && flag2 == 1)//this part checks the data with flags using data length and digit        
            {
                motorbits = data.Substring((4 * (motornumber - 1) + datastart + 1), 4);//this part split the choosen motor data into speed and direction bits 
                Console.WriteLine(motorbits);
            }
            return motorbits;//return the values of speed and direction as string for choosen motor

        }
        //01111001 01101111 01110101 00100000 01100011 01100001 01101110 00100000 01101101 01111001 00100000 01101100 01101001 01100110 01100101 00100000 01110111 01101111 01110010 01110100 01101000 00100000 01110111 01101000 01101001 01101100 01100101 00100000 01001001 00100000 01100011 01100001 01101110 00100000 01101101 01100001 01101011 01100101 00100000 01111001 01101111 01110101 00100000 01110011 01110100 01100001 01110010 01110100 00100000 01110100 01101111 00100000 01110011 01101101 01101001 01101100 01100101
    }
}
