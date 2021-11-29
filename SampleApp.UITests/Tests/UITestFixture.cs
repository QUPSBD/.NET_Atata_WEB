using Atata;
using NUnit.Framework;
using SampleApp.UITests;
using SampleApp.UITests.Pages;
using SampleApp.UITests.Utils;

namespace SampleApp.UITests.Tests
{
    [TestFixture]
    public class UITestFixture
    {
        [SetUp]
        public void SetUp()
        {
            AtataContext.Configure().Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }

        protected HomePage Login()
        {
            return Go.To<HomePage>()
                .Report.Screenshot()
                .SignIn.Click()
                .ContinueWithEmail.Click()
                .Email.Set(Locators.email)
                .Password.Set(Locators.password)
                .LoginBtn.Click();
        }
    }
}
