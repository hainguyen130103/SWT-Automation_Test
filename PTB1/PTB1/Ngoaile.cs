using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTB1
{
    public class Ngoaile_08_Hai
    {
        // Phương thức giải phương trình bậc 2 ax^2 + bx + c = 0
        public static Tuple<double, double> GiaiPhuongTrinhBac2_08_Hai(double a_08_Hai, double b_08_Hai, double c_08_Hai)
        {
            // Kiểm tra bậc 2 hay không
            if (a_08_Hai == 0)
            {
                throw new ArgumentException("Hệ số 'a' không thể bằng 0");
            }

            // Tính delta
            double delta_08_Hai = b_08_Hai * b_08_Hai - 4 * a_08_Hai * c_08_Hai;

            // Kiểm tra giá trị của delta để xác định số nghiệm
            if (delta_08_Hai > 0)
            {
                //phương trình có 2 nghiệm phân biệt
                double x1_08_Hai = (-b_08_Hai + Math.Sqrt(delta_08_Hai)) / (2 * a_08_Hai);
                double x2_08_Hai = (-b_08_Hai - Math.Sqrt(delta_08_Hai)) / (2 * a_08_Hai);
                return Tuple.Create(x1_08_Hai, x2_08_Hai);
            }
            else if (delta_08_Hai == 0)
            {
                //phương trình có nghiệm kép
                double x_08_Hai = -b_08_Hai / (2 * a_08_Hai);
                return Tuple.Create(x_08_Hai, x_08_Hai);
            }
            else
            {
                //phương trình vô nghiệm (trong tập số thực)
                throw new ArgumentException("Phương trình vô nghiệm");
            }
        }
    }

}

