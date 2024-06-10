using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver driver;

        [TestMethod]
        public void TestMethod1()
        {
            try
            {

                var options = new EdgeOptions();

                options.AddExcludedArgument("enable-logging");

                driver = new EdgeDriver(@"C:\Users\janis\OneDrive\Dators\EKA\Programmaturas izstrades tehnologijas\Web driver", options);

                driver.Url = "https://www.ebay.com/";

                IWebElement element = driver.FindElement(By.Id("gh-ac"));
                Assert.IsNotNull(element);
            }
            catch (NoSuchElementException ex)
            {
                Assert.Fail("Neizdevās atrast elementu: " + ex.Message);
            }
            catch (Exception ex)
            {
                Assert.Fail("Notika neparedzēta kļūda: " + ex.Message);
            }
            finally
            {
                driver.Quit();
            }
        }

        [TestMethod]
        public void testMethod2()
        {
            try
            {
                var options = new EdgeOptions();

                options.AddExcludedArgument("enable-logging");

                driver = new EdgeDriver(@"C:\Users\janis\OneDrive\Dators\EKA\Programmaturas izstrades tehnologijas\Web driver", options);

                driver.Url = "https://www.ebay.com/";


                IWebElement element2 = driver.FindElement(By.Id("gh-btn"));
                Assert.IsNotNull(element2);
            }
            catch (NoSuchElementException ex)
            {
                Assert.Fail("Neizdevās atrast elementu: " + ex.Message);
            }
            catch (Exception ex)
            {
                Assert.Fail("Notika neparedzēta kļūda: " + ex.Message);
            }
            finally
            {
                driver.Quit();
            }
        }
    }
}
