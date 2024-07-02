using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTB1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btngiai_Click(object sender, EventArgs e)
        {

            double a_08_Hai = double.Parse(txta.Text);
            double b_08_Hai = double.Parse(txtb.Text);
            double c_08_Hai = double.Parse(txtc.Text);

            // Tính delta
            double delta_08_Hai = b_08_Hai * b_08_Hai - 4 * a_08_Hai * c_08_Hai;

            // Khởi tạo biến để lưu kết quả
            string result;

            // Kiểm tra điều kiện để giải phương trình
            if (delta_08_Hai > 0)
            {
                double x1_08_Hai = (-b_08_Hai + Math.Sqrt(delta_08_Hai)) / (2 * a_08_Hai);
                double x2_08_Hai = (-b_08_Hai - Math.Sqrt(delta_08_Hai)) / (2 * a_08_Hai);
                result = $"Phương trình có hai nghiệm: x1 = {x1_08_Hai}, x2 = {x2_08_Hai}";
            }
            else if (delta_08_Hai == 0)
            {
                double x_08_Hai = -b_08_Hai / (2 * a_08_Hai);
                result = $"Phương trình có nghiệm kép: x = {x_08_Hai}";
            }
            else
            {
                result = "Phương trình vô nghiệm";
            }

            // Hiển thị kết quả vào ô txtkq
            txtkq.Text = result;
        }
    }
}
