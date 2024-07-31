using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    public class TinhTienDien
    {
        public double bac1(double a)
        {
            return a*1678;
        }
        public double bac2(double a)
        {
            a = a - 50;
            double T = (a * 1734) + bac1(50);
            return T;
        }
        public double bac3(double a)
        {
            a = a - 100;
            double T = (a * 2014) + bac2(100);
            return T;
        }
        public double bac4(double a)
        {
            a = a - 200;
            double T = (a * 2536) + bac3(200);
            return T;
        }
        public double bac5(double a)
        {
            a = a - 300;
            double T = (a * 2834) + bac4(300);
            return T;
        }
        public double bac6(double a)
        {
            a = a - 400;
            double T = (a * 2927) + bac5(400);
            return T;
        }

        public double caculator(double a)
        {
            if (a <= 50)
                return bac1(a);
            else if (a <= 100)
                return bac2(a);
            else if (a <= 200)
                return bac3(a);
            else if (a <= 300)
                return bac4(a);
            else if (a <= 400)
                return bac5(a);
            else
                return bac6(a);
        }
    }
}
