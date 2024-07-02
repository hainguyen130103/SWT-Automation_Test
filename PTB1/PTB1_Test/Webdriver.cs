using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PTB1_Test
{
    public class DangNhapWEb_08_Hai
    {
        IWebDriver driver_08_TruongQuangDat;
        [TestMethod]
        public void TestDangNhap_08_Hai()
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
            IWebElement timkiem = driver_08_TruongQuangDat.FindElement(By.Name("keyword"));
            timkiem.SendKeys("Iphone 11");
            IWebElement search = driver_08_TruongQuangDat.FindElement(By.Name("submit"));
            search.Click();
            IWebElement timthay = driver_08_TruongQuangDat.FindElement(By.CssSelector("#mp-pusher > section > section:nth-child(4) > div.product-list"));
            Thread.Sleep(3000);

        }
    }
}
