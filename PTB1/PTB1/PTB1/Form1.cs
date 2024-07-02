using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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
        private void btnclick_Click(object sender, EventArgs e)
        {
            IWebDriver driver_08_TruongQuangDat = new ChromeDriver();
            driver_08_TruongQuangDat.Url = "https://mobilecity.vn/";      
            Thread.Sleep(3000);         
            driver_08_TruongQuangDat.Navigate().GoToUrl("https://mobilecity.vn/login");           
            IWebElement tendangnhap = driver_08_TruongQuangDat.FindElement(By.Name("login"));
            tendangnhap.SendKeys("datctn2003@gmail.com");
            IWebElement passdangnhap = driver_08_TruongQuangDat.FindElement(By.Name("password"));
            passdangnhap.SendKeys("khongnho");              
            IWebElement dangnhap = driver_08_TruongQuangDat.FindElement(By.XPath("//*[@id=\"mp-pusher\"]/div/div[2]/form/div[2]/button"));
            dangnhap.Click();
            Thread.Sleep(3000);
            driver_08_TruongQuangDat.Navigate().GoToUrl("https://mobilecity.vn/");         
            IWebElement timkiem = driver_08_TruongQuangDat.FindElement(By.Name("keyword"));
            timkiem.SendKeys("Iphone 11");
            IWebElement timthay = driver_08_TruongQuangDat.FindElement(By.CssSelector("#mp-pusher > section > section:nth-child(4) > div.product-list"));           
            Thread.Sleep(3000);                     
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn__giai_Click(object sender, EventArgs e)
        {
            // Lấy giá trị của a từ Textbox txta và chuyển đổi thành số
            double a;
            a =double.Parse(txta.Text);
            // Lấy giá trị của b từ Textbox txta và chuyển đổi thành số
            double b;
            b = double.Parse(txtb.Text);
            // kiểm tra nếu a=0
            if (a == 0)
            {
                if (b == 0)
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
                double x = -b / a;
                txtkq.Text = "Nghiệm của phương trình là:" + x.ToString();
            }

        }
    }
}
