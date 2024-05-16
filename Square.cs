using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_interfeis
{
    //квадрат реализация периметра и площади
    public class  Square : Figure
    {
        public double A { get; set; }
        public override double S()
        {
            return A * A;
        }
        public override double P()
        {
            return A * 4;
        }
    }
    public interface INUgol 
    {
        public double Height { get; set; }
        public double Base { get; set; }
        public double Corner { get; set; }
        public int Count { get; set; }
        public List<double>Length { get; set; } //делаем список
        public double S();
        public double P();
    }
}
