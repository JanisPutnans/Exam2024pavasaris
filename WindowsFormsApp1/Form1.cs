using System;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private IWebDriver driver;

        public Form1()
        {
            InitializeComponent();
            try
            {
                var options = new EdgeOptions();
                driver = new EdgeDriver(@"C:\Users\janis\OneDrive\Dators\EKA\Programmaturas izstrades tehnologijas\Web driver");

                // Maksimizējiet logu
                driver.Manage().Window.Maximize();

                // Atveriet eBay mājaslapu
                driver.Url = "https://www.ebay.com";

                // Pagaidiet, lai redzētu atvērtu vietni (piemēram, 5 sekundes)
                System.Threading.Thread.Sleep(5000);

                // Aizveriet pārlūku, kad forma tiek aizvērta
                this.FormClosed += (s, e) => driver.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kļūda, atverot pārlūkprogrammu: " + ex.Message);
            }


        }





        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                IWebElement searchInput = driver.FindElement(By.Id("gh-ac"));
                searchInput.Clear();
                searchInput.SendKeys(textBox1.Text);

                IWebElement searchButton = driver.FindElement(By.Id("gh-btn"));
                searchButton.Click();

                string currentURL = driver.Url;
                richTextBox1.Text += currentURL;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kļūda veicot meklēšanu: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                driver.Navigate().Back();


                textBox2.Text = "";
                richTextBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kļūda veicot pārlūka atpakaļpāreju: " + ex.Message);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            driver.Quit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
