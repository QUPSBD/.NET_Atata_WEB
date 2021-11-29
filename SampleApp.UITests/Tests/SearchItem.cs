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
    public class SearchItem : UITestFixture
    {
        [Test]
        public void SearchTest ()
        {
            Login().Wait(3)
                .SearchBox.Click()
                .SearchBox.Set(Locators.searchText).Wait(2)
                .SearchBtn.Click().Wait(2)
                .SearchPageText.Should.Equal(Locators.searchAssertText).Wait(2);

        }
    }
}
