using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
//using Baseclass.Contrib.SpecFlow.Selenium.NUnit.Bindings;

namespace TestingSwagLabsSpecFlow.StepDefinitions
{
    [Binding]
    public class TestsSteps
    {
        private int cartnumber;

        String test_url = "https://www.saucedemo.com/";
        String UserName = "standard_user";
        String Password = "secret_sauce";

        public IWebDriver currentdriver;

        [Given(@"Navigate to Login Page")]
        public void GivenNavigateToLoginPage()
        {
            currentdriver = new FirefoxDriver();
            currentdriver.Url = test_url;
            currentdriver.Url = test_url;
        }
        
        [Given(@"Enter UserName")]
        public void GivenEnterUserName()
        {
            IWebElement username = currentdriver.FindElement(By.Name("user-name"));
            username.SendKeys(UserName);
        }
        
        [Given(@"Enter PassWord")]
        public void GivenEnterPassWord()
        {
            IWebElement password = currentdriver.FindElement(By.Name("password"));
            password.SendKeys(Password);
        }
        
        [When(@"Home Page")]
        public void WhenHomePage()
        {
            Assert.IsTrue(currentdriver.Url.ToLower().Contains("inventory.html"));
        }
        
        [When(@"Click on Login button")]
        public void WhenClickOnLoginButton()
        {
            IWebElement LoginButton = currentdriver.FindElement(By.Name("login-button"));
            LoginButton.Click();
        }
        
        [Then(@"Click Add to cart for Sauce Labs Backpack")]
        public void ThenClickAddToCartForSauceLabsBackpack()
        {
            IWebElement btnItemSauceLabsBackpack = currentdriver.FindElement(By.Name("add-to-cart-sauce-labs-backpack"));
            btnItemSauceLabsBackpack.Click();
        }
        
        [Then(@"Click Add to cart for Sauce Sauce Labs Bike Light")]
        public void ThenClickAddToCartForSauceSauceLabsBikeLight()
        {
            IWebElement btnItemSauceLabsBikeLight = currentdriver.FindElement(By.Name("add-to-cart-sauce-labs-bike-light"));
            btnItemSauceLabsBikeLight.Click();
        }
        
        [Then(@"Click Add to cart for Sauce Labs Bolt T-Shirt")]
        public void ThenClickAddToCartForSauceLabsBoltT_Shirt()
        {
            IWebElement btnItemSauceLabsBoltT_Shirt = currentdriver.FindElement(By.Name("add-to-cart-sauce-labs-bolt-t-shirt"));
            btnItemSauceLabsBoltT_Shirt.Click();
        }
        
        [Then(@"Click Add to cart for Sauce Labs Fleece Jacket")]
        public void ThenClickAddToCartForSauceLabsFleeceJacket()
        {
            IWebElement btnItemSauceLabsFleeceJacket = currentdriver.FindElement(By.Name("add-to-cart-sauce-labs-fleece-jacket"));
            btnItemSauceLabsFleeceJacket.Click();
        }
        
        [Then(@"Click Add to cart for Sauce Labs Onesie")]
        public void ThenClickAddToCartForSauceLabsOnesie()
        {
            IWebElement btnItemSauceLabsOnesie = currentdriver.FindElement(By.Name("add-to-cart-sauce-labs-onesie"));
            btnItemSauceLabsOnesie.Click();
        }
        
        [Then(@"Click Add to cart for Test\.allTheThings\(\) T-Shirt \(Red\)")]
        public void ThenClickAddToCartForTest_AllTheThingsT_ShirtRed()
        {
            IWebElement btnItemTestallTheThingsT_ShirtRed = currentdriver.FindElement(By.Name("add-to-cart-test.allthethings()-t-shirt-(red)"));
            btnItemTestallTheThingsT_ShirtRed.Click();
        }
        
        [Then(@"Click Remove for Sauce Labs Backpack")]
        public void ThenClickRemoveForSauceLabsBackpack()
        {
            IWebElement btnItemRemoveSauceLabsBackpack = currentdriver.FindElement(By.Name("remove-sauce-labs-backpack"));
            btnItemRemoveSauceLabsBackpack.Click();
        }
        
        [Then(@"Click Remove for Sauce Sauce Labs Bike Light")]
        public void ThenClickRemoveForSauceSauceLabsBikeLight()
        {
            IWebElement btnItemRemoveSauceLabsBikeLight = currentdriver.FindElement(By.Name("remove-sauce-labs-bike-light"));
            btnItemRemoveSauceLabsBikeLight.Click();
        }
        
        [Then(@"Click Remove for Sauce Labs Bolt T-Shirt")]
        public void ThenlickRemoveForSauceLabsBoltT_Shirt()
        {
            IWebElement btnItemRemoveSauceLabsBoltT_Shirt = currentdriver.FindElement(By.Name("remove-sauce-labs-bolt-t-shirt"));
            btnItemRemoveSauceLabsBoltT_Shirt.Click();
        }
        
        [Then(@"Click Remove for Sauce Labs Fleece Jacket")]
        public void ThenClickRemoveForSauceLabsFleeceJacket()
        {
            IWebElement btnItemRemoveSauceLabsFleeceJacket = currentdriver.FindElement(By.Name("remove-sauce-labs-fleece-jacket"));
            btnItemRemoveSauceLabsFleeceJacket.Click();
        }
        
        [Then(@"Click Remove for Sauce Labs Onesie")]
        public void ThenClickRemoveForSauceLabsOnesie()
        {
            IWebElement btnItemRemoveSauceLabsOnesie = currentdriver.FindElement(By.Name("remove-sauce-labs-onesie"));
            btnItemRemoveSauceLabsOnesie.Click();
        }
        
        [Then(@"Click Remove for Test\.allTheThings\(\) T-Shirt \(Red\)")]
        public void ThenClickRemoveForTest_AllTheThingsT_ShirtRed()
        {
            IWebElement btnItemRemoveTestallTheThingsT_ShirtRed = currentdriver.FindElement(By.Name("remove-test.allthethings()-t-shirt-(red)"));
            btnItemRemoveTestallTheThingsT_ShirtRed.Click();
        }
        
        [When(@"Click on shopping cart")]
        public void WhenClickOnShoppingCart()
        {
            IWebElement btnCart = currentdriver.FindElement(By.Id("shopping_cart_container"));
            btnCart.Click();
        }
        
        [Then(@"Should open Home Page")]
        public void ThenShouldOpenHomePage()
        {
            System.Threading.Thread.Sleep(2000);
            Assert.IsTrue(currentdriver.Url.ToLower().Contains("inventory.html"));
        }
        
        
        [Then(@"Should open shopping cart page")]
        public void ThenShouldOpenShoppingCartPage()
        {
            Assert.IsTrue(currentdriver.Url.ToLower().Contains("cart.html"));
        }

        [Then(@"Close browser")]
        public void ThenCloseBrowser()
        {
            currentdriver.Quit();
        }

    }
}
