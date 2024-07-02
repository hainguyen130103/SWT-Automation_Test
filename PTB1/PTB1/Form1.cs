using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace PTB1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btngiai_Click(object sender, EventArgs e)
        {
            // Lấy giá trị của a từ Textbox txta và chuyển đổi thành số
            double a_08_Hai;
            a_08_Hai = double.Parse(txta.Text);
            // Lấy giá trị của b từ Textbox txta và chuyển đổi thành số
            double b_08_Hai;
            b_08_Hai = double.Parse(txtb.Text);
            // kiểm tra nếu a=0
            if (a_08_Hai == 0)
            {
                if (b_08_Hai == 0)
                {
                    txtkq.Text = "Phương trình vô số nghiệm";
                }
                else
                {
                    txtkq.Text = "Phương trình vô nghiệm";

                }
            }
            else
            {
                // Giải phương trình và hiển thị kết quả
                double x_08_Hai = -b_08_Hai / a_08_Hai;
                txtkq.Text = "Nghiệm của phương trình là:" + x_08_Hai.ToString();
            }

        }

        private void btnr_Click(object sender, EventArgs e)
        {
            
        }

        private void btnlamlai_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            txtkq.Text = "";
        }
    }
}
