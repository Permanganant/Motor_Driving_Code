using System;

namespace suruskodu
{
    class Program
    {
        static void Main()
        {
            int pinb = 5; //
            double tolerance = 0.00001; //This variable indicates the tolerance value for pid //

            serial1 motor1 = new serial1();//this part creates object for motors
            serial1 motor2 = new serial1();
            serial1 motor3 = new serial1();
            serial1 motor4 = new serial1();
            serial1 motor5 = new serial1();
            serial1 motor6 = new serial1();
            serial1 motor7 = new serial1();
            serial1 motor8 = new serial1();
            serial1 motor9 = new serial1();
            serial1 motor10 = new serial1();
            serial1 motor11 = new serial1();
            serial1 motor12 = new serial1();
            serial1 motor13 = new serial1();
            motor1 message1 = new motor1();//this part creates message object for motors
            motor1 message2 = new motor1();
            motor1 message3 = new motor1();
            motor1 message4 = new motor1();
            motor1 message5 = new motor1();
            motor1 message6 = new motor1();
            motor1 message7 = new motor1(); 
            motor1 message8 = new motor1();
            motor1 message9 = new motor1();
            motor1 message10 = new motor1();
            motor1 message11 = new motor1();
            motor1 message12 = new motor1();
            motor1 message13 = new motor1();
            encoder1 encoderspeed1 = new encoder1();//this part creates speed data for encoder
            encoder1 encoderspeed2 = new encoder1();           
            encoder1 encoderspeed3 = new encoder1();
            encoder1 encoderspeed4 = new encoder1();
            encoder1 encoderspeed5 = new encoder1();
            encoder1 encoderspeed6 = new encoder1();
            encoder1 encoderspeed7 = new encoder1();
            encoder1 encoderspeed8 = new encoder1();
            encoder1 encoderspeed9 = new encoder1();
            encoder1 encoderspeed10 = new encoder1();
            encoder1 encoderspeed11 = new encoder1();
            encoder1 encoderspeed12 = new encoder1();
            encoder1 encoderspeed13 = new encoder1();
            pid1 pidspeed1 = new pid1();//this part creates object for pid
            pid1 pidspeed2 = new pid1();
            pid1 pidspeed3 = new pid1();
            pid1 pidspeed4 = new pid1();
            pid1 pidspeed5 = new pid1();
            pid1 pidspeed6 = new pid1();
            pid1 pidspeed7 = new pid1();
            pid1 pidspeed8 = new pid1();
            pid1 pidspeed9 = new pid1();
            pid1 pidspeed10 = new pid1();
            pid1 pidspeed11 = new pid1();
            pid1 pidspeed12 = new pid1();
            pid1 pidspeed13 = new pid1();
            string m1 = motor1.Serial("1004S1234124401240100011112000123020011121222011112050231F214345", 1);
            string m2 = motor2.Serial("1004S1234124401240100011112000123020011121222011112050231F214345", 2);
            string m3 = motor3.Serial("1004S1234124401240100011112000123020011121222011112050231F214345", 3);
            string m4 = motor4.Serial("1004S1234124401240100011112000123020011121222011112050231F214345", 4);
            string m5 = motor5.Serial("1004S1234124401240100011112000123020011121222011112050231F214345", 5);
            string m6 = motor6.Serial("1004S1234124401240100011112000123020011121222011112050231F214345", 6);
            string m7 = motor7.Serial("1004S1234124401240100011112000123020011121222011112050231F214345", 7);
            string m8 = motor8.Serial("1004S1234124401240100011112000123020011121222011112050231F214345", 8);
            string m9 = motor9.Serial("1004S1234124401240100011112000123020011121222011112050231F214345", 9);
            string m10 = motor10.Serial("1004S1234124401240100011112000123020011121222011112050231F214345", 10);
            string m11 = motor11.Serial("1004S1234124401240100011112000123020011121222011112050231F214345", 11);
            string m12 = motor12.Serial("1004S1234124401240100011112000123020011121222011112050231F214345", 12);
            string m13 = motor13.Serial("1004S1234124401240100011112000123020011121222011112050231F214345", 13);

            double pid1 = pidspeed1.computePID(tolerance,1,2,3, encoderspeed1.doEncoder(message1.Vd(m1), pinb, 0));
            double pid2 = pidspeed2.computePID(tolerance, 1, 2, 3, encoderspeed2.doEncoder(message2.Vd(m1), pinb, 0));
            double pid3 = pidspeed3.computePID(tolerance, 1, 2, 3, encoderspeed3.doEncoder(message3.Vd(m1), pinb, 0));
            double pid4 = pidspeed4.computePID(tolerance, 1, 2, 3, encoderspeed4.doEncoder(message4.Vd(m1), pinb, 0));
            double pid5 = pidspeed5.computePID(tolerance, 1, 2, 3, encoderspeed5.doEncoder(message5.Vd(m1), pinb, 0));
            double pid6 = pidspeed6.computePID(tolerance, 1, 2, 3, encoderspeed6.doEncoder(message6.Vd(m1), pinb, 0));
            double pid7 = pidspeed7.computePID(tolerance, 1, 2, 3, encoderspeed7.doEncoder(message7.Vd(m1), pinb, 0));
            double pid8 = pidspeed8.computePID(tolerance, 1, 2, 3, encoderspeed8.doEncoder(message8.Vd(m1), pinb, 0));
            double pid9 = pidspeed9.computePID(tolerance, 1, 2, 3, encoderspeed9.doEncoder(message9.Vd(m1), pinb, 0));
            double pid10 = pidspeed10.computePID(tolerance, 1, 2, 3, encoderspeed10.doEncoder(message10.Vd(m1), pinb, 0));
            double pid11 = pidspeed11.computePID(tolerance, 1, 2, 3, encoderspeed11.doEncoder(message11.Vd(m1), pinb, 0));
            double pid12 = pidspeed12.computePID(tolerance, 1, 2, 3, encoderspeed12.doEncoder(message12.Vd(m1), pinb, 0));
            double pid13 = pidspeed13.computePID(tolerance, 1, 2, 3, encoderspeed13.doEncoder(message13.Vd(m1), pinb, 0));

            Console.WriteLine("pid speeds:");
            Console.WriteLine(pid1);
            Console.WriteLine(pid2);
            Console.WriteLine(pid3);
            Console.WriteLine(pid4);
            Console.WriteLine(pid5);
            Console.WriteLine(pid6);
            Console.WriteLine(pid7);
            Console.WriteLine(pid8);
            Console.WriteLine(pid9);
            Console.WriteLine(pid10);
            Console.WriteLine(pid11);
            Console.WriteLine(pid12);
            Console.WriteLine(pid13);
       
            Console.ReadKey();
           
        }
    }
}



