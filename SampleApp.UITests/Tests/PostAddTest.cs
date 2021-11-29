using Atata;
using NUnit.Framework;
using SampleApp.UITests.Pages;
using SampleApp.UITests.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UITests.Tests
{
    public class PostAddTest : UITestFixture
    {
        [Test]
        public void PostAdd()
        {
            Login()
                .PostYourAdd.ClickAndGo()
                .LoogForSomethingToBuy.Click()
                .Electronics.Click().Wait(3)
                .Laptops.Click()
                .Rajshahi.Click()
                .Uposohor.Click().Wait(3)
                .Title.Set(Locators.titleText)
                .Description.Set(Locators.descriptionText).Wait(2)
                .PhoneNumber.Set(Locators.phoneNumber)
                .Add.Click()
                .Wait(3);
        }
    }
}
