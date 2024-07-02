using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PTB1;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System.Runtime.InteropServices;

namespace Dangnhap_08_Hai
{
    [TestClass]
    public class TestWeb_08_Hai

    {
        //private Giai c_08_Hai;
        //[TestInitialize] // thiet lap du lieu dung chung cho TC
        //public void SetUp()
        //{
        //    c_08_Hai = new Giai(2, 4);
        //}
        //[TestMethod] //TC1: a_08_Hai =2, b_08_Hai = 4, kq_08_Hai= -2
        //public void Testconghiem_08_Hai()
        //{
        //    double expected, actual;
        //    expected = -2;
        //    actual = c_08_Hai.Solve();
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void Testvosonghiem_08_Hai()
        //{
        //    Giai c_08_Hai = new Giai(0, 0);
        //    Assert.ThrowsException<ArgumentException>(() => c_08_Hai.Solve());

        //}
        //[TestMethod]
        //public void Testvonghiem_08_Hai()
        //{
        //    Giai c_08_Hai = new Giai(0, 3);
        //    Assert.ThrowsException<ArgumentException>(() => c_08_Hai.Solve());

        //}



        // Phương thức kiểm tra khi delta lớn hơn 0
        //[TestMethod]
        //public void Test2nghiemphanbiet_08_Hai()
        //{
        //    double a_08_Hai = 2.0;
        //    double b_08_Hai = 3.0;
        //    double c_08_Hai = 1.0;
        //    double expectedx1_08_Hai = -0.5;
        //    double expectedx2_08_Hai = -1;

        //    // Thực hiện giải phương trình bậc 2
        //    var result_08_Hai = Ngoaile_08_Hai.GiaiPhuongTrinhBac2_08_Hai(a_08_Hai, b_08_Hai, c_08_Hai);

        //    // Kiểm tra kết quả có đúng như mong đợi
        //    Assert.IsTrue(result_08_Hai.Item1 == expectedx1_08_Hai && result_08_Hai.Item2 == expectedx2_08_Hai || result_08_Hai.Item1 == expectedx2_08_Hai && result_08_Hai.Item2 == expectedx1_08_Hai);
        //}

        //// Phương thức kiểm tra khi delta bằng 0
        //[TestMethod]
        //public void Testnghiemkep_08_Hai()
        //{          
        //    double a_08_Hai = 2.0;
        //    double b_08_Hai = 4.0;
        //    double c_08_Hai = 2.0;
        //    double expected_08_Hai = -1;

        //    // Thực hiện giải phương trình bậc 2
        //    var result_08_Hai = Ngoaile_08_Hai.GiaiPhuongTrinhBac2_08_Hai(a_08_Hai, b_08_Hai, c_08_Hai);

        //    // Kiểm tra kết quả có đúng như mong đợi
        //    Assert.AreEqual(expected_08_Hai, result_08_Hai.Item1);
        //    Assert.AreEqual(expected_08_Hai, result_08_Hai.Item2);
        //}

        //// Phương thức kiểm tra khi delta nhỏ hơn 0
        //[TestMethod]
        //public void Testvonghiem_08_Hai()
        //{          
        //    double a_08_Hai = 2.0;
        //    double b_08_Hai = 4.0;
        //    double c_08_Hai = 3.0;    
        //    Assert.ThrowsException<ArgumentException>(() => Ngoaile_08_Hai.GiaiPhuongTrinhBac2_08_Hai(a_08_Hai, b_08_Hai, c_08_Hai));
        //}
        IWebDriver driver_08_Hai;
        [TestMethod]
        public void TestTimkhongthay_08_Hai()
        {
            IWebDriver driver_08_Hai = new ChromeDriver();
            driver_08_Hai.Url = "https://mobilecity.vn/";
            Thread.Sleep(3000);
            
            driver_08_Hai.Navigate().GoToUrl("https://mobilecity.vn/login");
            IWebElement tendangnhap = driver_08_Hai.FindElement(By.Name("login"));
            tendangnhap.SendKeys("haintse170559@fpt.edu.vn");
            IWebElement passdangnhap = driver_08_Hai.FindElement(By.Name("password"));
            passdangnhap.SendKeys("haizo123");
            Thread.Sleep(3000);
            IWebElement dangnhap = driver_08_Hai.FindElement(By.XPath("//*[@id=\"mp-pusher\"]/div/div[2]/form/div[2]/button"));
            dangnhap.Click();
            Thread.Sleep(3000);
            
            IWebElement timkiem = driver_08_Hai.FindElement(By.Name("keyword"));
            timkiem.SendKeys("tu lanh");
            IWebElement search = driver_08_Hai.FindElement(By.Name("submit"));
            search.Click();          
            // Lấy URL hiện tại sau khi tìm kiếm
            string link = driver_08_Hai.Url;
            Console.WriteLine("URL sau khi tìm kiếm: " + link);
        }

    }
}


