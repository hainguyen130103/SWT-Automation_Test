using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTB1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IWebDriver driver_08_Hai = new ChromeDriver();
            driver_08_Hai.Url = "https://mobilecity.vn/";
            Thread.Sleep(3000);
            driver_08_Hai.Navigate().GoToUrl("https://mobilecity.vn/login");
            IWebElement tendangnhap = driver_08_Hai.FindElement(By.Name("login"));
            tendangnhap.SendKeys("datctn2003@gmail.com");
            IWebElement passdangnhap = driver_08_Hai.FindElement(By.Name("password"));
            passdangnhap.SendKeys("khongnho");
            IWebElement dangnhap = driver_08_Hai.FindElement(By.XPath("//*[@id=\"mp-pusher\"]/div/div[2]/form/div[2]/button"));
            dangnhap.Click();
            Thread.Sleep(3000);
            IWebElement timkiem = driver_08_Hai.FindElement(By.Name("keyword"));
            timkiem.SendKeys("Iphone 11");
            IWebElement search = driver_08_Hai.FindElement(By.Name("submit"));
            search.Click();
            IWebElement timthay = driver_08_Hai.FindElement(By.CssSelector("#mp-pusher > section > section:nth-child(4) > div.product-list"));
            Thread.Sleep(3000);
        }
    }
}
