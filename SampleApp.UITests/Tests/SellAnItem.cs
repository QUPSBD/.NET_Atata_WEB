using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;
using SampleApp.UITests.Pages;
using SampleApp.UITests.Utils;

namespace SampleApp.UITests.Tests
{
    public class SellAnItem : UITestFixture
    {
        [Test]
        public void SellItemTest ()
        {
            Login().Wait(3)
                .PostYourAdd.ClickAndGo().Wait(2)
                .SellAnItem.Click()
                .Electronics.Click().Wait(3)
                .Laptops.Click()
                .Rajshahi.Click().Wait(2)
                .Uposohor.Click().Wait(3)
                .Brand.Click().Wait(2)
                .UnorderedList.Click().Wait(2)
                .Model.Set("ex-d")
                .Title.Set("laptop").Wait(2)
                .Price.Set(20000).Wait(2)
                .ScrollDown()
                .PhoneNumber.Set(Locators.phoneNumber).Wait(2)
                .Add.Click();

        }
    }
}
