using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTB1
{
    public class Giai
    {
        private double a_08_Hai, b_08_Hai;
        public Giai(double a_08_Hai, double b_08_Hai)
        {
            this.a_08_Hai = a_08_Hai;
            this.b_08_Hai = b_08_Hai;
        }
        public double Solve()
        {
            if (a_08_Hai == 0)
            {
                if (b_08_Hai == 0)
                {
                    throw new ArgumentException("Phương trình có vô số nghiệm.");
                }
                else
                {
                    throw new ArgumentException("Phương trình vô nghiệm.");
                }
            }
            return -b_08_Hai / a_08_Hai;
        }
    }
}
