using Atata;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.UITests
{
    public class SignInTest : UITestFixture
    {
        [Test]
        public void LoginTest()
        {
            Go.To<HomePage>()
                .SignIn.Click()
                .ContinueWithEmail.Click()
                .Email.Set(Locators.email)
                .Password.Set(Locators.password)
                .LoginBtn.Click();
        }
    }
}
