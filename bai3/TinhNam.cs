using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    public class AmLich
    {
       
        public static string GetCanChi(int year)
        {
            if (year < 0) return "Không hợp lệ";
            String[] Can = new String[10] { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            String[] Chi = new String[12] { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tị", "Ngọ", "Mùi" };
            return Can[year % 10] + " " + Chi[year % 12];
        }
    }
}
