using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2001216219_TranVanTinh_Buoi3
{
    public class Test
    {
        public static string ktraTamGiac(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    return "Tam giac deu";
                else if (a == b || b == c || c == a)
                    return "Tam giac can";
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                    return "Tam giac vuong";
                else
                    return "Tam giac thuong";
            }
            else
                return "Khong phai tam giac";
        }

    }
}
